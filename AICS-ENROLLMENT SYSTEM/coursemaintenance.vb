Imports System.Data.SqlClient
Imports AICS_ENROLLMENT_SYSTEM._AICS_ENROLLMENT_SYSTEMDataSet2TableAdapters


Public Class coursemaintenance
    Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;" ' Replace with your actual connection string
    Dim connection As New SqlConnection(connectionString)
    Dim dataTable As New DataTable


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Start a transaction to ensure data consistency
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        Dim query As String = "UPDATE COURSES SET COURSE_CODE = @code, COURSE_TITLE = @ctitle, COURSE_DURATION = @cduration, DepartmentID = @deptid  WHERE COURSE_ID = @cid"

                        Using cmdUpdate As New SqlCommand(query, conn, transaction)
                            cmdUpdate.Parameters.AddWithValue("@code", txtboxcoursecode.Text)
                            cmdUpdate.Parameters.AddWithValue("@ctitle", txtcoursedesc.Text)
                            cmdUpdate.Parameters.AddWithValue("@cduration", txtcourseduration.Text)
                            ' Use the correct field name to get DepartmentID from the selected item
                            cmdUpdate.Parameters.AddWithValue("@deptid", DirectCast(cmbdept.SelectedItem, DataRowView)("DepartmentID"))
                            cmdUpdate.Parameters.AddWithValue("@cid", txtid.Text)
                            cmdUpdate.ExecuteNonQuery()

                            ' Update related rows in SUBJECTS table
                            Dim updateSubjectsQuery As String = "UPDATE SUBJECTS SET COURSE_ID = @cid WHERE SubjectID = @sid"

                            Using cmdUpdateSubjects As New SqlCommand(updateSubjectsQuery, conn, transaction)
                                ' Use the correct value for COURSE_ID based on the selected item in the ComboBox
                                cmdUpdateSubjects.Parameters.AddWithValue("@cid", txtid.Text)
                                cmdUpdateSubjects.Parameters.AddWithValue("@sid", txtid.Text)
                                cmdUpdateSubjects.ExecuteNonQuery()
                            End Using

                            transaction.Commit()

                            MAINTENANCES.courseload()
                            MAINTENANCES.subjectload()
                            MessageBox.Show("Updated Successfully")
                            Me.Close()
                        End Using
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

    Public Sub COMBOBOXDEPT()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"
        Dim query As String = "SELECT DepartmentID, DepartmentCode, DepartmentName FROM tbldepartment"
        Dim adapter As New SqlDataAdapter(query, connectionString)
        Dim table As New DataTable()
        adapter.Fill(table)
        ' Set the DataTable as the ComboBox's data source
        cmbdept.DataSource = table
        cmbdept.DisplayMember = "DepartmentName"
        cmbdept.ValueMember = "DepartmentID"
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Check if there are related records in SUBJECTS
                Dim countSubjectsQuery As String = "SELECT COUNT(*) FROM SUBJECTS WHERE COURSE_ID = @id"

                Using cmdCountSubjects As New SqlCommand(countSubjectsQuery, conn)
                    cmdCountSubjects.Parameters.AddWithValue("@id", txtid.Text)
                    Dim countSubjects As Integer = CInt(cmdCountSubjects.ExecuteScalar())

                    If countSubjects > 0 Then
                        ' Update SUBJECTS table to set COURSE_ID to NULL
                        Dim updateSubjectsQuery As String = "UPDATE SUBJECTS SET COURSE_ID = NULL WHERE COURSE_ID = @id"

                        Using cmdUpdateSubjects As New SqlCommand(updateSubjectsQuery, conn)
                            cmdUpdateSubjects.Parameters.AddWithValue("@id", txtid.Text)
                            cmdUpdateSubjects.ExecuteNonQuery()
                        End Using

                        ' Proceed with deletion
                        Dim deleteQuery As String = "DELETE FROM COURSES WHERE COURSE_ID = @id"

                        Using cmdDelete As New SqlCommand(deleteQuery, conn)
                            cmdDelete.Parameters.AddWithValue("@id", txtid.Text)
                            cmdDelete.ExecuteNonQuery()
                            MessageBox.Show("Record Deleted Successfully")
                            MAINTENANCES.courseload()
                            MAINTENANCES.subjectload()
                            Me.Close()
                        End Using
                    Else
                        ' No related records, proceed with deletion
                        Dim deleteQuery As String = "DELETE FROM COURSES WHERE COURSE_ID = @id"

                        Using cmdDelete As New SqlCommand(deleteQuery, conn)
                            cmdDelete.Parameters.AddWithValue("@id", txtid.Text)
                            cmdDelete.ExecuteNonQuery()
                            MessageBox.Show("Record Deleted Successfully")
                            MAINTENANCES.courseload()
                            Me.Close()
                        End Using
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub coursemaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        COMBOBOXDEPT()
    End Sub
End Class