<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coursemaintenance
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
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.txtid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbdept = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcourseduration = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcoursedesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtboxcoursecode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnupdate
        '
        Me.btnupdate.BorderRadius = 3
        Me.btnupdate.BorderThickness = 1
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdate.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnupdate.Location = New System.Drawing.Point(49, 290)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(121, 40)
        Me.btnupdate.TabIndex = 35
        Me.btnupdate.Text = "UPDATE"
        '
        'btndelete
        '
        Me.btndelete.BorderRadius = 3
        Me.btndelete.BorderThickness = 1
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndelete.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btndelete.Location = New System.Drawing.Point(188, 290)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(121, 40)
        Me.btndelete.TabIndex = 38
        Me.btndelete.Text = "DELETE"
        '
        'txtid
        '
        Me.txtid.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.CustomizableEdges.BottomLeft = False
        Me.txtid.CustomizableEdges.TopLeft = False
        Me.txtid.DefaultText = ""
        Me.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtid.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(305, -3)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.PlaceholderText = ""
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(52, 44)
        Me.txtid.TabIndex = 39
        Me.txtid.Visible = False
        '
        'cmbdept
        '
        Me.cmbdept.BackColor = System.Drawing.Color.Transparent
        Me.cmbdept.BorderColor = System.Drawing.Color.Black
        Me.cmbdept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbdept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdept.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbdept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbdept.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbdept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbdept.ItemHeight = 30
        Me.cmbdept.Location = New System.Drawing.Point(49, 234)
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Size = New System.Drawing.Size(260, 36)
        Me.cmbdept.TabIndex = 47
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(121, 210)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(136, 15)
        Me.Guna2HtmlLabel3.TabIndex = 46
        Me.Guna2HtmlLabel3.Text = "COURSE DEPARTMENT"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(121, 141)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(116, 15)
        Me.Guna2HtmlLabel4.TabIndex = 45
        Me.Guna2HtmlLabel4.Text = "COURSE DURATION"
        '
        'txtcourseduration
        '
        Me.txtcourseduration.BorderColor = System.Drawing.Color.Black
        Me.txtcourseduration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcourseduration.CustomizableEdges.BottomLeft = False
        Me.txtcourseduration.CustomizableEdges.TopLeft = False
        Me.txtcourseduration.DefaultText = ""
        Me.txtcourseduration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcourseduration.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcourseduration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourseduration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourseduration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcourseduration.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtcourseduration.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcourseduration.Location = New System.Drawing.Point(49, 165)
        Me.txtcourseduration.Name = "txtcourseduration"
        Me.txtcourseduration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcourseduration.PlaceholderText = ""
        Me.txtcourseduration.SelectedText = ""
        Me.txtcourseduration.Size = New System.Drawing.Size(260, 36)
        Me.txtcourseduration.TabIndex = 44
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(112, 75)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(135, 15)
        Me.Guna2HtmlLabel2.TabIndex = 43
        Me.Guna2HtmlLabel2.Text = "COURSE DESCRIPTION"
        '
        'txtcoursedesc
        '
        Me.txtcoursedesc.BorderColor = System.Drawing.Color.Black
        Me.txtcoursedesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcoursedesc.CustomizableEdges.BottomLeft = False
        Me.txtcoursedesc.CustomizableEdges.TopLeft = False
        Me.txtcoursedesc.DefaultText = ""
        Me.txtcoursedesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcoursedesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcoursedesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcoursedesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcoursedesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcoursedesc.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtcoursedesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcoursedesc.Location = New System.Drawing.Point(49, 99)
        Me.txtcoursedesc.Name = "txtcoursedesc"
        Me.txtcoursedesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcoursedesc.PlaceholderText = ""
        Me.txtcoursedesc.SelectedText = ""
        Me.txtcoursedesc.Size = New System.Drawing.Size(260, 36)
        Me.txtcoursedesc.TabIndex = 42
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(135, 8)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(89, 15)
        Me.Guna2HtmlLabel1.TabIndex = 41
        Me.Guna2HtmlLabel1.Text = "COURSE CODE"
        '
        'txtboxcoursecode
        '
        Me.txtboxcoursecode.BorderColor = System.Drawing.Color.Black
        Me.txtboxcoursecode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxcoursecode.CustomizableEdges.BottomLeft = False
        Me.txtboxcoursecode.CustomizableEdges.TopLeft = False
        Me.txtboxcoursecode.DefaultText = ""
        Me.txtboxcoursecode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxcoursecode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxcoursecode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxcoursecode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxcoursecode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxcoursecode.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtboxcoursecode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxcoursecode.Location = New System.Drawing.Point(49, 32)
        Me.txtboxcoursecode.Name = "txtboxcoursecode"
        Me.txtboxcoursecode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxcoursecode.PlaceholderText = ""
        Me.txtboxcoursecode.SelectedText = ""
        Me.txtboxcoursecode.Size = New System.Drawing.Size(260, 36)
        Me.txtboxcoursecode.TabIndex = 40
        '
        'coursemaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(359, 339)
        Me.Controls.Add(Me.cmbdept)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.txtcourseduration)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtcoursedesc)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtboxcoursecode)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "coursemaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "coursemaintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbdept As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcourseduration As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcoursedesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtboxcoursecode As Guna.UI2.WinForms.Guna2TextBox
End Class
