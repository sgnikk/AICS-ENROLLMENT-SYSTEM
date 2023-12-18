Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class roommaintenance
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Start a transaction to ensure data consistency
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        Dim query As String = "UPDATE tblROOM SET RoomNumber = @rnumber, RoomType = @rtype WHERE RoomID = @id"

                        Using cmdUpdateRoom As New SqlCommand(query, conn, transaction)
                            cmdUpdateRoom.Parameters.AddWithValue("@id", txtid.Text)
                            cmdUpdateRoom.Parameters.AddWithValue("@rnumber", txtroomnumber.Text)
                            cmdUpdateRoom.Parameters.AddWithValue("@rtype", txtroomtype.Text)
                            cmdUpdateRoom.ExecuteNonQuery()
                        End Using

                        ' Update related rows in SUBJECTS table
                        Dim updateSubjectsQuery As String = "UPDATE SUBJECTS SET RoomID = @roomid WHERE RoomID = @id"

                        Using cmdUpdateSubjects As New SqlCommand(updateSubjectsQuery, conn, transaction)
                            cmdUpdateSubjects.Parameters.AddWithValue("@roomid", txtid.Text)
                            cmdUpdateSubjects.Parameters.AddWithValue("@id", txtid.Text)
                            cmdUpdateSubjects.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction if everything is successful
                        transaction.Commit()

                        MAINTENANCES.roomload()
                        MAINTENANCES.subjectload()
                        MessageBox.Show("Updated Successfully")
                        Me.Close()
                    Catch ex As Exception
                        ' Roll back the transaction if an error occurs
                        transaction.Rollback()
                        MessageBox.Show("Error updating data: " & ex.Message)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Check if there are related records in tblstudentsubjects
                Dim checkQuery As String = "SELECT COUNT(*) FROM tblstudentsubjects WHERE SubjectID = @id"

                Using cmdCheck As New SqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@id", txtid.Text)
                    Dim count As Integer = CInt(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Cannot delete the room. There are related records in tblstudentsubjects.")
                    Else
                        ' No related records, update SubjectID to NULL in SUBJECTS table
                        Dim updateSubjectsQuery As String = "UPDATE SUBJECTS SET RoomID = NULL WHERE RoomID = @id"

                        Using cmdUpdateSubjects As New SqlCommand(updateSubjectsQuery, conn)
                            cmdUpdateSubjects.Parameters.AddWithValue("@id", txtid.Text)
                            cmdUpdateSubjects.ExecuteNonQuery()
                        End Using

                        ' Proceed with deletion
                        Dim deleteQuery As String = "DELETE FROM tblROOM WHERE RoomID = @id"

                        Using cmdDelete As New SqlCommand(deleteQuery, conn)
                            cmdDelete.Parameters.AddWithValue("@id", txtid.Text)
                            cmdDelete.ExecuteNonQuery()
                            MessageBox.Show("Record Deleted Successfully")
                            MAINTENANCES.roomload()
                            subjectspage.subjectload()
                            MAINTENANCES.subjectload()
                            Me.Close()
                        End Using
                    End If
                End Using

            End Using
        End If
    End Sub




    Private Sub roommaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class