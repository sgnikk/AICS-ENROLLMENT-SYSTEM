Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Collections.ObjectModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms

Public Class adminform
    Dim sqlconnection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True")

    Private Sub usersform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbrole.Items.Add("ADMIN")
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png"
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim originalImage As Image = Image.FromFile(dlg.FileName)
            Guna2PictureBox1.Image = ResizeImage(originalImage, Guna2PictureBox1.Size)
            Dim imageData As Byte() = ImageToByteArray(Guna2PictureBox1.Image)
            Guna2PictureBox1.Tag = imageData
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Using conn As New SqlConnection(sqlconnection.ConnectionString)
            conn.Open()
            Using cmdInsert As New SqlCommand("INSERT INTO USERS_TABLE (PICTURE, LASTNAME, FIRSTNAME, EMAIL_ADDRESS, CONTACT_NUMBER, USERNAME, PASSWORD, USER_ROLE) VALUES (@PICTURE, @LASTNAME, @FIRSTNAME, @EMAIL_ADDRESS, @CONTACT_NUMBER, @USERNAME, @PASSWORD, @USER_ROLE)", conn)
                cmdInsert.Parameters.AddWithValue("@LASTNAME", txtlastname.Text)
                cmdInsert.Parameters.AddWithValue("@FIRSTNAME", txtfirstname.Text)
                cmdInsert.Parameters.AddWithValue("@EMAIL_ADDRESS", txtemail.Text)
                cmdInsert.Parameters.AddWithValue("@CONTACT_NUMBER", txtcontact.Text)
                cmdInsert.Parameters.AddWithValue("@USERNAME", txtusername.Text)
                cmdInsert.Parameters.AddWithValue("@PASSWORD", txtpassword.Text)
                cmdInsert.Parameters.AddWithValue("@USER_ROLE", cmbrole.Text)
                cmdInsert.Parameters.Add("@PICTURE", SqlDbType.VarBinary).Value = Guna2PictureBox1.Tag
                cmdInsert.ExecuteNonQuery()
                MessageBox.Show("New User Added Successfully")
            End Using
        End Using
    End Sub

    Private Sub adminform_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnsubmit.PerformClick()
        End If
    End Sub
End Class
