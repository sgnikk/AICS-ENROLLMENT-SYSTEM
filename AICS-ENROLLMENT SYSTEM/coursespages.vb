Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class coursespages

    Private _sqlcommand As SqlCommand

    'Public Shared coursesPagesFormInstance As coursespages

    Private Sub coursespages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_AICS_ENROLLMENT_SYSTEMDataSet2.tblcourses' table. You can move, or remove it, as needed.
        Me.TblcoursesTableAdapter.Fill(Me._AICS_ENROLLMENT_SYSTEMDataSet2.tblcourses)
        load_data()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        COURSEFORM.Show()
    End Sub

    Public Sub load_data()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
        Dim query As String = "SELECT COURSE_ID, COURSE_CODE, COURSE_DESCRIPTION, COURSE_DURATION FROM tblcourses "
        Dim adapter As New SqlDataAdapter(query, connectionString)
        Dim table As New DataTable()
        adapter.Fill(table)

        CATEGORIESDGV.DataSource = table
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CATEGORIESDGV.CellClick
        Dim SelectedRow As DataGridViewRow
        With CATEGORIESDGV.CurrentRow.Cells
            coursemaintenance.txtid.Text = .Item(0).Value
            coursemaintenance.txtboxcoursecode.Text = .Item(1).Value
            coursemaintenance.txtcoursedesc.Text = .Item(2).Value
            coursemaintenance.txtcourseduration.Text = .Item(3).Value
        End With
        If e.RowIndex >= 0 Then
            SelectedRow = CATEGORIESDGV.Rows(e.RowIndex)
            coursemaintenance.Show()
        End If
    End Sub

End Class
