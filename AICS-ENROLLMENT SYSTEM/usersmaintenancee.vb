Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class usersmaintenancee

    Private connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;"

    Private Sub usersmaintenancee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbrole.Items.Add("ADMIN")
        cmbrole.Items.Add("STAFF")
        cmbrole.Items.Add("CASHIER")
    End Sub
    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            With openFileDialog
                .Filter = "Image Files|*.png;*.jpeg;*.jpg"
                .FilterIndex = 1
            End With
            If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Guna2PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                pathtxt.Text = openFileDialog.FileName ' Set the file path
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Using conn As New SqlConnection(connectionString)
            Dim command As New SqlCommand("UPDATE USERS_TABLE SET LASTNAME = @lname, FIRSTNAME = @fname, EMAIL_ADDRESS = @email, CONTACT_NUMBER = @contact, USERNAME = @username, PASSWORD = @password, USER_ROLE = @userrole, PICTURE = @picture WHERE USERS_ID = @userID", conn)
            command.Parameters.AddWithValue("@lname", txtlastname.Text)
            command.Parameters.AddWithValue("@fname", txtfirstname.Text)
            command.Parameters.AddWithValue("@email", txtemail.Text)
            command.Parameters.AddWithValue("@contact", txtcontact.Text)
            command.Parameters.AddWithValue("@username", txtusername.Text)
            command.Parameters.AddWithValue("@password", txtpassword.Text)
            command.Parameters.AddWithValue("@userrole", cmbrole.Text)
            command.Parameters.AddWithValue("@picture", pathtxt.Text)
            command.Parameters.AddWithValue("@userID", txtid.Text)
            Try
                conn.Open()
                If command.ExecuteNonQuery() > 0 Then
                    MsgBox("User updated")
                    MAINTENANCES.userload()
                Else
                    MsgBox("Update failed")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub



    Private Sub pathtxt_TextChanged(sender As Object, e As EventArgs) Handles pathtxt.TextChanged
        If (System.IO.File.Exists(pathtxt.Text)) Then
            Guna2PictureBox1.Image = Image.FromFile(pathtxt.Text)
        End If
    End Sub
End Class
