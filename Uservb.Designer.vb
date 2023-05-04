<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uservb
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
        Me.TCUser = New System.Windows.Forms.TabControl()
        Me.TableUser = New System.Windows.Forms.TabPage()
        Me.GLabelCARole = New System.Windows.Forms.Label()
        Me.GLabelCARt = New System.Windows.Forms.Label()
        Me.GLabelPass = New System.Windows.Forms.Label()
        Me.GLabelCAAdd = New System.Windows.Forms.Label()
        Me.GLAbelCAUN = New System.Windows.Forms.Label()
        Me.GTbCAAdd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GBtnCAClear = New Guna.UI2.WinForms.Guna2Button()
        Me.GBtnCASave = New Guna.UI2.WinForms.Guna2Button()
        Me.GComboCA = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GTbCARpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTbCAPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GTbACUserN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TCUser.SuspendLayout()
        Me.TableUser.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TCUser
        '
        Me.TCUser.Controls.Add(Me.TableUser)
        Me.TCUser.Controls.Add(Me.TabPage2)
        Me.TCUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCUser.Location = New System.Drawing.Point(0, 0)
        Me.TCUser.Margin = New System.Windows.Forms.Padding(2)
        Me.TCUser.Name = "TCUser"
        Me.TCUser.SelectedIndex = 0
        Me.TCUser.Size = New System.Drawing.Size(785, 556)
        Me.TCUser.TabIndex = 0
        '
        'TableUser
        '
        Me.TableUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TableUser.Controls.Add(Me.GLabelCARole)
        Me.TableUser.Controls.Add(Me.GLabelCARt)
        Me.TableUser.Controls.Add(Me.GLabelPass)
        Me.TableUser.Controls.Add(Me.GLabelCAAdd)
        Me.TableUser.Controls.Add(Me.GLAbelCAUN)
        Me.TableUser.Controls.Add(Me.GTbCAAdd)
        Me.TableUser.Controls.Add(Me.GBtnCAClear)
        Me.TableUser.Controls.Add(Me.GBtnCASave)
        Me.TableUser.Controls.Add(Me.GComboCA)
        Me.TableUser.Controls.Add(Me.GTbCARpass)
        Me.TableUser.Controls.Add(Me.GTbCAPass)
        Me.TableUser.Controls.Add(Me.GTbACUserN)
        Me.TableUser.Location = New System.Drawing.Point(4, 22)
        Me.TableUser.Margin = New System.Windows.Forms.Padding(2)
        Me.TableUser.Name = "TableUser"
        Me.TableUser.Padding = New System.Windows.Forms.Padding(2)
        Me.TableUser.Size = New System.Drawing.Size(777, 530)
        Me.TableUser.TabIndex = 0
        Me.TableUser.Text = "Create Account"
        '
        'GLabelCARole
        '
        Me.GLabelCARole.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabelCARole.AutoSize = True
        Me.GLabelCARole.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelCARole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelCARole.Location = New System.Drawing.Point(226, 371)
        Me.GLabelCARole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GLabelCARole.Name = "GLabelCARole"
        Me.GLabelCARole.Size = New System.Drawing.Size(33, 13)
        Me.GLabelCARole.TabIndex = 37
        Me.GLabelCARole.Text = "Role"
        '
        'GLabelCARt
        '
        Me.GLabelCARt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabelCARt.AutoSize = True
        Me.GLabelCARt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelCARt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelCARt.Location = New System.Drawing.Point(226, 315)
        Me.GLabelCARt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GLabelCARt.Name = "GLabelCARt"
        Me.GLabelCARt.Size = New System.Drawing.Size(112, 13)
        Me.GLabelCARt.TabIndex = 36
        Me.GLabelCARt.Text = "Re_type Password"
        '
        'GLabelPass
        '
        Me.GLabelPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabelPass.AutoSize = True
        Me.GLabelPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelPass.Location = New System.Drawing.Point(226, 252)
        Me.GLabelPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GLabelPass.Name = "GLabelPass"
        Me.GLabelPass.Size = New System.Drawing.Size(61, 13)
        Me.GLabelPass.TabIndex = 35
        Me.GLabelPass.Text = "Password"
        '
        'GLabelCAAdd
        '
        Me.GLabelCAAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabelCAAdd.AutoSize = True
        Me.GLabelCAAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLabelCAAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLabelCAAdd.Location = New System.Drawing.Point(226, 182)
        Me.GLabelCAAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GLabelCAAdd.Name = "GLabelCAAdd"
        Me.GLabelCAAdd.Size = New System.Drawing.Size(52, 13)
        Me.GLabelCAAdd.TabIndex = 34
        Me.GLabelCAAdd.Text = "Address"
        '
        'GLAbelCAUN
        '
        Me.GLAbelCAUN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLAbelCAUN.AutoSize = True
        Me.GLAbelCAUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GLAbelCAUN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GLAbelCAUN.Location = New System.Drawing.Point(226, 115)
        Me.GLAbelCAUN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GLAbelCAUN.Name = "GLAbelCAUN"
        Me.GLAbelCAUN.Size = New System.Drawing.Size(63, 13)
        Me.GLAbelCAUN.TabIndex = 33
        Me.GLAbelCAUN.Text = "Username"
        '
        'GTbCAAdd
        '
        Me.GTbCAAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GTbCAAdd.BorderRadius = 13
        Me.GTbCAAdd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbCAAdd.DefaultText = ""
        Me.GTbCAAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbCAAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbCAAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbCAAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbCAAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbCAAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbCAAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbCAAdd.Location = New System.Drawing.Point(390, 168)
        Me.GTbCAAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTbCAAdd.Name = "GTbCAAdd"
        Me.GTbCAAdd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbCAAdd.PlaceholderText = ""
        Me.GTbCAAdd.SelectedText = ""
        Me.GTbCAAdd.Size = New System.Drawing.Size(172, 39)
        Me.GTbCAAdd.TabIndex = 32
        '
        'GBtnCAClear
        '
        Me.GBtnCAClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBtnCAClear.BackColor = System.Drawing.Color.Transparent
        Me.GBtnCAClear.BorderRadius = 17
        Me.GBtnCAClear.BorderThickness = 2
        Me.GBtnCAClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnCAClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnCAClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnCAClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnCAClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnCAClear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnCAClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnCAClear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.GBtnCAClear.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnCAClear.Location = New System.Drawing.Point(404, 423)
        Me.GBtnCAClear.Margin = New System.Windows.Forms.Padding(2)
        Me.GBtnCAClear.Name = "GBtnCAClear"
        Me.GBtnCAClear.ShadowDecoration.BorderRadius = 17
        Me.GBtnCAClear.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnCAClear.ShadowDecoration.Depth = 10
        Me.GBtnCAClear.ShadowDecoration.Enabled = True
        Me.GBtnCAClear.Size = New System.Drawing.Size(97, 48)
        Me.GBtnCAClear.TabIndex = 31
        Me.GBtnCAClear.Text = "Clear"
        '
        'GBtnCASave
        '
        Me.GBtnCASave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBtnCASave.BackColor = System.Drawing.Color.Transparent
        Me.GBtnCASave.BorderRadius = 17
        Me.GBtnCASave.BorderThickness = 2
        Me.GBtnCASave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GBtnCASave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GBtnCASave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GBtnCASave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GBtnCASave.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GBtnCASave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GBtnCASave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnCASave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GBtnCASave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.GBtnCASave.Location = New System.Drawing.Point(245, 423)
        Me.GBtnCASave.Margin = New System.Windows.Forms.Padding(2)
        Me.GBtnCASave.Name = "GBtnCASave"
        Me.GBtnCASave.ShadowDecoration.BorderRadius = 17
        Me.GBtnCASave.ShadowDecoration.Color = System.Drawing.Color.White
        Me.GBtnCASave.ShadowDecoration.Depth = 10
        Me.GBtnCASave.ShadowDecoration.Enabled = True
        Me.GBtnCASave.Size = New System.Drawing.Size(97, 48)
        Me.GBtnCASave.TabIndex = 30
        Me.GBtnCASave.Text = "Save"
        '
        'GComboCA
        '
        Me.GComboCA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GComboCA.BackColor = System.Drawing.Color.Transparent
        Me.GComboCA.BorderRadius = 13
        Me.GComboCA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GComboCA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GComboCA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GComboCA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GComboCA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GComboCA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GComboCA.ItemHeight = 30
        Me.GComboCA.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.GComboCA.Location = New System.Drawing.Point(390, 363)
        Me.GComboCA.Margin = New System.Windows.Forms.Padding(2)
        Me.GComboCA.Name = "GComboCA"
        Me.GComboCA.Size = New System.Drawing.Size(106, 36)
        Me.GComboCA.TabIndex = 29
        '
        'GTbCARpass
        '
        Me.GTbCARpass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GTbCARpass.BorderRadius = 13
        Me.GTbCARpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbCARpass.DefaultText = ""
        Me.GTbCARpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbCARpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbCARpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbCARpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbCARpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbCARpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbCARpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbCARpass.Location = New System.Drawing.Point(390, 299)
        Me.GTbCARpass.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTbCARpass.Name = "GTbCARpass"
        Me.GTbCARpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbCARpass.PlaceholderText = ""
        Me.GTbCARpass.SelectedText = ""
        Me.GTbCARpass.Size = New System.Drawing.Size(172, 39)
        Me.GTbCARpass.TabIndex = 28
        '
        'GTbCAPass
        '
        Me.GTbCAPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GTbCAPass.BorderRadius = 13
        Me.GTbCAPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbCAPass.DefaultText = ""
        Me.GTbCAPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbCAPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbCAPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbCAPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbCAPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbCAPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbCAPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbCAPass.Location = New System.Drawing.Point(390, 236)
        Me.GTbCAPass.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTbCAPass.Name = "GTbCAPass"
        Me.GTbCAPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbCAPass.PlaceholderText = ""
        Me.GTbCAPass.SelectedText = ""
        Me.GTbCAPass.Size = New System.Drawing.Size(172, 39)
        Me.GTbCAPass.TabIndex = 27
        '
        'GTbACUserN
        '
        Me.GTbACUserN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GTbACUserN.BorderRadius = 13
        Me.GTbACUserN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GTbACUserN.DefaultText = ""
        Me.GTbACUserN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GTbACUserN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GTbACUserN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbACUserN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GTbACUserN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbACUserN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GTbACUserN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTbACUserN.Location = New System.Drawing.Point(390, 99)
        Me.GTbACUserN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTbACUserN.Name = "GTbACUserN"
        Me.GTbACUserN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GTbACUserN.PlaceholderText = ""
        Me.GTbACUserN.SelectedText = ""
        Me.GTbACUserN.Size = New System.Drawing.Size(172, 39)
        Me.GTbACUserN.TabIndex = 25
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Guna2DataGridView1)
        Me.TabPage2.Controls.Add(Me.Guna2Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(777, 530)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Active/InActive Account"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.Guna2DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(773, 445)
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
        Me.Column2.DataPropertyName = "username"
        Me.Column2.HeaderText = "Username"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "address"
        Me.Column3.HeaderText = "Address"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "status"
        Me.Column4.HeaderText = "Account Activity"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "role"
        Me.Column5.HeaderText = "Role"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(2, 447)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(773, 81)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 17
        Me.Guna2Button3.BorderThickness = 2
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(370, 18)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.BorderRadius = 17
        Me.Guna2Button3.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button3.ShadowDecoration.Depth = 10
        Me.Guna2Button3.ShadowDecoration.Enabled = True
        Me.Guna2Button3.Size = New System.Drawing.Size(106, 43)
        Me.Guna2Button3.TabIndex = 2
        Me.Guna2Button3.Text = "Reset password"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 17
        Me.Guna2Button2.BorderThickness = 2
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Location = New System.Drawing.Point(501, 18)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.BorderRadius = 17
        Me.Guna2Button2.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button2.ShadowDecoration.Depth = 10
        Me.Guna2Button2.ShadowDecoration.Enabled = True
        Me.Guna2Button2.Size = New System.Drawing.Size(106, 43)
        Me.Guna2Button2.TabIndex = 1
        Me.Guna2Button2.Text = "Remove"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 17
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(235, 18)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 17
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button1.ShadowDecoration.Depth = 10
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.Size = New System.Drawing.Size(106, 43)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Upadte"
        '
        'Uservb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(785, 556)
        Me.Controls.Add(Me.TCUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Uservb"
        Me.Text = "Uservb"
        Me.TCUser.ResumeLayout(False)
        Me.TableUser.ResumeLayout(False)
        Me.TableUser.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCUser As TabControl
    Friend WithEvents TableUser As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GTbACUserN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GComboCA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GTbCARpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTbCAPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GBtnCAClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBtnCASave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GTbCAAdd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GLabelCARole As Label
    Friend WithEvents GLabelCARt As Label
    Friend WithEvents GLabelPass As Label
    Friend WithEvents GLabelCAAdd As Label
    Friend WithEvents GLAbelCAUN As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
