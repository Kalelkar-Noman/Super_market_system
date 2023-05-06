<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sign_in_bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sign_in_bill))
        Me.GGPanelPass = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GBTnSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.GTbPassBill = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Labelpassbill = New System.Windows.Forms.Label()
        Me.GTbUserNbill = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Labeluserbill = New System.Windows.Forms.Label()
        Me.GGPanelPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'GGPanelPass
        '
        Me.GGPanelPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GGPanelPass.BackColor = System.Drawing.Color.Transparent
        Me.GGPanelPass.BorderRadius = 30
        Me.GGPanelPass.Controls.Add(Me.GBTnSignIn)
        Me.GGPanelPass.Controls.Add(Me.GBtnShow)
        Me.GGPanelPass.Controls.Add(Me.GTbPassBill)
        Me.GGPanelPass.Controls.Add(Me.Labelpassbill)
        Me.GGPanelPass.Controls.Add(Me.GTbUserNbill)
        Me.GGPanelPass.Controls.Add(Me.Labeluserbill)
        Me.GGPanelPass.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GGPanelPass.FillColor2 = System.Drawing.Color.Transparent
        Me.GGPanelPass.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GGPanelPass.Location = New System.Drawing.Point(106, 54)
        Me.GGPanelPass.Margin = New System.Windows.Forms.Padding(2)
        Me.GGPanelPass.Name = "GGPanelPass"
        Me.GGPanelPass.Size = New System.Drawing.Size(473, 318)
        Me.GGPanelPass.TabIndex = 0
        '
        'GBTnSignIn
        '
        Me.GBTnSignIn.Animated = True
        Me.GBTnSignIn.BackColor = System.Drawing.Color.Transparent
        Me.GBTnSignIn.BorderRadius = 13
        Me.GBTnSignIn.BorderThickness = 2
        Me.GBTnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBTnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBTnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBTnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBTnSignIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBTnSignIn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTnSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBTnSignIn.HoverState.FillColor = System.Drawing.Color.White
        Me.GBTnSignIn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBTnSignIn.Location = New System.Drawing.Point(166, 236)
        Me.GBTnSignIn.Margin = New System.Windows.Forms.Padding(2)
        Me.GBTnSignIn.Name = "GBTnSignIn"
        Me.GBTnSignIn.ShadowDecoration.BorderRadius = 13
        Me.GBTnSignIn.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBTnSignIn.ShadowDecoration.Depth = 20
        Me.GBTnSignIn.ShadowDecoration.Enabled = True
        Me.GBTnSignIn.Size = New System.Drawing.Size(133, 39)
        Me.GBTnSignIn.TabIndex = 8
        Me.GBTnSignIn.Text = "Sign In"
        '
        'GBtnShow
        '
        Me.GBtnShow.Animated = True
        Me.GBtnShow.BackColor = System.Drawing.Color.Transparent
        Me.GBtnShow.BorderRadius = 7
        Me.GBtnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnShow.FillColor = System.Drawing.Color.White
        Me.GBtnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBtnShow.ForeColor = System.Drawing.Color.White
        Me.GBtnShow.Image = Global.Sybca_BillingSystem.My.Resources.Resources.close
        Me.GBtnShow.Location = New System.Drawing.Point(364, 169)
        Me.GBtnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.GBtnShow.Name = "GBtnShow"
        Me.GBtnShow.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnShow.ShadowDecoration.Depth = 10
        Me.GBtnShow.ShadowDecoration.Enabled = True
        Me.GBtnShow.Size = New System.Drawing.Size(32, 36)
        Me.GBtnShow.TabIndex = 7
        '
        'GTbPassBill
        '
        Me.GTbPassBill.Animated = True
        Me.GTbPassBill.BackColor = System.Drawing.Color.Transparent
        Me.GTbPassBill.BorderColor = System.Drawing.Color.Black
        Me.GTbPassBill.BorderRadius = 15
        Me.GTbPassBill.BorderThickness = 2
        Me.GTbPassBill.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbPassBill.DefaultText = ""
        Me.GTbPassBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbPassBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbPassBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPassBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbPassBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPassBill.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTbPassBill.ForeColor = System.Drawing.Color.Black
        Me.GTbPassBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbPassBill.IconLeft = Global.Sybca_BillingSystem.My.Resources.Resources.key
        Me.GTbPassBill.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.GTbPassBill.Location = New System.Drawing.Point(204, 167)
        Me.GTbPassBill.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTbPassBill.Name = "GTbPassBill"
        Me.GTbPassBill.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbPassBill.PlaceholderText = ""
        Me.GTbPassBill.SelectedText = ""
        Me.GTbPassBill.ShadowDecoration.BorderRadius = 15
        Me.GTbPassBill.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GTbPassBill.ShadowDecoration.Depth = 20
        Me.GTbPassBill.ShadowDecoration.Enabled = True
        Me.GTbPassBill.Size = New System.Drawing.Size(157, 39)
        Me.GTbPassBill.TabIndex = 6
        '
        'Labelpassbill
        '
        Me.Labelpassbill.AutoSize = True
        Me.Labelpassbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpassbill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Labelpassbill.Location = New System.Drawing.Point(86, 176)
        Me.Labelpassbill.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelpassbill.Name = "Labelpassbill"
        Me.Labelpassbill.Size = New System.Drawing.Size(86, 20)
        Me.Labelpassbill.TabIndex = 4
        Me.Labelpassbill.Text = "Password"
        '
        'GTbUserNbill
        '
        Me.GTbUserNbill.Animated = True
        Me.GTbUserNbill.BackColor = System.Drawing.Color.Transparent
        Me.GTbUserNbill.BorderColor = System.Drawing.Color.Black
        Me.GTbUserNbill.BorderRadius = 15
        Me.GTbUserNbill.BorderThickness = 2
        Me.GTbUserNbill.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbUserNbill.DefaultText = ""
        Me.GTbUserNbill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbUserNbill.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbUserNbill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbUserNbill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbUserNbill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbUserNbill.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTbUserNbill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GTbUserNbill.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbUserNbill.IconLeft = Global.Sybca_BillingSystem.My.Resources.Resources.userpass
        Me.GTbUserNbill.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.GTbUserNbill.Location = New System.Drawing.Point(204, 71)
        Me.GTbUserNbill.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTbUserNbill.Name = "GTbUserNbill"
        Me.GTbUserNbill.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbUserNbill.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GTbUserNbill.PlaceholderText = "username"
        Me.GTbUserNbill.SelectedText = ""
        Me.GTbUserNbill.ShadowDecoration.BorderRadius = 15
        Me.GTbUserNbill.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GTbUserNbill.ShadowDecoration.Depth = 15
        Me.GTbUserNbill.ShadowDecoration.Enabled = True
        Me.GTbUserNbill.Size = New System.Drawing.Size(192, 39)
        Me.GTbUserNbill.TabIndex = 3
        '
        'Labeluserbill
        '
        Me.Labeluserbill.AutoSize = True
        Me.Labeluserbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeluserbill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Labeluserbill.Location = New System.Drawing.Point(86, 78)
        Me.Labeluserbill.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labeluserbill.Name = "Labeluserbill"
        Me.Labeluserbill.Size = New System.Drawing.Size(91, 20)
        Me.Labeluserbill.TabIndex = 1
        Me.Labeluserbill.Text = "Username"
        '
        'sign_in_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(662, 413)
        Me.Controls.Add(Me.GGPanelPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "sign_in_bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sign_in_bill"
        Me.GGPanelPass.ResumeLayout(False)
        Me.GGPanelPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GGPanelPass As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Labeluserbill As Label
    Friend WithEvents Labelpassbill As Label
    Friend WithEvents GTbUserNbill As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTbPassBill As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GBtnShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBTnSignIn As Guna.UI2.WinForms.Guna2Button
End Class
