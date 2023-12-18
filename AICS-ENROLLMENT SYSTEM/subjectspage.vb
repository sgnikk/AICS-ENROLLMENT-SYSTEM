Imports System.Data.SqlClient

Public Class subjectspage
    Public Shared subjectsPagesFormInstance As subjectspage

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        subjectform.Show()
    End Sub

    Private Sub subjectspage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subjectload()
    End Sub


    Dim dataTable As New DataTable()
    Public Sub subjectload()
        Try
            Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
            Dim query As String = "
            SELECT
            s.SubjectID AS 'Subject ID',
            s.SubjectCODE AS 'Subject Code',
            s.SubjectDESCRIPTION AS 'Subject Title',
            s.SubjectUNIT AS 'Unit',
            s.SubjectLEVEL AS 'Subject Level',
            s.SubjectCAPACITY AS 'Capacity',
            s.CLASS_NUMBER AS 'Class Number',
            CONCAT(p.FIRST_NAME, ', ', p.LAST_NAME) AS Instructor,
            s.DAY AS 'Day',
            CONCAT(CONVERT(varchar, s.STARTTIME, 108), ' -- ', CONVERT(varchar, s.ENDTIME, 108)) AS Time,
            CASE WHEN s.RoomID IS NULL THEN 'None' ELSE r.RoomNumber END AS 'Room Number',
            COALESCE(r.RoomType, 'NONE') AS 'Room Type',
            sem.SEMESTER_NAME AS 'Semester',
            c.COURSE_CODE AS 'Course'
            FROM
                SUBJECTS s
            LEFT JOIN
                tblprofessorss p ON s.PROFESSORS_ID = p.PROFESSORS_ID
            LEFT JOIN
                tblROOM r ON s.RoomID = r.RoomID
            LEFT JOIN
                tblsemester sem ON s.SEMESTER_ID = sem.SEMESTER_ID
            LEFT JOIN
                COURSES c ON s.COURSE_ID = c.COURSE_ID;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)

                dataTable.Clear()
                adapter.Fill(dataTable)
                Guna2DataGridView1.DataSource = dataTable

                ' Hide all columns first
                For Each column As DataGridViewColumn In Guna2DataGridView1.Columns
                    column.Visible = False
                Next

                ' Display only the desired columns
                Guna2DataGridView1.Columns("Class Number").Visible = True
                Guna2DataGridView1.Columns("Subject Code").Visible = True
                Guna2DataGridView1.Columns("Subject Title").Visible = True
                Guna2DataGridView1.Columns("Time").Visible = True
                Guna2DataGridView1.Columns("Unit").Visible = True
                Guna2DataGridView1.Columns("Day").Visible = True
                Guna2DataGridView1.Columns("Instructor").Visible = True
                Guna2DataGridView1.Columns("Room Number").Visible = True
                Guna2DataGridView1.Columns("Room Type").Visible = True
                Guna2DataGridView1.Columns("Course").Visible = False
                Guna2DataGridView1.Columns("Semester").Visible = False

                ' Set the display index for each column
                Guna2DataGridView1.Columns("Class Number").DisplayIndex = 0
                Guna2DataGridView1.Columns("Subject Code").DisplayIndex = 1
                Guna2DataGridView1.Columns("Subject Title").DisplayIndex = 2
                Guna2DataGridView1.Columns("Unit").DisplayIndex = 3
                Guna2DataGridView1.Columns("Time").DisplayIndex = 4
                Guna2DataGridView1.Columns("Day").DisplayIndex = 5
                Guna2DataGridView1.Columns("Instructor").DisplayIndex = 6
                Guna2DataGridView1.Columns("Room Number").DisplayIndex = 7
                Guna2DataGridView1.Columns("Room Type").DisplayIndex = 8
            End Using
            Console.WriteLine("Data loaded successfully")
        Catch ex As Exception
            Console.WriteLine($"Error loading data: {ex.Message}")
        End Try
    End Sub



    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim selectedrow As DataGridViewRow
        With Guna2DataGridView1.CurrentRow.Cells
            subjectmaintenance.txtid.Text = .Item(0).Value
            subjectmaintenance.txtscodes.Text = .Item(1).Value
            subjectmaintenance.txtsname.Text = .Item(2).Value
            subjectmaintenance.txtsunits.Text = .Item(4).Value
            subjectmaintenance.cmbslevel.Text = .Item(3).Value
            subjectmaintenance.cmbsemester.Text = .Item(5).Value
            subjectmaintenance.cmbcourse.Text = .Item(6).Value
        End With
        If e.RowIndex >= 0 Then
            selectedrow = Guna2DataGridView1.Rows(e.RowIndex)
            subjectmaintenance.Show()
        End If
    End Sub

End Class
