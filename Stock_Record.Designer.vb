<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Record
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GPanelStockRecord = New Guna.UI2.WinForms.Guna2Panel()
        Me.GLabelRecordTo = New System.Windows.Forms.Label()
        Me.GLabelRecordF = New System.Windows.Forms.Label()
        Me.GBtnSR = New Guna.UI2.WinForms.Guna2Button()
        Me.GDTPSrD2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GDTPSRD1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPanelStockRecord.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GPanelStockRecord
        '
        Me.GPanelStockRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GPanelStockRecord.Controls.Add(Me.GLabelRecordTo)
        Me.GPanelStockRecord.Controls.Add(Me.GLabelRecordF)
        Me.GPanelStockRecord.Controls.Add(Me.GBtnSR)
        Me.GPanelStockRecord.Controls.Add(Me.GDTPSrD2)
        Me.GPanelStockRecord.Controls.Add(Me.GDTPSRD1)
        Me.GPanelStockRecord.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPanelStockRecord.Location = New System.Drawing.Point(0, 0)
        Me.GPanelStockRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelStockRecord.Name = "GPanelStockRecord"
        Me.GPanelStockRecord.Size = New System.Drawing.Size(931, 108)
        Me.GPanelStockRecord.TabIndex = 0
        '
        'GLabelRecordTo
        '
        Me.GLabelRecordTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabelRecordTo.AutoSize = True
        Me.GLabelRecordTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelRecordTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelRecordTo.Location = New System.Drawing.Point(416, 41)
        Me.GLabelRecordTo.Name = "GLabelRecordTo"
        Me.GLabelRecordTo.Size = New System.Drawing.Size(26, 16)
        Me.GLabelRecordTo.TabIndex = 18
        Me.GLabelRecordTo.Text = "To"
        '
        'GLabelRecordF
        '
        Me.GLabelRecordF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabelRecordF.AutoSize = True
        Me.GLabelRecordF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelRecordF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelRecordF.Location = New System.Drawing.Point(61, 41)
        Me.GLabelRecordF.Name = "GLabelRecordF"
        Me.GLabelRecordF.Size = New System.Drawing.Size(109, 16)
        Me.GLabelRecordF.TabIndex = 17
        Me.GLabelRecordF.Text = "Filter By : Date"
        '
        'GBtnSR
        '
        Me.GBtnSR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBtnSR.Animated = True
        Me.GBtnSR.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSR.BorderRadius = 17
        Me.GBtnSR.BorderThickness = 2
        Me.GBtnSR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSR.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSR.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSR.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnSR.Image = Global.Sybca_BillingSystem.My.Resources.Resources.load
        Me.GBtnSR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnSR.ImageSize = New System.Drawing.Size(35, 35)
        Me.GBtnSR.Location = New System.Drawing.Point(696, 25)
        Me.GBtnSR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSR.Name = "GBtnSR"
        Me.GBtnSR.ShadowDecoration.BorderRadius = 17
        Me.GBtnSR.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnSR.ShadowDecoration.Depth = 10
        Me.GBtnSR.ShadowDecoration.Enabled = True
        Me.GBtnSR.Size = New System.Drawing.Size(169, 51)
        Me.GBtnSR.TabIndex = 16
        Me.GBtnSR.Text = "Load Data"
        Me.GBtnSR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GDTPSrD2
        '
        Me.GDTPSrD2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GDTPSrD2.BorderRadius = 10
        Me.GDTPSrD2.Checked = True
        Me.GDTPSrD2.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GDTPSrD2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GDTPSrD2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.GDTPSrD2.Location = New System.Drawing.Point(475, 27)
        Me.GDTPSrD2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDTPSrD2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GDTPSrD2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GDTPSrD2.Name = "GDTPSrD2"
        Me.GDTPSrD2.Size = New System.Drawing.Size(200, 46)
        Me.GDTPSrD2.TabIndex = 15
        Me.GDTPSrD2.Value = New Date(2023, 4, 26, 21, 12, 55, 794)
        '
        'GDTPSRD1
        '
        Me.GDTPSRD1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GDTPSRD1.BorderRadius = 10
        Me.GDTPSRD1.Checked = True
        Me.GDTPSRD1.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GDTPSRD1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GDTPSRD1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.GDTPSRD1.Location = New System.Drawing.Point(198, 27)
        Me.GDTPSRD1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDTPSRD1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GDTPSRD1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GDTPSRD1.Name = "GDTPSRD1"
        Me.GDTPSRD1.Size = New System.Drawing.Size(200, 46)
        Me.GDTPSRD1.TabIndex = 14
        Me.GDTPSRD1.Value = New Date(2023, 4, 26, 21, 12, 40, 356)
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DataGridView1.ColumnHeadersHeight = 18
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(0, 108)
        Me.Guna2DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(931, 468)
        Me.Guna2DataGridView1.TabIndex = 1
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PID"
        Me.Column2.HeaderText = "Product"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "PRODUCT_NAME"
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "QUANTITY"
        Me.Column4.HeaderText = "Quntity Added"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "DATE"
        Me.Column5.HeaderText = "Date"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Stock_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(931, 576)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.GPanelStockRecord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Stock_Record"
        Me.Text = "Stock_Record"
        Me.GPanelStockRecord.ResumeLayout(False)
        Me.GPanelStockRecord.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GPanelStockRecord As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnSR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GDTPSrD2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GDTPSRD1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents GLabelRecordTo As Label
    Friend WithEvents GLabelRecordF As Label
End Class
