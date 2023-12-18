Public Class formAccountingMaintenance
    Public idtf As String = ""

    Public Sub clear()
        txtfee.Clear()
        txtamount.Clear()
        idtf = ""
    End Sub
    Public Sub load_data()
        RunQuery("Select * from tblfee")
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = ds.Tables("querytable")

        RunQuery("Select * from tblunit")
        If ds.Tables("querytable").Rows.Count > 0 Then
            txtOldAmount.Text = ds.Tables("querytable").Rows(0)(0).ToString
        Else
            txtOldAmount.Clear()
        End If

    End Sub
    Private Sub formAccounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
        load_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtfee.Text = "" Or txtamount.Text = "" Then
            MsgBox("Fields are required!")
            Exit Sub
        End If

        Dim input As String = txtamount.Text
        Dim valid As Integer

        If Integer.TryParse(input, valid) Then
        Else
            MsgBox("Please enter a valid amount")
            Exit Sub
        End If




        RunQuery("Select * from tblfee where fee = '" & txtfee.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            MsgBox("Fee already registered")
            txtfee.Clear()
            Exit Sub
        End If

        RunCommand("Insert into tblfee VALUES (@fee,@amount)")
        cmd.Parameters.AddWithValue("@fee", txtfee.Text)
        cmd.Parameters.AddWithValue("@amount", txtamount.Text)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        MsgBox("Success")
        load_data()
        clear()
        MAINTENANCES.tfload()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                idtf = row.Cells(0).Value
                txtfee.Text = row.Cells(1).Value
                txtamount.Text = row.Cells(2).Value
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtfee.Text = "" Or txtamount.Text = "" Then
            MsgBox("Fields are required!")
            Exit Sub
        End If

        Dim input As String = txtamount.Text
        Dim valid As Integer

        If Integer.TryParse(input, valid) Then
        Else
            MsgBox("Please enter a valid amount")
            txtamount.Clear()
            Exit Sub
        End If

        RunQuery("Select * from tblfee where fee = '" & txtfee.Text & "' and id <> '" & idtf & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            MsgBox("Fee already exist")
            clear()
            Exit Sub
        End If

        RunCommand("Update tblfee set fee=@fee,amount=@amount WHERE id = '" & idtf & "'")
        cmd.Parameters.AddWithValue("@fee", txtfee.Text)
        cmd.Parameters.AddWithValue("@amount", txtamount.Text)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        MsgBox("Success")
        load_data()
        clear()
        MAINTENANCES.tfload()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If idtf = "" Then
            MsgBox("Please select a fee to delete")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RunCommand("Delete from tblfee WHERE id = '" & idtf & "'")
            cmd.ExecuteNonQuery()
            MsgBox("Success")
            load_data()
            clear()

        End If
        MAINTENANCES.tfload()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            GroupBox2.Show()
            GroupBox1.Hide()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            GroupBox2.Hide()
            GroupBox1.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrEmpty(txtNewAmount.Text) Then
            MsgBox("Please enter a new amount")
            Exit Sub
        End If

        Dim isvalid As String = txtNewAmount.Text
        Dim valid As Integer

        If Not Integer.TryParse(isvalid, valid) Then
            MsgBox("Enter a valid amount")
            Exit Sub
        End If

        RunCommand("DELETE FROM tblunit; INSERT INTO tblunit VALUES (@newamount)")
        cmd.Parameters.AddWithValue("@newamount", txtNewAmount.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Success")
        txtNewAmount.Clear()
        load_data()
    End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    If String.IsNullOrEmpty(txtNewAmount.Text) Then
    '        MsgBox("Please enter a new amount")
    '        Exit Sub
    '    End If

    '    Dim isvalid As String = txtNewAmount.Text
    '    Dim valid As Integer

    '    If Not Integer.TryParse(isvalid, valid) Then
    '        MsgBox("Enter a valid amount")
    '        Exit Sub
    '    End If

    '    RunCommand("DELETE FROM tblunit; INSERT INTO tblunit VALUES (@newamount)")
    '    cmd.Parameters.AddWithValue("@newamount", txtNewAmount.Text)
    '    cmd.ExecuteNonQuery()
    '    MsgBox("Success")
    '    txtNewAmount.Clear()
    '    load_data()
    'End Sub

End Class