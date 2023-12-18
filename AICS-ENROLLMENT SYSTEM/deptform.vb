Imports System.Data.SqlClient

Public Class deptform
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open() ' Open the connection before executing the query

                ' Check if controls and other objects are not null before using them
                If txtdeptcode IsNot Nothing AndAlso txtdeptname IsNot Nothing AndAlso MAINTENANCES IsNot Nothing Then
                    ' Check if the department code or name already exists
                    If Not IsDepartmentExists(conn, txtdeptcode.Text, txtdeptname.Text) Then
                        ' Department code and name are unique, proceed with insertion
                        Dim query As String = "INSERT INTO tbldepartment (DepartmentCode, DepartmentName) VALUES(@deptcode, @deptname)"
                        Using cmdInsert As New SqlCommand(query, conn)
                            cmdInsert.Parameters.AddWithValue("@deptcode", txtdeptcode.Text)
                            cmdInsert.Parameters.AddWithValue("@deptname", txtdeptname.Text)
                            cmdInsert.ExecuteNonQuery()
                            MessageBox.Show("Added Successfully")
                            MAINTENANCES.deptload()
                            Me.Close()
                        End Using
                    Else
                        MessageBox.Show("Department code or name already exists.")
                    End If
                Else
                    MessageBox.Show("One or more controls or objects are null.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function IsDepartmentExists(connection As SqlConnection, deptCode As String, deptName As String) As Boolean
        ' Check if the department code or name already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM tbldepartment WHERE DepartmentCode = @deptcode OR DepartmentName = @deptname"
        Using cmdCheck As New SqlCommand(query, connection)
            cmdCheck.Parameters.AddWithValue("@deptcode", deptCode)
            cmdCheck.Parameters.AddWithValue("@deptname", deptName)
            Dim count As Integer = CInt(cmdCheck.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub deptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
