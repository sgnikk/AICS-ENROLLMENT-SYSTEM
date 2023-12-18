Imports System.Data.SqlClient

Public Class reqmaintenance
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Using conn As New SqlConnection(connection.ConnectionString)
            conn.Open() ' Open the connection before executing the query
            Dim query As String = "UPDATE tblrequirements SET requirements_name = @requirements_name, requirements_classifications = @requirements_classifications WHERE requirements_id = @id"
            Using cmdUpdate As New SqlCommand(query, conn)
                cmdUpdate.Parameters.AddWithValue("@id", txtid.Text)
                cmdUpdate.Parameters.AddWithValue("@requirements_name", Guna2TextBox1.Text)
                cmdUpdate.Parameters.AddWithValue("@requirements_classifications", cmbclassification.Text)
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Updated Successfully")
                MAINTENANCES.reqloaddata()
                Me.Close()
            End Using
        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Prompt the user for confirmation before deleting the record.
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open() ' Open the connection before executing the query
                Dim query As String = "DELETE FROM tblrequirements WHERE requirements_id = @id"
                Using cmdDelete As New SqlCommand(query, conn)
                    cmdDelete.Parameters.AddWithValue("@id", txtid.Text)
                    cmdDelete.ExecuteNonQuery()
                    MessageBox.Show("Record Deleted Successfully")
                    MAINTENANCES.reqloaddata()
                    Me.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub reqmaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class