Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Xml

Public Class addmissionpage
    Private connStr As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
    Private connection As New SqlConnection(connStr)
    Dim adapter As New SqlDataAdapter
    Dim datatable As New DataTable
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        assessmentform.Show()
    End Sub

    Private Sub LoadCourseComboBox()
        Using connection As New SqlConnection(connStr)
            connection.Open()
            Dim query As String = "SELECT DISTINCT COURSE_CODE FROM COURSES"

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbcourse.Items.Add(reader("COURSE_CODE").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged
        courseandyrfilter()
        Guna2HtmlLabel1.Hide()
        cmbyearr.Items.Clear()

        Dim selectedCourse As String = cmbcourse.Text

        If Not String.IsNullOrWhiteSpace(selectedCourse) Then

            Using connection As New SqlConnection(connStr)
                connection.Open()

                Dim query As String = "SELECT COURSE_DURATION FROM COURSES WHERE COURSE_CODE = @coursecode"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@coursecode", selectedCourse)

                    Dim courseDuration As Object = command.ExecuteScalar()

                    If courseDuration IsNot Nothing AndAlso Not IsDBNull(courseDuration) Then
                        Dim durationYears As Integer
                        If Integer.TryParse(courseDuration.ToString(), durationYears) Then
                            For i As Integer = 1 To durationYears
                                cmbyearr.Items.Add(i & If(i = 1, "st", If(i = 2, "nd", If(i = 3, "rd", "th"))) & " year")
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
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            assessmentform2.txtid.Text = selectedRow.Cells(0).Value.ToString()
            assessmentform2.Show()
        End If
    End Sub



    Public Sub LoadData()
        Dim query As String = "SELECT 
                            StudentID AS 'Student ID',
                            AdmissionID AS 'Admission ID',
                            LastName AS 'Last Name',
                            FirstName AS 'First Name',
                            MiddleName AS 'Middle Name',
                            Age AS 'Age',
                            Address AS 'Address',
                            PlaceOfBirth AS 'Place of Birth',
                            Birthdate AS 'Birthdate',
                            GuardianName AS 'Guardian Name',
                            TelephoneNumber AS 'Telephone Number',
                            Lrn AS 'LRN',
                            Gender AS 'Gender',
                            LastSchoolYearAttended AS 'Last School Year Attended',
                            Course AS 'Course',
                            YearLevel AS 'Year Level',
                            EnrolleeType AS 'Enrollee Type'
                            FROM tblstudentss s
                            WHERE NOT EXISTS (
    SELECT 1
    FROM tblstudentsubjects a
    WHERE a.[StudentID] = s.[StudentID]
)"
        RunQuery(query)
        Guna2DataGridView1.DataSource = ds.Tables("querytable")
        Guna2DataGridView1.Columns("Student ID").Visible = False
        Guna2DataGridView1.Columns("Last School Year Attended").Visible = False
    End Sub


    Private Sub addmissionpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadCourseComboBox()
        courseandyrfilter()
    End Sub

    Public Sub courseandyrfilter()
        If cmbyearr.SelectedItem IsNot Nothing AndAlso cmbcourse.SelectedItem IsNot Nothing Then
            Using connection As New SqlConnection(connStr)
                Dim selectedYear As String = cmbyearr.SelectedItem.ToString()
                Dim selectedCourse As String = cmbcourse.SelectedItem.ToString()

                ' Requery the database with the new filter condition
                Dim selectQuery As String = $"SELECT * FROM tblstudentss WHERE YearLevel = '{selectedYear}' AND Course = '{selectedCourse}'"
                adapter.SelectCommand = New SqlCommand(selectQuery, connection)

                ' Clear the existing DataTable and refill it with the filtered data
                datatable.Clear()
                adapter.Fill(datatable)

                ' Update the DataGridView with the filtered data
                Guna2DataGridView1.DataSource = datatable
            End Using
        End If
    End Sub
    Private Sub cmbyearr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyearr.SelectedIndexChanged
        Guna2HtmlLabel3.Hide()
        courseandyrfilter()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Using connection As New SqlConnection(connStr)
            connection.Open()
            Dim query As String = "SELECT * FROM tblstudentss WHERE FirstName LIKE @fname OR LastName LIKE @lname"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@fname", "%" & txtusername.Text & "%")
                adapter.SelectCommand.Parameters.AddWithValue("@lname", "%" & txtusername.Text & "%")
                datatable.Clear()
                adapter.Fill(datatable)
            End Using
        End Using
        ReloadDataGridView()
    End Sub

    Private Sub ReloadDataGridView()
        If datatable.Rows.Count > 0 Then
            ' Assuming you have a DataGridView named Guna2DataGridView1
            Guna2DataGridView1.DataSource = datatable

            ' Check if Guna2DataGridView1 is not Nothing and has columns
            If Guna2DataGridView1 IsNot Nothing AndAlso Guna2DataGridView1.Columns.Count > 0 Then
                ' Hide the first column (index 0), which is assumed to be "Student ID"
                Guna2DataGridView1.Columns(0).Visible = False
            End If
        Else
            ' If there are no results, clear the DataGridView
            Guna2DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        ' Check if the text in txtusername is empty and reload the DataGridView
        If String.IsNullOrEmpty(txtusername.Text) Then
            ReloadDataGridView()
        End If
    End Sub



End Class
