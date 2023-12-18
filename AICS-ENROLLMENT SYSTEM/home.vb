Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class home
    Dim sqlconnection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True")
    Private ReadOnly loggedInUsername As String

    Public Sub New(ByVal username As String)
        InitializeComponent()

        loggedInUsername = username
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        LoadUserData(loggedInUsername)
    End Sub


    Public Sub LoadUserData(username As String)
        sqlconnection.Open()


        Dim query As String = "SELECT PICTURE, FIRSTNAME, LASTNAME, USER_ROLE FROM USERS_TABLE WHERE USERNAME=@USERNAME"
        Dim command As New SqlCommand(query, sqlconnection)
        command.Parameters.AddWithValue("@USERNAME", username)
        Dim reader As SqlDataReader = command.ExecuteReader()


        If reader.Read() Then

            Dim firstname As String = reader("FIRSTNAME").ToString()
            Dim lastname As String = reader("LASTNAME").ToString()
            Dim rolee As String = reader("USER_ROLE").ToString().ToUpper()


            DisplayUserData(firstname, lastname, rolee)


            LoadUserPicture(reader)
        End If


        reader.Close()
    End Sub

    Public Sub RefreshUserData(username As String)
        LoadUserData(username)
    End Sub

    Private Sub DisplayUserData(firstname As String, lastname As String, rolee As String)
        lblname.Text = firstname.ToUpper & " " & lastname.ToUpper
        lblname.Left = (Guna2Panel1.Width - lblname.Width) \ 2
        lblname.Top = (Guna2Panel1.Height - lblname.Height) \ 6

        lblrole.Text = rolee.ToUpper
        lblrole.Left = (Guna2Panel1.Width - lblrole.Width) \ 2
    End Sub

    Private Sub LoadUserPicture(reader As SqlDataReader)
        Dim pictureBytes As String = reader("PICTURE")

        If pictureBytes IsNot Nothing AndAlso pictureBytes.Length > 0 Then
            Try
                Guna2CirclePictureBox1.Image = Image.FromFile(pictureBytes)
            Catch ex As Exception

                MessageBox.Show("Error loading user image: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No user image data found.")
        End If
    End Sub

    Private Sub UpdateDateTimeAndCenter()
        datetimee.Text = DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")

        ' Calculate the center position of the panel
        Dim centerX As Integer = (Guna2Panel1.Width - datetimee.Width) \ 2
        Dim centerY As Integer = (Guna2Panel1.Height - datetimee.Height) \ 27

        ' Set the location of datetimee to center it within the panel
        datetimee.Location = New Point(centerX, centerY)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Call the method to update datetimee and center it
        UpdateDateTimeAndCenter()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        With MAINTENANCES
            .TopLevel = False
            Guna2Panel2.Controls.Add(MAINTENANCES)
            .BringToFront()
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub

    Private Sub Guna2ButtonHover(button As Guna2Button)
        ' Change the HoverState.FillColor of the clicked button
        button.HoverState.FillColor = SystemColors.ControlLightLight
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With addmissionpage
            .TopLevel = False
            Guna2Panel2.Controls.Add(addmissionpage)
            .BringToFront()
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        With collegeenrollingpage
            .TopLevel = False
            Guna2Panel2.Controls.Add(collegeenrollingpage)
            .BringToFront()
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub



    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        With professorspage
            .TopLevel = False
            Guna2Panel2.Controls.Add(professorspage)
            .BringToFront()
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With subjectspage
            .TopLevel = False
            Guna2Panel2.Controls.Add(subjectspage)
            .BringToFront()
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User confirmed to exit, so exit the program
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        With dashboard
            .TopLevel = False
            Guna2Panel2.Controls.Add(dashboard)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
            .Dock = DockStyle.Fill
        End With
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Form_RegFormPrinting.Show()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        formAccountingPlatform.Show()
    End Sub
End Class
