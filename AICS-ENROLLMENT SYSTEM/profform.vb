Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class profform

    Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"

    Public Sub ReloadData()
        load_data()
    End Sub

    Public Sub load_data()
        RunQuery("Select * from tblprofessorss")
        professorspage.Guna2DataGridView1.DataSource = ds.Tables("querytable")
    End Sub
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ' Check if required fields are not empty
        If String.IsNullOrWhiteSpace(txtfname.Text) OrElse String.IsNullOrWhiteSpace(txtlname.Text) OrElse String.IsNullOrWhiteSpace(txtemail.Text) Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Use parameterized query to insert data into tblprofessors
        Dim sql As String = "INSERT INTO tblprofessorss (FIRST_NAME, LAST_NAME, EMAIL) VALUES (@FirstName, @LastName, @Email)"

        Using connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")
            Using cmd As New SqlCommand(sql, connection)
                connection.Open()
                cmd.Parameters.AddWithValue("@FirstName", txtfname.Text)
                cmd.Parameters.AddWithValue("@LastName", txtlname.Text)
                cmd.Parameters.AddWithValue("@Email", txtemail.Text)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Added", MsgBoxStyle.OkOnly)
                    load_data()
                    txtemail.Clear()
                    txtlname.Clear()
                    txtfname.Clear()

                    Dim parentForm As professorspage = TryCast(Me.ParentForm, professorspage)
                    If parentForm IsNot Nothing Then
                        parentForm.ReloadData()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try

            End Using
        End Using

    End Sub


    Private Sub profform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
    End Sub
End Class