Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class assessmentform2
    Dim connStr As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
    Dim connection As New SqlConnection(connStr)

    Public Sub CheckRequirement()
        ' Clear all check marks in the ListView
        For Each item As ListViewItem In ListView1.Items
            item.Checked = False
        Next

        RunQuery("Select * from tbl_submittedreqs WHERE StudentsID = '" & txtid.Text & "' ")

        ' Create a list to store the submitted requirement names
        Dim submittedRequirements As New List(Of String)

        For Each row As DataRow In ds.Tables("querytable").Rows
            Dim submittedRequirementName As String = row("requirements_name").ToString()
            submittedRequirements.Add(submittedRequirementName)

            ' Check the corresponding item in the ListView
            For Each item As ListViewItem In ListView1.Items
                If item.Text = submittedRequirementName Then
                    item.Checked = True
                End If
            Next
        Next

        ' Uncheck items that were not found in the submitted requirements list
        For Each item As ListViewItem In ListView1.Items
            If Not submittedRequirements.Contains(item.Text) Then
                item.Checked = False
            End If
        Next
    End Sub

    Public Sub DisplayComboBoxes()
        RunQuery("Select DISTINCT COURSE_CODE from COURSES")
        If ds.Tables("querytable").Rows.Count > 0 Then
            cmbcourse.DataSource = ds.Tables("querytable")
            cmbcourse.DisplayMember = "COURSE_CODE"
            cmbcourse.ValueMember = "COURSE_CODE"
        End If
    End Sub


    Public Sub DisplayRequirement()
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


    Public Sub LoadStudentDetails()
        RunQuery("Select * from tblstudentss WHERE StudentID = '" & txtid.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            txtage.Text = ds.Tables("querytable").Rows(0)("Age").ToString
            txtaddress.Text = ds.Tables("querytable").Rows(0)("Address").ToString
            txtlastname.Text = ds.Tables("querytable").Rows(0)("LastName").ToString
            txtfirstname.Text = ds.Tables("querytable").Rows(0)("FirstName").ToString
            admissionidgenerated.Text = ds.Tables("querytable").Rows(0)("AdmissionID").ToString
            txtmiddlename.Text = ds.Tables("querytable").Rows(0)("MiddleName").ToString
            txtpob.Text = ds.Tables("querytable").Rows(0)("PlaceOfBirth").ToString
            txtdob.Value = ds.Tables("querytable").Rows(0)("Birthdate").ToString
            txtguardianname.Text = ds.Tables("querytable").Rows(0)("GuardianName").ToString
            txttelno.Text = ds.Tables("querytable").Rows(0)("TelephoneNumber").ToString
            ''Gender
            If ds.Tables("querytable").Rows(0)("Gender").ToString = "Male" Then
                radmale.Checked = True
            Else
                radfemale.Checked = True
            End If
            txtlrn.Text = ds.Tables("querytable").Rows(0)("Lrn").ToString
            txtlastschool.Text = ds.Tables("querytable").Rows(0)("LastSchoolYearAttended").ToString
            cmbcourse.Text = ds.Tables("querytable").Rows(0)("Course").ToString
            Dim yearLevel As String = ds.Tables("querytable").Rows(0)("YearLevel").ToString()

            ' Find the index of the matching year level in the ComboBox
            Dim index As Integer = cmbyear.FindString(yearLevel)

            ' Set the selected index in the ComboBox
            If index <> 1 Then
                cmbyear.SelectedIndex = index
            Else
                ' Handle the case when the year level from the database doesn't match any in the ComboBox.
                ' You might want to show a message or take appropriate action.
            End If
            cmbtype.Text = ds.Tables("querytable").Rows(0)("EnrolleeType").ToString
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Assuming txtStudentID.Text contains the StudentID you want to delete
                Dim studentID As Integer = Integer.Parse(txtid.Text)

                ' Check if there are associated records
                Dim checkQuery As String = "SELECT COUNT(*) FROM tblstudentsubjects WHERE StudentID = @studentID"

                Using cmdCheck As New SqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@studentID", studentID)
                    Dim count As Integer = CInt(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        ' Associated records found, update StudentID to NULL
                        Dim updateSubjectsQuery As String = "UPDATE tblstudentsubjects SET StudentID = NULL WHERE StudentID = @studentID"

                        Using cmdUpdateSubjects As New SqlCommand(updateSubjectsQuery, conn)
                            cmdUpdateSubjects.Parameters.AddWithValue("@studentID", studentID)
                            cmdUpdateSubjects.ExecuteNonQuery()
                        End Using
                    End If

                    ' Proceed with deleting the student record
                    Dim deleteStudentQuery As String = "DELETE FROM tblstudentss WHERE StudentID = @studentID"

                    Using cmdDeleteStudent As New SqlCommand(deleteStudentQuery, conn)
                        cmdDeleteStudent.Parameters.AddWithValue("@studentID", studentID)
                        cmdDeleteStudent.ExecuteNonQuery()

                        MessageBox.Show("Student record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Assuming addmissionpage is an instance of the form containing LoadData method
                        addmissionpage.LoadData()
                        Me.Close()
                    End Using
                End Using
            End Using
        End If
    End Sub



    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Using conn As New SqlConnection(connection.ConnectionString)
            conn.Open() ' Open the connection before executing the query
            Dim query As String = "UPDATE tblstudentss SET LastName = @lname, FirstName = @fname, MiddleName = @mname, Age = @age, Address = @address, PlaceOfBirth = @pob, Birthdate = @birthdate, GuardianName = @gname, TelephoneNumber = @tnumber, Lrn = @lrn, Gender = @gender, LastSchoolYearAttended = @lastschool, Course = @course, YearLevel = @ylevel, EnrolleeType = @enrolltype WHERE StudentID = @id"
            Using cmdUpdate As New SqlCommand(query, conn)
                If txtid IsNot Nothing Then
                    cmdUpdate.Parameters.AddWithValue("@id", txtid.Text)
                End If
                cmdUpdate.Parameters.AddWithValue("@lname", txtlastname.Text)
                cmdUpdate.Parameters.AddWithValue("@fname", txtfirstname.Text)
                cmdUpdate.Parameters.AddWithValue("@mname", txtmiddlename.Text)
                cmdUpdate.Parameters.AddWithValue("@age", txtage.Text)
                cmdUpdate.Parameters.AddWithValue("@address", txtaddress.Text)
                cmdUpdate.Parameters.AddWithValue("@pob", txtpob.Text)
                cmdUpdate.Parameters.AddWithValue("@birthdate", txtdob.Value)
                cmdUpdate.Parameters.AddWithValue("@gname", txtguardianname.Text)
                cmdUpdate.Parameters.AddWithValue("@tnumber", txttelno.Text)
                cmdUpdate.Parameters.AddWithValue("@lrn", txtlrn.Text)
                If radmale.Checked Then
                    cmdUpdate.Parameters.AddWithValue("@gender", "Male")
                ElseIf radfemale.Checked Then
                    cmdUpdate.Parameters.AddWithValue("@gender", "Female")
                Else
                    cmdUpdate.Parameters.AddWithValue("@gender", "Unknown")
                End If
                cmdUpdate.Parameters.AddWithValue("@lastschool", txtlastschool.Text)
                cmdUpdate.Parameters.AddWithValue("@course", cmbcourse.Text)
                cmdUpdate.Parameters.AddWithValue("@ylevel", cmbyear.Text)
                cmdUpdate.Parameters.AddWithValue("@enrolltype", cmbtype.Text)
                cmdUpdate.ExecuteNonQuery()

                ' Update or insert records in tbl_submittedreqs
                For Each item As ListViewItem In ListView1.Items
                    If item.Checked Then
                        Dim requirements_name As String = item.SubItems(0).Text

                        ' Check if a record with the same StudentsID and requirements_name already exists
                        Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_submittedreqs WHERE StudentsID = @StudentsID AND requirements_name = @requirements_name;"
                        Using checkCmd As New SqlCommand(checkQuery, conn)
                            checkCmd.Parameters.AddWithValue("@StudentsID", txtid.Text) ' Assuming txtid contains the StudentID
                            checkCmd.Parameters.AddWithValue("@requirements_name", requirements_name)
                            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                            If count > 0 Then
                                ' Update the existing record
                                Dim updateQuery As String = "UPDATE tbl_submittedreqs SET StudentsID = @StudentsID WHERE requirements_name = @requirements_name;"
                                Using updateCmd As New SqlCommand(updateQuery, conn)
                                    updateCmd.Parameters.AddWithValue("@StudentsID", txtid.Text) ' Assuming txtid contains the StudentID
                                    updateCmd.Parameters.AddWithValue("@requirements_name", requirements_name)
                                    updateCmd.ExecuteNonQuery()
                                End Using
                            Else
                                ' Insert a new record
                                Dim insertQuery As String = "INSERT INTO tbl_submittedreqs (StudentsID, requirements_name) VALUES (@StudentsID, @requirements_name);"
                                Using insertCmd As New SqlCommand(insertQuery, conn)
                                    insertCmd.Parameters.AddWithValue("@StudentsID", txtid.Text) ' Assuming txtid contains the StudentID
                                    insertCmd.Parameters.AddWithValue("@requirements_name", requirements_name)
                                    insertCmd.ExecuteNonQuery()
                                End Using
                            End If
                        End Using
                    End If
                Next
                MessageBox.Show("Updated Successfully")
                addmissionpage.LoadData()
                Me.Close()
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


    Private Sub assessmentform2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayComboBoxes()
        LoadStudentDetails()
        DisplayRequirement()
        CheckRequirement()
    End Sub



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


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cmbyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyear.SelectedIndexChanged

    End Sub


End Class