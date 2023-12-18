Imports Guna.UI2.WinForms
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class profmaintenance
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open() ' Open the connection before executing the query
                Dim query As String = "UPDATE tblprofessorss SET FIRST_NAME = @fname, LAST_NAME = @lname, EMAIL=@email WHERE PROFESSORS_ID = @profid"
                Using cmdUpdate As New SqlCommand(query, conn)
                    cmdUpdate.Parameters.AddWithValue("@fname", txtfname.Text)
                    cmdUpdate.Parameters.AddWithValue("@lname", txtlname.Text)
                    cmdUpdate.Parameters.AddWithValue("@email", txtemail.Text)
                    cmdUpdate.Parameters.AddWithValue("@profid", txtid.Text)
                    cmdUpdate.ExecuteNonQuery()
                    professorspage.load_data()
                    subjectspage.subjectload()
                    MessageBox.Show("Updated Successfully")
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this professor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                Using conn As New SqlConnection(connection.ConnectionString)
                    conn.Open()

                    ' Start a database transaction to ensure atomicity
                    Dim transaction As SqlTransaction = conn.BeginTransaction()

                    Try
                        ' Update related subjects to set PROFESSORS_ID to the default value (-1) in tblsubjectsss
                        Dim updateSubjectsQuery As String = "UPDATE tblsubject SET PROFESSORS_ID = NULL WHERE PROFESSORS_ID = @profid"
                        Using cmdUpdateSubjects As New SqlCommand(updateSubjectsQuery, conn, transaction)
                            cmdUpdateSubjects.Parameters.AddWithValue("@profid", txtid.Text)
                            cmdUpdateSubjects.ExecuteNonQuery()
                        End Using

                        ' Then, delete the professor from tblprofessorss
                        Dim professorDeleteQuery As String = "DELETE FROM tblprofessorss WHERE PROFESSORS_ID = @profid"
                        Using cmdDeleteProfessor As New SqlCommand(professorDeleteQuery, conn, transaction)
                            cmdDeleteProfessor.Parameters.AddWithValue("@profid", txtid.Text)
                            cmdDeleteProfessor.ExecuteNonQuery()
                        End Using

                        ' If both UPDATE and DELETE statements succeed, commit the transaction
                        transaction.Commit()

                        MessageBox.Show("Professor deleted successfully")

                        ' Refresh the professors list in the main page
                        professorspage.load_data()
                        subjectspage.subjectload()
                        ' Close the form
                        Me.Close()
                    Catch ex As Exception
                        ' If an error occurs, roll back the transaction
                        transaction.Rollback()
                        MessageBox.Show("Error deleting professor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub profmaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class