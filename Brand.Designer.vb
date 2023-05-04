<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Brand
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GDataGridVBrand = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_COUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBtnPLaddrefresh = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.GDataGridVBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GDataGridVBrand
        '
        Me.GDataGridVBrand.AllowUserToAddRows = False
        Me.GDataGridVBrand.AllowUserToDeleteRows = False
        Me.GDataGridVBrand.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridVBrand.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.GDataGridVBrand.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GDataGridVBrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridVBrand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.GDataGridVBrand.ColumnHeadersHeight = 27
        Me.GDataGridVBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridVBrand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.PRODUCT_COUNT})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDataGridVBrand.DefaultCellStyle = DataGridViewCellStyle11
        Me.GDataGridVBrand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GDataGridVBrand.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVBrand.Location = New System.Drawing.Point(0, 0)
        Me.GDataGridVBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDataGridVBrand.Name = "GDataGridVBrand"
        Me.GDataGridVBrand.ReadOnly = True
        Me.GDataGridVBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridVBrand.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.GDataGridVBrand.RowHeadersVisible = False
        Me.GDataGridVBrand.RowHeadersWidth = 51
        Me.GDataGridVBrand.RowTemplate.Height = 26
        Me.GDataGridVBrand.Size = New System.Drawing.Size(913, 529)
        Me.GDataGridVBrand.TabIndex = 0
        Me.GDataGridVBrand.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridVBrand.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDataGridVBrand.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDataGridVBrand.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDataGridVBrand.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDataGridVBrand.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GDataGridVBrand.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVBrand.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVBrand.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDataGridVBrand.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridVBrand.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDataGridVBrand.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridVBrand.ThemeStyle.HeaderStyle.Height = 27
        Me.GDataGridVBrand.ThemeStyle.ReadOnly = True
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.Height = 26
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVBrand.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "BRAND"
        Me.Column2.HeaderText = "Brand"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'PRODUCT_COUNT
        '
        Me.PRODUCT_COUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PRODUCT_COUNT.DataPropertyName = "PCOUNT"
        Me.PRODUCT_COUNT.HeaderText = "PRODUCT CATEGORIES"
        Me.PRODUCT_COUNT.MinimumWidth = 6
        Me.PRODUCT_COUNT.Name = "PRODUCT_COUNT"
        Me.PRODUCT_COUNT.ReadOnly = True
        Me.PRODUCT_COUNT.Width = 191
        '
        'GBtnPLaddrefresh
        '
        Me.GBtnPLaddrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBtnPLaddrefresh.BorderRadius = 17
        Me.GBtnPLaddrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLaddrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLaddrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnPLaddrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnPLaddrefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnPLaddrefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBtnPLaddrefresh.ForeColor = System.Drawing.Color.White
        Me.GBtnPLaddrefresh.Location = New System.Drawing.Point(768, 435)
        Me.GBtnPLaddrefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnPLaddrefresh.Name = "GBtnPLaddrefresh"
        Me.GBtnPLaddrefresh.Size = New System.Drawing.Size(127, 51)
        Me.GBtnPLaddrefresh.TabIndex = 1
        Me.GBtnPLaddrefresh.Text = "REFRESH"
        '
        'Brand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(913, 529)
        Me.Controls.Add(Me.GBtnPLaddrefresh)
        Me.Controls.Add(Me.GDataGridVBrand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Brand"
        Me.Text = "Brand"
        CType(Me.GDataGridVBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GDataGridVBrand As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GBtnPLaddrefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_COUNT As DataGridViewTextBoxColumn
End Class
