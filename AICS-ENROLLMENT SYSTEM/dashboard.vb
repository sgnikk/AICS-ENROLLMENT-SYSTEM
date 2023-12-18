Imports System.Data.SqlClient

Public Class dashboard
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click
    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel7.Click
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click
    End Sub

    Public Sub TeacherCount()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM tblprofessorss"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim result As Integer = CInt(command.ExecuteScalar())
                    Guna2HtmlLabel2.Text = result.ToString()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error in TeacherCount: " & ex.Message)
        End Try
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TeacherCount()
        SubjectCount()
        CourseCount()
        countunenrolled()
        enrolledcount()
    End Sub
    Public Sub countunenrolled()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM tblstudentss"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim result As Integer = CInt(command.ExecuteScalar())
                    Guna2HtmlLabel7.Text = result.ToString()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error in TeacherCount: " & ex.Message)
        End Try
    End Sub


    Public Sub SubjectCount()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM SUBJECTS"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim result As Integer = CInt(command.ExecuteScalar())
                    Guna2HtmlLabel3.Text = result.ToString()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error in TeacherCount: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2HtmlLabel10_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel10.Click

    End Sub

    Public Sub CourseCount()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM COURSES"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim result As Integer = CInt(command.ExecuteScalar())
                    Guna2HtmlLabel10.Text = result.ToString()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error in TeacherCount: " & ex.Message)
        End Try
    End Sub


    Public Sub enrolledcount()
        Dim connectionString As String = "Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM tblstudentsubjects"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim result As Integer = CInt(command.ExecuteScalar())
                    Guna2HtmlLabel11.Text = result.ToString()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error in TeacherCount: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
