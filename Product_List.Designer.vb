<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_List
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
        Me.GDataGridVPL = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPanelPL = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBtnPLDel = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnPLEd = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnPLadd = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.GDataGridVPL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPanelPL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GDataGridVPL
        '
        Me.GDataGridVPL.AllowUserToAddRows = False
        Me.GDataGridVPL.AllowUserToDeleteRows = False
        Me.GDataGridVPL.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridVPL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GDataGridVPL.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GDataGridVPL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridVPL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GDataGridVPL.ColumnHeadersHeight = 27
        Me.GDataGridVPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridVPL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDataGridVPL.DefaultCellStyle = DataGridViewCellStyle3
        Me.GDataGridVPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GDataGridVPL.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVPL.Location = New System.Drawing.Point(0, 0)
        Me.GDataGridVPL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDataGridVPL.Name = "GDataGridVPL"
        Me.GDataGridVPL.ReadOnly = True
        Me.GDataGridVPL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridVPL.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GDataGridVPL.RowHeadersVisible = False
        Me.GDataGridVPL.RowHeadersWidth = 51
        Me.GDataGridVPL.RowTemplate.Height = 24
        Me.GDataGridVPL.Size = New System.Drawing.Size(913, 542)
        Me.GDataGridVPL.TabIndex = 0
        Me.GDataGridVPL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridVPL.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDataGridVPL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDataGridVPL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDataGridVPL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDataGridVPL.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GDataGridVPL.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVPL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVPL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDataGridVPL.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridVPL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDataGridVPL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridVPL.ThemeStyle.HeaderStyle.Height = 27
        Me.GDataGridVPL.ThemeStyle.ReadOnly = True
        Me.GDataGridVPL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridVPL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDataGridVPL.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridVPL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridVPL.ThemeStyle.RowsStyle.Height = 24
        Me.GDataGridVPL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVPL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.Column4.DataPropertyName = "BRAND"
        Me.Column4.HeaderText = "Brand"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CATEGORY"
        Me.Column5.HeaderText = "Categroy"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "DISCOUNT"
        Me.Column7.HeaderText = "Discount"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "PRICE"
        Me.Column6.HeaderText = "Price"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GPanelPL
        '
        Me.GPanelPL.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GPanelPL.Controls.Add(Me.GBtnPLDel)
        Me.GPanelPL.Controls.Add(Me.GBtnPLEd)
        Me.GPanelPL.Controls.Add(Me.GBtnPLadd)
        Me.GPanelPL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GPanelPL.Location = New System.Drawing.Point(0, 442)
        Me.GPanelPL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelPL.Name = "GPanelPL"
        Me.GPanelPL.Size = New System.Drawing.Size(913, 100)
        Me.GPanelPL.TabIndex = 1
        '
        'GBtnPLDel
        '
        Me.GBtnPLDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GBtnPLDel.Animated = True
        Me.GBtnPLDel.BackColor = System.Drawing.Color.Transparent
        Me.GBtnPLDel.BorderRadius = 17
        Me.GBtnPLDel.BorderThickness = 2
        Me.GBtnPLDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnPLDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnPLDel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnPLDel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnPLDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnPLDel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnPLDel.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnPLDel.Location = New System.Drawing.Point(600, 23)
        Me.GBtnPLDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnPLDel.Name = "GBtnPLDel"
        Me.GBtnPLDel.ShadowDecoration.BorderRadius = 17
        Me.GBtnPLDel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnPLDel.ShadowDecoration.Depth = 20
        Me.GBtnPLDel.ShadowDecoration.Enabled = True
        Me.GBtnPLDel.Size = New System.Drawing.Size(131, 52)
        Me.GBtnPLDel.TabIndex = 2
        Me.GBtnPLDel.Text = "Delete"
        '
        'GBtnPLEd
        '
        Me.GBtnPLEd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GBtnPLEd.Animated = True
        Me.GBtnPLEd.BackColor = System.Drawing.Color.Transparent
        Me.GBtnPLEd.BorderRadius = 17
        Me.GBtnPLEd.BorderThickness = 2
        Me.GBtnPLEd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLEd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLEd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnPLEd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnPLEd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnPLEd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnPLEd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnPLEd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnPLEd.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnPLEd.Location = New System.Drawing.Point(426, 23)
        Me.GBtnPLEd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnPLEd.Name = "GBtnPLEd"
        Me.GBtnPLEd.ShadowDecoration.BorderRadius = 17
        Me.GBtnPLEd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnPLEd.ShadowDecoration.Depth = 20
        Me.GBtnPLEd.ShadowDecoration.Enabled = True
        Me.GBtnPLEd.Size = New System.Drawing.Size(131, 52)
        Me.GBtnPLEd.TabIndex = 1
        Me.GBtnPLEd.Text = "Edit"
        '
        'GBtnPLadd
        '
        Me.GBtnPLadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GBtnPLadd.Animated = True
        Me.GBtnPLadd.BackColor = System.Drawing.Color.Transparent
        Me.GBtnPLadd.BorderRadius = 17
        Me.GBtnPLadd.BorderThickness = 2
        Me.GBtnPLadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPLadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnPLadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnPLadd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnPLadd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnPLadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnPLadd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnPLadd.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnPLadd.Location = New System.Drawing.Point(252, 23)
        Me.GBtnPLadd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnPLadd.Name = "GBtnPLadd"
        Me.GBtnPLadd.ShadowDecoration.BorderRadius = 17
        Me.GBtnPLadd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnPLadd.ShadowDecoration.Depth = 20
        Me.GBtnPLadd.ShadowDecoration.Enabled = True
        Me.GBtnPLadd.Size = New System.Drawing.Size(131, 52)
        Me.GBtnPLadd.TabIndex = 0
        Me.GBtnPLadd.Text = "Add"
        '
        'Product_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(913, 542)
        Me.Controls.Add(Me.GPanelPL)
        Me.Controls.Add(Me.GDataGridVPL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Product_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_List"
        CType(Me.GDataGridVPL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPanelPL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GDataGridVPL As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GPanelPL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnPLDel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnPLEd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnPLadd As Guna.UI2.WinForms.Guna2Button
    ' Friend WithEvents SMDBDataSet As SMDBDataSet
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
