<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAdim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAdim))
        Me.PanelLeft = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBtnLog = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.GPanelRecordSub = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBtnRPOS = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnSaleHis = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnRecord = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnSup = New Guna.UI2.WinForms.Guna2Button()
        Me.GPanelStockSub = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBtnStocRe = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnStockIn = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnStock = New Guna.UI2.WinForms.Guna2Button()
        Me.GPanelProductSub = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBtnsubBrand = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnsubCat = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnSubPL = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDash = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelAdmin = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelAdAdd = New System.Windows.Forms.Label()
        Me.LabelAdminU = New System.Windows.Forms.Label()
        Me.GPBAdmin = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelText = New Guna.UI2.WinForms.Guna2Panel()
        Me.GLTitle = New System.Windows.Forms.Label()
        Me.PanelMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.PanelLeft.SuspendLayout()
        Me.GPanelRecordSub.SuspendLayout()
        Me.GPanelStockSub.SuspendLayout()
        Me.GPanelProductSub.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        CType(Me.GPBAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelText.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.AutoScroll = True
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.GBtnLog)
        Me.PanelLeft.Controls.Add(Me.GBtnUser)
        Me.PanelLeft.Controls.Add(Me.GPanelRecordSub)
        Me.PanelLeft.Controls.Add(Me.GBtnRecord)
        Me.PanelLeft.Controls.Add(Me.GBtnSup)
        Me.PanelLeft.Controls.Add(Me.GPanelStockSub)
        Me.PanelLeft.Controls.Add(Me.GBtnStock)
        Me.PanelLeft.Controls.Add(Me.GPanelProductSub)
        Me.PanelLeft.Controls.Add(Me.GBtnProduct)
        Me.PanelLeft.Controls.Add(Me.BtnDash)
        Me.PanelLeft.Controls.Add(Me.PanelAdmin)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(273, 654)
        Me.PanelLeft.TabIndex = 0
        '
        'GBtnLog
        '
        Me.GBtnLog.Animated = True
        Me.GBtnLog.BackColor = System.Drawing.Color.Transparent
        Me.GBtnLog.BorderRadius = 10
        Me.GBtnLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBtnLog.FillColor = System.Drawing.Color.Transparent
        Me.GBtnLog.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnLog.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnLog.Image = CType(resources.GetObject("GBtnLog.Image"), System.Drawing.Image)
        Me.GBtnLog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnLog.ImageSize = New System.Drawing.Size(47, 47)
        Me.GBtnLog.Location = New System.Drawing.Point(0, 1098)
        Me.GBtnLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnLog.Name = "GBtnLog"
        Me.GBtnLog.Size = New System.Drawing.Size(252, 65)
        Me.GBtnLog.TabIndex = 10
        Me.GBtnLog.Text = "Logout"
        '
        'GBtnUser
        '
        Me.GBtnUser.Animated = True
        Me.GBtnUser.BackColor = System.Drawing.Color.Transparent
        Me.GBtnUser.BorderRadius = 10
        Me.GBtnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnUser.FillColor = System.Drawing.Color.Transparent
        Me.GBtnUser.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnUser.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnUser.Image = CType(resources.GetObject("GBtnUser.Image"), System.Drawing.Image)
        Me.GBtnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnUser.ImageSize = New System.Drawing.Size(47, 47)
        Me.GBtnUser.Location = New System.Drawing.Point(0, 1033)
        Me.GBtnUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnUser.Name = "GBtnUser"
        Me.GBtnUser.Size = New System.Drawing.Size(252, 65)
        Me.GBtnUser.TabIndex = 9
        Me.GBtnUser.Text = "User"
        '
        'GPanelRecordSub
        '
        Me.GPanelRecordSub.Controls.Add(Me.GBtnRPOS)
        Me.GPanelRecordSub.Controls.Add(Me.GBtnSaleHis)
        Me.GPanelRecordSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPanelRecordSub.Location = New System.Drawing.Point(0, 904)
        Me.GPanelRecordSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelRecordSub.Name = "GPanelRecordSub"
        Me.GPanelRecordSub.Size = New System.Drawing.Size(252, 129)
        Me.GPanelRecordSub.TabIndex = 8
        '
        'GBtnRPOS
        '
        Me.GBtnRPOS.Animated = True
        Me.GBtnRPOS.BackColor = System.Drawing.Color.Transparent
        Me.GBtnRPOS.BorderRadius = 13
        Me.GBtnRPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnRPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnRPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnRPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnRPOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBtnRPOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnRPOS.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnRPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnRPOS.Location = New System.Drawing.Point(0, 64)
        Me.GBtnRPOS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnRPOS.Name = "GBtnRPOS"
        Me.GBtnRPOS.Size = New System.Drawing.Size(252, 65)
        Me.GBtnRPOS.TabIndex = 6
        Me.GBtnRPOS.Text = "POS Of Sales"
        '
        'GBtnSaleHis
        '
        Me.GBtnSaleHis.Animated = True
        Me.GBtnSaleHis.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSaleHis.BorderRadius = 13
        Me.GBtnSaleHis.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSaleHis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSaleHis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSaleHis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSaleHis.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnSaleHis.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnSaleHis.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSaleHis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSaleHis.Location = New System.Drawing.Point(0, 0)
        Me.GBtnSaleHis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSaleHis.Name = "GBtnSaleHis"
        Me.GBtnSaleHis.Size = New System.Drawing.Size(252, 65)
        Me.GBtnSaleHis.TabIndex = 5
        Me.GBtnSaleHis.Text = "Sale History"
        '
        'GBtnRecord
        '
        Me.GBtnRecord.Animated = True
        Me.GBtnRecord.BorderRadius = 10
        Me.GBtnRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnRecord.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnRecord.FillColor = System.Drawing.Color.Transparent
        Me.GBtnRecord.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnRecord.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnRecord.Image = CType(resources.GetObject("GBtnRecord.Image"), System.Drawing.Image)
        Me.GBtnRecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnRecord.ImageSize = New System.Drawing.Size(35, 35)
        Me.GBtnRecord.Location = New System.Drawing.Point(0, 839)
        Me.GBtnRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnRecord.Name = "GBtnRecord"
        Me.GBtnRecord.Size = New System.Drawing.Size(252, 65)
        Me.GBtnRecord.TabIndex = 7
        Me.GBtnRecord.Text = "Record"
        '
        'GBtnSup
        '
        Me.GBtnSup.Animated = True
        Me.GBtnSup.BorderRadius = 10
        Me.GBtnSup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnSup.FillColor = System.Drawing.Color.Transparent
        Me.GBtnSup.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSup.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnSup.Image = CType(resources.GetObject("GBtnSup.Image"), System.Drawing.Image)
        Me.GBtnSup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnSup.ImageSize = New System.Drawing.Size(47, 47)
        Me.GBtnSup.Location = New System.Drawing.Point(0, 774)
        Me.GBtnSup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSup.Name = "GBtnSup"
        Me.GBtnSup.Size = New System.Drawing.Size(252, 65)
        Me.GBtnSup.TabIndex = 6
        Me.GBtnSup.Text = "Supplier"
        '
        'GPanelStockSub
        '
        Me.GPanelStockSub.Controls.Add(Me.GBtnStocRe)
        Me.GPanelStockSub.Controls.Add(Me.GBtnStockIn)
        Me.GPanelStockSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPanelStockSub.Location = New System.Drawing.Point(0, 646)
        Me.GPanelStockSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelStockSub.Name = "GPanelStockSub"
        Me.GPanelStockSub.Size = New System.Drawing.Size(252, 128)
        Me.GPanelStockSub.TabIndex = 5
        '
        'GBtnStocRe
        '
        Me.GBtnStocRe.Animated = True
        Me.GBtnStocRe.BackColor = System.Drawing.Color.Transparent
        Me.GBtnStocRe.BorderRadius = 13
        Me.GBtnStocRe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnStocRe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnStocRe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnStocRe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnStocRe.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBtnStocRe.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnStocRe.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnStocRe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnStocRe.Location = New System.Drawing.Point(0, 63)
        Me.GBtnStocRe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnStocRe.Name = "GBtnStocRe"
        Me.GBtnStocRe.Size = New System.Drawing.Size(252, 65)
        Me.GBtnStocRe.TabIndex = 6
        Me.GBtnStocRe.Text = "Stock Record"
        '
        'GBtnStockIn
        '
        Me.GBtnStockIn.Animated = True
        Me.GBtnStockIn.BackColor = System.Drawing.Color.Transparent
        Me.GBtnStockIn.BorderRadius = 13
        Me.GBtnStockIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnStockIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnStockIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnStockIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnStockIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnStockIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnStockIn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnStockIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnStockIn.Location = New System.Drawing.Point(0, 0)
        Me.GBtnStockIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnStockIn.Name = "GBtnStockIn"
        Me.GBtnStockIn.Size = New System.Drawing.Size(252, 65)
        Me.GBtnStockIn.TabIndex = 5
        Me.GBtnStockIn.Text = "Stock IN"
        '
        'GBtnStock
        '
        Me.GBtnStock.Animated = True
        Me.GBtnStock.BorderRadius = 10
        Me.GBtnStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnStock.FillColor = System.Drawing.Color.Transparent
        Me.GBtnStock.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnStock.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnStock.Image = CType(resources.GetObject("GBtnStock.Image"), System.Drawing.Image)
        Me.GBtnStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnStock.ImageSize = New System.Drawing.Size(47, 47)
        Me.GBtnStock.Location = New System.Drawing.Point(0, 581)
        Me.GBtnStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnStock.Name = "GBtnStock"
        Me.GBtnStock.Size = New System.Drawing.Size(252, 65)
        Me.GBtnStock.TabIndex = 4
        Me.GBtnStock.Text = "Stock"
        '
        'GPanelProductSub
        '
        Me.GPanelProductSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GPanelProductSub.Controls.Add(Me.GBtnsubBrand)
        Me.GPanelProductSub.Controls.Add(Me.GBtnsubCat)
        Me.GPanelProductSub.Controls.Add(Me.GBtnSubPL)
        Me.GPanelProductSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPanelProductSub.ForeColor = System.Drawing.Color.Transparent
        Me.GPanelProductSub.Location = New System.Drawing.Point(0, 387)
        Me.GPanelProductSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelProductSub.Name = "GPanelProductSub"
        Me.GPanelProductSub.Size = New System.Drawing.Size(252, 194)
        Me.GPanelProductSub.TabIndex = 3
        '
        'GBtnsubBrand
        '
        Me.GBtnsubBrand.Animated = True
        Me.GBtnsubBrand.BackColor = System.Drawing.Color.Transparent
        Me.GBtnsubBrand.BorderRadius = 13
        Me.GBtnsubBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnsubBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnsubBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnsubBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnsubBrand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBtnsubBrand.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnsubBrand.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnsubBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnsubBrand.Location = New System.Drawing.Point(0, 65)
        Me.GBtnsubBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnsubBrand.Name = "GBtnsubBrand"
        Me.GBtnsubBrand.Size = New System.Drawing.Size(252, 64)
        Me.GBtnsubBrand.TabIndex = 5
        Me.GBtnsubBrand.Text = "Brand"
        '
        'GBtnsubCat
        '
        Me.GBtnsubCat.Animated = True
        Me.GBtnsubCat.BackColor = System.Drawing.Color.Transparent
        Me.GBtnsubCat.BorderRadius = 13
        Me.GBtnsubCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnsubCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnsubCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnsubCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnsubCat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBtnsubCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnsubCat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnsubCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnsubCat.Location = New System.Drawing.Point(0, 129)
        Me.GBtnsubCat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnsubCat.Name = "GBtnsubCat"
        Me.GBtnsubCat.Size = New System.Drawing.Size(252, 65)
        Me.GBtnsubCat.TabIndex = 4
        Me.GBtnsubCat.Text = "Categroy"
        '
        'GBtnSubPL
        '
        Me.GBtnSubPL.Animated = True
        Me.GBtnSubPL.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSubPL.BorderRadius = 13
        Me.GBtnSubPL.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSubPL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSubPL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSubPL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSubPL.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnSubPL.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.GBtnSubPL.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSubPL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSubPL.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnSubPL.ImageSize = New System.Drawing.Size(47, 47)
        Me.GBtnSubPL.Location = New System.Drawing.Point(0, 0)
        Me.GBtnSubPL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSubPL.Name = "GBtnSubPL"
        Me.GBtnSubPL.Size = New System.Drawing.Size(252, 65)
        Me.GBtnSubPL.TabIndex = 3
        Me.GBtnSubPL.Text = "Product List"
        '
        'GBtnProduct
        '
        Me.GBtnProduct.Animated = True
        Me.GBtnProduct.BackColor = System.Drawing.Color.Transparent
        Me.GBtnProduct.BorderRadius = 10
        Me.GBtnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBtnProduct.FillColor = System.Drawing.Color.Transparent
        Me.GBtnProduct.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnProduct.Image = CType(resources.GetObject("GBtnProduct.Image"), System.Drawing.Image)
        Me.GBtnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GBtnProduct.ImageSize = New System.Drawing.Size(47, 47)
        Me.GBtnProduct.Location = New System.Drawing.Point(0, 322)
        Me.GBtnProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnProduct.Name = "GBtnProduct"
        Me.GBtnProduct.Size = New System.Drawing.Size(252, 65)
        Me.GBtnProduct.TabIndex = 2
        Me.GBtnProduct.Text = "Product"
        '
        'BtnDash
        '
        Me.BtnDash.Animated = True
        Me.BtnDash.BorderRadius = 10
        Me.BtnDash.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDash.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDash.FillColor = System.Drawing.Color.Transparent
        Me.BtnDash.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDash.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BtnDash.Image = CType(resources.GetObject("BtnDash.Image"), System.Drawing.Image)
        Me.BtnDash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnDash.ImageSize = New System.Drawing.Size(47, 47)
        Me.BtnDash.Location = New System.Drawing.Point(0, 257)
        Me.BtnDash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDash.Name = "BtnDash"
        Me.BtnDash.Size = New System.Drawing.Size(252, 65)
        Me.BtnDash.TabIndex = 1
        Me.BtnDash.Text = "Dashboard"
        '
        'PanelAdmin
        '
        Me.PanelAdmin.Controls.Add(Me.LabelAdAdd)
        Me.PanelAdmin.Controls.Add(Me.LabelAdminU)
        Me.PanelAdmin.Controls.Add(Me.GPBAdmin)
        Me.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAdmin.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(252, 257)
        Me.PanelAdmin.TabIndex = 0
        '
        'LabelAdAdd
        '
        Me.LabelAdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LabelAdAdd.Location = New System.Drawing.Point(50, 209)
        Me.LabelAdAdd.Name = "LabelAdAdd"
        Me.LabelAdAdd.Size = New System.Drawing.Size(141, 32)
        Me.LabelAdAdd.TabIndex = 24
        Me.LabelAdAdd.Text = "Administrator"
        Me.LabelAdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAdminU
        '
        Me.LabelAdminU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdminU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LabelAdminU.Location = New System.Drawing.Point(40, 172)
        Me.LabelAdminU.Name = "LabelAdminU"
        Me.LabelAdminU.Size = New System.Drawing.Size(159, 33)
        Me.LabelAdminU.TabIndex = 23
        Me.LabelAdminU.Text = "Username"
        Me.LabelAdminU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GPBAdmin
        '
        Me.GPBAdmin.Image = CType(resources.GetObject("GPBAdmin.Image"), System.Drawing.Image)
        Me.GPBAdmin.ImageRotate = 0!
        Me.GPBAdmin.Location = New System.Drawing.Point(51, 28)
        Me.GPBAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPBAdmin.Name = "GPBAdmin"
        Me.GPBAdmin.Size = New System.Drawing.Size(132, 122)
        Me.GPBAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GPBAdmin.TabIndex = 2
        Me.GPBAdmin.TabStop = False
        '
        'PanelText
        '
        Me.PanelText.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PanelText.Controls.Add(Me.GLTitle)
        Me.PanelText.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PanelText.Location = New System.Drawing.Point(273, 0)
        Me.PanelText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelText.Name = "PanelText"
        Me.PanelText.Size = New System.Drawing.Size(908, 78)
        Me.PanelText.TabIndex = 1
        '
        'GLTitle
        '
        Me.GLTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLTitle.AutoSize = True
        Me.GLTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLTitle.Location = New System.Drawing.Point(375, 28)
        Me.GLTitle.Name = "GLTitle"
        Me.GLTitle.Size = New System.Drawing.Size(113, 25)
        Me.GLTitle.TabIndex = 1
        Me.GLTitle.Text = "Title name"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(273, 78)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(908, 576)
        Me.PanelMain.TabIndex = 2
        '
        'MainAdim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1181, 654)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelText)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainAdim"
        Me.Text = "MainAdim"
        Me.PanelLeft.ResumeLayout(False)
        Me.GPanelRecordSub.ResumeLayout(False)
        Me.GPanelStockSub.ResumeLayout(False)
        Me.GPanelProductSub.ResumeLayout(False)
        Me.PanelAdmin.ResumeLayout(False)
        CType(Me.GPBAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelText.ResumeLayout(False)
        Me.PanelText.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelText As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelAdmin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GPanelProductSub As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnsubBrand As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnsubCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnSubPL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnLog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GPanelRecordSub As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnRPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnSaleHis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnRecord As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnSup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GPanelStockSub As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GBtnStocRe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnStockIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GPBAdmin As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAdminU As Label
    Friend WithEvents LabelAdAdd As Label
    Friend WithEvents GLTitle As Label
End Class
