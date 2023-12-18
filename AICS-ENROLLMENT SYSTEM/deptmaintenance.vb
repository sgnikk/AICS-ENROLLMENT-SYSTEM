Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class deptmaintenance
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Using conn As New SqlConnection(connection.ConnectionString)
            conn.Open() ' Open the connection before executing the query
            Dim query As String = "UPDATE tbldepartment SET DepartmentCode = @deptcode, DepartmentName = @deptname WHERE DepartmentID = @id"
            Using cmdUpdate As New SqlCommand(query, conn)
                cmdUpdate.Parameters.AddWithValue("@id", txtid.Text)
                cmdUpdate.Parameters.AddWithValue("@deptcode", txtdeptcode.Text)
                cmdUpdate.Parameters.AddWithValue("@deptname", txtdeptname.Text)
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Updated Successfully")
                MAINTENANCES.deptload()
                MAINTENANCES.courseload()
                Me.Close()
            End Using
        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open()

                ' Check if there are related records in COURSES
                Dim countCoursesQuery As String = "SELECT COUNT(*) FROM COURSES WHERE DepartmentID = @id"

                Using cmdCountCourses As New SqlCommand(countCoursesQuery, conn)
                    cmdCountCourses.Parameters.AddWithValue("@id", txtid.Text)
                    Dim countCourses As Integer = CInt(cmdCountCourses.ExecuteScalar())

                    ' Update COURSES table to set DepartmentID to NULL
                    Dim updateCoursesQuery As String = "UPDATE COURSES SET DepartmentID = NULL WHERE DepartmentID = @id"

                    Using cmdUpdateCourses As New SqlCommand(updateCoursesQuery, conn)
                        cmdUpdateCourses.Parameters.AddWithValue("@id", txtid.Text)
                        cmdUpdateCourses.ExecuteNonQuery()
                    End Using

                    ' Proceed with deletion
                    Dim deleteQuery As String = "DELETE FROM tbldepartment WHERE DepartmentID = @id"

                    Using cmdDelete As New SqlCommand(deleteQuery, conn)
                        cmdDelete.Parameters.AddWithValue("@id", txtid.Text)
                        cmdDelete.ExecuteNonQuery()
                        MessageBox.Show("Record Deleted Successfully")
                        MAINTENANCES.deptload()
                        MAINTENANCES.courseload()
                        Me.Close()
                    End Using
                End Using
            End Using
        End If
    End Sub




    Private Sub deptmaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class