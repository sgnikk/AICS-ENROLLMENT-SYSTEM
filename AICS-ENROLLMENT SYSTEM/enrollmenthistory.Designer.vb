<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class enrollmenthistory
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cmbyear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(750, 480)
        Me.Guna2GroupBox1.TabIndex = 10
        Me.Guna2GroupBox1.Text = "ENROLLMENT HISTORY"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbyear
        '
        Me.cmbyear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbyear.BackColor = System.Drawing.Color.Transparent
        Me.cmbyear.BorderColor = System.Drawing.Color.Black
        Me.cmbyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbyear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbyear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbyear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbyear.ItemHeight = 30
        Me.cmbyear.Location = New System.Drawing.Point(0, 480)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(188, 36)
        Me.cmbyear.TabIndex = 61
        '
        'enrollmenthistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(750, 516)
        Me.Controls.Add(Me.cmbyear)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "enrollmenthistory"
        Me.Text = "enrollmenthistory"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cmbyear As Guna.UI2.WinForms.Guna2ComboBox
End Class
