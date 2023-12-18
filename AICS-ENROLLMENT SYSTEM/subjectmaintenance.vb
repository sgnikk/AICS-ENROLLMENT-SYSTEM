Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class subjectmaintenance
    Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)
    Dim dataTable As New DataTable

    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged
        ' Clear the year level ComboBox
        cmbslevel.Items.Clear()

        ' Get the selected course from the cmbcourse ComboBox
        Dim selectedCourse As String = cmbcourse.Text  ' Use the Text property

        ' Make sure a course is selected before querying for course duration
        If Not String.IsNullOrWhiteSpace(selectedCourse) Then
            ' Create a SqlConnection and SqlCommand
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' SQL query to dynamically retrieve the available year levels based on course duration
                Dim query As String = "SELECT COURSE_DURATION FROM COURSES WHERE COURSE_CODE= @coursecode"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@coursecode", selectedCourse)

                    ' Execute the SQL query and retrieve the result
                    Dim courseDuration As Object = command.ExecuteScalar()

                    If courseDuration IsNot Nothing AndAlso Not IsDBNull(courseDuration) Then
                        ' 
                        Dim durationYears As Integer

                        If Integer.TryParse(courseDuration.ToString(), durationYears) Then
                            ' ASDFASD
                            For i As Integer = 1 To durationYears
                                ' ASDFASDF
                                Dim yearLabel As String = i.ToString() & GetYearSuffix(i)
                                cmbslevel.Items.Add(yearLabel)
                            Next
                        Else
                            ' ASDFASDF
                        End If
                    Else
                        ' ASDFASDFASF
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Function GetYearSuffix(year As Integer) As String
        Select Case year
            Case 1
                Return "st Year"
            Case 2
                Return "nd Year"
            Case 3
                Return "rd Year"
            Case Else
                Return "th Year"
        End Select
    End Function
    Public Sub coursepopulate()
        Dim COURSES As String = "SELECT COURSE_ID,COURSE_CODE,COURSE_TITLE,COURSE_DURATION,DepartmentID FROM COURSES"
        Using courseconnection As New SqlConnection(connectionString)
            Using courseCommand As New SqlCommand(COURSES, courseconnection)
                Try
                    courseconnection.Open()
                    Dim courseAdapter As New SqlDataAdapter(courseCommand)
                    Dim courseTable As New DataTable()
                    courseAdapter.Fill(courseTable)
                    cmbcourse.DataSource = courseTable
                    cmbcourse.DisplayMember = "COURSE_CODE"
                    cmbcourse.ValueMember = "COURSE_ID"
                Catch semesterrEx As Exception
                    MessageBox.Show("Error while loading professors: " & semesterrEx.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub semester()
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
    End Sub

    Public Sub subjectpopulate()
        RunQuery("SELECT * FROM SUBJECTS WHERE SubjectID = '" & txtid.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            txtscodes.Text = ds.Tables("querytable").Rows(0)("SubjectCODE").ToString
            txtsname.Text = ds.Tables("querytable").Rows(0)("SubjectDESCRIPTION").ToString
            txtsunits.Text = ds.Tables("querytable").Rows(0)("SubjectUNIT").ToString
            cmbslevel.Text = ds.Tables("querytable").Rows(0)("SubjectLEVEL").ToString
            txtcapacity.Text = ds.Tables("querytable").Rows(0)("SubjectCAPACITY").ToString
            cmbprof.Text = ds.Tables("querytable").Rows(0)("PROFESSORS_ID").ToString
            txtclassday.Text = ds.Tables("querytable").Rows(0)("DAY").ToString
            txtclassnumber.Text = ds.Tables("querytable").Rows(0)("CLASS_NUMBER").ToString


            Dim prof As String = ds.Tables("querytable").Rows(0)("PROFESSORS_ID").ToString
            Dim profindex As Integer = cmbprof.FindString(prof)
            If profindex <> -1 Then
                cmbprof.SelectedIndex = profindex
            End If

            Dim semester As String = ds.Tables("querytable").Rows(0)("SEMESTER_ID").ToString
            Dim semesterindex As Integer = cmbsemester.FindString(semester)
            If semesterindex <> -1 Then
                cmbsemester.SelectedIndex = semesterindex
            End If

            Dim course As String = ds.Tables("querytable").Rows(0)("COURSE_ID").ToString
            Dim courseindex As Integer = cmbcourse.FindString(course)
            If courseindex <> -1 Then
                cmbcourse.SelectedIndex = courseindex
            End If
        End If
    End Sub

    Private Sub subjectmaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load professor and course data
        LoadProfessorData()
        semester()
        subjectpopulate()
        room()
        coursepopulate()
    End Sub

    Public Sub room()
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

    Private Sub GetSemesterAndCourseIDs(semesterName As String, courseCode As String, ByRef semesterID As Integer, ByRef courseID As Integer)
        semesterID = -1 ' Default value if not found
        courseID = -1 ' Default value if not found

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Get SEMESTER_ID
            Dim semesterQuery As String = "SELECT DISTINCT SEMESTER_ID FROM tblsemester WHERE SEMESTER_NAME = @semesterName"

            Using cmdSemester As New SqlCommand(semesterQuery, conn)
                cmdSemester.Parameters.AddWithValue("@semesterName", semesterName)
                Dim semesterResult As Object = cmdSemester.ExecuteScalar()

                If semesterResult IsNot Nothing AndAlso Not DBNull.Value.Equals(semesterResult) Then
                    Integer.TryParse(semesterResult.ToString(), semesterID)
                End If
            End Using

            ' Get COURSE_ID
            Dim courseQuery As String = "SELECT DISTINCT COURSE_ID FROM tblcourses WHERE COURSE_CODE = @courseCode"

            Using cmdCourse As New SqlCommand(courseQuery, conn)
                cmdCourse.Parameters.AddWithValue("@courseCode", courseCode)
                Dim courseResult As Object = cmdCourse.ExecuteScalar()

                If courseResult IsNot Nothing AndAlso Not DBNull.Value.Equals(courseResult) Then
                    Integer.TryParse(courseResult.ToString(), courseID)
                End If
            End Using
        End Using

    End Sub

    Private Sub LoadProfessorData()
        ' Load professors data into cmbprof combo box
        Dim professorsDataTable As DataTable = GetProfessorsData()

        cmbprof.DataSource = professorsDataTable
        cmbprof.DisplayMember = "FULL NAME"
        cmbprof.ValueMember = "PROFESSORS_ID"
    End Sub


    Private Sub cmbgrdlvl_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Update the label with the selected value from cmbgrdlvl
        cmbslevel.Text = cmbslevel.SelectedValue.ToString()
    End Sub


    Private Function GetProfessorsData() As DataTable
        Dim professorsDataTable As New DataTable

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query As String = "SELECT DISTINCT PROFESSORS_ID, FIRST_NAME + ' ' + LAST_NAME AS [FULL NAME] FROM tblprofessorss"

            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(professorsDataTable)
            End Using
        End Using

        Return professorsDataTable
    End Function

    Private Function GetRoomId(connection As SqlConnection, roomNumber As String, roomType As String) As Integer
        Dim getRoomIdQuery As String = "SELECT RoomID FROM tblROOM WHERE RoomNumber = @RoomNumber AND RoomType = @RoomType"

        Using command As New SqlCommand(getRoomIdQuery, connection)
            command.Parameters.AddWithValue("@RoomNumber", roomNumber)
            command.Parameters.AddWithValue("@RoomType", roomType)

            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return CInt(result)
            Else
                Return -1 ' Room not found
            End If
        End Using
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String = "DELETE FROM SUBJECTS WHERE SubjectID = @id"

                Using cmdDelete As New SqlCommand(query, conn)
                    cmdDelete.Parameters.AddWithValue("@id", txtid.Text)

                    cmdDelete.ExecuteNonQuery()
                    MessageBox.Show("Subject deleted successfully")
                    subjectspage.subjectload()
                    MAINTENANCES.subjectload()
                    Me.Close()
                End Using
            End Using
        End If
    End Sub


    Private Sub cmbroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbroom.SelectedIndexChanged
        cmbroomtype.SelectedValue = cmbroom.SelectedValue
    End Sub


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

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Using conn As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")
            conn.Open()

            ' Get the existing RoomID based on selected room type and room number
            Dim roomNumber As String = If(cmbroom.SelectedItem IsNot Nothing, CType(cmbroom.SelectedItem, DataRowView).Row("RoomNumber").ToString(), "")
            Dim roomType As String = If(cmbroomtype.SelectedItem IsNot Nothing, CType(cmbroomtype.SelectedItem, DataRowView).Row("RoomType").ToString(), "")
            Dim roomId As Integer = GetRoomId(conn, roomNumber, roomType)

            ' Check if the class number already exists

            ' Use the existing RoomID to update data in SUBJECTS table
            Using cmdUpdate As New SqlCommand("
            UPDATE SUBJECTS
            SET 
                SubjectCODE = @scode,
                SubjectDESCRIPTION = @sdescription,
                SubjectUNIT = @sunits,
                SubjectLEVEL = @slevel,
                SubjectCAPACITY = @scapacity,
                CLASS_NUMBER = @cnumber,
                PROFESSORS_ID = @sprofessors,
                DAY = @day,
                STARTTIME = @starttime,
                ENDTIME = @endtime,
                RoomID = @room,
                SEMESTER_ID = @semesters,
                COURSE_ID = @scourse
            WHERE SubjectID = @subjectid;
        ", conn)

                cmdUpdate.Parameters.AddWithValue("@subjectid", txtid.Text)
                cmdUpdate.Parameters.AddWithValue("@scode", txtscodes.Text)
                cmdUpdate.Parameters.AddWithValue("@sdescription", txtsname.Text)
                cmdUpdate.Parameters.AddWithValue("@sunits", txtsunits.Text)
                cmdUpdate.Parameters.AddWithValue("@slevel", cmbslevel.Text)
                cmdUpdate.Parameters.AddWithValue("@scapacity", txtcapacity.Text)
                cmdUpdate.Parameters.AddWithValue("@sprofessors", cmbprof.SelectedValue)
                cmdUpdate.Parameters.AddWithValue("@day", txtclassday.Text)
                cmdUpdate.Parameters.AddWithValue("@starttime", starttime.Text) ' Format to hh:mm
                cmdUpdate.Parameters.AddWithValue("@endtime", endtime.Text)
                cmdUpdate.Parameters.AddWithValue("@cnumber", txtclassnumber.Text)

                ' Use DBNull.Value for RoomID if it's -1 (not found) to allow NULL in the database
                cmdUpdate.Parameters.AddWithValue("@room", If(roomId = -1, DBNull.Value, CType(roomId, Object)))

                cmdUpdate.Parameters.AddWithValue("@semesters", cmbsemester.SelectedValue.ToString)
                cmdUpdate.Parameters.AddWithValue("@scourse", cmbcourse.SelectedValue) ' No need for ToString()

                cmdUpdate.ExecuteNonQuery()

                MessageBox.Show("Updated Successfully")
                MAINTENANCES.subjectload()
                subjectspage.subjectload()
                Me.Close()
            End Using
        End Using
    End Sub

End Class
