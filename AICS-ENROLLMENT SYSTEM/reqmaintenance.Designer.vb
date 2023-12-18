<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reqmaintenance
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
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.cmbclassification = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.txtid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'cmbclassification
        '
        Me.cmbclassification.BackColor = System.Drawing.Color.Transparent
        Me.cmbclassification.BorderColor = System.Drawing.Color.Black
        Me.cmbclassification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbclassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbclassification.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbclassification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbclassification.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbclassification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbclassification.ItemHeight = 30
        Me.cmbclassification.Location = New System.Drawing.Point(27, 149)
        Me.cmbclassification.Name = "cmbclassification"
        Me.cmbclassification.Size = New System.Drawing.Size(250, 36)
        Me.cmbclassification.TabIndex = 26
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(87, 26)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(131, 15)
        Me.Guna2HtmlLabel1.TabIndex = 25
        Me.Guna2HtmlLabel1.Text = "REQUIREMENTS NAME"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(102, 120)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(101, 15)
        Me.Guna2HtmlLabel3.TabIndex = 24
        Me.Guna2HtmlLabel3.Text = "CLASSIFICATION"
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
        Me.btnupdate.Location = New System.Drawing.Point(27, 211)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(108, 40)
        Me.btnupdate.TabIndex = 23
        Me.btnupdate.Text = "UPDATE"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.CustomizableEdges.BottomLeft = False
        Me.Guna2TextBox1.CustomizableEdges.TopLeft = False
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(27, 55)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(250, 33)
        Me.Guna2TextBox1.TabIndex = 22
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
        Me.btndelete.Location = New System.Drawing.Point(169, 211)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(108, 40)
        Me.btndelete.TabIndex = 27
        Me.btndelete.Text = "DELETE"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(279, -2)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.PlaceholderText = ""
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(26, 21)
        Me.txtid.TabIndex = 28
        Me.txtid.Visible = False
        '
        'reqmaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 276)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cmbclassification)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reqmaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reqmaintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbclassification As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtid As Guna.UI2.WinForms.Guna2TextBox
End Class
