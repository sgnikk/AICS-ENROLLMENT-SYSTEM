Imports System.Linq.Expressions

Public Class formTuitionPayment
    Dim TotalAmount As Integer = 0
    Public Sub clearFields()
        txtAmountPerUnit.Clear()
        txtBalance.Clear()
        txtORAmount.Clear()
        txtORNumber.Clear()
        txtPerTerm.Clear()
        txtTotalAmount.Clear()
        txtTotalUnits.Clear()
        rbAnnual.Checked = False
        rbSemiAnnual.Checked = False
        rbQuarterly.Checked = False
        rbMonthly.Checked = False
    End Sub
    Public Sub load_data()
        RunQuery("Select * from tblfee")
        DataGridView2.DataSource = ds.Tables("querytable")


        RunQuery("Select * from tblunit")
        If ds.Tables("querytable").Rows.Count > 0 Then
            txtAmountPerUnit.Text = ds.Tables("querytable").Rows(0)(0).ToString
        End If

        RunQuery("Select sum(t1.subjectunit) from subjects as t1
                  join tblstudentsubjects as t2 on t2.SubjectID = t1.SubjectID
                  WHERE t2.StudentNumber = '" & Label1.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            txtTotalUnits.Text = ds.Tables("querytable").Rows(0)(0).ToString
        End If
    End Sub
    Private Sub formTuitionPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
        load_data()
        txtTotalAmount.Text = (txtAmountPerUnit.Text) * Val(txtTotalUnits.Text)
        TotalAmount = Val(txtTotalAmount.Text)
    End Sub
    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView2.Columns("Column6").Index Then
            UpdateTotalAmount()
        End If
    End Sub

    Private Sub UpdateTotalAmount()
        Dim total As Integer = 0

        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim cell As DataGridViewCell = row.Cells("Column6")

            If cell.Value IsNot Nothing AndAlso cell.Value.Equals(True) Then
                Dim valueInColumn8 As Object = row.Cells("Column8").Value

                If valueInColumn8 IsNot Nothing AndAlso IsNumeric(valueInColumn8) Then
                    total += CInt(valueInColumn8)
                End If
            End If
        Next
        txtTotalAmount.Text = TotalAmount + total.ToString()
    End Sub
    Private Sub DataGridView2_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView2.CurrentCellDirtyStateChanged
        If DataGridView2.IsCurrentCellDirty Then
            DataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit)
            UpdateTotalAmount()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If rbAnnual.Checked = True Then
            txtPerTerm.Text = txtTotalAmount.Text
        ElseIf rbMonthly.Checked = True Then
            txtPerTerm.Text = Val(txtTotalAmount.Text) / 8
        ElseIf rbSemiAnnual.Checked = True Then
            txtPerTerm.Text = Val(txtTotalAmount.Text) / 2
        ElseIf rbQuarterly.Checked = True Then
            txtPerTerm.Text = Val(txtTotalAmount.Text) / 4
        Else
            txtPerTerm.Clear()
        End If

        If txtORAmount.Text = "" Then
            txtBalance.Clear()
        Else
            txtBalance.Text = Val(txtTotalAmount.Text) - Val(txtORAmount.Text)
        End If

    End Sub

    Private Sub btnenroll_Click(sender As Object, e As EventArgs) Handles btnenroll.Click
        If txtORAmount.Text = "" Or txtORNumber.Text = "" Then
            MsgBox("Fields are required")
            Exit Sub
        End If

        Dim isvalid As String = txtORAmount.Text
        Dim number As Integer

        If Integer.TryParse(isvalid, number) Then
        Else
            MsgBox("Enter a valid amount")
            Exit Sub
        End If

        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim cell As DataGridViewCell = row.Cells("Column6")

            If cell.Value IsNot Nothing AndAlso cell.Value.Equals(True) Then
                Dim fee As String = row.Cells(2).Value

                RunQuery("Select * from tblOtherFee WHERE idnumber = '" & Label1.Text & "' and fee = '" & fee & "'")
                If ds.Tables("querytable").Rows.Count = 0 Then
                    RunCommand("Insert into tblOtherFee VALUES ('" & Label1.Text & "','" & fee & "')")
                    cmd.ExecuteNonQuery()
                End If
            End If
        Next

        Dim rb As String = ""
        If rbAnnual.Checked = True Then
            rb = "Annual"
        ElseIf rbSemiAnnual.Checked = True Then
            rb = "Semi Annual"
        ElseIf rbQuarterly.Checked = True Then
            rb = "Quarterly"
        ElseIf rbMonthly.Checked = True Then
            rb = "Monthly"
        End If


        RunQuery("Select * from tblMode WHERE idnumber = '" & Label1.Text & "' and modeofpayment = '" & rb & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then
            MsgBox("Transaction already exist")
            collegeenrollingpage.displayenrolled()
            Me.Close()
            Exit Sub
        Else
            RunCommand("Insert into tblMode values ('" & Label1.Text & "','" & rb & "')")
            cmd.ExecuteNonQuery()
        End If

        RunQuery("Select * from tblInitialPayment where idnumber ='" & Label1.Text & "'")
        If ds.Tables("querytable").Rows.Count > 0 Then

            MsgBox("Student already has Initial Payment")
            collegeenrollingpage.displayenrolled()
            Me.Close()
            Exit Sub
        Else
            RunCommand("Insert into tblInitialPayment VALUES (@idnumber,@total,@amountperterm,@ornumber,@oramount,@balance)")
            cmd.Parameters.AddWithValue("@idnumber", Label1.Text)
            cmd.Parameters.AddWithValue("@total", txtTotalAmount.Text)
            cmd.Parameters.AddWithValue("@amountperterm", txtPerTerm.Text)
            cmd.Parameters.AddWithValue("@ornumber", txtORNumber.Text)
            cmd.Parameters.AddWithValue("@oramount", txtORAmount.Text)
            cmd.Parameters.AddWithValue("@balance", txtBalance.Text)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            If MsgBox("Success", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                enrollmentforms.Show()
                Me.Close()
            End If
        End If
        collegeenrollingpage.displayenrolled()
    End Sub
End Class