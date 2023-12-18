Public Class formAccountingPlatform
    Dim idnumber As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Insert ID Number")
            Exit Sub
        End If


        RunQuery("Select * from tblInitialPayment where idnumber = '" & TextBox1.Text & "' order by id")
        If ds.Tables("querytable").Rows.Count = 0 Then
            MsgBox("No record")
            Exit Sub
        Else
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ds.Tables("querytable")
        End If

        RunQuery("Select TOP 1 concat(t1.LastName,',',t1.FirstName,' ',t1.MiddleName) as fullname,t2.modeofpayment,t3.amountperterm,t3.total,max(t3.balance) as balance from tblstudentss as t1
                  JOIN tblstudentsubjects as t9 on t9.StudentID = t1.StudentID
                  JOIN tblmode as t2 on t2.idnumber = t9.StudentNumber
                  JOIN tblInitialPayment as t3 on t3.idnumber = t9.StudentNumber
                  WHERE t3.idnumber = '" & TextBox1.Text & "'
				  group by t1.LastName,t1.FirstName,t1.MiddleName,t2.modeofpayment,t3.amountperterm,t3.total,t3.balance,t3.id
				  order by t3.id desc")
        If ds.Tables("querytable").Rows.Count > 0 Then
            txtStudent.Text = ds.Tables("querytable").Rows(0)(0).ToString
            txtModeOfPayment.Text = ds.Tables("querytable").Rows(0)(1).ToString
            txtAmountPerTerm.Text = ds.Tables("querytable").Rows(0)(2).ToString
            txtTotalTuition.Text = ds.Tables("querytable").Rows(0)(3).ToString
            txtBalance.Text = ds.Tables("querytable").Rows(0)(4).ToString
        Else
            MsgBox("No records")
            Exit Sub
        End If
    End Sub

    Private Sub formAccountingPlatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
    End Sub

    Private Sub txtORAmount_TextChanged(sender As Object, e As EventArgs) Handles txtORAmount.TextChanged
        txtNewBalance.Text = Val(txtBalance.Text) - Val(txtORAmount.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RunCommand("Insert into tblInitialPayment VALUES (@idnumber,@total,@amountperterm,@ornumber,@oramount,@balance)") '
        cmd.Parameters.AddWithValue("@idnumber", TextBox1.Text)
        cmd.Parameters.AddWithValue("@total", txtTotalTuition.Text)
        cmd.Parameters.AddWithValue("@amountperterm", txtAmountPerTerm.Text)
        cmd.Parameters.AddWithValue("@ornumber", txtORNumber.Text)
        cmd.Parameters.AddWithValue("@oramount", txtORAmount.Text)
        cmd.Parameters.AddWithValue("@balance", txtNewBalance.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Success")
        TextBox1.Clear()
        txtTotalTuition.Clear()
        txtAmountPerTerm.Clear()
        txtORNumber.Clear()
        txtORAmount.Clear()
        txtNewBalance.Clear()
        txtBalance.Clear()
        txtModeOfPayment.Clear()
        txtStudent.Clear()
        DataGridView1.DataSource = Nothing
    End Sub
End Class