Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class MAINTENANCES

    Dim UserDataTable As New DataTable
    Dim reader As SqlDataReader

    Private Sub MAINTENANCES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userload()
        reqloaddata()
        deptload()
        courseload()
        roomload()
        subjectload()
        tfload()
        schoolyearload()
    End Sub


    Public Sub tfload()
        Dim tftable As New DataTable
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT ID, fee AS 'Fee', amount AS 'Amount' FROM tblfee"

        tftable.Clear()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(tftable)
        End Using

        ' Bind the DataGridView to the DataTable
        tfgridview.DataSource = tftable
        tfgridview.Columns("ID").Visible = False
    End Sub


    Public Sub userload()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT USERS_ID AS 'Users ID',LASTNAME AS 'Last Name',FIRSTNAME AS 'First Name', EMAIL_ADDRESS AS 'Email Address', CONTACT_NUMBER AS 'Contact Number', USERNAME AS 'Username', PASSWORD AS 'Password', USER_ROLE AS 'User Role', PICTURE AS 'User Image' FROM USERS_TABLE"

        UserDataTable.Clear()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(UserDataTable)
        End Using

        ' Bind the DataGridView to the DataTable
        usergridview.DataSource = UserDataTable
        usergridview.Columns("User Image").Visible = False

        ' Populate the ComboBox with the "USER_ROLE" column from the loaded data
        For Each row As DataRow In UserDataTable.Rows
            usersmaintenancee.cmbrole.Items.Add(row("User Role"))
        Next
    End Sub


    Private Sub usergridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles usergridview.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = usergridview.Rows(e.RowIndex)
            Dim imagePath As String = selectedRow.Cells("User Image").Value.ToString()

            usersmaintenancee.txtid.Text = selectedRow.Cells("Users ID").Value.ToString()
            usersmaintenancee.txtlastname.Text = selectedRow.Cells("Last Name").Value.ToString()
            usersmaintenancee.txtfirstname.Text = selectedRow.Cells("First Name").Value.ToString()
            usersmaintenancee.txtemail.Text = selectedRow.Cells("Email Address").Value.ToString()
            usersmaintenancee.txtcontact.Text = selectedRow.Cells("Contact Number").Value.ToString()
            usersmaintenancee.txtusername.Text = selectedRow.Cells("Username").Value.ToString()
            usersmaintenancee.txtpassword.Text = selectedRow.Cells("Password").Value.ToString()
            usersmaintenancee.cmbrole.Text = selectedRow.Cells("User Role").Value.ToString()
            usersmaintenancee.pathtxt.Text = imagePath

            If Not String.IsNullOrEmpty(imagePath) Then
                usersmaintenancee.Guna2PictureBox1.Image = System.Drawing.Image.FromFile(imagePath)
            Else
                usersmaintenancee.Guna2PictureBox1.Image = Nothing ' Set to a default image or clear the picture box
            End If

            usersmaintenancee.Show()
        End If
    End Sub

    Public Sub reqloaddata()
        Dim ReqDataTable As New DataTable
        ' Load data for Guna2DataGridView1
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT * FROM tblrequirements"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            ReqDataTable.Clear() ' Clear the existing data
            adapter.Fill(ReqDataTable)
        End Using

        regridview.DataSource = ReqDataTable

        ' Clear existing items in the ComboBox
        reqmaintenance.cmbclassification.Items.Clear()

        ' Use a HashSet to store unique values
        Dim uniqueClassifications As New HashSet(Of String)

        For Each row As DataRow In ReqDataTable.Rows
            Dim classification As String = row("requirements_classifications").ToString()

            ' Check if the classification is not already in the HashSet
            If Not uniqueClassifications.Contains(classification) Then
                uniqueClassifications.Add(classification)
                reqmaintenance.cmbclassification.Items.Add(classification)
            End If
        Next
        ReqDataTable.Columns("requirements_name").ColumnName = "Requirements Name"
        ReqDataTable.Columns("requirements_classifications").ColumnName = "Requirements Classifications"
        regridview.Columns("requirements_id").Visible = False

    End Sub

    Private Sub regridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles regridview.CellClick
        Dim selectedrow As DataGridViewRow
        'Dim reader As New SqlDataReader
        'Dim query As New SqlCommand = "SELECT requirements_id, requirements_name, requirements_classifications from tblrequirements WHERE requirements_classifications = @requirements_classifications"
        With regridview.CurrentRow.Cells
            reqmaintenance.txtid.Text = .Item(0).Value
            reqmaintenance.Guna2TextBox1.Text = .Item(1).Value
            'Dim classreq As String = reader("requirements_classifications").ToString()
            reqmaintenance.cmbclassification.Text = .Item(2).Value
        End With
        If e.RowIndex >= 0 Then
            selectedrow = regridview.Rows(e.RowIndex)
            reqmaintenance.Show()
        End If
    End Sub

    Public Sub deptload()
        Dim DeptDataTable As New DataTable
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT DepartmentID, DepartmentCode, DepartmentName FROM tbldepartment"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(DeptDataTable)
        End Using

        ' Bind the DataGridView to the DataTable
        departmentgridview.DataSource = DeptDataTable
        ' Populate the ComboBox with the "USER_ROLE" column from the loaded data
        For Each row As DataRow In DeptDataTable.Rows
            usersmaintenancee.cmbrole.Items.Add(row("DepartmentName"))
            coursemaintenance.cmbdept.Items.Add(row("DepartmentName"))
        Next
        DeptDataTable.Columns("DepartmentCode").ColumnName = "Department Code"
        DeptDataTable.Columns("DepartmentName").ColumnName = "Departemnt Name"
    End Sub
    Private Sub departmentgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles departmentgridview.CellClick
        Dim selectedrow As DataGridViewRow
        'Dim reader As New SqlDataReader
        'Dim query As New SqlCommand = "SELECT requirements_id, requirements_name, requirements_classifications from tblrequirements WHERE requirements_classifications = @requirements_classifications"
        With departmentgridview.CurrentRow.Cells
            deptmaintenance.txtid.Text = .Item(0).Value
            deptmaintenance.txtdeptcode.Text = .Item(1).Value
            deptmaintenance.txtdeptname.Text = .Item(2).Value
        End With
        If e.RowIndex >= 0 Then
            selectedrow = departmentgridview.Rows(e.RowIndex)
            deptmaintenance.Show()
        End If
    End Sub

    Public Sub courseload()
        Dim coursedatatable As New DataTable
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT c.COURSE_ID ,c.COURSE_CODE, c.COURSE_TITLE, c.COURSE_DURATION, d.DepartmentName AS DEPARTMENT " &
                      "FROM COURSES c " &
                      "LEFT JOIN tbldepartment d ON c.DepartmentID = d.DepartmentID"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(coursedatatable)
        End Using

        ' Bind the DataGridView to the DataTable
        coursegridview.DataSource = coursedatatable
        coursegridview.Columns("COURSE_ID").Visible = False
        coursedatatable.Columns("COURSE_CODE").ColumnName = "Course Code"
        coursedatatable.Columns("COURSE_TITLE").ColumnName = "Course Title"
        coursedatatable.Columns("COURSE_DURATION").ColumnName = "Course Duration"
        coursedatatable.Columns("DEPARTMENT").ColumnName = "Department"

    End Sub

    Private Sub coursegridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles coursegridview.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = coursegridview.Rows(e.RowIndex)

            If Not IsDBNull(selectedRow.Cells(0).Value) Then
                coursemaintenance.txtid.Text = selectedRow.Cells(0).Value.ToString()
            End If

            If Not IsDBNull(selectedRow.Cells(1).Value) Then
                coursemaintenance.txtboxcoursecode.Text = selectedRow.Cells(1).Value.ToString()
            End If

            If Not IsDBNull(selectedRow.Cells(2).Value) Then
                coursemaintenance.txtcoursedesc.Text = selectedRow.Cells(2).Value.ToString()
            End If

            If Not IsDBNull(selectedRow.Cells(3).Value) Then
                coursemaintenance.txtcourseduration.Text = selectedRow.Cells(3).Value.ToString()
            End If

            If Not IsDBNull(selectedRow.Cells(4).Value) Then
                coursemaintenance.cmbdept.Text = selectedRow.Cells(4).Value.ToString()
            End If

            coursemaintenance.Show()
        End If
    End Sub

    Public Sub roomload()
        Dim roomdatatable As New DataTable
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT RoomID, RoomNumber, " &
                          "CASE WHEN RoomType IS NULL OR RoomType = '' THEN 'NOTHING' ELSE RoomType END AS RoomType " &
                          "FROM tblROOM;"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(roomdatatable)
        End Using

        ' Bind the DataGridView to the DataTable
        roomgridview.DataSource = roomdatatable

        ' Optionally, set the visibility of RoomID column
        roomgridview.Columns("RoomID").Visible = False
    End Sub


    Private Sub roomgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles roomgridview.CellClick
        Dim selectedrow As DataGridViewRow
        With roomgridview.CurrentRow.Cells
            roommaintenance.txtid.Text = .Item(0).Value
            roommaintenance.txtroomnumber.Text = .Item(1).Value
            roommaintenance.txtroomtype.Text = .Item(2).Value
        End With
        If e.RowIndex >= 0 Then
            selectedrow = roomgridview.Rows(e.RowIndex)
            roommaintenance.Show()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        userformm.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        requirementsform.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        deptform.Show()
    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        COURSEFORM.Show()
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        roomform.Show()
    End Sub

    Public Sub subjectload()
        Dim subjectdatatable As New DataTable()

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
            adapter.Fill(subjectdatatable)
            ' Bind the DataTable to the Guna2DataGridView       
            subjectgridview.DataSource = subjectdatatable
            subjectgridview.Columns("Subject ID").Visible = False
            subjectgridview.Columns("Class Number").DisplayIndex = 0
            subjectgridview.Columns("Subject Code").DisplayIndex = 1
            subjectgridview.Columns("Subject Title").DisplayIndex = 2
            subjectgridview.Columns("Unit").DisplayIndex = 3
            subjectgridview.Columns("Room Type").DisplayIndex = 4
            subjectgridview.Columns("Day").DisplayIndex = 5
            subjectgridview.Columns("Time").DisplayIndex = 6
            subjectgridview.Columns("Instructor").DisplayIndex = 7
            subjectgridview.Columns("Room Number").DisplayIndex = 8
            subjectgridview.Columns("Subject Level").DisplayIndex = 9
            subjectgridview.Columns("Semester").DisplayIndex = 10
            subjectgridview.Columns("Course").DisplayIndex = 11
            subjectgridview.Columns("Capacity").DisplayIndex = 12
            subjectgridview.AutoGenerateColumns = False
        End Using
    End Sub


    'Private Sub subjectgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectgridview.CellClick
    '    If e.RowIndex >= 0 Then
    '        Dim selectedRow As DataGridViewRow = subjectgridview.Rows(e.RowIndex)

    '        ' Set values to the subjectmaintenance form controls
    '        subjectmaintenance.txtid.Text = selectedRow.Cells(0).Value?.ToString()
    '        subjectmaintenance.txtscodes.Text = selectedRow.Cells(1).Value?.ToString()
    '        subjectmaintenance.txtsname.Text = selectedRow.Cells(2).Value?.ToString()
    '        subjectmaintenance.txtsunits.Text = selectedRow.Cells(3).Value?.ToString()
    '        subjectmaintenance.cmbslevel.Text = selectedRow.Cells(4).Value?.ToString()
    '        subjectmaintenance.txtcapacity.Text = selectedRow.Cells(5).Value?.ToString()
    '        subjectmaintenance.cmbprof.Text = selectedRow.Cells(6).Value?.ToString()
    '        subjectmaintenance.txtclassday.Text = selectedRow.Cells(7).Value?.ToString()

    '        ' Check if the value in the cell is a valid DateTime for start time
    '        Dim startTimeString As String = selectedRow.Cells(8).Value?.ToString()
    '        Dim parsedStartTime As DateTime
    '        If DateTime.TryParse(startTimeString, parsedStartTime) Then
    '            subjectmaintenance.starttime.Value = parsedStartTime
    '        Else
    '            ' Handle the case where parsing fails (display a message, log, etc.)
    '            MessageBox.Show("Invalid start time format.")
    '        End If

    '        ' Check if the value in the cell is a valid DateTime for end time
    '        Dim endTimeString As String = selectedRow.Cells(9).Value?.ToString()
    '        Dim parsedEndTime As DateTime
    '        If DateTime.TryParse(endTimeString, parsedEndTime) Then
    '            subjectmaintenance.endtime.Value = parsedEndTime
    '        Else
    '            MessageBox.Show("Invalid end time format.")
    '        End If

    '        ' Show the subjectmaintenance form
    '        subjectmaintenance.Show()
    '    End If
    'End Sub


    Private Sub subjectgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectgridview.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = subjectgridview.Rows(e.RowIndex)
            ' Rest of your code to set other values in assessmentform2
            subjectmaintenance.txtid.Text = selectedRow.Cells(0).Value.ToString()

            subjectmaintenance.Show()
        End If
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        schoolyearform.Show()
    End Sub

    Public Sub schoolyearload()
        Dim schoolyeardatatable As New DataTable
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT * FROM SCHOOLYEAR"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(schoolyeardatatable)
        End Using

        ' Bind the DataGridView to the DataTable
        sygridview.DataSource = schoolyeardatatable
        'sygridview.Columns("SCHOOLYEAR_ID").Visible = False
    End Sub

    Private Sub sygridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles sygridview.CellClick
        Dim selectedrow As New DataGridViewRow
        With sygridview.CurrentRow.Cells
            symaintenances.txtid.Text = .Item(0).Value
            symaintenances.txtschoolyr.Text = .Item(1).Value
        End With
        If e.RowIndex >= 0 Then
            selectedrow = sygridview.Rows(e.RowIndex)
            symaintenances.Show()
        End If
    End Sub

    Private Sub btnaddroom_Click(sender As Object, e As EventArgs) Handles btnaddroom.Click
        deptform.Show()
    End Sub

    Private Sub btnaddroomss_Click(sender As Object, e As EventArgs) Handles btnaddroomss.Click
        roomform.Show()
    End Sub

    Private Sub btnaddcourse_Click(sender As Object, e As EventArgs) Handles btnaddcourse.Click
        COURSEFORM.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        subjectform.Show()
    End Sub

    Private Sub tfgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tfgridview.CellClick
        For Each row As DataGridViewRow In tfgridview.SelectedRows
            With formAccountingMaintenance
                .idtf = row.Cells(0).Value
                .txtfee.Text = row.Cells(1).Value
                .txtamount.Text = row.Cells(2).Value
                .Show()
                .ComboBox1.SelectedIndex = 1
            End With
        Next
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        formAccountingMaintenance.Show()
    End Sub
End Class
