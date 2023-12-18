Imports System.Data.SqlClient

Public Class assessmentform
    Private connStr As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
    Private connection As New SqlConnection(connStr)
    Dim studid As String = ""



    Public Sub GenerateAdmissionID()
        RunQuery("Select * from tblstudentss")
        If ds.Tables("querytable").Rows.Count = 0 Then
            admissionidgenerated.Text = "AID" + Format(Now, "yyyy") + "00001"
        Else
            RunCommand("Select TOP 1 StudentID from tblstudentss ORDER BY StudentID Desc")
            Dim num As Integer = cmd.ExecuteScalar
            num += 1
            admissionidgenerated.Text = "AID" + Format(Now, "yyyy") + Format(num, "D5")
        End If
    End Sub


    Private Sub LoadCourseComboBox()

        Using connection As New SqlConnection(connStr)
            connection.Open()

            Dim query As String = "SELECT DISTINCT COURSE_TITLE FROM COURSES"

            Using command As New SqlCommand(query, connection)
                ' Execute the SQL query and retrieve the results
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Populate the CourseComboBox
                        cmbcourse.Items.Add(reader("COURSE_TITLE").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        ListView1.Items.Clear()
        Using connection As New SqlConnection(connStr)
            Using command As New SqlCommand("Select * from tblrequirements WHERE requirements_classifications = '" & cmbtype.Text & "'", connection)
                connection.Open()
                Using dr As SqlDataReader = command.ExecuteReader
                    While dr.Read
                        Dim lvitem As New ListViewItem
                        lvitem.Text = dr("requirements_name")
                        ListView1.Items.Add(lvitem)
                    End While
                End Using
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Using con As New SqlConnection(connStr)
                con.Open()

                Dim query As String = "INSERT INTO tblstudentss (AdmissionID,LastName, FirstName, MiddleName, Age, Address, PlaceOfBirth, Birthdate, GuardianName, TelephoneNumber, Lrn, Gender, LastSchoolYearAttended, Course, YearLevel, EnrolleeType) VALUES (@AdmissionID,@LastName, @FirstName, @MiddleName, @Age, @Address, @PlaceOfBirth, @Birthdate, @GuardianName, @TelephoneNumber, @Lrn, @Gender, @LastSchoolyearAttended, @Course, @YearLevel, @Type);"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@AdmissionID", admissionidgenerated.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtlastname.Text)
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtmiddlename.Text)
                    cmd.Parameters.AddWithValue("@Age", txtage.Text)
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text)
                    cmd.Parameters.AddWithValue("@PlaceOfBirth", txtpob.Text)
                    cmd.Parameters.AddWithValue("@Birthdate", txtdob.Value)
                    cmd.Parameters.AddWithValue("@GuardianName", txtguardianname.Text)
                    cmd.Parameters.AddWithValue("@TelephoneNumber", txttelno.Text)
                    cmd.Parameters.AddWithValue("@Lrn", txtlrn.Text)
                    cmd.Parameters.AddWithValue("@Gender", GetSelectedGender())
                    cmd.Parameters.AddWithValue("@LastSchoolyearAttended", txtlastschool.Text)
                    cmd.Parameters.AddWithValue("@Course", cmbcourse.Text)
                    cmd.Parameters.AddWithValue("@Type", cmbtype.Text)
                    ' Convert the selected year level to an integer
                    Dim yearLevel As String = cmbyear.Text
                    cmd.Parameters.AddWithValue("@YearLevel", cmbyear.Text)

                    cmd.ExecuteNonQuery()
                End Using

                RunCommand("Select TOP 1 StudentID from tblstudentss ORDER BY StudentID DESC")
                Dim StudentID As String = cmd.ExecuteScalar

                For Each item As ListViewItem In ListView1.Items
                    If item.Checked Then
                        Dim requirements_name As String = item.SubItems(0).Text
                        RunCommand("Insert into tbl_submittedreqs VALUES ('" & StudentID & "','" & requirements_name & "')")
                        cmd.ExecuteNonQuery()
                    End If
                Next

                MessageBox.Show("Student record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                addmissionpage.LoadData()
                ' Clear form fields if needed
                ClearFormFields()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFormFields()
        txtfirstname.Clear()
        txtlastname.Clear()
        txtdob.Value = Date.Now
        radmale.Checked = False
        radfemale.Checked = False
    End Sub

    Private Function GetSelectedGender() As String
        If radmale.Checked Then
            Return "Male"
        ElseIf radfemale.Checked Then
            Return "Female"
        Else
            ' Default to "Not Specified" if none is selected
            Return "Not Specified"
        End If
    End Function

    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged
        ' Clear the year level ComboBox
        cmbyear.Items.Clear()

        ' Get the selected course from the cmbcourse ComboBox
        Dim selectedCourse As String = cmbcourse.Text  ' Use the Text property

        ' Make sure a course is selected before querying for course duration
        If Not String.IsNullOrWhiteSpace(selectedCourse) Then
            ' Create a SqlConnection and SqlCommand
            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' SQL query to dynamically retrieve the available year levels based on course duration
                Dim query As String = "SELECT COURSE_DURATION FROM tblcourses WHERE COURSE_CODE= @coursecode"

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
                                ' Append "st", "nd", "rd", or "th" based on the year number
                                Dim yearLabel As String = i.ToString() & GetYearSuffix(i)
                                cmbyear.Items.Add(yearLabel)
                            Next
                        Else
                            ' Handle the case where course duration is not a valid integer
                        End If
                    Else
                        ' Handle the case where course duration is missing or invalid for the selected course
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

    Private Sub assessmentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseComboBox()
        GenerateAdmissionID()

        ' Load department data into a ComboBox
        Dim query As String = "SELECT DISTINCT requirements_classifications FROM tblrequirements"
        Using connection As New SqlConnection(connStr)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    cmbtype.DataSource = table
                    cmbtype.DisplayMember = "requirements_classifications"
                    cmbtype.ValueMember = "requirements_classifications"
                Catch ex As Exception
                    MessageBox.Show("Error while loading departments: " & ex.Message)
                End Try
            End Using
        End Using

        Dim courseQuery As String = "SELECT COURSE_ID, COURSE_CODE, COURSE_TITLE, COURSE_DURATION, DepartmentID FROM COURSES"
        Using courseConnection As New SqlConnection(connStr)
            Using courseCommand As New SqlCommand(courseQuery, courseConnection)
                Try
                    courseConnection.Open()
                    Dim courseAdapter As New SqlDataAdapter(courseCommand)
                    Dim courseTable As New DataTable()
                    courseAdapter.Fill(courseTable)
                    cmbcourse.DataSource = courseTable
                    cmbcourse.DisplayMember = "COURSE_CODE"
                    cmbcourse.ValueMember = "COURSE_ID"
                Catch courseEx As Exception
                    MessageBox.Show("Error while loading courses: " & courseEx.Message)
                End Try
            End Using
        End Using
        ' Clear form fields if needed
        ClearFormFields()
    End Sub


End Class