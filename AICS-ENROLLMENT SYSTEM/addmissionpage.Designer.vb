<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addmissionpage
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TblstudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._AICS_ENROLLMENT_SYSTEMDataSet9 = New AICS_ENROLLMENT_SYSTEM._AICS_ENROLLMENT_SYSTEMDataSet9()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbyearr = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbcourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Tbl_studentsTableAdapter = New AICS_ENROLLMENT_SYSTEM._AICS_ENROLLMENT_SYSTEMDataSet9TableAdapters.tbl_studentsTableAdapter()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._AICS_ENROLLMENT_SYSTEMDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(750, 493)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "LISTS OF STUDENTS"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 8.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DataGridView1.ColumnHeadersHeight = 35
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(2, 41)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(746, 448)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TblstudentsBindingSource
        '
        Me.TblstudentsBindingSource.DataMember = "tbl_students"
        Me.TblstudentsBindingSource.DataSource = Me._AICS_ENROLLMENT_SYSTEMDataSet9
        '
        '_AICS_ENROLLMENT_SYSTEMDataSet9
        '
        Me._AICS_ENROLLMENT_SYSTEMDataSet9.DataSetName = "_AICS_ENROLLMENT_SYSTEMDataSet9"
        Me._AICS_ENROLLMENT_SYSTEMDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BorderRadius = 11
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(4, 510)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(122, 37)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "ADD STUDENT"
        '
        'txtusername
        '
        Me.txtusername.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtusername.BorderColor = System.Drawing.Color.Black
        Me.txtusername.BorderRadius = 13
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.CustomizableEdges.BottomRight = False
        Me.txtusername.CustomizableEdges.TopRight = False
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(400, 509)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderText = "Search Student"
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(244, 37)
        Me.txtusername.TabIndex = 9
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button2.BorderRadius = 13
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.CustomizableEdges.BottomLeft = False
        Me.Guna2Button2.CustomizableEdges.TopLeft = False
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Location = New System.Drawing.Point(644, 510)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(98, 37)
        Me.Guna2Button2.TabIndex = 10
        Me.Guna2Button2.Text = "SEARCH"
        '
        'cmbyearr
        '
        Me.cmbyearr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbyearr.BackColor = System.Drawing.Color.Transparent
        Me.cmbyearr.BorderColor = System.Drawing.Color.Black
        Me.cmbyearr.BorderRadius = 3
        Me.cmbyearr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbyearr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyearr.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbyearr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbyearr.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbyearr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbyearr.ItemHeight = 30
        Me.cmbyearr.Location = New System.Drawing.Point(129, 511)
        Me.cmbyearr.Name = "cmbyearr"
        Me.cmbyearr.Size = New System.Drawing.Size(127, 36)
        Me.cmbyearr.TabIndex = 11
        Me.cmbyearr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(157, 522)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(74, 15)
        Me.Guna2HtmlLabel3.TabIndex = 12
        Me.Guna2HtmlLabel3.Text = "YEAR LEVEL"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(300, 522)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(52, 15)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "COURSE"
        '
        'cmbcourse
        '
        Me.cmbcourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbcourse.BackColor = System.Drawing.Color.Transparent
        Me.cmbcourse.BorderColor = System.Drawing.Color.Black
        Me.cmbcourse.BorderRadius = 3
        Me.cmbcourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbcourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbcourse.ItemHeight = 30
        Me.cmbcourse.Location = New System.Drawing.Point(262, 511)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(127, 36)
        Me.cmbcourse.TabIndex = 13
        Me.cmbcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_studentsTableAdapter
        '
        Me.Tbl_studentsTableAdapter.ClearBeforeFill = True
        '
        'addmissionpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(750, 557)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.cmbyearr)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addmissionpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addmissionpage"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._AICS_ENROLLMENT_SYSTEMDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbyearr As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbcourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents _AICS_ENROLLMENT_SYSTEMDataSet9 As _AICS_ENROLLMENT_SYSTEMDataSet9
    Friend WithEvents TblstudentsBindingSource As BindingSource
    Friend WithEvents Tbl_studentsTableAdapter As _AICS_ENROLLMENT_SYSTEMDataSet9TableAdapters.tbl_studentsTableAdapter
End Class
