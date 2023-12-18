<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccountingPlatform
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.txtModeOfPayment = New System.Windows.Forms.TextBox()
        Me.txtAmountPerTerm = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtORAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNewBalance = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalTuition = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 94)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 64)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Number"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(553, 289)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(491, 188)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ornumber"
        Me.Column2.HeaderText = "OR Number"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "oramount"
        Me.Column3.HeaderText = "OR Amount"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'txtStudent
        '
        Me.txtStudent.Enabled = False
        Me.txtStudent.Location = New System.Drawing.Point(189, 154)
        Me.txtStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(305, 22)
        Me.txtStudent.TabIndex = 4
        '
        'txtModeOfPayment
        '
        Me.txtModeOfPayment.Enabled = False
        Me.txtModeOfPayment.Location = New System.Drawing.Point(189, 235)
        Me.txtModeOfPayment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtModeOfPayment.Name = "txtModeOfPayment"
        Me.txtModeOfPayment.Size = New System.Drawing.Size(305, 22)
        Me.txtModeOfPayment.TabIndex = 5
        '
        'txtAmountPerTerm
        '
        Me.txtAmountPerTerm.Enabled = False
        Me.txtAmountPerTerm.Location = New System.Drawing.Point(189, 309)
        Me.txtAmountPerTerm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAmountPerTerm.Name = "txtAmountPerTerm"
        Me.txtAmountPerTerm.Size = New System.Drawing.Size(305, 22)
        Me.txtAmountPerTerm.TabIndex = 6
        '
        'txtBalance
        '
        Me.txtBalance.Enabled = False
        Me.txtBalance.Location = New System.Drawing.Point(189, 455)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(305, 22)
        Me.txtBalance.TabIndex = 7
        '
        'txtORNumber
        '
        Me.txtORNumber.Location = New System.Drawing.Point(696, 67)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(305, 22)
        Me.txtORNumber.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Student's Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 239)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mode of Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 313)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Amount per Term"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 459)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(564, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "OR Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(564, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "OR Amount"
        '
        'txtORAmount
        '
        Me.txtORAmount.Location = New System.Drawing.Point(696, 122)
        Me.txtORAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtORAmount.Name = "txtORAmount"
        Me.txtORAmount.Size = New System.Drawing.Size(305, 22)
        Me.txtORAmount.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(564, 186)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Remaining Balance"
        '
        'txtNewBalance
        '
        Me.txtNewBalance.Enabled = False
        Me.txtNewBalance.Location = New System.Drawing.Point(696, 182)
        Me.txtNewBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewBalance.Name = "txtNewBalance"
        Me.txtNewBalance.Size = New System.Drawing.Size(305, 22)
        Me.txtNewBalance.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 384)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Tuition"
        '
        'txtTotalTuition
        '
        Me.txtTotalTuition.Enabled = False
        Me.txtTotalTuition.Location = New System.Drawing.Point(189, 380)
        Me.txtTotalTuition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalTuition.Name = "txtTotalTuition"
        Me.txtTotalTuition.Size = New System.Drawing.Size(305, 22)
        Me.txtTotalTuition.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(755, 223)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 28)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Pay"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'formAccountingPlatform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalTuition)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNewBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtORAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtORNumber)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtAmountPerTerm)
        Me.Controls.Add(Me.txtModeOfPayment)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "formAccountingPlatform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents txtModeOfPayment As TextBox
    Friend WithEvents txtAmountPerTerm As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtORNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtORAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNewBalance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalTuition As TextBox
    Friend WithEvents Button2 As Button
End Class
