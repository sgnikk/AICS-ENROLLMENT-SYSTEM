<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollmentforms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtsearchbar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnenroll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtstudentnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbsyyear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtcourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbsemester = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtstudentname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.enrolleddate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lvsubjects = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.txtsearchbar)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(705, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(103, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Search Student "
        '
        'txtsearchbar
        '
        Me.txtsearchbar.BorderColor = System.Drawing.Color.Black
        Me.txtsearchbar.BorderRadius = 13
        Me.txtsearchbar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearchbar.CustomizableEdges.BottomRight = False
        Me.txtsearchbar.CustomizableEdges.TopRight = False
        Me.txtsearchbar.DefaultText = ""
        Me.txtsearchbar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearchbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearchbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearchbar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearchbar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchbar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearchbar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchbar.Location = New System.Drawing.Point(438, 10)
        Me.txtsearchbar.Name = "txtsearchbar"
        Me.txtsearchbar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearchbar.PlaceholderText = ""
        Me.txtsearchbar.SelectedText = ""
        Me.txtsearchbar.Size = New System.Drawing.Size(261, 30)
        Me.txtsearchbar.TabIndex = 0
        '
        'btnenroll
        '
        Me.btnenroll.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnenroll.BorderColor = System.Drawing.Color.White
        Me.btnenroll.BorderThickness = 1
        Me.btnenroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnenroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnenroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnenroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnenroll.FillColor = System.Drawing.Color.Black
        Me.btnenroll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnenroll.ForeColor = System.Drawing.Color.White
        Me.btnenroll.Location = New System.Drawing.Point(2, 464)
        Me.btnenroll.Name = "btnenroll"
        Me.btnenroll.Size = New System.Drawing.Size(162, 46)
        Me.btnenroll.TabIndex = 2
        Me.btnenroll.Text = "ENROLL"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2Button2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Button2.BorderRadius = 1
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(657, 464)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(158, 46)
        Me.Guna2Button2.TabIndex = 3
        Me.Guna2Button2.Text = "Close"
        '
        'txtstudentnumber
        '
        Me.txtstudentnumber.BorderColor = System.Drawing.Color.Black
        Me.txtstudentnumber.BorderRadius = 5
        Me.txtstudentnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstudentnumber.DefaultText = ""
        Me.txtstudentnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstudentnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstudentnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstudentnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstudentnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstudentnumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstudentnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstudentnumber.Location = New System.Drawing.Point(26, 144)
        Me.txtstudentnumber.Name = "txtstudentnumber"
        Me.txtstudentnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstudentnumber.PlaceholderText = ""
        Me.txtstudentnumber.SelectedText = ""
        Me.txtstudentnumber.Size = New System.Drawing.Size(230, 35)
        Me.txtstudentnumber.TabIndex = 4
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(26, 124)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(107, 17)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Student Number"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(26, 58)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(81, 17)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "School Year"
        '
        'cmbsyyear
        '
        Me.cmbsyyear.BackColor = System.Drawing.Color.Transparent
        Me.cmbsyyear.BorderColor = System.Drawing.Color.Black
        Me.cmbsyyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbsyyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsyyear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsyyear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsyyear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbsyyear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbsyyear.ItemHeight = 30
        Me.cmbsyyear.Location = New System.Drawing.Point(26, 82)
        Me.cmbsyyear.Name = "cmbsyyear"
        Me.cmbsyyear.Size = New System.Drawing.Size(230, 36)
        Me.cmbsyyear.TabIndex = 7
        '
        'txtcourse
        '
        Me.txtcourse.BorderColor = System.Drawing.Color.Black
        Me.txtcourse.BorderRadius = 5
        Me.txtcourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcourse.DefaultText = ""
        Me.txtcourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcourse.Location = New System.Drawing.Point(295, 81)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcourse.PlaceholderText = ""
        Me.txtcourse.SelectedText = ""
        Me.txtcourse.Size = New System.Drawing.Size(230, 35)
        Me.txtcourse.TabIndex = 8
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(295, 58)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(49, 17)
        Me.Guna2HtmlLabel4.TabIndex = 9
        Me.Guna2HtmlLabel4.Text = "Course"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(295, 122)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(64, 17)
        Me.Guna2HtmlLabel5.TabIndex = 11
        Me.Guna2HtmlLabel5.Text = "Semester"
        '
        'cmbsemester
        '
        Me.cmbsemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbsemester.BorderColor = System.Drawing.Color.Black
        Me.cmbsemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsemester.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbsemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbsemester.ItemHeight = 30
        Me.cmbsemester.Location = New System.Drawing.Point(295, 143)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.Size = New System.Drawing.Size(230, 36)
        Me.cmbsemester.TabIndex = 12
        '
        'txtstudentname
        '
        Me.txtstudentname.BorderColor = System.Drawing.Color.Black
        Me.txtstudentname.BorderRadius = 5
        Me.txtstudentname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstudentname.DefaultText = ""
        Me.txtstudentname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstudentname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstudentname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstudentname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstudentname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstudentname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstudentname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstudentname.Location = New System.Drawing.Point(565, 83)
        Me.txtstudentname.Name = "txtstudentname"
        Me.txtstudentname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstudentname.PlaceholderText = ""
        Me.txtstudentname.SelectedText = ""
        Me.txtstudentname.Size = New System.Drawing.Size(230, 35)
        Me.txtstudentname.TabIndex = 13
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(565, 58)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(94, 17)
        Me.Guna2HtmlLabel6.TabIndex = 14
        Me.Guna2HtmlLabel6.Text = "Student Name"
        '
        'enrolleddate
        '
        Me.enrolleddate.BorderThickness = 1
        Me.enrolleddate.Checked = True
        Me.enrolleddate.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.enrolleddate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.enrolleddate.ForeColor = System.Drawing.Color.Black
        Me.enrolleddate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.enrolleddate.Location = New System.Drawing.Point(565, 143)
        Me.enrolleddate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.enrolleddate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.enrolleddate.Name = "enrolleddate"
        Me.enrolleddate.Size = New System.Drawing.Size(230, 36)
        Me.enrolleddate.TabIndex = 15
        Me.enrolleddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.enrolleddate.Value = New Date(2023, 11, 22, 1, 0, 38, 186)
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(565, 122)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(33, 17)
        Me.Guna2HtmlLabel7.TabIndex = 16
        Me.Guna2HtmlLabel7.Text = "Date"
        '
        'lvsubjects
        '
        Me.lvsubjects.CheckBoxes = True
        Me.lvsubjects.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Underline)
        Me.lvsubjects.GridLines = True
        Me.lvsubjects.HideSelection = False
        Me.lvsubjects.Location = New System.Drawing.Point(0, 184)
        Me.lvsubjects.Margin = New System.Windows.Forms.Padding(0)
        Me.lvsubjects.Name = "lvsubjects"
        Me.lvsubjects.Size = New System.Drawing.Size(820, 275)
        Me.lvsubjects.TabIndex = 17
        Me.lvsubjects.UseCompatibleStateImageBehavior = False
        Me.lvsubjects.View = System.Windows.Forms.View.Details
        '
        'enrollmentforms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(820, 516)
        Me.Controls.Add(Me.lvsubjects)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.enrolleddate)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.txtstudentname)
        Me.Controls.Add(Me.cmbsemester)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.cmbsyyear)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtstudentnumber)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.btnenroll)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "enrollmentforms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "enrollmentforms"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents enrolleddate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtstudentname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbsemester As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbsyyear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtstudentnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnenroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtsearchbar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lvsubjects As ListView
End Class
