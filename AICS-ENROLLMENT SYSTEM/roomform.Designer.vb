<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomform
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtroomnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtroomtype = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(106, 21)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(92, 15)
        Me.Guna2HtmlLabel1.TabIndex = 27
        Me.Guna2HtmlLabel1.Text = "ROOM NUMBER"
        '
        'txtroomnumber
        '
        Me.txtroomnumber.BorderColor = System.Drawing.Color.Black
        Me.txtroomnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtroomnumber.CustomizableEdges.BottomLeft = False
        Me.txtroomnumber.CustomizableEdges.TopLeft = False
        Me.txtroomnumber.DefaultText = ""
        Me.txtroomnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtroomnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtroomnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtroomnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtroomnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtroomnumber.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtroomnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtroomnumber.Location = New System.Drawing.Point(27, 50)
        Me.txtroomnumber.Name = "txtroomnumber"
        Me.txtroomnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtroomnumber.PlaceholderText = ""
        Me.txtroomnumber.SelectedText = ""
        Me.txtroomnumber.Size = New System.Drawing.Size(250, 33)
        Me.txtroomnumber.TabIndex = 26
        '
        'Guna2Button5
        '
        Me.Guna2Button5.BorderThickness = 1
        Me.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Button5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.Location = New System.Drawing.Point(77, 187)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(150, 40)
        Me.Guna2Button5.TabIndex = 28
        Me.Guna2Button5.Text = "ADD ROOM"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(115, 98)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(74, 15)
        Me.Guna2HtmlLabel2.TabIndex = 60
        Me.Guna2HtmlLabel2.Text = "ROOM TYPE"
        '
        'txtroomtype
        '
        Me.txtroomtype.BorderColor = System.Drawing.Color.Black
        Me.txtroomtype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtroomtype.CustomizableEdges.BottomLeft = False
        Me.txtroomtype.CustomizableEdges.TopLeft = False
        Me.txtroomtype.DefaultText = ""
        Me.txtroomtype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtroomtype.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtroomtype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtroomtype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtroomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtroomtype.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtroomtype.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtroomtype.Location = New System.Drawing.Point(27, 125)
        Me.txtroomtype.Name = "txtroomtype"
        Me.txtroomtype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtroomtype.PlaceholderText = ""
        Me.txtroomtype.SelectedText = ""
        Me.txtroomtype.Size = New System.Drawing.Size(250, 33)
        Me.txtroomtype.TabIndex = 59
        '
        'roomform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 242)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtroomtype)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtroomnumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "roomform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtroomnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtroomtype As Guna.UI2.WinForms.Guna2TextBox
End Class
