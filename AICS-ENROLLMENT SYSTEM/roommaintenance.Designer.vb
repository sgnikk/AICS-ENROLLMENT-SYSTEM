<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roommaintenance
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
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtroomnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.txtid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtroomtype = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnupdate
        '
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
        Me.btnupdate.Location = New System.Drawing.Point(27, 175)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(119, 40)
        Me.btnupdate.TabIndex = 31
        Me.btnupdate.Text = "UPDATE"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(106, 22)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(92, 15)
        Me.Guna2HtmlLabel1.TabIndex = 30
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
        Me.txtroomnumber.Location = New System.Drawing.Point(27, 51)
        Me.txtroomnumber.Name = "txtroomnumber"
        Me.txtroomnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtroomnumber.PlaceholderText = ""
        Me.txtroomnumber.SelectedText = ""
        Me.txtroomnumber.Size = New System.Drawing.Size(250, 33)
        Me.txtroomnumber.TabIndex = 29
        '
        'btndelete
        '
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
        Me.btndelete.Location = New System.Drawing.Point(158, 175)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(119, 40)
        Me.btndelete.TabIndex = 32
        Me.btndelete.Text = "DELETE"
        '
        'txtid
        '
        Me.txtid.BorderColor = System.Drawing.Color.Black
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.CustomizableEdges.BottomLeft = False
        Me.txtid.CustomizableEdges.TopLeft = False
        Me.txtid.DefaultText = ""
        Me.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(283, 1)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.PlaceholderText = ""
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(24, 20)
        Me.txtid.TabIndex = 56
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(106, 96)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(92, 15)
        Me.Guna2HtmlLabel2.TabIndex = 58
        Me.Guna2HtmlLabel2.Text = "ROOM NUMBER"
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
        Me.txtroomtype.Location = New System.Drawing.Point(27, 123)
        Me.txtroomtype.Name = "txtroomtype"
        Me.txtroomtype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtroomtype.PlaceholderText = ""
        Me.txtroomtype.SelectedText = ""
        Me.txtroomtype.Size = New System.Drawing.Size(250, 33)
        Me.txtroomtype.TabIndex = 57
        '
        'roommaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 242)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.txtroomtype)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtroomnumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "roommaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "roommaintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtroomnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtroomtype As Guna.UI2.WinForms.Guna2TextBox
End Class
