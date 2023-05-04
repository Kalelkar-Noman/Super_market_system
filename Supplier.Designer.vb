<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Me.GDataGridVSupp = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPanelSupp = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2BDELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnSUPUp = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnSupAd = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.GDataGridVSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPanelSupp.SuspendLayout()
        Me.SuspendLayout()
        '
        'GDataGridVSupp
        '
        Me.GDataGridVSupp.AllowUserToAddRows = False
        Me.GDataGridVSupp.AllowUserToDeleteRows = False
        Me.GDataGridVSupp.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridVSupp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GDataGridVSupp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridVSupp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GDataGridVSupp.ColumnHeadersHeight = 34
        Me.GDataGridVSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridVSupp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column7, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDataGridVSupp.DefaultCellStyle = DataGridViewCellStyle3
        Me.GDataGridVSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GDataGridVSupp.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVSupp.Location = New System.Drawing.Point(0, 0)
        Me.GDataGridVSupp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDataGridVSupp.Name = "GDataGridVSupp"
        Me.GDataGridVSupp.ReadOnly = True
        Me.GDataGridVSupp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDataGridVSupp.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GDataGridVSupp.RowHeadersVisible = False
        Me.GDataGridVSupp.RowHeadersWidth = 51
        Me.GDataGridVSupp.RowTemplate.Height = 24
        Me.GDataGridVSupp.Size = New System.Drawing.Size(913, 542)
        Me.GDataGridVSupp.TabIndex = 0
        Me.GDataGridVSupp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridVSupp.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDataGridVSupp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDataGridVSupp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDataGridVSupp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDataGridVSupp.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GDataGridVSupp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVSupp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVSupp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDataGridVSupp.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridVSupp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDataGridVSupp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDataGridVSupp.ThemeStyle.HeaderStyle.Height = 34
        Me.GDataGridVSupp.ThemeStyle.ReadOnly = True
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.Height = 24
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDataGridVSupp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "SPNAME"
        Me.Column2.HeaderText = "Supplier Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "SADDRESS"
        Me.Column3.HeaderText = "Address"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "SCATEGORY"
        Me.Column7.HeaderText = "Categories"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "SPHONE"
        Me.Column5.HeaderText = "Phone No"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "SEMAIL"
        Me.Column6.HeaderText = "Email Id"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GPanelSupp
        '
        Me.GPanelSupp.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GPanelSupp.Controls.Add(Me.Guna2BDELETE)
        Me.GPanelSupp.Controls.Add(Me.GBtnSUPUp)
        Me.GPanelSupp.Controls.Add(Me.GBtnSupAd)
        Me.GPanelSupp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GPanelSupp.Location = New System.Drawing.Point(0, 442)
        Me.GPanelSupp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelSupp.Name = "GPanelSupp"
        Me.GPanelSupp.Size = New System.Drawing.Size(913, 100)
        Me.GPanelSupp.TabIndex = 1
        '
        'Guna2BDELETE
        '
        Me.Guna2BDELETE.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2BDELETE.Animated = True
        Me.Guna2BDELETE.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BDELETE.BorderRadius = 17
        Me.Guna2BDELETE.BorderThickness = 2
        Me.Guna2BDELETE.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Guna2BDELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BDELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BDELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BDELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BDELETE.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2BDELETE.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2BDELETE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2BDELETE.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Guna2BDELETE.Location = New System.Drawing.Point(213, 25)
        Me.Guna2BDELETE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2BDELETE.Name = "Guna2BDELETE"
        Me.Guna2BDELETE.ShadowDecoration.BorderRadius = 17
        Me.Guna2BDELETE.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2BDELETE.ShadowDecoration.Depth = 10
        Me.Guna2BDELETE.ShadowDecoration.Enabled = True
        Me.Guna2BDELETE.Size = New System.Drawing.Size(141, 57)
        Me.Guna2BDELETE.TabIndex = 2
        Me.Guna2BDELETE.Text = "Delete"
        '
        'GBtnSUPUp
        '
        Me.GBtnSUPUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GBtnSUPUp.Animated = True
        Me.GBtnSUPUp.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSUPUp.BorderRadius = 17
        Me.GBtnSUPUp.BorderThickness = 2
        Me.GBtnSUPUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSUPUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSUPUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSUPUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSUPUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSUPUp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSUPUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSUPUp.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnSUPUp.Location = New System.Drawing.Point(624, 25)
        Me.GBtnSUPUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSUPUp.Name = "GBtnSUPUp"
        Me.GBtnSUPUp.ShadowDecoration.BorderRadius = 17
        Me.GBtnSUPUp.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnSUPUp.ShadowDecoration.Depth = 10
        Me.GBtnSUPUp.ShadowDecoration.Enabled = True
        Me.GBtnSUPUp.Size = New System.Drawing.Size(143, 57)
        Me.GBtnSUPUp.TabIndex = 1
        Me.GBtnSUPUp.Text = "Upadte"
        '
        'GBtnSupAd
        '
        Me.GBtnSupAd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GBtnSupAd.Animated = True
        Me.GBtnSupAd.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSupAd.BorderRadius = 17
        Me.GBtnSupAd.BorderThickness = 2
        Me.GBtnSupAd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GBtnSupAd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSupAd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSupAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSupAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSupAd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSupAd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSupAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSupAd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnSupAd.Location = New System.Drawing.Point(422, 25)
        Me.GBtnSupAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSupAd.Name = "GBtnSupAd"
        Me.GBtnSupAd.ShadowDecoration.BorderRadius = 17
        Me.GBtnSupAd.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnSupAd.ShadowDecoration.Depth = 10
        Me.GBtnSupAd.ShadowDecoration.Enabled = True
        Me.GBtnSupAd.Size = New System.Drawing.Size(141, 57)
        Me.GBtnSupAd.TabIndex = 0
        Me.GBtnSupAd.Text = "Add"
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(913, 542)
        Me.Controls.Add(Me.GPanelSupp)
        Me.Controls.Add(Me.GDataGridVSupp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        CType(Me.GDataGridVSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPanelSupp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GDataGridVSupp As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GPanelSupp As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnSUPUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnSupAd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2BDELETE As Guna.UI2.WinForms.Guna2Button
End Class
