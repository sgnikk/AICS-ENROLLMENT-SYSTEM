Imports System.Data.SqlClient

Public Class collegeenrollingpage
    Dim Datatable As New DataTable
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        enrollmentforms.Show()
    End Sub

    Private Sub collegeenrollingpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayenrolled()
    End Sub

    Public Sub displayenrolled()
        Dim enrolledtable As New DataTable
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT sus.StudentNumber As 'Student ID' ,CONCAT(s.LastName, ', ',s.FirstName, ', ',s.MiddleName) AS 'Student Name', s.Lrn AS LRN, s.Course, sy.SCHOOLYEAR AS 'School Year', sem.SEMESTER_NAME AS 'Semester Name', ss.SubjectID " &
                      "FROM tblstudentsubjects sus " &
                      "LEFT JOIN tblstudentss s ON sus.StudentID = s.StudentID " &
                      "LEFT JOIN SCHOOLYEAR sy ON sus.SCHOOLYEAR_ID = sy.SCHOOLYEAR_ID " &
                      "LEFT JOIN tblsemester sem ON sus.SEMESTER_ID = sem.SEMESTER_ID " & ' Added space here
                      "LEFT JOIN SUBJECTS ss ON sus.SubjectID = ss.SubjectID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(enrolledtable)
        End Using

        ' Bind the DataGridView to the DataTable
        Guna2DataGridView1.DataSource = enrolledtable
        Guna2DataGridView1.Columns("SubjectID").Visible = False
        Guna2DataGridView1.Columns("School Year").Visible = False
        Guna2DataGridView1.Columns("LRN").DisplayIndex = 0


    End Sub


    'Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
    '    Dim selectedrow As New DataGridViewRow
    '    enrollmentforms.Show()
    'End Sub
End Class