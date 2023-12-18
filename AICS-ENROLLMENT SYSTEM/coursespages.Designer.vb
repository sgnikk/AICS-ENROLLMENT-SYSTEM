<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class coursespages
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TblcoursedeptBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.TblcourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcoursedeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldepartmentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcoursedeptBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORIESDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COURSEDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._AICS_ENROLLMENT_SYSTEMDataSet2 = New AICS_ENROLLMENT_SYSTEM._AICS_ENROLLMENT_SYSTEMDataSet2()
        Me.TblcourseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcoursesTableAdapter = New AICS_ENROLLMENT_SYSTEM._AICS_ENROLLMENT_SYSTEMDataSet2TableAdapters.tblcoursesTableAdapter()
        CType(Me.TblcoursedeptBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcoursedeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldepartmentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcoursedeptBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORIESDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._AICS_ENROLLMENT_SYSTEMDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcourseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me
        '
        'TblcoursedeptBindingSource1
        '
        Me.TblcoursedeptBindingSource1.DataMember = "tblcoursedept"
        '
        'TbldepartmentBindingSource
        '
        Me.TbldepartmentBindingSource.DataMember = "tbldepartment"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(149, 475)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(147, 37)
        Me.Guna2Button1.TabIndex = 16
        Me.Guna2Button1.Text = "EDIT COURSE"
        '
        'btnsubmit
        '
        Me.btnsubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsubmit.BorderThickness = 1
        Me.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsubmit.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.Black
        Me.btnsubmit.Location = New System.Drawing.Point(1, 475)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(147, 37)
        Me.btnsubmit.TabIndex = 15
        Me.btnsubmit.Text = "ADD COURSE"
        '
        'TblcoursedeptBindingSource
        '
        Me.TblcoursedeptBindingSource.DataMember = "tblcoursedept"
        '
        'TbldepartmentBindingSource1
        '
        Me.TbldepartmentBindingSource1.DataMember = "tbldepartment"
        '
        'TblcoursedeptBindingSource2
        '
        Me.TblcoursedeptBindingSource2.DataMember = "tblcoursedept"
        '
        'CATEGORIESDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CATEGORIESDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CATEGORIESDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CATEGORIESDGV.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CATEGORIESDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CATEGORIESDGV.ColumnHeadersHeight = 32
        Me.CATEGORIESDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CATEGORIESDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.COURSEDESCRIPTIONDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4})
        Me.CATEGORIESDGV.DataSource = Me.TblcoursesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CATEGORIESDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.CATEGORIESDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CATEGORIESDGV.Location = New System.Drawing.Point(0, 0)
        Me.CATEGORIESDGV.Name = "CATEGORIESDGV"
        Me.CATEGORIESDGV.RowHeadersVisible = False
        Me.CATEGORIESDGV.Size = New System.Drawing.Size(750, 467)
        Me.CATEGORIESDGV.TabIndex = 0
        Me.CATEGORIESDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CATEGORIESDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CATEGORIESDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CATEGORIESDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CATEGORIESDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CATEGORIESDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CATEGORIESDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CATEGORIESDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CATEGORIESDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CATEGORIESDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CATEGORIESDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CATEGORIESDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CATEGORIESDGV.ThemeStyle.HeaderStyle.Height = 32
        Me.CATEGORIESDGV.ThemeStyle.ReadOnly = False
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.Height = 22
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CATEGORIESDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COURSE_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "COURSE_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "COURSE_CODE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "COURSE_CODE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'COURSEDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.COURSEDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "COURSE_DESCRIPTION"
        Me.COURSEDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "COURSE_DESCRIPTION"
        Me.COURSEDESCRIPTIONDataGridViewTextBoxColumn.Name = "COURSEDESCRIPTIONDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "COURSE_DURATION"
        Me.DataGridViewTextBoxColumn4.HeaderText = "COURSE_DURATION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TblcoursesBindingSource
        '
        Me.TblcoursesBindingSource.DataMember = "tblcourses"
        Me.TblcoursesBindingSource.DataSource = Me._AICS_ENROLLMENT_SYSTEMDataSet2
        '
        '_AICS_ENROLLMENT_SYSTEMDataSet2
        '
        Me._AICS_ENROLLMENT_SYSTEMDataSet2.DataSetName = "_AICS_ENROLLMENT_SYSTEMDataSet2"
        Me._AICS_ENROLLMENT_SYSTEMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcourseBindingSource1
        '
        Me.TblcourseBindingSource1.DataMember = "tblcourse"
        '
        'TblcoursesTableAdapter
        '
        Me.TblcoursesTableAdapter.ClearBeforeFill = True
        '
        'coursespages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(750, 516)
        Me.Controls.Add(Me.CATEGORIESDGV)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnsubmit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "coursespages"
        Me.Text = "coursespages"
        CType(Me.TblcoursedeptBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcoursedeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldepartmentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcoursedeptBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORIESDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._AICS_ENROLLMENT_SYSTEMDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcourseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TbldepartmentBindingSource As BindingSource
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TblcourseBindingSource As BindingSource
    Friend WithEvents TblcoursedeptBindingSource As BindingSource
    Friend WithEvents TblcoursedeptBindingSource1 As BindingSource
    Friend WithEvents CoursedeptidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbldepartmentBindingSource1 As BindingSource
    Friend WithEvents TblcoursedeptBindingSource2 As BindingSource
    Friend WithEvents CATEGORIESDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TblcourseBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CoursecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursedurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents _AICS_ENROLLMENT_SYSTEMDataSet2 As _AICS_ENROLLMENT_SYSTEMDataSet2
    Friend WithEvents TblcoursesBindingSource As BindingSource
    Friend WithEvents TblcoursesTableAdapter As _AICS_ENROLLMENT_SYSTEMDataSet2TableAdapters.tblcoursesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents COURSEDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
