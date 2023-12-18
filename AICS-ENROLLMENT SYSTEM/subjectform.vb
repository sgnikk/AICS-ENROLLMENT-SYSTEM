Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class subjectform

    Public connStr As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
    Private connection As New SqlConnection(connStr)


    Private Sub LoadCourseComboBox()
        ' Create a SqlConnection and SqlCommand
        Using connection As New SqlConnection(connStr)
            connection.Open()

            ' SQL query to retrieve course names
            Dim query As String = "SELECT DISTINCT COURSE_TITLE FROM COURSES"

            Using command As New SqlCommand(query, connection)
                ' Execute the SQL query and retrieve the results
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Populate the CourseComboBox
                        cmbcourse.Items.Add(reader("COURSE_CODE").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub subjectform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        starttime.Format = DateTimePickerFormat.Custom
        starttime.CustomFormat = "hh:mm tt"


        endtime.Format = DateTimePickerFormat.Custom
        endtime.CustomFormat = "hh:mm tt"

        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"

        ' Load professor data into a ComboBox
        Dim professorQuery As String = "SELECT PROFESSORS_ID, CONCAT(FIRST_NAME, ', ', LAST_NAME) AS NAME, EMAIL FROM tblprofessorss"
        Using professorConnection As New SqlConnection(connectionString)
            Using professorCommand As New SqlCommand(professorQuery, professorConnection)
                Try
                    professorConnection.Open()
                    Dim professorAdapter As New SqlDataAdapter(professorCommand)
                    Dim professorTable As New DataTable()
                    professorAdapter.Fill(professorTable)
                    cmbprof.DataSource = professorTable
                    cmbprof.DisplayMember = "NAME"
                    cmbprof.ValueMember = "PROFESSORS_ID"
                Catch professorEx As Exception
                    MessageBox.Show("Error while loading professors: " & professorEx.Message)
                End Try
            End Using
        End Using

        Dim semesterr As String = "SELECT SEMESTER_ID,SEMESTER_NAME FROM tblsemester"
        Using semesterConnection As New SqlConnection(connectionString)
            Using semesterCommand As New SqlCommand(semesterr, semesterConnection)
                Try
                    semesterConnection.Open()
                    Dim semesterAdapter As New SqlDataAdapter(semesterCommand)
                    Dim semesterTable As New DataTable()
                    semesterAdapter.Fill(semesterTable)
                    cmbsemester.DataSource = semesterTable
                    cmbsemester.DisplayMember = "SEMESTER_NAME"
                    cmbsemester.ValueMember = "SEMESTER_ID"
                Catch semesterrEx As Exception
                    MessageBox.Show("Error while loading professors: " & semesterrEx.Message)
                End Try
            End Using
        End Using

        Dim courseQuery As String = "SELECT COURSE_ID, COURSE_CODE, COURSE_TITLE, COURSE_DURATION, DepartmentID FROM COURSES"

        Using courseConnection As New SqlConnection(connectionString)
            Using courseCommand As New SqlCommand(courseQuery, courseConnection)
                Try
                    courseConnection.Open()
                    Dim courseAdapter As New SqlDataAdapter(courseCommand)
                    Dim courseTable As New DataTable()
                    courseAdapter.Fill(courseTable)
                    cmbcourse.DataSource = courseTable
                    cmbcourse.DisplayMember = "COURSE_CODE"
                    cmbcourse.ValueMember = "COURSE_ID" ' Change to the appropriate column
                Catch courseEx As Exception
                    MessageBox.Show("Error while loading courses: " & courseEx.Message)
                End Try
            End Using
        End Using

        Dim roomnumberQuery As String = "SELECT RoomID, RoomNumber, RoomType FROM tblROOM"
        Using roomnumberConnection As New SqlConnection(connectionString)
            Using roomnumberCommand As New SqlCommand(roomnumberQuery, roomnumberConnection)
                Try
                    roomnumberConnection.Open()
                    Dim roomNumberAdapter As New SqlDataAdapter(roomnumberCommand)
                    Dim roomnumberTable As New DataTable()
                    roomNumberAdapter.Fill(roomnumberTable)
                    cmbroom.DataSource = roomnumberTable
                    cmbroom.DisplayMember = "RoomNumber"
                    cmbroom.ValueMember = "RoomID" ' Change to the appropriate column
                Catch courseEx As Exception
                    MessageBox.Show("Error while loading ROOM NUMBER: " & courseEx.Message)
                End Try
            End Using
        End Using

        Dim roomTypeQuery As String = "SELECT DISTINCT RoomID, RoomNumber, " &
                              "CASE WHEN RoomType IS NULL OR RoomType = '' THEN 'NOTHING' ELSE TRIM(RoomType) END AS RoomType " &
                              "FROM tblROOM "
        'Dim roomTypeQuery As String = "SELECT RoomID, RoomNumber, RoomType FROM tblROOM"
        Using roomTypeConnection As New SqlConnection(connectionString)
            Using roomTypeCommand As New SqlCommand(roomTypeQuery, roomTypeConnection)
                Try
                    roomTypeConnection.Open()
                    Dim roomTypeAdapter As New SqlDataAdapter(roomTypeCommand)
                    Dim roomTypeTable As New DataTable()
                    roomTypeAdapter.Fill(roomTypeTable)
                    cmbroomtype.DataSource = roomTypeTable
                    cmbroomtype.DisplayMember = "RoomType"
                    cmbroomtype.ValueMember = "RoomID"
                Catch ex As Exception
                    MessageBox.Show("Error while loading ROOM TYPE: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Using conn As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")
            conn.Open()

            ' Get the existing RoomID based on selected room type and room number
            Dim roomNumber As String = If(cmbroom.SelectedItem IsNot Nothing, CType(cmbroom.SelectedItem, DataRowView).Row("RoomNumber").ToString(), "")
            Dim roomType As String = If(cmbroomtype.SelectedItem IsNot Nothing, CType(cmbroomtype.SelectedItem, DataRowView).Row("RoomType").ToString(), "")
            Dim roomId As Integer = GetRoomId(conn, roomNumber, roomType)

            ' Check if the class number already exists
            Dim classNumber As String = txtclassnumber.Text.Trim()
            If IsClassNumberExists(conn, classNumber) Then
                MessageBox.Show("Class number already exists. Please choose a different class number.")
                Return ' Exit the method without performing the insert operation
            End If

            ' Check if the subject code already exists
            Dim subjectCode As String = txtscodes.Text.Trim()
            If IsSubjectCodeExists(conn, subjectCode) Then
                MessageBox.Show("Subject code already exists. Please choose a different subject code.")
                Return ' Exit the method without performing the insert operation
            End If

            ' Use the existing RoomID to insert data into SUBJECTS table
            Using cmdInsert As New SqlCommand("INSERT INTO SUBJECTS (SubjectCODE, SubjectDESCRIPTION, SubjectUNIT, SubjectLEVEL, SubjectCAPACITY, CLASS_NUMBER, PROFESSORS_ID, DAY, STARTTIME, ENDTIME, RoomID, SEMESTER_ID, COURSE_ID) 
    VALUES (@scode, @sdescription, @sunits, @slevel, @scapacity, @cnumber ,@sprofessors, @day, @starttime, @endtime, @room, @semesters, @scourse)", conn)
                
                cmdInsert.Parameters.AddWithValue("@scode", txtscodes.Text)
                cmdInsert.Parameters.AddWithValue("@sdescription", txtsname.Text)
                cmdInsert.Parameters.AddWithValue("@sunits", txtsunits.Text)
                cmdInsert.Parameters.AddWithValue("@slevel", cmbslevel.Text)
                cmdInsert.Parameters.AddWithValue("@scapacity", txtcapacity.Text)
                cmdInsert.Parameters.AddWithValue("@sprofessors", cmbprof.SelectedValue)
                cmdInsert.Parameters.AddWithValue("@day", txtclassday.Text)
                cmdInsert.Parameters.AddWithValue("@starttime", starttime.Text) ' Format to hh:mm
                cmdInsert.Parameters.AddWithValue("@endtime", endtime.Text)
                cmdInsert.Parameters.AddWithValue("@cnumber", txtclassnumber.Text)
                ' Use DBNull.Value for RoomID if it's -1 (not found) to allow NULL in the database
                cmdInsert.Parameters.AddWithValue("@room", cmbroom.SelectedValue)
                'cmdInsert.Parameters.AddWithValue("@room", If(roomId = -1, DBNull.Value, CType(roomId, Object)))

                cmdInsert.Parameters.AddWithValue("@semesters", cmbsemester.SelectedValue)
                cmdInsert.Parameters.AddWithValue("@scourse", cmbcourse.SelectedValue)
                cmdInsert.ExecuteNonQuery()

                MessageBox.Show("Added Successfully")
                subjectspage.subjectload()
                MAINTENANCES.subjectload()
                Me.Close()
            End Using
        End Using
    End Sub

    Private Function GetRoomId(connection As SqlConnection, roomNumber As String, roomType As String) As Integer
        Dim getRoomIdQuery As String = "SELECT RoomID FROM tblROOM WHERE RoomNumber = @RoomNumber AND (RoomType = @RoomTypeParam OR (@RoomTypeParam IS NULL AND RoomType IS NULL))"

        Using command As New SqlCommand(getRoomIdQuery, connection)
            command.Parameters.AddWithValue("@RoomNumber", roomNumber)
            command.Parameters.AddWithValue("@RoomTypeParam", If(String.IsNullOrEmpty(roomType), DBNull.Value, roomType))

            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return CInt(result)
            Else
                Return -1 ' Room not found
            End If
        End Using
    End Function

    Private Function IsClassNumberExists(connection As SqlConnection, classNumber As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM SUBJECTS WHERE CLASS_NUMBER = @ClassNumber"
        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClassNumber", classNumber)
            Return CInt(command.ExecuteScalar()) > 0
        End Using
    End Function

    Private Function IsSubjectCodeExists(connection As SqlConnection, subjectCode As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM SUBJECTS WHERE SubjectCODE = @SubjectCode"
        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@SubjectCode", subjectCode)
            Return CInt(command.ExecuteScalar()) > 0
        End Using
    End Function




    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged
        cmbslevel.Items.Clear()

        ' Get the selected course from the cmbcourse ComboBox
        Dim selectedCourse As String = cmbcourse.Text  ' Use the Text property

        ' Make sure a course is selected before querying for course duration
        If Not String.IsNullOrWhiteSpace(selectedCourse) Then
            ' Create a SqlConnection and SqlCommand
            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' SQL query to dynamically retrieve the available year levels based on course duration
                Dim query As String = "SELECT COURSE_DURATION FROM COURSES WHERE COURSE_CODE = @coursecode"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@coursecode", selectedCourse)

                    ' Execute the SQL query and retrieve the result
                    Dim courseDuration As Object = command.ExecuteScalar()

                    If courseDuration IsNot Nothing AndAlso Not IsDBNull(courseDuration) Then
                        ' Try parsing courseDuration into an integer
                        Dim durationYears As Integer

                        If Integer.TryParse(courseDuration.ToString(), durationYears) Then
                            ' Generate year level options based on course duration
                            For i As Integer = 1 To durationYears
                                cmbslevel.Items.Add(i & If(i = 1, "st", If(i = 2, "nd", If(i = 3, "rd", "th"))) & " year")
                            Next
                        Else
                            'MessageBox.Show("Course duration is not in a valid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        'MessageBox.Show("Course duration is missing or invalid for the selected course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End If
    End Sub

    Dim datatable As New DataTable

    Public Sub load_data()
        datatable.Clear() ' Clear the existing data in the DataTable

        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT SUBJECT_ID [SUBJECT ID], SUBJECT_CODES [SUBJECT CODES], SUBJECT_DESCRIPTION [SUBJECT DESCRIPTION],YEAR_LEVEL[YEAR LEVEL], UNITS, s.SEMESTER_NAME [SEMESTER NAME], c.COURSE_CODE [COURSE CODE], CONCAT(p.FIRST_NAME, ' ', p.LAST_NAME) [FULL NAME] FROM tblsubject su
JOIN tblsemester s ON su.SEMESTER_ID = s.SEMESTER_ID
JOIN tblcourses c ON su.COURSE_ID = c.COURSE_ID
JOIN tblprofessorss p ON su.PROFESSORS_ID = p.PROFESSORS_Id"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(datatable)
        End Using

        subjectspage.Guna2DataGridView1.DataSource = datatable
    End Sub

    Private Sub cmbroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbroom.SelectedIndexChanged
        cmbroomtype.SelectedValue = cmbroom.SelectedValue
        'Using conn As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")
        '    conn.Open()
        '    cmd = New SqlCommand("SELECT * FROM tblROOM WHERE RoomNumber LIKE '%" & cmbroom.Text & "%' ", conn)
        '    Dim adapter As New SqlDataAdapter(cmd)
        '    Dim dt As New DataTable
        '    adapter.Fill(dt)
        '    If dt.Rows.Count > 0 Then
        '        cmbroomtype.Text = dt.Rows(0).Item("RoomType").ToString

        '    End If

        'End Using
    End Sub

    Private Sub cmbroomtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbroomtype.SelectedIndexChanged
        'cmbroom.SelectedValue = cmbroomtype.SelectedValue
    End Sub
End Class