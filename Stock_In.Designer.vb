<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock_In
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabCStock = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GBtnSLAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GDataGridStockLis = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GDataGridStockEn = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPanelSEntry = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBtnSeqty = New System.Windows.Forms.Label()
        Me.GBtnSESID = New System.Windows.Forms.Label()
        Me.GBtnSESupp = New System.Windows.Forms.Label()
        Me.GBtnSeProName = New System.Windows.Forms.Label()
        Me.GBtnSEPID = New System.Windows.Forms.Label()
        Me.GBtnSIB = New System.Windows.Forms.Label()
        Me.GBtnSEAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.LinkSe = New System.Windows.Forms.LinkLabel()
        Me.GTextSEpn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GDTPSE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GTBSEQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTBSESupp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTBSEpID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTBSeSib = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabCStock.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GDataGridStockLis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GDataGridStockEn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPanelSEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCStock
        '
        Me.TabCStock.Controls.Add(Me.TabPage1)
        Me.TabCStock.Controls.Add(Me.TabPage2)
        Me.TabCStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCStock.Location = New System.Drawing.Point(0, 0)
        Me.TabCStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabCStock.Name = "TabCStock"
        Me.TabCStock.SelectedIndex = 0
        Me.TabCStock.Size = New System.Drawing.Size(698, 468)
        Me.TabCStock.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GBtnSLAdd)
        Me.TabPage1.Controls.Add(Me.GDataGridStockLis)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(690, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stock List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GBtnSLAdd
        '
        Me.GBtnSLAdd.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSLAdd.BorderRadius = 17
        Me.GBtnSLAdd.BorderThickness = 2
        Me.GBtnSLAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSLAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSLAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSLAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSLAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSLAdd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSLAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSLAdd.ImageSize = New System.Drawing.Size(35, 35)
        Me.GBtnSLAdd.Location = New System.Drawing.Point(585, 394)
        Me.GBtnSLAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBtnSLAdd.Name = "GBtnSLAdd"
        Me.GBtnSLAdd.ShadowDecoration.BorderRadius = 17
        Me.GBtnSLAdd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnSLAdd.ShadowDecoration.Depth = 20
        Me.GBtnSLAdd.ShadowDecoration.Enabled = True
        Me.GBtnSLAdd.Size = New System.Drawing.Size(98, 41)
        Me.GBtnSLAdd.TabIndex = 1
        Me.GBtnSLAdd.Text = "REFRESH"
        Me.GBtnSLAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GDataGridStockLis
        '
        Me.GDataGridStockLis.AllowUserToAddRows = False
        Me.GDataGridStockLis.AllowUserToDeleteRows = False
        Me.GDataGridStockLis.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridStockLis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.GDataGridStockLis.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridStockLis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.GDataGridStockLis.ColumnHeadersHeight = 18
        Me.GDataGridStockLis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridStockLis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDataGridStockLis.DefaultCellStyle = DataGridViewCellStyle15
        Me.GDataGridStockLis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GDataGridStockLis.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockLis.Location = New System.Drawing.Point(2, 2)
        Me.GDataGridStockLis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GDataGridStockLis.Name = "GDataGridStockLis"
        Me.GDataGridStockLis.ReadOnly = True
        Me.GDataGridStockLis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridStockLis.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.GDataGridStockLis.RowHeadersVisible = False
        Me.GDataGridStockLis.RowHeadersWidth = 51
        Me.GDataGridStockLis.RowTemplate.Height = 24
        Me.GDataGridStockLis.Size = New System.Drawing.Size(686, 438)
        Me.GDataGridStockLis.TabIndex = 0
        Me.GDataGridStockLis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridStockLis.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDataGridStockLis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDataGridStockLis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDataGridStockLis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDataGridStockLis.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GDataGridStockLis.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockLis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockLis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDataGridStockLis.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridStockLis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDataGridStockLis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridStockLis.ThemeStyle.HeaderStyle.Height = 18
        Me.GDataGridStockLis.ThemeStyle.ReadOnly = True
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.Height = 24
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockLis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "PID"
        Me.Column9.HeaderText = "ProductID"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "PRODUCT_NAME"
        Me.Column10.HeaderText = "Product Name"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "PRICE"
        Me.Column11.HeaderText = "Price"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "QUANTITY"
        Me.Column12.HeaderText = "Qty Remaining"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GDataGridStockEn)
        Me.TabPage2.Controls.Add(Me.GPanelSEntry)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(690, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock Entry"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GDataGridStockEn
        '
        Me.GDataGridStockEn.AllowUserToAddRows = False
        Me.GDataGridStockEn.AllowUserToDeleteRows = False
        Me.GDataGridStockEn.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridStockEn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.GDataGridStockEn.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridStockEn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.GDataGridStockEn.ColumnHeadersHeight = 18
        Me.GDataGridStockEn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridStockEn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDataGridStockEn.DefaultCellStyle = DataGridViewCellStyle11
        Me.GDataGridStockEn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GDataGridStockEn.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockEn.Location = New System.Drawing.Point(2, 155)
        Me.GDataGridStockEn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GDataGridStockEn.Name = "GDataGridStockEn"
        Me.GDataGridStockEn.ReadOnly = True
        Me.GDataGridStockEn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridStockEn.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.GDataGridStockEn.RowHeadersVisible = False
        Me.GDataGridStockEn.RowHeadersWidth = 51
        Me.GDataGridStockEn.RowTemplate.Height = 24
        Me.GDataGridStockEn.Size = New System.Drawing.Size(686, 285)
        Me.GDataGridStockEn.TabIndex = 1
        Me.GDataGridStockEn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridStockEn.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDataGridStockEn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDataGridStockEn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDataGridStockEn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDataGridStockEn.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GDataGridStockEn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockEn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockEn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDataGridStockEn.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridStockEn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDataGridStockEn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridStockEn.ThemeStyle.HeaderStyle.Height = 18
        Me.GDataGridStockEn.ThemeStyle.ReadOnly = True
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.Height = 24
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridStockEn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PID"
        Me.Column2.HeaderText = "ProductID"
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
        Me.Column4.HeaderText = "Qty"
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
        'Column6
        '
        Me.Column6.DataPropertyName = "STOCKINBY"
        Me.Column6.HeaderText = "Stock In By"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "SPNAME"
        Me.Column7.HeaderText = "Supplier"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'GPanelSEntry
        '
        Me.GPanelSEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GPanelSEntry.Controls.Add(Me.GBtnSeqty)
        Me.GPanelSEntry.Controls.Add(Me.GBtnSESID)
        Me.GPanelSEntry.Controls.Add(Me.GBtnSESupp)
        Me.GPanelSEntry.Controls.Add(Me.GBtnSeProName)
        Me.GPanelSEntry.Controls.Add(Me.GBtnSEPID)
        Me.GPanelSEntry.Controls.Add(Me.GBtnSIB)
        Me.GPanelSEntry.Controls.Add(Me.GBtnSEAdd)
        Me.GPanelSEntry.Controls.Add(Me.LinkSe)
        Me.GPanelSEntry.Controls.Add(Me.GTextSEpn)
        Me.GPanelSEntry.Controls.Add(Me.GDTPSE)
        Me.GPanelSEntry.Controls.Add(Me.GTBSEQty)
        Me.GPanelSEntry.Controls.Add(Me.GTBSESupp)
        Me.GPanelSEntry.Controls.Add(Me.GTBSEpID)
        Me.GPanelSEntry.Controls.Add(Me.GTBSeSib)
        Me.GPanelSEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPanelSEntry.Location = New System.Drawing.Point(2, 2)
        Me.GPanelSEntry.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GPanelSEntry.Name = "GPanelSEntry"
        Me.GPanelSEntry.Size = New System.Drawing.Size(686, 153)
        Me.GPanelSEntry.TabIndex = 0
        '
        'GBtnSeqty
        '
        Me.GBtnSeqty.AutoSize = True
        Me.GBtnSeqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSeqty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSeqty.Location = New System.Drawing.Point(374, 113)
        Me.GBtnSeqty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GBtnSeqty.Name = "GBtnSeqty"
        Me.GBtnSeqty.Size = New System.Drawing.Size(47, 13)
        Me.GBtnSeqty.TabIndex = 25
        Me.GBtnSeqty.Text = "Quntity"
        '
        'GBtnSESID
        '
        Me.GBtnSESID.AutoSize = True
        Me.GBtnSESID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSESID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSESID.Location = New System.Drawing.Point(361, 59)
        Me.GBtnSESID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GBtnSESID.Name = "GBtnSESID"
        Me.GBtnSESID.Size = New System.Drawing.Size(86, 13)
        Me.GBtnSESID.TabIndex = 24
        Me.GBtnSESID.Text = "Stock In Date"
        '
        'GBtnSESupp
        '
        Me.GBtnSESupp.AutoSize = True
        Me.GBtnSESupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSESupp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSESupp.Location = New System.Drawing.Point(361, 21)
        Me.GBtnSESupp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GBtnSESupp.Name = "GBtnSESupp"
        Me.GBtnSESupp.Size = New System.Drawing.Size(53, 13)
        Me.GBtnSESupp.TabIndex = 23
        Me.GBtnSESupp.Text = "Supplier"
        '
        'GBtnSeProName
        '
        Me.GBtnSeProName.AutoSize = True
        Me.GBtnSeProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSeProName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSeProName.Location = New System.Drawing.Point(50, 120)
        Me.GBtnSeProName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GBtnSeProName.Name = "GBtnSeProName"
        Me.GBtnSeProName.Size = New System.Drawing.Size(87, 13)
        Me.GBtnSeProName.TabIndex = 22
        Me.GBtnSeProName.Text = "Product Name"
        '
        'GBtnSEPID
        '
        Me.GBtnSEPID.AutoSize = True
        Me.GBtnSEPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSEPID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSEPID.Location = New System.Drawing.Point(50, 72)
        Me.GBtnSEPID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GBtnSEPID.Name = "GBtnSEPID"
        Me.GBtnSEPID.Size = New System.Drawing.Size(68, 13)
        Me.GBtnSEPID.TabIndex = 21
        Me.GBtnSEPID.Text = "Product ID"
        '
        'GBtnSIB
        '
        Me.GBtnSIB.AutoSize = True
        Me.GBtnSIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSIB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSIB.Location = New System.Drawing.Point(50, 28)
        Me.GBtnSIB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GBtnSIB.Name = "GBtnSIB"
        Me.GBtnSIB.Size = New System.Drawing.Size(73, 13)
        Me.GBtnSIB.TabIndex = 20
        Me.GBtnSIB.Text = "Stock In By"
        '
        'GBtnSEAdd
        '
        Me.GBtnSEAdd.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSEAdd.BorderRadius = 17
        Me.GBtnSEAdd.BorderThickness = 2
        Me.GBtnSEAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSEAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSEAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSEAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSEAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSEAdd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSEAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSEAdd.Location = New System.Drawing.Point(529, 102)
        Me.GBtnSEAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBtnSEAdd.Name = "GBtnSEAdd"
        Me.GBtnSEAdd.ShadowDecoration.BorderRadius = 17
        Me.GBtnSEAdd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnSEAdd.ShadowDecoration.Depth = 20
        Me.GBtnSEAdd.ShadowDecoration.Enabled = True
        Me.GBtnSEAdd.Size = New System.Drawing.Size(100, 43)
        Me.GBtnSEAdd.TabIndex = 19
        Me.GBtnSEAdd.Text = "Add Stock"
        '
        'LinkSe
        '
        Me.LinkSe.AutoSize = True
        Me.LinkSe.LinkColor = System.Drawing.Color.White
        Me.LinkSe.Location = New System.Drawing.Point(191, 91)
        Me.LinkSe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkSe.Name = "LinkSe"
        Me.LinkSe.Size = New System.Drawing.Size(105, 13)
        Me.LinkSe.TabIndex = 18
        Me.LinkSe.TabStop = True
        Me.LinkSe.Text = "[ Search Product Id ]"
        '
        'GTextSEpn
        '
        Me.GTextSEpn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GTextSEpn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.GTextSEpn.BorderRadius = 13
        Me.GTextSEpn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTextSEpn.DefaultText = ""
        Me.GTextSEpn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTextSEpn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTextSEpn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTextSEpn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTextSEpn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTextSEpn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTextSEpn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTextSEpn.Location = New System.Drawing.Point(162, 113)
        Me.GTextSEpn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTextSEpn.Name = "GTextSEpn"
        Me.GTextSEpn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTextSEpn.PlaceholderText = ""
        Me.GTextSEpn.SelectedText = ""
        Me.GTextSEpn.Size = New System.Drawing.Size(172, 29)
        Me.GTextSEpn.TabIndex = 17
        '
        'GDTPSE
        '
        Me.GDTPSE.BorderRadius = 10
        Me.GDTPSE.Checked = True
        Me.GDTPSE.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GDTPSE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GDTPSE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.GDTPSE.Location = New System.Drawing.Point(447, 53)
        Me.GDTPSE.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GDTPSE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GDTPSE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GDTPSE.Name = "GDTPSE"
        Me.GDTPSE.Size = New System.Drawing.Size(170, 35)
        Me.GDTPSE.TabIndex = 15
        Me.GDTPSE.Value = New Date(2023, 4, 28, 0, 0, 0, 0)
        '
        'GTBSEQty
        '
        Me.GTBSEQty.BorderRadius = 13
        Me.GTBSEQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSEQty.DefaultText = ""
        Me.GTBSEQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSEQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSEQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSEQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSEQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSEQty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSEQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSEQty.Location = New System.Drawing.Point(447, 113)
        Me.GTBSEQty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTBSEQty.Name = "GTBSEQty"
        Me.GTBSEQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSEQty.PlaceholderText = ""
        Me.GTBSEQty.SelectedText = ""
        Me.GTBSEQty.Size = New System.Drawing.Size(62, 29)
        Me.GTBSEQty.TabIndex = 8
        '
        'GTBSESupp
        '
        Me.GTBSESupp.BorderRadius = 13
        Me.GTBSESupp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSESupp.DefaultText = ""
        Me.GTBSESupp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSESupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSESupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSESupp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSESupp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSESupp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSESupp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSESupp.Location = New System.Drawing.Point(447, 11)
        Me.GTBSESupp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTBSESupp.Name = "GTBSESupp"
        Me.GTBSESupp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSESupp.PlaceholderText = ""
        Me.GTBSESupp.SelectedText = ""
        Me.GTBSESupp.Size = New System.Drawing.Size(172, 29)
        Me.GTBSESupp.TabIndex = 7
        '
        'GTBSEpID
        '
        Me.GTBSEpID.BorderRadius = 13
        Me.GTBSEpID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSEpID.DefaultText = ""
        Me.GTBSEpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSEpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSEpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSEpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSEpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSEpID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSEpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSEpID.Location = New System.Drawing.Point(162, 55)
        Me.GTBSEpID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTBSEpID.Name = "GTBSEpID"
        Me.GTBSEpID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSEpID.PlaceholderText = ""
        Me.GTBSEpID.SelectedText = ""
        Me.GTBSEpID.Size = New System.Drawing.Size(172, 29)
        Me.GTBSEpID.TabIndex = 6
        '
        'GTBSeSib
        '
        Me.GTBSeSib.BorderRadius = 13
        Me.GTBSeSib.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSeSib.DefaultText = ""
        Me.GTBSeSib.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSeSib.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSeSib.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSeSib.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSeSib.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSeSib.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSeSib.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSeSib.Location = New System.Drawing.Point(162, 11)
        Me.GTBSeSib.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTBSeSib.Name = "GTBSeSib"
        Me.GTBSeSib.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSeSib.PlaceholderText = ""
        Me.GTBSeSib.SelectedText = ""
        Me.GTBSeSib.Size = New System.Drawing.Size(172, 29)
        Me.GTBSeSib.TabIndex = 5
        '
        'Stock_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(698, 468)
        Me.Controls.Add(Me.TabCStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Stock_In"
        Me.Text = "Stock_In"
        Me.TabCStock.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GDataGridStockLis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GDataGridStockEn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPanelSEntry.ResumeLayout(False)
        Me.GPanelSEntry.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCStock As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GPanelSEntry As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GTBSEQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTBSEpID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTBSeSib As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LinkSe As LinkLabel
    Friend WithEvents GTextSEpn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GDTPSE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GBtnSLAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GDataGridStockLis As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GDataGridStockEn As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GBtnSEAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GTBSESupp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents GBtnSeqty As Label
    Friend WithEvents GBtnSESID As Label
    Friend WithEvents GBtnSESupp As Label
    Friend WithEvents GBtnSeProName As Label
    Friend WithEvents GBtnSEPID As Label
    Friend WithEvents GBtnSIB As Label
End Class
