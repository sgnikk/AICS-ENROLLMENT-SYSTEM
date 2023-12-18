Imports System.Data.SqlClient
Imports System.Globalization

Public Class enrollmentforms
    Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
    Dim dataTable As New DataTable()
    Private subjectUnits As New Dictionary(Of ListViewItem, Integer)
    Private Const MaxUnits As Integer = 24
    Private selectedSubjects As New List(Of ListViewItem)

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub '

    Private Sub enrollmentforms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatedschoolyear()
        populatesemester()
        populatesubjects()

    End Sub

    Private Sub SearchData()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM tblstudentss WHERE FirstName LIKE @fname OR LastName LIKE @lname"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@fname", "%" & txtsearchbar.Text & "%")
                adapter.SelectCommand.Parameters.AddWithValue("@lname", "%" & txtsearchbar.Text & "%")
                dataTable.Clear()
                adapter.Fill(dataTable)
            End Using
        End Using

        If dataTable.Rows.Count > 0 Then
            Dim row As DataRow = dataTable.Rows(0)

            If dataTable.Columns.Contains("Course") AndAlso dataTable.Columns.Contains("FirstName") AndAlso dataTable.Columns.Contains("LastName") Then
                If Not row.IsNull("Course") AndAlso Not row.IsNull("FirstName") AndAlso Not row.IsNull("LastName") Then
                    txtcourse.Text = row.Field(Of String)("Course")
                    txtstudentname.Text = row.Field(Of String)("FirstName") & " " & row.Field(Of String)("LastName")
                Else
                    MessageBox.Show("Data in the row is null.")
                End If
            Else
                MessageBox.Show("Columns not found in the DataTable.")
            End If
        Else
            txtcourse.Text = ""
            txtstudentname.Text = ""
        End If
    End Sub

    Private Sub txtsearchbar_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbar.TextChanged
        SearchData()
    End Sub

    Public Sub populatesemester()
        Dim semester As String = "SELECT SEMESTER_ID, SEMESTER_NAME FROM tblsemester"
        Using semesterConnection As New SqlConnection(connectionString)
            Using semesterCommand As New SqlCommand(semester, semesterConnection)
                Try
                    semesterConnection.Open()
                    Dim semesterAdapter As New SqlDataAdapter(semesterCommand)
                    Dim semesterTable As New DataTable()
                    semesterAdapter.Fill(semesterTable)
                    cmbsemester.DataSource = semesterTable
                    cmbsemester.DisplayMember = "SEMESTER_NAME"
                    cmbsemester.ValueMember = "SEMESTER_ID"
                Catch semesterEx As Exception
                    MessageBox.Show("Error while loading professors: " & semesterEx.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub populatedschoolyear()
        Dim schoolyear As String = "SELECT SCHOOLYEAR_ID, SCHOOLYEAR FROM SCHOOLYEAR"
        Using schoolyearConnection As New SqlConnection(connectionString)
            Using schoolyearCommand As New SqlCommand(schoolyear, schoolyearConnection)
                Try
                    schoolyearConnection.Open()
                    Dim schoolyearAdapter As New SqlDataAdapter(schoolyearCommand)
                    Dim schoolyearTable As New DataTable()
                    schoolyearAdapter.Fill(schoolyearTable)
                    cmbsyyear.DataSource = schoolyearTable
                    cmbsyyear.DisplayMember = "SCHOOLYEAR"
                    cmbsyyear.ValueMember = "SCHOOLYEAR_ID"
                Catch schoolyearEx As Exception
                    MessageBox.Show("Error while loading professors: " & schoolyearEx.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbsyyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsyyear.SelectedIndexChanged

        If cmbsyyear.SelectedItem IsNot Nothing AndAlso TypeOf cmbsyyear.SelectedItem Is DataRowView Then
            Dim selectedRow As DataRowView = DirectCast(cmbsyyear.SelectedItem, DataRowView)

            ' Access the specific column value from the DataRowView
            Dim selectedYear As String = selectedRow("SCHOOLYEAR").ToString()

            ' Check if the selected school year has the expected format (e.g., "2023-2024")
            If IsSchoolYearFormatValid(selectedYear) Then
                ' Extract the first two digits of the selected school year
                Dim yearPrefix As String = selectedYear.Substring(2, 2)

                ' Generate a sequentially increasing number (you may need to adapt this based on your requirements)
                Dim sequentialNumber As Integer = GetNextSequentialNumber()

                ' Combine the extracted year and the sequential number to form the student number

                RunQuery("Select * from tblstudentsubjects")
                If ds.Tables("querytable").Rows.Count = 0 Then

                    Dim studentNumber As String = yearPrefix & sequentialNumber.ToString("D5")

                    ' Set the generated student number to the txtstudentnumber.Text
                    txtstudentnumber.Text = studentNumber
                Else
                    RunQuery("Select TOP 1 StudentNumber + 1 from tblstudentsubjects ORDER by StudentNumber DESC")
                    txtstudentnumber.Text = ds.Tables("querytable").Rows(0)(0).ToString
                End If
            Else
                ' Handle the case where the selected school year doesn't have the expected format
                MessageBox.Show("Selected school year format is invalid. Selected year: " & selectedYear)
            End If
        End If
    End Sub

    Private Function IsSchoolYearFormatValid(year As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(year, "^\d{4}-\d{4}$")
    End Function

    Private Sub populatesubjects()
        Dim subjectsQuery As String = "
    SELECT
        s.SubjectID AS 'Subject ID',
        s.SubjectCODE AS 'Subject Code',
        s.SubjectDESCRIPTION AS 'Subject Title',
        s.SubjectUNIT AS 'Units',
        s.SubjectLEVEL AS 'Subject Level',
        s.SubjectCAPACITY AS 'Capacity',
        s.CLASS_NUMBER AS 'Class No.',
        CONCAT(p.FIRST_NAME, ', ', p.LAST_NAME) AS Instructor,
        s.DAY AS 'Day',
        CONCAT(CONVERT(varchar, s.STARTTIME, 108), ' - ', CONVERT(varchar, s.ENDTIME, 108)) AS Time,
        CASE WHEN s.RoomID IS NULL THEN 'None' ELSE r.RoomNumber END AS 'Room Number', 
        COALESCE(r.RoomType, 'NONE') AS 'Room Type',
        sem.SEMESTER_NAME AS 'Semester',
        c.COURSE_CODE AS 'Course'
    FROM
        SUBJECTS s
    JOIN
        tblprofessorss p ON s.PROFESSORS_ID = p.PROFESSORS_ID
    LEFT JOIN
        tblROOM r ON s.RoomID = r.RoomID
    JOIN
        tblsemester sem ON s.SEMESTER_ID = sem.SEMESTER_ID
    JOIN
        COURSES c ON s.COURSE_ID = c.COURSE_ID
    WHERE
        c.COURSE_CODE = @CourseCode AND sem.SEMESTER_NAME = @SemesterName"

        Using subjectsConnection As New SqlConnection(connectionString)
            Try
                subjectsConnection.Open()
                Dim subjectsAdapter As New SqlDataAdapter()
                subjectsAdapter.SelectCommand = New SqlCommand(subjectsQuery, subjectsConnection)
                subjectsAdapter.SelectCommand.Parameters.AddWithValue("@CourseCode", txtcourse.Text)
                subjectsAdapter.SelectCommand.Parameters.AddWithValue("@SemesterName", cmbsemester.Text)

                Dim subjectsTable As New DataTable()
                subjectsAdapter.Fill(subjectsTable)

                ' Assuming lvsubjects is the name of your ListView
                lvsubjects.Items.Clear()
                lvsubjects.Columns.Clear()

                ' Specify the order of columns in the ListView
                Dim columnOrder() As String = {"Class No.", "Subject Code", "Subject Title", "Units", "Room Type", "Day", "Time", "Instructor", "Room Number"}

                ' Calculate the width for each column based on the total width of the ListView
                Dim totalColumns As Integer = columnOrder.Length
                Dim totalWidth As Integer = lvsubjects.Width

                ' Increase the width for the Time column (adjust the multiplier based on your preference)
                Dim timeColumnWidth As Integer = CInt(totalWidth * 0.15) ' Adjust the multiplier as needed
                Dim otherColumnsWidth As Integer = CInt((totalWidth - timeColumnWidth) / (totalColumns - 1))

                ' Add columns to ListView with specified widths
                For Each columnName As String In columnOrder
                    If subjectsTable.Columns.Contains(columnName) Then
                        Dim column As New ColumnHeader()

                        If columnName = "Time" Then
                            column.Width = timeColumnWidth
                        Else
                            column.Width = otherColumnsWidth
                        End If

                        column.Text = columnName
                        column.TextAlign = HorizontalAlignment.Center
                        lvsubjects.Columns.Add(column)
                    End If
                Next


                ' Set font size for non-header cells
                lvsubjects.Font = New Font(lvsubjects.Font.FontFamily, 8)


                For Each row As DataRow In subjectsTable.Rows
                    Dim listViewItem As New ListViewItem(columnOrder.Select(Function(col) row(col).ToString()).ToArray())
                    lvsubjects.Items.Add(listViewItem)
                Next


            Catch subjectsEx As Exception
                MessageBox.Show("Error while loading subjects: " & subjectsEx.Message)
            End Try

        End Using
    End Sub

    Private Sub lvsubjects_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvsubjects.ItemChecked
        ' ... (your existing lvsubjects_ItemChecked code)

        ' If the item is checked, add it to the list
        If e.Item.Checked Then
            selectedSubjects.Add(e.Item)
        Else
            ' If the item is unchecked, remove it from the list
            selectedSubjects.Remove(e.Item)
        End If
    End Sub




    Private Sub lvsubjects_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvsubjects.DrawColumnHeader
        ' Set font size for column headers
        e.Graphics.DrawString(e.Header.Text, New Font(lvsubjects.Font.FontFamily, 14, FontStyle.Bold), Brushes.Black, e.Bounds)
    End Sub


    Private Function GetCourseId(courseCode As String) As Integer
        ' Function to get the Course_ID based on the course code
        ' You need to implement this function based on your database schema
        ' Replace the following line with the actual code to retrieve the Course_ID
        Return 1 ' Placeholder value, replace with actual Course_ID
    End Function

    Private Sub txtcourse_TextChanged(sender As Object, e As EventArgs) Handles txtcourse.TextChanged
        ' Call the method 
        populatesubjects()
    End Sub

    Private Sub cmbsemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsemester.SelectedIndexChanged
        ' Call the method to repopulate subjects when the semester selection changes
        populatesubjects()
    End Sub

    Private Function GetNextSequentialNumber() As Integer
        Return 1
    End Function




    Private Sub btnenroll_Click(sender As Object, e As EventArgs) Handles btnenroll.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim studentId As Integer
                Dim course As String

                ' Fetch student information
                If Not FetchStudentInfo(connection, txtstudentname.Text, txtcourse.Text, studentId, course) Then
                    MessageBox.Show("Student not found.")
                    Return
                End If

                ' Iterate through all checked subjects
                For Each listItem As ListViewItem In selectedSubjects
                    ' Process the selected subject
                    Try
                        If Not ProcessSubjectItem(connection, listItem, txtstudentnumber.Text, DateTime.Parse(enrolleddate.Text), cmbsemester.SelectedValue, cmbsyyear.SelectedValue, studentId) Then
                            ' Handle the error or notify the user appropriately
                            MessageBox.Show($"Enrollment failed for subject: {listItem.Text}")
                        End If
                    Catch exSubject As Exception
                        MessageBox.Show($"Error processing subject '{listItem.Text}': {exSubject.Message}")
                    End Try
                Next

                ' Display success message after processing all selected subjects
                MessageBox.Show("Enrollment successful.")
                formTuitionPayment.Label1.Text = txtstudentnumber.Text
                formTuitionPayment.Show()
                Me.Close()
            End Using
        Catch ex As SqlException
            MessageBox.Show($"Database error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"Error in btnenroll_Click: {ex.Message}")
        End Try
        addmissionpage.LoadData()
    End Sub

    Private Function ProcessSubjectItem(connection As SqlConnection, selectedItem As ListViewItem, studentNumber As Integer, dateEnrolled As DateTime, semester As Integer, schoolYear As Integer, studentId As Integer) As Boolean
        Try
            Dim subjectCodeSubItem As ListViewItem.ListViewSubItem = selectedItem.SubItems(1) ' Adjust the index based on your actual column index

            ' Check if the subitem is found
            If subjectCodeSubItem IsNot Nothing Then
                ' Extract the subject code from the 'Subject Code' subitem
                Dim subjectCode As String = subjectCodeSubItem.Text

                ' Retrieve the subject ID using the subject code
                Dim subjectId As Integer = GetSubjectIdByCode(connection, subjectCode)

                If subjectId > 0 Then
                    ' Check enrollment status using SQL logic
                    Dim enrollmentStatus As String = GetEnrollmentStatus(connection, subjectId)

                    If enrollmentStatus = "Space Available" Then
                        ' Insert the enrollment record
                        Try
                            Using cmdInsert As New SqlCommand("INSERT INTO tblstudentsubjects (StudentNumber, DateEnrolled, StudentID, SCHOOLYEAR_ID, SEMESTER_ID, SubjectID) " &
                                              "VALUES (@snumber, @dateenrolled, @studentid, @schoolyear, @semester, @subjectid)", connection)
                                cmdInsert.Parameters.AddWithValue("@snumber", studentNumber)
                                cmdInsert.Parameters.AddWithValue("@dateenrolled", dateEnrolled)
                                cmdInsert.Parameters.AddWithValue("@semester", semester)
                                cmdInsert.Parameters.AddWithValue("@schoolyear", schoolYear)
                                cmdInsert.Parameters.AddWithValue("@studentid", studentId)
                                cmdInsert.Parameters.AddWithValue("@subjectid", subjectId)

                                cmdInsert.ExecuteNonQuery()
                                Return True
                            End Using
                        Catch exInsert As Exception
                            MessageBox.Show($"Error inserting enrollment record for subject '{subjectCode}': {exInsert.Message}")
                            Return False
                        End Try
                    Else
                        MessageBox.Show($"Enrollment failed for subject '{subjectCode}' because: {enrollmentStatus}")
                        Return False
                    End If
                Else
                    MessageBox.Show($"Invalid or missing Subject ID for the selected subject code '{subjectCode}'. ListViewItem: {selectedItem.Text}")
                    Return False
                End If
            Else
                ' Handle the case where the subitem with the key 'Subject Code' doesn't exist
                MessageBox.Show("Subitem with index 2 not found in the selected item.")
                Return False
            End If
        Catch exSubjectItem As Exception
            MessageBox.Show($"Error processing subject item: {exSubjectItem.Message}")
            Return False
        End Try
    End Function

    Private Function GetEnrollmentStatus(connection As SqlConnection, subjectId As Integer) As String
        Try
            Using cmdStatus As New SqlCommand("SELECT CASE WHEN COUNT(DISTINCT ss.StudentID) < s.SubjectCAPACITY THEN 'Space Available' ELSE 'Capacity Full' END AS EnrollmentStatus " &
                                            "FROM SUBJECTS s LEFT JOIN tblstudentsubjects ss ON s.SubjectID = ss.SubjectID " &
                                            "WHERE s.SubjectID = @subjectId " &
                                            "GROUP BY s.SubjectCAPACITY", connection)
                cmdStatus.Parameters.AddWithValue("@subjectId", subjectId)

                Dim result As Object = cmdStatus.ExecuteScalar()

                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Return result.ToString()
                Else
                    MessageBox.Show($"Subject with ID '{subjectId}' not found.")
                    Return "Unknown"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error checking enrollment status: {ex.Message}")
            Return "Error"
        End Try
    End Function

    Private Function GetSubjectIdByCode(connection As SqlConnection, subjectCode As String) As Integer
        Try
            Using cmdFetch As New SqlCommand("SELECT SubjectID FROM SUBJECTS WHERE SubjectCODE = @subjectCode", connection)
                cmdFetch.Parameters.AddWithValue("@subjectCode", subjectCode)

                Dim result As Object = cmdFetch.ExecuteScalar()

                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Return Convert.ToInt32(result)
                Else
                    Return -1
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching SubjectID for subject code '{subjectCode}': {ex.Message}")
            Return -1 ' or throw an exception, depending on your error handling strategy
        End Try
    End Function

    Private Function FetchStudentInfo(connection As SqlConnection, studentName As String, course As String, ByRef studentId As Integer, ByRef courseResult As String) As Boolean
        Try
            Using cmdFetch As New SqlCommand("SELECT StudentID, Course FROM tblstudentss WHERE FirstName + ' ' + LastName = @studentname AND Course = @course", connection)
                cmdFetch.Parameters.AddWithValue("@studentname", SqlDbType.VarChar).Value = studentName
                cmdFetch.Parameters.AddWithValue("@course", SqlDbType.VarChar).Value = course

                Using reader As SqlDataReader = cmdFetch.ExecuteReader()
                    If reader.Read() Then
                        studentId = If(reader("StudentID") IsNot DBNull.Value, Convert.ToInt32(reader("StudentID")), 0)
                        courseResult = If(reader("Course") IsNot DBNull.Value, reader("Course").ToString(), String.Empty)
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch exFetch As Exception
            MessageBox.Show($"Error fetching student information: {exFetch.Message}")
            Return False
        End Try
    End Function



End Class
