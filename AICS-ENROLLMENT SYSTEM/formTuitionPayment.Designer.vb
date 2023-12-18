<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTuitionPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnenroll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtORAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.rbMonthly = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbQuarterly = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbSemiAnnual = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbAnnual = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtORNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalUnits = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAmountPerUnit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPerTerm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnenroll.Location = New System.Drawing.Point(232, 436)
        Me.btnenroll.Name = "btnenroll"
        Me.btnenroll.Size = New System.Drawing.Size(162, 46)
        Me.btnenroll.TabIndex = 31
        Me.btnenroll.Text = "SUBMIT"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(364, 347)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(56, 18)
        Me.Guna2HtmlLabel3.TabIndex = 30
        Me.Guna2HtmlLabel3.Text = "Balance"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(364, 277)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(81, 18)
        Me.Guna2HtmlLabel2.TabIndex = 29
        Me.Guna2HtmlLabel2.Text = "OR Amount"
        '
        'txtORAmount
        '
        Me.txtORAmount.BorderColor = System.Drawing.Color.Black
        Me.txtORAmount.BorderRadius = 5
        Me.txtORAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtORAmount.DefaultText = ""
        Me.txtORAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtORAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtORAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtORAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtORAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtORAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtORAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtORAmount.Location = New System.Drawing.Point(364, 302)
        Me.txtORAmount.Name = "txtORAmount"
        Me.txtORAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtORAmount.PlaceholderText = ""
        Me.txtORAmount.SelectedText = ""
        Me.txtORAmount.Size = New System.Drawing.Size(262, 35)
        Me.txtORAmount.TabIndex = 28
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(364, 206)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(81, 18)
        Me.Guna2HtmlLabel1.TabIndex = 27
        Me.Guna2HtmlLabel1.Text = "OR Number"
        '
        'rbMonthly
        '
        Me.rbMonthly.AutoSize = True
        Me.rbMonthly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMonthly.CheckedState.BorderThickness = 0
        Me.rbMonthly.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMonthly.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbMonthly.CheckedState.InnerOffset = -4
        Me.rbMonthly.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.rbMonthly.Location = New System.Drawing.Point(174, 385)
        Me.rbMonthly.Name = "rbMonthly"
        Me.rbMonthly.Size = New System.Drawing.Size(85, 22)
        Me.rbMonthly.TabIndex = 26
        Me.rbMonthly.Text = "Monthly"
        Me.rbMonthly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbMonthly.UncheckedState.BorderThickness = 2
        Me.rbMonthly.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbMonthly.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbQuarterly
        '
        Me.rbQuarterly.AutoSize = True
        Me.rbQuarterly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbQuarterly.CheckedState.BorderThickness = 0
        Me.rbQuarterly.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbQuarterly.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbQuarterly.CheckedState.InnerOffset = -4
        Me.rbQuarterly.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.rbQuarterly.Location = New System.Drawing.Point(31, 385)
        Me.rbQuarterly.Name = "rbQuarterly"
        Me.rbQuarterly.Size = New System.Drawing.Size(97, 22)
        Me.rbQuarterly.TabIndex = 25
        Me.rbQuarterly.Text = "Quarterly"
        Me.rbQuarterly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbQuarterly.UncheckedState.BorderThickness = 2
        Me.rbQuarterly.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbQuarterly.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbSemiAnnual
        '
        Me.rbSemiAnnual.AutoSize = True
        Me.rbSemiAnnual.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSemiAnnual.CheckedState.BorderThickness = 0
        Me.rbSemiAnnual.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSemiAnnual.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbSemiAnnual.CheckedState.InnerOffset = -4
        Me.rbSemiAnnual.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.rbSemiAnnual.Location = New System.Drawing.Point(174, 356)
        Me.rbSemiAnnual.Name = "rbSemiAnnual"
        Me.rbSemiAnnual.Size = New System.Drawing.Size(119, 22)
        Me.rbSemiAnnual.TabIndex = 24
        Me.rbSemiAnnual.Text = "Semi Annual"
        Me.rbSemiAnnual.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbSemiAnnual.UncheckedState.BorderThickness = 2
        Me.rbSemiAnnual.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbSemiAnnual.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbAnnual
        '
        Me.rbAnnual.AutoSize = True
        Me.rbAnnual.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAnnual.CheckedState.BorderThickness = 0
        Me.rbAnnual.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAnnual.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbAnnual.CheckedState.InnerOffset = -4
        Me.rbAnnual.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.rbAnnual.Location = New System.Drawing.Point(31, 356)
        Me.rbAnnual.Name = "rbAnnual"
        Me.rbAnnual.Size = New System.Drawing.Size(77, 22)
        Me.rbAnnual.TabIndex = 23
        Me.rbAnnual.Text = "Annual"
        Me.rbAnnual.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbAnnual.UncheckedState.BorderThickness = 2
        Me.rbAnnual.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbAnnual.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'txtORNumber
        '
        Me.txtORNumber.BorderColor = System.Drawing.Color.Black
        Me.txtORNumber.BorderRadius = 5
        Me.txtORNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtORNumber.DefaultText = ""
        Me.txtORNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtORNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtORNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtORNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtORNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtORNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtORNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtORNumber.Location = New System.Drawing.Point(364, 230)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtORNumber.PlaceholderText = ""
        Me.txtORNumber.SelectedText = ""
        Me.txtORNumber.Size = New System.Drawing.Size(262, 35)
        Me.txtORNumber.TabIndex = 22
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(12, 57)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(120, 18)
        Me.Guna2HtmlLabel4.TabIndex = 33
        Me.Guna2HtmlLabel4.Text = "Total No. of Units"
        '
        'txtTotalUnits
        '
        Me.txtTotalUnits.BorderColor = System.Drawing.Color.Black
        Me.txtTotalUnits.BorderRadius = 5
        Me.txtTotalUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalUnits.DefaultText = ""
        Me.txtTotalUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalUnits.Enabled = False
        Me.txtTotalUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalUnits.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalUnits.Location = New System.Drawing.Point(12, 81)
        Me.txtTotalUnits.Name = "txtTotalUnits"
        Me.txtTotalUnits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalUnits.PlaceholderText = ""
        Me.txtTotalUnits.SelectedText = ""
        Me.txtTotalUnits.Size = New System.Drawing.Size(262, 35)
        Me.txtTotalUnits.TabIndex = 32
        '
        'txtAmountPerUnit
        '
        Me.txtAmountPerUnit.BorderColor = System.Drawing.Color.Black
        Me.txtAmountPerUnit.BorderRadius = 5
        Me.txtAmountPerUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountPerUnit.DefaultText = ""
        Me.txtAmountPerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmountPerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmountPerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmountPerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmountPerUnit.Enabled = False
        Me.txtAmountPerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPerUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmountPerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPerUnit.Location = New System.Drawing.Point(12, 151)
        Me.txtAmountPerUnit.Name = "txtAmountPerUnit"
        Me.txtAmountPerUnit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmountPerUnit.PlaceholderText = ""
        Me.txtAmountPerUnit.SelectedText = ""
        Me.txtAmountPerUnit.Size = New System.Drawing.Size(262, 35)
        Me.txtAmountPerUnit.TabIndex = 34
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(364, 57)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(94, 18)
        Me.Guna2HtmlLabel6.TabIndex = 37
        Me.Guna2HtmlLabel6.Text = "Total Amount"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BorderColor = System.Drawing.Color.Black
        Me.txtTotalAmount.BorderRadius = 5
        Me.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalAmount.DefaultText = ""
        Me.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalAmount.Location = New System.Drawing.Point(364, 81)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalAmount.PlaceholderText = ""
        Me.txtTotalAmount.SelectedText = ""
        Me.txtTotalAmount.Size = New System.Drawing.Size(262, 35)
        Me.txtTotalAmount.TabIndex = 36
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(12, 127)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(116, 18)
        Me.Guna2HtmlLabel5.TabIndex = 35
        Me.Guna2HtmlLabel5.Text = "Amount Per Unit"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(12, 200)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(79, 18)
        Me.Guna2HtmlLabel7.TabIndex = 38
        Me.Guna2HtmlLabel7.Text = "Other Fees"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(12, 18)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(117, 18)
        Me.Guna2HtmlLabel8.TabIndex = 39
        Me.Guna2HtmlLabel8.Text = "Student Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "*******"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView2.Location = New System.Drawing.Point(11, 230)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(305, 107)
        Me.DataGridView2.TabIndex = 41
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ID"
        Me.Column5.HeaderText = "ID"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "fee"
        Me.Column7.HeaderText = "Fee"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "amount"
        Me.Column8.HeaderText = "Amount"
        Me.Column8.Name = "Column8"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(364, 126)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(124, 18)
        Me.Guna2HtmlLabel9.TabIndex = 42
        Me.Guna2HtmlLabel9.Text = "Amount Per Term"
        '
        'txtPerTerm
        '
        Me.txtPerTerm.BorderColor = System.Drawing.Color.Black
        Me.txtPerTerm.BorderRadius = 5
        Me.txtPerTerm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerTerm.DefaultText = ""
        Me.txtPerTerm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerTerm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerTerm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerTerm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerTerm.Enabled = False
        Me.txtPerTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPerTerm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerTerm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPerTerm.Location = New System.Drawing.Point(364, 151)
        Me.txtPerTerm.Name = "txtPerTerm"
        Me.txtPerTerm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerTerm.PlaceholderText = ""
        Me.txtPerTerm.SelectedText = ""
        Me.txtPerTerm.Size = New System.Drawing.Size(262, 35)
        Me.txtPerTerm.TabIndex = 43
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtBalance
        '
        Me.txtBalance.BorderColor = System.Drawing.Color.Black
        Me.txtBalance.BorderRadius = 5
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.DefaultText = ""
        Me.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBalance.Enabled = False
        Me.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBalance.Location = New System.Drawing.Point(364, 372)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBalance.PlaceholderText = ""
        Me.txtBalance.SelectedText = ""
        Me.txtBalance.Size = New System.Drawing.Size(262, 35)
        Me.txtBalance.TabIndex = 44
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'formTuitionPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(674, 494)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtPerTerm)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.txtAmountPerUnit)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.txtTotalUnits)
        Me.Controls.Add(Me.btnenroll)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtORAmount)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.rbMonthly)
        Me.Controls.Add(Me.rbQuarterly)
        Me.Controls.Add(Me.rbSemiAnnual)
        Me.Controls.Add(Me.rbAnnual)
        Me.Controls.Add(Me.txtORNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formTuitionPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formTuitionPayment"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnenroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtORAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents rbMonthly As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbQuarterly As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbSemiAnnual As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbAnnual As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtORNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalUnits As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAmountPerUnit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPerTerm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtBalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
