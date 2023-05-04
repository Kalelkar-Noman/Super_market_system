<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Add
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
        Me.LinkSA = New System.Windows.Forms.LinkLabel()
        Me.GTextSApn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GDTPSA = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GTBSAQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTBSASupp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTBSApID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTBSASib = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GBtnSAAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnX1 = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnSASIB = New System.Windows.Forms.Label()
        Me.GBtnSAPID = New System.Windows.Forms.Label()
        Me.GBtnSAPN = New System.Windows.Forms.Label()
        Me.GBtnSASUP = New System.Windows.Forms.Label()
        Me.GBtnSADate = New System.Windows.Forms.Label()
        Me.GBtnSAQ = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkSA
        '
        Me.LinkSA.AutoSize = True
        Me.LinkSA.Location = New System.Drawing.Point(144, 174)
        Me.LinkSA.Name = "LinkSA"
        Me.LinkSA.Size = New System.Drawing.Size(127, 16)
        Me.LinkSA.TabIndex = 31
        Me.LinkSA.TabStop = True
        Me.LinkSA.Text = "[ Search Product Id ]"
        '
        'GTextSApn
        '
        Me.GTextSApn.BorderRadius = 13
        Me.GTextSApn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTextSApn.DefaultText = ""
        Me.GTextSApn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTextSApn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTextSApn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTextSApn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTextSApn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTextSApn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTextSApn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTextSApn.Location = New System.Drawing.Point(147, 210)
        Me.GTextSApn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTextSApn.Name = "GTextSApn"
        Me.GTextSApn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTextSApn.PlaceholderText = ""
        Me.GTextSApn.SelectedText = ""
        Me.GTextSApn.Size = New System.Drawing.Size(229, 44)
        Me.GTextSApn.TabIndex = 30
        '
        'GDTPSA
        '
        Me.GDTPSA.BorderRadius = 10
        Me.GDTPSA.Checked = True
        Me.GDTPSA.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GDTPSA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GDTPSA.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.GDTPSA.Location = New System.Drawing.Point(523, 112)
        Me.GDTPSA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GDTPSA.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GDTPSA.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GDTPSA.Name = "GDTPSA"
        Me.GDTPSA.Size = New System.Drawing.Size(200, 46)
        Me.GDTPSA.TabIndex = 28
        Me.GDTPSA.Value = New Date(2023, 4, 26, 20, 44, 51, 724)
        '
        'GTBSAQty
        '
        Me.GTBSAQty.BorderRadius = 13
        Me.GTBSAQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSAQty.DefaultText = ""
        Me.GTBSAQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSAQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSAQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSAQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSAQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSAQty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSAQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSAQty.Location = New System.Drawing.Point(523, 210)
        Me.GTBSAQty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTBSAQty.Name = "GTBSAQty"
        Me.GTBSAQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSAQty.PlaceholderText = ""
        Me.GTBSAQty.SelectedText = ""
        Me.GTBSAQty.Size = New System.Drawing.Size(92, 41)
        Me.GTBSAQty.TabIndex = 22
        '
        'GTBSASupp
        '
        Me.GTBSASupp.BorderRadius = 13
        Me.GTBSASupp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSASupp.DefaultText = ""
        Me.GTBSASupp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSASupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSASupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSASupp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSASupp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSASupp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSASupp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSASupp.Location = New System.Drawing.Point(521, 45)
        Me.GTBSASupp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTBSASupp.Name = "GTBSASupp"
        Me.GTBSASupp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSASupp.PlaceholderText = ""
        Me.GTBSASupp.SelectedText = ""
        Me.GTBSASupp.Size = New System.Drawing.Size(229, 42)
        Me.GTBSASupp.TabIndex = 21
        '
        'GTBSApID
        '
        Me.GTBSApID.BorderRadius = 13
        Me.GTBSApID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSApID.DefaultText = ""
        Me.GTBSApID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSApID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSApID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSApID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSApID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSApID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSApID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSApID.Location = New System.Drawing.Point(147, 114)
        Me.GTBSApID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTBSApID.Name = "GTBSApID"
        Me.GTBSApID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSApID.PlaceholderText = ""
        Me.GTBSApID.SelectedText = ""
        Me.GTBSApID.Size = New System.Drawing.Size(229, 44)
        Me.GTBSApID.TabIndex = 20
        '
        'GTBSASib
        '
        Me.GTBSASib.BorderRadius = 13
        Me.GTBSASib.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTBSASib.DefaultText = ""
        Me.GTBSASib.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTBSASib.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTBSASib.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSASib.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTBSASib.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSASib.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTBSASib.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBSASib.Location = New System.Drawing.Point(147, 43)
        Me.GTBSASib.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GTBSASib.Name = "GTBSASib"
        Me.GTBSASib.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTBSASib.PlaceholderText = ""
        Me.GTBSASib.SelectedText = ""
        Me.GTBSASib.Size = New System.Drawing.Size(229, 44)
        Me.GTBSASib.TabIndex = 19
        '
        'GBtnSAAdd
        '
        Me.GBtnSAAdd.Animated = True
        Me.GBtnSAAdd.BackColor = System.Drawing.Color.Transparent
        Me.GBtnSAAdd.BorderRadius = 17
        Me.GBtnSAAdd.BorderThickness = 2
        Me.GBtnSAAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSAAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnSAAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnSAAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnSAAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnSAAdd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnSAAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSAAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnSAAdd.Location = New System.Drawing.Point(606, 267)
        Me.GBtnSAAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnSAAdd.Name = "GBtnSAAdd"
        Me.GBtnSAAdd.ShadowDecoration.BorderRadius = 17
        Me.GBtnSAAdd.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnSAAdd.ShadowDecoration.Depth = 10
        Me.GBtnSAAdd.ShadowDecoration.Enabled = True
        Me.GBtnSAAdd.Size = New System.Drawing.Size(135, 50)
        Me.GBtnSAAdd.TabIndex = 32
        Me.GBtnSAAdd.Text = "Add Stock"
        '
        'GBtnX1
        '
        Me.GBtnX1.Animated = True
        Me.GBtnX1.BackColor = System.Drawing.Color.Transparent
        Me.GBtnX1.BorderColor = System.Drawing.Color.Silver
        Me.GBtnX1.BorderRadius = 8
        Me.GBtnX1.BorderThickness = 2
        Me.GBtnX1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnX1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnX1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnX1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnX1.FillColor = System.Drawing.Color.White
        Me.GBtnX1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBtnX1.ForeColor = System.Drawing.Color.White
        Me.GBtnX1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnX1.Image = Global.Sybca_BillingSystem.My.Resources.Resources.cl
        Me.GBtnX1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GBtnX1.Location = New System.Drawing.Point(723, 4)
        Me.GBtnX1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBtnX1.Name = "GBtnX1"
        Me.GBtnX1.ShadowDecoration.BorderRadius = 10
        Me.GBtnX1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBtnX1.ShadowDecoration.Depth = 20
        Me.GBtnX1.ShadowDecoration.Enabled = True
        Me.GBtnX1.Size = New System.Drawing.Size(47, 31)
        Me.GBtnX1.TabIndex = 33
        Me.GBtnX1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'GBtnSASIB
        '
        Me.GBtnSASIB.AutoSize = True
        Me.GBtnSASIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSASIB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSASIB.Location = New System.Drawing.Point(12, 58)
        Me.GBtnSASIB.Name = "GBtnSASIB"
        Me.GBtnSASIB.Size = New System.Drawing.Size(84, 16)
        Me.GBtnSASIB.TabIndex = 34
        Me.GBtnSASIB.Text = "Stock In By"
        '
        'GBtnSAPID
        '
        Me.GBtnSAPID.AutoSize = True
        Me.GBtnSAPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSAPID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSAPID.Location = New System.Drawing.Point(12, 129)
        Me.GBtnSAPID.Name = "GBtnSAPID"
        Me.GBtnSAPID.Size = New System.Drawing.Size(79, 16)
        Me.GBtnSAPID.TabIndex = 35
        Me.GBtnSAPID.Text = "Product ID"
        '
        'GBtnSAPN
        '
        Me.GBtnSAPN.AutoSize = True
        Me.GBtnSAPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSAPN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSAPN.Location = New System.Drawing.Point(12, 221)
        Me.GBtnSAPN.Name = "GBtnSAPN"
        Me.GBtnSAPN.Size = New System.Drawing.Size(105, 16)
        Me.GBtnSAPN.TabIndex = 36
        Me.GBtnSAPN.Text = "Product Name"
        '
        'GBtnSASUP
        '
        Me.GBtnSASUP.AutoSize = True
        Me.GBtnSASUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSASUP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSASUP.Location = New System.Drawing.Point(410, 58)
        Me.GBtnSASUP.Name = "GBtnSASUP"
        Me.GBtnSASUP.Size = New System.Drawing.Size(65, 16)
        Me.GBtnSASUP.TabIndex = 37
        Me.GBtnSASUP.Text = "Supplier"
        '
        'GBtnSADate
        '
        Me.GBtnSADate.AutoSize = True
        Me.GBtnSADate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSADate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSADate.Location = New System.Drawing.Point(410, 129)
        Me.GBtnSADate.Name = "GBtnSADate"
        Me.GBtnSADate.Size = New System.Drawing.Size(99, 16)
        Me.GBtnSADate.TabIndex = 38
        Me.GBtnSADate.Text = "Stock In Date"
        '
        'GBtnSAQ
        '
        Me.GBtnSAQ.AutoSize = True
        Me.GBtnSAQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GBtnSAQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnSAQ.Location = New System.Drawing.Point(413, 221)
        Me.GBtnSAQ.Name = "GBtnSAQ"
        Me.GBtnSAQ.Size = New System.Drawing.Size(54, 16)
        Me.GBtnSAQ.TabIndex = 39
        Me.GBtnSAQ.Text = "Quntity"
        '
        'Stock_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(772, 330)
        Me.Controls.Add(Me.GBtnSAQ)
        Me.Controls.Add(Me.GBtnSADate)
        Me.Controls.Add(Me.GBtnSASUP)
        Me.Controls.Add(Me.GBtnSAPN)
        Me.Controls.Add(Me.GBtnSAPID)
        Me.Controls.Add(Me.GBtnSASIB)
        Me.Controls.Add(Me.GBtnX1)
        Me.Controls.Add(Me.GBtnSAAdd)
        Me.Controls.Add(Me.LinkSA)
        Me.Controls.Add(Me.GTextSApn)
        Me.Controls.Add(Me.GDTPSA)
        Me.Controls.Add(Me.GTBSAQty)
        Me.Controls.Add(Me.GTBSASupp)
        Me.Controls.Add(Me.GTBSApID)
        Me.Controls.Add(Me.GTBSASib)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Stock_Add"
        Me.Text = "Stock_Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkSA As LinkLabel
    Friend WithEvents GTextSApn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GDTPSA As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GTBSAQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTBSASupp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTBSApID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTBSASib As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GBtnSAAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnX1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnSASIB As Label
    Friend WithEvents GBtnSAPID As Label
    Friend WithEvents GBtnSAPN As Label
    Friend WithEvents GBtnSASUP As Label
    Friend WithEvents GBtnSADate As Label
    Friend WithEvents GBtnSAQ As Label
End Class
