<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profform
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
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.btnsubmit.Location = New System.Drawing.Point(105, 275)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(150, 40)
        Me.btnsubmit.TabIndex = 35
        Me.btnsubmit.Text = "SUBMIT"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(131, 189)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(97, 15)
        Me.Guna2HtmlLabel3.TabIndex = 33
        Me.Guna2HtmlLabel3.Text = "EMAIL ADDRESS"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(144, 106)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(71, 15)
        Me.Guna2HtmlLabel2.TabIndex = 32
        Me.Guna2HtmlLabel2.Text = "LAST NAME"
        '
        'txtlname
        '
        Me.txtlname.BorderColor = System.Drawing.Color.Black
        Me.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlname.CustomizableEdges.BottomLeft = False
        Me.txtlname.CustomizableEdges.TopLeft = False
        Me.txtlname.DefaultText = ""
        Me.txtlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Location = New System.Drawing.Point(49, 127)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.PlaceholderText = ""
        Me.txtlname.SelectedText = ""
        Me.txtlname.Size = New System.Drawing.Size(260, 36)
        Me.txtlname.TabIndex = 31
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(142, 24)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(74, 15)
        Me.Guna2HtmlLabel1.TabIndex = 30
        Me.Guna2HtmlLabel1.Text = "FIRST NAME"
        '
        'txtfname
        '
        Me.txtfname.BorderColor = System.Drawing.Color.Black
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.CustomizableEdges.BottomLeft = False
        Me.txtfname.CustomizableEdges.TopLeft = False
        Me.txtfname.DefaultText = ""
        Me.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Location = New System.Drawing.Point(49, 45)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.PlaceholderText = ""
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(260, 36)
        Me.txtfname.TabIndex = 29
        '
        'txtemail
        '
        Me.txtemail.BorderColor = System.Drawing.Color.Black
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.CustomizableEdges.BottomLeft = False
        Me.txtemail.CustomizableEdges.TopLeft = False
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(49, 210)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderText = ""
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(260, 36)
        Me.txtemail.TabIndex = 36
        '
        'profform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(359, 338)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtfname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "profform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "profform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class
