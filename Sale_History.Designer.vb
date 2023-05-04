<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sale_History
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GPanelSaleHis = New Guna.UI2.WinForms.Guna2Panel()
        Me.GLabelCas = New System.Windows.Forms.Label()
        Me.GLabelSHTS = New System.Windows.Forms.Label()
        Me.GLabelSHT1 = New System.Windows.Forms.Label()
        Me.GLabelSHF1 = New System.Windows.Forms.Label()
        Me.GTBSHTS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GBtnSH = New Guna.UI2.WinForms.Guna2Button()
        Me.GTBSHC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GDTPSHD2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GDTPSHD1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPanelSaleHis.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GPanelSaleHis
        '
        Me.GPanelSaleHis.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GPanelSaleHis.Controls.Add(Me.GLabelCas)
        Me.GPanelSaleHis.Controls.Add(Me.GLabelSHTS)
        Me.GPanelSaleHis.Controls.Add(Me.GLabelSHT1)
        Me.GPanelSaleHis.Controls.Add(Me.GLabelSHF1)
        Me.GPanelSaleHis.Controls.Add(Me.GTBSHTS)
        Me.GPanelSaleHis.Controls.Add(Me.GBtnSH)
        Me.GPanelSaleHis.Controls.Add(Me.GTBSHC)
        Me.GPanelSaleHis.Controls.Add(Me.GDTPSHD2)
        Me.GPanelSaleHis.Controls.Add(Me.GDTPSHD1)
        Me.GPanelSaleHis.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GPanelSaleHis.Location = New System.Drawing.Point(0, 387)
        Me.GPanelSaleHis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelSaleHis.Name = "GPanelSaleHis"
        Me.GPanelSaleHis.Size = New System.Drawing.Size(1145, 142)
        Me.GPanelSaleHis.TabIndex = 0
        '
        'GLabelCas
        '
        Me.GLabelCas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GLabelCas.AutoSize = True
        Me.GLabelCas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelCas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelCas.Location = New System.Drawing.Point(771, 91)
        Me.GLabelCas.Name = "GLabelCas"
        Me.GLabelCas.Size = New System.Drawing.Size(60, 16)
        Me.GLabelCas.TabIndex = 29
        Me.GLabelCas.Text = "Cashier"
        '
        'GLabelSHTS
        '
        Me.GLabelSHTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GLabelSHTS.AutoSize = True
        Me.GLabelSHTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelSHTS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelSHTS.Location = New System.Drawing.Point(755, 34)
        Me.GLabelSHTS.Name = "GLabelSHTS"
        Me.GLabelSHTS.Size = New System.Drawing.Size(87, 16)
        Me.GLabelSHTS.TabIndex = 28
        Me.GLabelSHTS.Text = "Total Sales"
        '
        'GLabelSHT1
        '
        Me.GLabelSHT1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GLabelSHT1.AutoSize = True
        Me.GLabelSHT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelSHT1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelSHT1.Location = New System.Drawing.Point(417, 34)
        Me.GLabelSHT1.Name = "GLabelSHT1"
        Me.GLabelSHT1.Size = New System.Drawing.Size(26, 16)
        Me.GLabelSHT1.TabIndex = 27
        Me.GLabelSHT1.Text = "To"
        '
        'GLabelSHF1
        '
        Me.GLabelSHF1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GLabelSHF1.AutoSize = True
        Me.GLabelSHF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelSHF1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelSHF1.Location = New System.Drawing.Point(51, 34)
        Me.GLabelSHF1.Name = "GLabelSHF1"
        Me.GLabelSHF1.Size = New System.Drawing.Size(109, 16)
        Me.GLabelSHF1.TabIndex = 26
        Me.GLabelSHF1.Text = "Filter By : Date"
        '
        'GTBSHTS
        '
        Me.GTBSHTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GTBSHTS.Animated = True
        Me.GTBSHTS.BackColor = System.Drawing.Color.Transparent
        Me.GTBSHTS.BorderColor = System.Drawing.Color.Black
        Me.GTBSHTS.BorderRadius = 13
        Me.GTBSHTS.BorderThickness = 2
        Me.GTBSHTS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSHTS.DefaultText = ""
        Me.GTBSHTS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSHTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSHTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSHTS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSHTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSHTS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSHTS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSHTS.Location = New System.Drawing.Point(884, 18)
        Me.GTBSHTS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTBSHTS.Name = "GTBSHTS"
        Me.GTBSHTS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSHTS.PlaceholderText = ""
        Me.GTBSHTS.SelectedText = ""
        Me.GTBSHTS.ShadowDecoration.BorderRadius = 13
        Me.GTBSHTS.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GTBSHTS.ShadowDecoration.Depth = 10
        Me.GTBSHTS.ShadowDecoration.Enabled = True
        Me.GTBSHTS.Size = New System.Drawing.Size(227, 48)
        Me.GTBSHTS.TabIndex = 25
        '
        'GBtnSH
        '
        Me.GBtnSH.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GBtnSH.Animated = True
        Me.GBtnSH.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSH.BorderRadius = 17
        Me.GBtnSH.BorderThickness = 2
        Me.GBtnSH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSH.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSH.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSH.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnSH.Image = Global.Sybca_BillingSystem.My.Resources.Resources.load
        Me.GBtnSH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnSH.ImageSize = New System.Drawing.Size(32, 32)
        Me.GBtnSH.Location = New System.Drawing.Point(376, 80)
        Me.GBtnSH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSH.Name = "GBtnSH"
        Me.GBtnSH.ShadowDecoration.BorderRadius = 17
        Me.GBtnSH.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnSH.ShadowDecoration.Depth = 10
        Me.GBtnSH.ShadowDecoration.Enabled = True
        Me.GBtnSH.Size = New System.Drawing.Size(164, 54)
        Me.GBtnSH.TabIndex = 21
        Me.GBtnSH.Text = "Load Data"
        Me.GBtnSH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GTBSHC
        '
        Me.GTBSHC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GTBSHC.Animated = True
        Me.GTBSHC.BackColor = System.Drawing.Color.Transparent
        Me.GTBSHC.BorderColor = System.Drawing.Color.Black
        Me.GTBSHC.BorderRadius = 13
        Me.GTBSHC.BorderThickness = 2
        Me.GTBSHC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSHC.DefaultText = ""
        Me.GTBSHC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSHC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSHC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSHC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSHC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSHC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSHC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSHC.Location = New System.Drawing.Point(884, 78)
        Me.GTBSHC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTBSHC.Name = "GTBSHC"
        Me.GTBSHC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSHC.PlaceholderText = ""
        Me.GTBSHC.SelectedText = ""
        Me.GTBSHC.ShadowDecoration.BorderRadius = 13
        Me.GTBSHC.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GTBSHC.ShadowDecoration.Depth = 10
        Me.GTBSHC.ShadowDecoration.Enabled = True
        Me.GTBSHC.Size = New System.Drawing.Size(229, 48)
        Me.GTBSHC.TabIndex = 24
        '
        'GDTPSHD2
        '
        Me.GDTPSHD2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GDTPSHD2.BorderRadius = 8
        Me.GDTPSHD2.Checked = True
        Me.GDTPSHD2.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GDTPSHD2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GDTPSHD2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.GDTPSHD2.Location = New System.Drawing.Point(473, 20)
        Me.GDTPSHD2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDTPSHD2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GDTPSHD2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GDTPSHD2.Name = "GDTPSHD2"
        Me.GDTPSHD2.Size = New System.Drawing.Size(227, 46)
        Me.GDTPSHD2.TabIndex = 20
        Me.GDTPSHD2.Value = New Date(2023, 4, 26, 21, 12, 55, 794)
        '
        'GDTPSHD1
        '
        Me.GDTPSHD1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GDTPSHD1.BorderRadius = 8
        Me.GDTPSHD1.Checked = True
        Me.GDTPSHD1.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GDTPSHD1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GDTPSHD1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.GDTPSHD1.Location = New System.Drawing.Point(184, 18)
        Me.GDTPSHD1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDTPSHD1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GDTPSHD1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GDTPSHD1.Name = "GDTPSHD1"
        Me.GDTPSHD1.Size = New System.Drawing.Size(227, 46)
        Me.GDTPSHD1.TabIndex = 19
        Me.GDTPSHD1.Value = New Date(2023, 4, 26, 21, 12, 40, 356)
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 18
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1145, 387)
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
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ProductID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Qty"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Discount"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Sale_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1145, 529)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.GPanelSaleHis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Sale_History"
        Me.Text = "Sale_History"
        Me.GPanelSaleHis.ResumeLayout(False)
        Me.GPanelSaleHis.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GPanelSaleHis As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GTBSHTS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GBtnSH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GTBSHC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GDTPSHD2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GDTPSHD1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents GLabelCas As Label
    Friend WithEvents GLabelSHTS As Label
    Friend WithEvents GLabelSHT1 As Label
    Friend WithEvents GLabelSHF1 As Label
End Class
