Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Guna.UI2.WinForms ' Import Guna UI Framework

Public Class Form1
    Dim sqlconnection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Customize the button's appearance for the HoverState
        Guna2Button1.HoverState.FillColor = SystemColors.ActiveCaption
        txtpassword.PasswordChar = "*"

        sqlconnection.Open()
        ' Check if there is an admin user in the database
        ' Using com As New SqlCommand("SELECT * FROM USERS_TABLE WHERE USER_ROLE = 'ADMIN'", sqlconnection)
        '     Using reader As SqlDataReader = com.ExecuteReader
        '         If reader.HasRows Then
        ' 
        '         Else
        '             MessageBox.Show("There's no Active Admin")
        '             Me.Close()
        '             Try
        '                 Dim adminForm As New adminform()
        '                 adminForm.ShowDialog()
        '             Catch ex As Exception
        '                 MessageBox.Show("An error occurred: " & ex.Message)
        '             End Try
        '         End If
        '     End Using
        ' End Using
    End Sub

    Private Sub LOGIN()
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        Using conn As New SqlConnection(sqlconnection.ConnectionString)
            conn.Open()
            Using cmd As New SqlCommand("SELECT * FROM USERS_TABLE WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD", conn)
                cmd.Parameters.AddWithValue("@USERNAME", username)
                cmd.Parameters.AddWithValue("@PASSWORD", password) ' Store the password as plain text

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    ' User is authenticated
                    MessageBox.Show("Login Successful!")
                    Me.Hide()
                    Dim homepage As New home(username)
                    homepage.ShowDialog()
                Else
                    MessageBox.Show("Invalid Username or Password")
                End If
            End Using
        End Using
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            ' Show the password
            txtpassword.PasswordChar = ""
        Else
            ' Hide the password
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        ' Check if the Enter key (character code 13) is pressed
        If e.KeyChar = ChrW(13) Then
            ' Trigger the login when Enter key is pressed
            LOGIN()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LOGIN()
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class
