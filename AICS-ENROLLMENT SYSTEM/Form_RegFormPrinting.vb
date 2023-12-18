Imports System.Data.SqlClient
Public Class Form_RegFormPrinting
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ds = New DataSet1
        da = New SqlDataAdapter("Select CONCAT(t1.FirstName,' ',t1.MiddleName,' ',t1.LastName) as fullname, t1.Gender,t1.Course,t1.YearLevel,t1.EnrolleeType,
                                 t2.SEMESTER_NAME,t3.StudentNumber,t4.SCHOOLYEAR,t5.STARTTIME,t5.SubjectCODE,t5.SubjectDESCRIPTION,t5.SubjectUNIT,
                                 t6.RoomNumber,t5.CLASS_NUMBER,t7.modeofpayment,t8.total,t8.amountperterm from tblstudentss as t1
                                 JOIN tblstudentsubjects as t3 on t3.StudentID = t1.StudentID
                                 JOIN tblsemester as t2 on t2.SEMESTER_ID = t3.SEMESTER_ID
                                 JOIN SCHOOLYEAR as t4 on t4.SCHOOLYEAR_ID = t3.SCHOOLYEAR_ID
                                 JOIN SUBJECTS as t5 on t5.SubjectID = t3.SubjectID
                                 JOIN tblROOM as t6 on t6.RoomID = t5.RoomID
                                 JOIN tblMode as t7 on t7.idnumber = t3.StudentNumber
                                 JOIN tblInitialPayment as t8 on t8.idnumber = t3.StudentNumber
                                 WHERE t3.StudentNumber = '" & TextBox1.Text & "'", con)
        da.Fill(ds, "DataTable1")

        da = New SqlDataAdapter("Select t1.StudentNumber,t2.SubjectCODE,t2.SubjectDESCRIPTION,t2.SubjectUNIT,t3.RoomNumber,t3.RoomType,t2.CLASS_NUMBER from tblstudentsubjects as t1
                                 JOIN SUBJECTS as t2 on t2.SubjectID = t1.SubjectID
                                 JOIN tblROOM as t3 on t3.RoomID = t2.RoomID
                                 WHERE t1.StudentNumber = '" & TextBox1.Text & "'", con)

        da.Fill(ds, "DataTable2")
        MsgBox(ds.Tables("DataTable2").Rows.Count)

        Dim SubReport As New SubReport
        SubReport.SetDataSource(ds)


        Dim RegistrationForm As New RegistrationForm
        RegistrationForm.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = RegistrationForm

    End Sub
End Class