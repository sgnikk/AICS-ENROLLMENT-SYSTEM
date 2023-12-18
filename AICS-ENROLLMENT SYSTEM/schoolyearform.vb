Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class schoolyearform
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")
    Private Sub schoolyearform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the function to generate the current school year
        Dim currentYear As Integer = DateTime.Now.Year
        Dim schoolYear As String = GenerateSchoolYear(currentYear)

        ' Set the generated school year in the TextBox
        txtschoolyr.Text = schoolYear
    End Sub

    Private Sub txtschoolyr_TextChanged(sender As Object, e As EventArgs) Handles txtschoolyr.TextChanged
        ' You can add any additional logic here if needed
    End Sub

    Function GenerateSchoolYear(startYear As Integer) As String
        Dim endYear As Integer = startYear + 1
        Return $"{startYear}-{endYear}"
    End Function

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Using conn As New SqlConnection(connection.ConnectionString)
            conn.Open() ' Open the connection before executing the query
            Dim query As String = "INSERT INTO SCHOOLYEAR (SCHOOLYEAR) VALUES(@sy)"
            Using cmdInsert As New SqlCommand(query, conn)
                cmdInsert.Parameters.AddWithValue("@sy", txtschoolyr.Text)
                cmdInsert.ExecuteNonQuery()
                MessageBox.Show("Added Successfully")
                MAINTENANCES.roomload()
                Me.Close()
                MAINTENANCES.schoolyearload()
            End Using
        End Using
    End Sub
End Class
