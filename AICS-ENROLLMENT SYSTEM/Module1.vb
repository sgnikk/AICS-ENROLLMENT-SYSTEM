Imports System.Data.SqlClient

Module ImageUtils

    Public con As New SqlConnection("Data Source=LAPTOP-NULU4S03\SQLEXPRESS02;Initial Catalog=AICS-ENROLLMENT-SYSTEM;Integrated Security=True")
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public cmd As New SqlCommand
    Public dt As New DataTable

    Public Function ImageToByteArray(image As Image) As Byte()
        Dim converter As New ImageConverter()
        Return DirectCast(converter.ConvertTo(image, GetType(Byte())), Byte())
    End Function

    Public Function ResizeImage(image As Image, size As Size) As Image
        Dim resizedImage As New Bitmap(size.Width, size.Height)
        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, size.Width, size.Height)
        End Using
        Return resizedImage
    End Function

    Public Sub openconnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub RunQuery(ByVal querystatement As String)
        openconnection()
        da = New SqlDataAdapter(querystatement, con)
        ds = New DataSet
        da.Fill(ds, "querytable")
    End Sub

    Public Sub RunCommand(ByVal commandstatement As String)
        cmd = New SqlCommand(commandstatement, con)
    End Sub

End Module
