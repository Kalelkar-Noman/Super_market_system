<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Add))
        Me.GTbPAID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GLablePAPId = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GLabelPABr = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GLablePAPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GLablePAPN = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GLablePACat = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GTbPAPN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTbPABrand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTbPACat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTbPAPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GBtnPASave = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnPACle = New Guna.UI2.WinForms.Guna2Button()
        Me.GLablePADis = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GTbPADis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'GTbPAID
        '
        Me.GTbPAID.BorderRadius = 10
        Me.GTbPAID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPAID.DefaultText = ""
        Me.GTbPAID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPAID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPAID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPAID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPAID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPAID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbPAID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPAID.Location = New System.Drawing.Point(148, 80)
        Me.GTbPAID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTbPAID.Name = "GTbPAID"
        Me.GTbPAID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPAID.PlaceholderText = ""
        Me.GTbPAID.SelectedText = ""
        Me.GTbPAID.Size = New System.Drawing.Size(229, 48)
        Me.GTbPAID.TabIndex = 40
        '
        'GLablePAPId
        '
        Me.GLablePAPId.AutoSize = False
        Me.GLablePAPId.BackColor = System.Drawing.Color.Transparent
        Me.GLablePAPId.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLablePAPId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLablePAPId.Location = New System.Drawing.Point(39, 34)
        Me.GLablePAPId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GLablePAPId.Name = "GLablePAPId"
        Me.GLablePAPId.Size = New System.Drawing.Size(115, 36)
        Me.GLablePAPId.TabIndex = 41
        Me.GLablePAPId.Text = "Product ID"
        Me.GLablePAPId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GLabelPABr
        '
        Me.GLabelPABr.AutoSize = False
        Me.GLabelPABr.BackColor = System.Drawing.Color.Transparent
        Me.GLabelPABr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabelPABr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelPABr.Location = New System.Drawing.Point(39, 145)
        Me.GLabelPABr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GLabelPABr.Name = "GLabelPABr"
        Me.GLabelPABr.Size = New System.Drawing.Size(115, 36)
        Me.GLabelPABr.TabIndex = 42
        Me.GLabelPABr.Text = "Brand"
        Me.GLabelPABr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GLablePAPrice
        '
        Me.GLablePAPrice.AutoSize = False
        Me.GLablePAPrice.BackColor = System.Drawing.Color.Transparent
        Me.GLablePAPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLablePAPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLablePAPrice.Location = New System.Drawing.Point(39, 257)
        Me.GLablePAPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GLablePAPrice.Name = "GLablePAPrice"
        Me.GLablePAPrice.Size = New System.Drawing.Size(115, 36)
        Me.GLablePAPrice.TabIndex = 43
        Me.GLablePAPrice.Text = "Price"
        Me.GLablePAPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GLablePAPN
        '
        Me.GLablePAPN.AutoSize = False
        Me.GLablePAPN.BackColor = System.Drawing.Color.Transparent
        Me.GLablePAPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLablePAPN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLablePAPN.Location = New System.Drawing.Point(406, 34)
        Me.GLablePAPN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GLablePAPN.Name = "GLablePAPN"
        Me.GLablePAPN.Size = New System.Drawing.Size(115, 36)
        Me.GLablePAPN.TabIndex = 44
        Me.GLablePAPN.Text = "Product Name"
        Me.GLablePAPN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GLablePACat
        '
        Me.GLablePACat.AutoSize = False
        Me.GLablePACat.BackColor = System.Drawing.Color.Transparent
        Me.GLablePACat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLablePACat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLablePACat.Location = New System.Drawing.Point(406, 145)
        Me.GLablePACat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GLablePACat.Name = "GLablePACat"
        Me.GLablePACat.Size = New System.Drawing.Size(115, 36)
        Me.GLablePACat.TabIndex = 45
        Me.GLablePACat.Text = "Categroy"
        Me.GLablePACat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GTbPAPN
        '
        Me.GTbPAPN.BorderRadius = 10
        Me.GTbPAPN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPAPN.DefaultText = ""
        Me.GTbPAPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPAPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPAPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPAPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPAPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPAPN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbPAPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPAPN.Location = New System.Drawing.Point(513, 80)
        Me.GTbPAPN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTbPAPN.Name = "GTbPAPN"
        Me.GTbPAPN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPAPN.PlaceholderText = ""
        Me.GTbPAPN.SelectedText = ""
        Me.GTbPAPN.Size = New System.Drawing.Size(229, 48)
        Me.GTbPAPN.TabIndex = 46
        '
        'GTbPABrand
        '
        Me.GTbPABrand.BorderRadius = 10
        Me.GTbPABrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPABrand.DefaultText = ""
        Me.GTbPABrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPABrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPABrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPABrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPABrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPABrand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbPABrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPABrand.Location = New System.Drawing.Point(147, 187)
        Me.GTbPABrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTbPABrand.Name = "GTbPABrand"
        Me.GTbPABrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPABrand.PlaceholderText = ""
        Me.GTbPABrand.SelectedText = ""
        Me.GTbPABrand.Size = New System.Drawing.Size(229, 48)
        Me.GTbPABrand.TabIndex = 47
        '
        'GTbPACat
        '
        Me.GTbPACat.BorderRadius = 10
        Me.GTbPACat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPACat.DefaultText = ""
        Me.GTbPACat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPACat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPACat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPACat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPACat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPACat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbPACat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPACat.Location = New System.Drawing.Point(513, 187)
        Me.GTbPACat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTbPACat.Name = "GTbPACat"
        Me.GTbPACat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPACat.PlaceholderText = ""
        Me.GTbPACat.SelectedText = ""
        Me.GTbPACat.Size = New System.Drawing.Size(229, 48)
        Me.GTbPACat.TabIndex = 48
        '
        'GTbPAPrice
        '
        Me.GTbPAPrice.BorderRadius = 10
        Me.GTbPAPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPAPrice.DefaultText = ""
        Me.GTbPAPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPAPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPAPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPAPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPAPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPAPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbPAPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPAPrice.Location = New System.Drawing.Point(148, 299)
        Me.GTbPAPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTbPAPrice.Name = "GTbPAPrice"
        Me.GTbPAPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPAPrice.PlaceholderText = ""
        Me.GTbPAPrice.SelectedText = ""
        Me.GTbPAPrice.Size = New System.Drawing.Size(229, 48)
        Me.GTbPAPrice.TabIndex = 49
        '
        'GBtnPASave
        '
        Me.GBtnPASave.Animated = True
        Me.GBtnPASave.BackColor = System.Drawing.Color.Transparent
        Me.GBtnPASave.BorderRadius = 17
        Me.GBtnPASave.BorderThickness = 2
        Me.GBtnPASave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPASave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPASave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnPASave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnPASave.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnPASave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnPASave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnPASave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnPASave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnPASave.Location = New System.Drawing.Point(445, 367)
        Me.GBtnPASave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnPASave.Name = "GBtnPASave"
        Me.GBtnPASave.ShadowDecoration.BorderRadius = 17
        Me.GBtnPASave.ShadowDecoration.Depth = 20
        Me.GBtnPASave.ShadowDecoration.Enabled = True
        Me.GBtnPASave.Size = New System.Drawing.Size(148, 53)
        Me.GBtnPASave.TabIndex = 50
        Me.GBtnPASave.Text = "Save"
        '
        'GBtnPACle
        '
        Me.GBtnPACle.Animated = True
        Me.GBtnPACle.BackColor = System.Drawing.Color.Transparent
        Me.GBtnPACle.BorderRadius = 17
        Me.GBtnPACle.BorderThickness = 2
        Me.GBtnPACle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPACle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnPACle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnPACle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnPACle.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnPACle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnPACle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnPACle.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnPACle.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnPACle.Location = New System.Drawing.Point(629, 367)
        Me.GBtnPACle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnPACle.Name = "GBtnPACle"
        Me.GBtnPACle.ShadowDecoration.BorderRadius = 17
        Me.GBtnPACle.ShadowDecoration.Depth = 20
        Me.GBtnPACle.ShadowDecoration.Enabled = True
        Me.GBtnPACle.Size = New System.Drawing.Size(148, 53)
        Me.GBtnPACle.TabIndex = 51
        Me.GBtnPACle.Text = "Clear"
        '
        'GLablePADis
        '
        Me.GLablePADis.AutoSize = False
        Me.GLablePADis.BackColor = System.Drawing.Color.Transparent
        Me.GLablePADis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLablePADis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLablePADis.Location = New System.Drawing.Point(406, 257)
        Me.GLablePADis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GLablePADis.Name = "GLablePADis"
        Me.GLablePADis.Size = New System.Drawing.Size(158, 36)
        Me.GLablePADis.TabIndex = 52
        Me.GLablePADis.Text = "Discount"
        Me.GLablePADis.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GTbPADis
        '
        Me.GTbPADis.BorderRadius = 10
        Me.GTbPADis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPADis.DefaultText = ""
        Me.GTbPADis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPADis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPADis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPADis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPADis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPADis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbPADis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPADis.Location = New System.Drawing.Point(513, 299)
        Me.GTbPADis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTbPADis.Name = "GTbPADis"
        Me.GTbPADis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPADis.PlaceholderText = ""
        Me.GTbPADis.SelectedText = ""
        Me.GTbPADis.Size = New System.Drawing.Size(229, 48)
        Me.GTbPADis.TabIndex = 53
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button1.Location = New System.Drawing.Point(744, 6)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 10
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.Depth = 20
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.Size = New System.Drawing.Size(49, 36)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Product_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 435)
        Me.Controls.Add(Me.GTbPADis)
        Me.Controls.Add(Me.GLablePADis)
        Me.Controls.Add(Me.GBtnPACle)
        Me.Controls.Add(Me.GBtnPASave)
        Me.Controls.Add(Me.GTbPAPrice)
        Me.Controls.Add(Me.GTbPACat)
        Me.Controls.Add(Me.GTbPABrand)
        Me.Controls.Add(Me.GTbPAPN)
        Me.Controls.Add(Me.GLablePACat)
        Me.Controls.Add(Me.GLablePAPN)
        Me.Controls.Add(Me.GLablePAPrice)
        Me.Controls.Add(Me.GLabelPABr)
        Me.Controls.Add(Me.GLablePAPId)
        Me.Controls.Add(Me.GTbPAID)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Product_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Add"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GTbPAID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GLablePAPId As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GLabelPABr As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GLablePAPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GLablePAPN As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GLablePACat As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GTbPAPN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTbPABrand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTbPACat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTbPAPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GBtnPASave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnPACle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GLablePADis As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GTbPADis As Guna.UI2.WinForms.Guna2TextBox
End Class
