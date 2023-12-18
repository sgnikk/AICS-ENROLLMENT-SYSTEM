<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class schoolyearform
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
        Me.btnadd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtschoolyr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnadd
        '
        Me.btnadd.BorderThickness = 1
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnadd.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnadd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.btnadd.ForeColor = System.Drawing.Color.Black
        Me.btnadd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnadd.Location = New System.Drawing.Point(77, 91)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(150, 40)
        Me.btnadd.TabIndex = 63
        Me.btnadd.Text = "ADD SCHOOL YEAR"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(106, 18)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(92, 15)
        Me.Guna2HtmlLabel1.TabIndex = 62
        Me.Guna2HtmlLabel1.Text = "ROOM NUMBER"
        '
        'txtschoolyr
        '
        Me.txtschoolyr.BorderColor = System.Drawing.Color.Black
        Me.txtschoolyr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtschoolyr.CustomizableEdges.BottomLeft = False
        Me.txtschoolyr.CustomizableEdges.TopLeft = False
        Me.txtschoolyr.DefaultText = ""
        Me.txtschoolyr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtschoolyr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtschoolyr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtschoolyr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtschoolyr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtschoolyr.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtschoolyr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtschoolyr.Location = New System.Drawing.Point(27, 47)
        Me.txtschoolyr.Name = "txtschoolyr"
        Me.txtschoolyr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtschoolyr.PlaceholderText = ""
        Me.txtschoolyr.SelectedText = ""
        Me.txtschoolyr.Size = New System.Drawing.Size(250, 33)
        Me.txtschoolyr.TabIndex = 61
        '
        'schoolyearform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 152)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtschoolyr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "schoolyearform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "schoolyearform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtschoolyr As Guna.UI2.WinForms.Guna2TextBox
End Class
