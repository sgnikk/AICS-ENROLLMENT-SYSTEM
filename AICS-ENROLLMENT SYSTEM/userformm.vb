Imports System.Data.SqlClient

Public Class userformm

    Dim sqlconnection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")
    Dim connectionString As String = sqlconnection.ConnectionString

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

    Private Sub pathtxt_TextChanged(sender As Object, e As EventArgs) Handles pathtxt.TextChanged
        If (System.IO.File.Exists(pathtxt.Text)) Then
            Guna2PictureBox1.Image = Image.FromFile(pathtxt.Text)
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Using conn As New SqlConnection(connectionString)
            Dim command As New SqlCommand("INSERT INTO USERS_TABLE (LASTNAME, FIRSTNAME, EMAIL_ADDRESS, CONTACT_NUMBER, USERNAME, PASSWORD, USER_ROLE, PICTURE) VALUES (@lname, @fname, @email, @contact, @username, @password, @userrole, @picture)", conn)
            command.Parameters.AddWithValue("@lname", txtlastname.Text)
            command.Parameters.AddWithValue("@fname", txtfirstname.Text)
            command.Parameters.AddWithValue("@email", txtemail.Text)
            command.Parameters.AddWithValue("@contact", txtcontact.Text)
            command.Parameters.AddWithValue("@username", txtusername.Text)
            command.Parameters.AddWithValue("@password", txtpassword.Text)
            command.Parameters.AddWithValue("@userrole", cmbrole.Text)
            command.Parameters.AddWithValue("@picture", pathtxt.Text) ' Store the file path directly

            Try
                conn.Open()
                If command.ExecuteNonQuery() > 0 Then
                    MsgBox("User inserted")
                    MAINTENANCES.userload()
                Else
                    MsgBox("Insertion failed")
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Guna2PictureBox1.Image = Nothing
        pathtxt.Text = "" ' Clear the file path
    End Sub
    Private Sub userformm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbrole.Items.Add("ADMIN")
        cmbrole.Items.Add("STAFF")
        cmbrole.Items.Add("CASHIER")
    End Sub
End Class