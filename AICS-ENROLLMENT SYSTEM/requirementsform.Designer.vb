<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requirementsform
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
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbclassification = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.Guna2TextBox1.TabIndex = 14
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
        Me.Guna2Button5.Location = New System.Drawing.Point(77, 210)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(150, 40)
        Me.Guna2Button5.TabIndex = 15
        Me.Guna2Button5.Text = "ADD REQUIREMENTS"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(102, 120)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(101, 15)
        Me.Guna2HtmlLabel3.TabIndex = 19
        Me.Guna2HtmlLabel3.Text = "CLASSIFICATION"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(87, 26)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(131, 15)
        Me.Guna2HtmlLabel1.TabIndex = 20
        Me.Guna2HtmlLabel1.Text = "REQUIREMENTS NAME"
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
        Me.cmbclassification.TabIndex = 21
        '
        'requirementsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 276)
        Me.Controls.Add(Me.cmbclassification)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "requirementsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "requirementsform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbclassification As Guna.UI2.WinForms.Guna2ComboBox
End Class
