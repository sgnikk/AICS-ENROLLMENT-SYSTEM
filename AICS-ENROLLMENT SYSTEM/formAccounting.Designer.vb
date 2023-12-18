<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccountingMaintenance
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
        Me.txtfee = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewAmount = New System.Windows.Forms.TextBox()
        Me.txtOldAmount = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfee
        '
        Me.txtfee.Location = New System.Drawing.Point(129, 15)
        Me.txtfee.Name = "txtfee"
        Me.txtfee.Size = New System.Drawing.Size(276, 20)
        Me.txtfee.TabIndex = 0
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(129, 68)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(276, 20)
        Me.txtamount.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Amount"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 188)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(397, 102)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "fee"
        Me.Column2.HeaderText = "Fee"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "amount"
        Me.Column3.HeaderText = "Amount"
        Me.Column3.Name = "Column3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 32)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 32)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtfee)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 299)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other Fee"
        Me.GroupBox1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Units", "Other Fee"})
        Me.ComboBox1.Location = New System.Drawing.Point(20, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNewAmount)
        Me.GroupBox2.Controls.Add(Me.txtOldAmount)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 167)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Units"
        Me.GroupBox2.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(164, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 32)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Set Amount"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "New Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Amount Per Unit"
        '
        'txtNewAmount
        '
        Me.txtNewAmount.Location = New System.Drawing.Point(129, 68)
        Me.txtNewAmount.Name = "txtNewAmount"
        Me.txtNewAmount.Size = New System.Drawing.Size(276, 20)
        Me.txtNewAmount.TabIndex = 1
        '
        'txtOldAmount
        '
        Me.txtOldAmount.Enabled = False
        Me.txtOldAmount.Location = New System.Drawing.Point(129, 29)
        Me.txtOldAmount.Name = "txtOldAmount"
        Me.txtOldAmount.Size = New System.Drawing.Size(276, 20)
        Me.txtOldAmount.TabIndex = 0
        '
        'formAccountingMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 355)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formAccountingMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formAccounting"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtfee As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewAmount As TextBox
    Friend WithEvents txtOldAmount As TextBox
End Class
