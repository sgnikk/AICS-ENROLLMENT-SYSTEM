<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class COURSEFORM
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtboxcoursecode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcoursedesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcourseduration = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbdept = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(135, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(89, 15)
        Me.Guna2HtmlLabel1.TabIndex = 22
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
        Me.txtboxcoursecode.Location = New System.Drawing.Point(49, 36)
        Me.txtboxcoursecode.Name = "txtboxcoursecode"
        Me.txtboxcoursecode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxcoursecode.PlaceholderText = ""
        Me.txtboxcoursecode.SelectedText = ""
        Me.txtboxcoursecode.Size = New System.Drawing.Size(260, 36)
        Me.txtboxcoursecode.TabIndex = 21
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(112, 79)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(135, 15)
        Me.Guna2HtmlLabel2.TabIndex = 24
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
        Me.txtcoursedesc.Location = New System.Drawing.Point(49, 103)
        Me.txtcoursedesc.Name = "txtcoursedesc"
        Me.txtcoursedesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcoursedesc.PlaceholderText = ""
        Me.txtcoursedesc.SelectedText = ""
        Me.txtcoursedesc.Size = New System.Drawing.Size(260, 36)
        Me.txtcoursedesc.TabIndex = 23
        '
        'btnsubmit
        '
        Me.btnsubmit.BorderRadius = 3
        Me.btnsubmit.BorderThickness = 1
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsubmit.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsubmit.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btnsubmit.ForeColor = System.Drawing.Color.Black
        Me.btnsubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnsubmit.Location = New System.Drawing.Point(104, 289)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(150, 40)
        Me.btnsubmit.TabIndex = 28
        Me.btnsubmit.Text = "SUBMIT"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(121, 145)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(116, 15)
        Me.Guna2HtmlLabel4.TabIndex = 30
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
        Me.txtcourseduration.Location = New System.Drawing.Point(49, 169)
        Me.txtcourseduration.Name = "txtcourseduration"
        Me.txtcourseduration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcourseduration.PlaceholderText = ""
        Me.txtcourseduration.SelectedText = ""
        Me.txtcourseduration.Size = New System.Drawing.Size(260, 36)
        Me.txtcourseduration.TabIndex = 29
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(121, 214)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(136, 15)
        Me.Guna2HtmlLabel3.TabIndex = 31
        Me.Guna2HtmlLabel3.Text = "COURSE DEPARTMENT"
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
        Me.cmbdept.Location = New System.Drawing.Point(49, 238)
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Size = New System.Drawing.Size(260, 36)
        Me.cmbdept.TabIndex = 32
        '
        'COURSEFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(359, 339)
        Me.Controls.Add(Me.cmbdept)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.txtcourseduration)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtcoursedesc)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtboxcoursecode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "COURSEFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COURSEFORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcoursedesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtboxcoursecode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcourseduration As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbdept As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
