Imports Guna.UI2.WinForms

Public Class professorspage
    Public Sub ReloadData()
        load_data()
    End Sub

    Public Sub load_data()
        RunQuery("Select * from tblprofessorss")
        Guna2DataGridView1.DataSource = ds.Tables("querytable")
    End Sub
    Private Sub professorspage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the '_AICS_ENROLLMENT_SYSTEMDataSet1.tblprofessors' table. You can move, or remove it, as needed.
        'Me.TblprofessorsTableAdapter.Fill(Me._AICS_ENROLLMENT_SYSTEMDataSet1.tblprofessors)
        load_data()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        profform.Show()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim selectedrow As New DataGridViewRow
        With Guna2DataGridView1.CurrentRow.Cells
            profmaintenance.txtid.Text = .Item(0).Value.ToString
            profmaintenance.txtfname.Text = .Item(1).Value.ToString
            profmaintenance.txtlname.Text = .Item(2).Value.ToString
            profmaintenance.txtemail.Text = .Item(3).Value.ToString
        End With
        If e.RowIndex >= 0 Then
            selectedrow = Guna2DataGridView1.Rows(e.RowIndex)
            profmaintenance.Show()
        End If
    End Sub

End Class