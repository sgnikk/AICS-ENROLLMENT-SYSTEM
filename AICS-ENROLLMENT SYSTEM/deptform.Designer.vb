<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deptform
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
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtdeptname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtdeptcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(99, 88)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(120, 15)
        Me.Guna2HtmlLabel2.TabIndex = 47
        Me.Guna2HtmlLabel2.Text = "DEPARTMENT NAME"
        '
        'txtdeptname
        '
        Me.txtdeptname.BorderColor = System.Drawing.Color.Black
        Me.txtdeptname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdeptname.CustomizableEdges.BottomLeft = False
        Me.txtdeptname.CustomizableEdges.TopLeft = False
        Me.txtdeptname.DefaultText = ""
        Me.txtdeptname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdeptname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdeptname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdeptname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdeptname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdeptname.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtdeptname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdeptname.Location = New System.Drawing.Point(29, 112)
        Me.txtdeptname.Name = "txtdeptname"
        Me.txtdeptname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdeptname.PlaceholderText = ""
        Me.txtdeptname.SelectedText = ""
        Me.txtdeptname.Size = New System.Drawing.Size(260, 36)
        Me.txtdeptname.TabIndex = 46
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(99, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(120, 15)
        Me.Guna2HtmlLabel1.TabIndex = 45
        Me.Guna2HtmlLabel1.Text = "DEPARTMENT CODE"
        '
        'txtdeptcode
        '
        Me.txtdeptcode.BorderColor = System.Drawing.Color.Black
        Me.txtdeptcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdeptcode.CustomizableEdges.BottomLeft = False
        Me.txtdeptcode.CustomizableEdges.TopLeft = False
        Me.txtdeptcode.DefaultText = ""
        Me.txtdeptcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdeptcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdeptcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdeptcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdeptcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdeptcode.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtdeptcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdeptcode.Location = New System.Drawing.Point(29, 40)
        Me.txtdeptcode.Name = "txtdeptcode"
        Me.txtdeptcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdeptcode.PlaceholderText = ""
        Me.txtdeptcode.SelectedText = ""
        Me.txtdeptcode.Size = New System.Drawing.Size(260, 36)
        Me.txtdeptcode.TabIndex = 44
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
        Me.btnsubmit.Location = New System.Drawing.Point(90, 165)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(150, 40)
        Me.btnsubmit.TabIndex = 48
        Me.btnsubmit.Text = "SUBMIT"
        '
        'deptform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(319, 224)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtdeptname)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtdeptcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "deptform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "deptform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtdeptname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtdeptcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2Button
End Class
