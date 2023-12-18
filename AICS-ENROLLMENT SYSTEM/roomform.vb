Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class roomform
    Dim connection As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True;")

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click

        ' If the room number is unique, proceed with the insertion
        Try
            Using conn As New SqlConnection(connection.ConnectionString)
                conn.Open() ' Open the connection before executing the query

                ' Check if controls and other objects are not null before using them
                If txtroomnumber IsNot Nothing AndAlso txtroomtype IsNot Nothing AndAlso MAINTENANCES IsNot Nothing Then
                    ' Check if the room number already exists
                    If Not IsRoomNumberExists(conn, txtroomnumber.Text) Then
                        ' Room number is unique, proceed with insertion
                        Dim query As String = "INSERT INTO tblROOM (RoomNumber, RoomType) VALUES(@rnumber, @rtype)"
                        Using cmdInsert As New SqlCommand(query, conn)
                            cmdInsert.Parameters.AddWithValue("@rnumber", txtroomnumber.Text)
                            cmdInsert.Parameters.AddWithValue("@rtype", txtroomtype.Text)
                            cmdInsert.ExecuteNonQuery()
                            MessageBox.Show("Added Successfully")
                            MAINTENANCES.roomload()
                            txtroomnumber.Clear()
                            Me.Close()
                        End Using
                    Else
                        MessageBox.Show("Room number already exists.")
                    End If
                Else
                    MessageBox.Show("One or more controls or objects are null.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function IsRoomNumberExists(connection As SqlConnection, roomNumber As String) As Boolean
        ' Check if the room number already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM tblROOM WHERE RoomNumber = @rnumber"
        Using cmdCheck As New SqlCommand(query, connection)
            cmdCheck.Parameters.AddWithValue("@rnumber", roomNumber)
            Dim count As Integer = CInt(cmdCheck.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub roomform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
