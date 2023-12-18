Imports System.Data.SqlClient

Public Class symaintenances
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Using conn As New SqlConnection(connection.ConnectionString)
            conn.Open() ' Open the connection before executing the query
            Dim query As String = "UPDATE SCHOOLYEAR SET SCHOOLYEAR = @syear WHERE SCHOOLYEAR_ID = @id"
            Using cmdUpdate As New SqlCommand(query, conn)
                cmdUpdate.Parameters.AddWithValue("@id", txtid.Text)
                cmdUpdate.Parameters.AddWithValue("@syear", txtschoolyr.Text)
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Updated Successfully")
                MAINTENANCES.schoolyearload()
                Me.Close()
            End Using
        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Check if there are related records in tblstudentsubjects
                Dim checkQuery As String = "SELECT COUNT(*) FROM tblstudentsubjects WHERE SCHOOLYEAR_ID = @id"

                Using cmdCheck As New SqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@id", txtid.Text)
                    Dim count As Integer = CInt(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Cannot delete this schoolyear because this is the active school year.")
                    Else
                        ' No related records, proceed with deletion
                        Dim deleteQuery As String = "DELETE FROM SCHOOLYEAR WHERE SCHOOLYEAR_ID = @id"

                        Using cmdDelete As New SqlCommand(deleteQuery, conn)
                            cmdDelete.Parameters.AddWithValue("@id", txtid.Text)
                            cmdDelete.ExecuteNonQuery()
                            MAINTENANCES.schoolyearload()
                            MessageBox.Show("Record Deleted Successfully")
                            ' Your additional logic here
                            Me.Close()
                        End Using
                    End If
                End Using
            End Using
        End If
    End Sub

End Class