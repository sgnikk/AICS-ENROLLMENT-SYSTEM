Imports System.Data.SqlClient

Public Class requirementsform

    Public Sub load_data()
        RunQuery("Select * from tblrequirements")
        MAINTENANCES.reqgridview.DataSource = ds.Tables("querytable")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        RunCommand("Insert into tblrequirements VALUES 
                    ('" & Guna2TextBox1.Text & "',
                    '" & cmbclassification.Text & "')")
        cmd.ExecuteNonQuery()
        MsgBox("Added", MsgBoxStyle.OkOnly)
        load_data()
        Guna2TextBox1.Clear()
        MAINTENANCES.reqloaddata()
    End Sub

    Private Sub requirementsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
        cmbclassification.Items.Add("New Enrollee")
        cmbclassification.Items.Add("Transferee")
        cmbclassification.Items.Add("Old Student")
    End Sub
End Class