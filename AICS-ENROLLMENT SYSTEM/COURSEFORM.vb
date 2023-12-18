Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class COURSEFORM
    ' Define your connection string here
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub COURSEFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMBOBOXDEPT()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open() ' Open the connection before executing the query

                ' Check if controls and other objects are not null before using them
                If txtboxcoursecode IsNot Nothing AndAlso txtcoursedesc IsNot Nothing AndAlso txtcourseduration IsNot Nothing AndAlso cmbdept IsNot Nothing AndAlso MAINTENANCES IsNot Nothing Then
                    ' Check if the course code and title combination already exists
                    If Not IsCourseExists(conn, txtboxcoursecode.Text, txtcoursedesc.Text) Then
                        ' Course code and title are unique, proceed with insertion
                        Dim query As String = "INSERT INTO COURSES (COURSE_CODE, COURSE_TITLE, COURSE_DURATION, DepartmentID) VALUES(@course_code,@course_name, @course_duration, @dept)"
                        Using cmdInsert As New SqlCommand(query, conn)
                            cmdInsert.Parameters.AddWithValue("@course_code", txtboxcoursecode.Text.ToUpper())
                            cmdInsert.Parameters.AddWithValue("@course_name", txtcoursedesc.Text.ToUpper())
                            cmdInsert.Parameters.AddWithValue("@course_duration", txtcourseduration.Text)
                            cmdInsert.Parameters.AddWithValue("@dept", cmbdept.SelectedValue)
                            cmdInsert.ExecuteNonQuery()
                            MessageBox.Show("Added Successfully")
                            MAINTENANCES.courseload()
                            Me.Close()
                        End Using
                    Else
                        MessageBox.Show("Course code and title combination already exists.")
                    End If
                Else
                    MessageBox.Show("One or more controls or objects are null.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function IsCourseExists(connection As SqlConnection, courseCode As String, courseTitle As String) As Boolean
        ' Check if the course code and title combination already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM COURSES WHERE COURSE_CODE = @course_code AND COURSE_TITLE = @course_title"
        Using cmdCheck As New SqlCommand(query, connection)
            cmdCheck.Parameters.AddWithValue("@course_code", courseCode)
            cmdCheck.Parameters.AddWithValue("@course_title", courseTitle)
            Dim count As Integer = CInt(cmdCheck.ExecuteScalar())
            Return count > 0
        End Using
    End Function

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
End Class
