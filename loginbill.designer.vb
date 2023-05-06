<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginbill
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginbill))
        Me.Gprogress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Timerlogin = New System.Windows.Forms.Timer(Me.components)
        Me.LabelLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Gprogress
        '
        Me.Gprogress.AnimationSpeed = 1.0!
        Me.Gprogress.BackColor = System.Drawing.Color.Transparent
        Me.Gprogress.FillColor = System.Drawing.Color.Transparent
        Me.Gprogress.FillThickness = 12
        Me.Gprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gprogress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Gprogress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gprogress.InnerColor = System.Drawing.Color.Transparent
        Me.Gprogress.Location = New System.Drawing.Point(225, 114)
        Me.Gprogress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Gprogress.Minimum = 0
        Me.Gprogress.Name = "Gprogress"
        Me.Gprogress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Gprogress.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Gprogress.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Gprogress.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Gprogress.ProgressThickness = 12
        Me.Gprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Gprogress.ShowText = True
        Me.Gprogress.Size = New System.Drawing.Size(176, 176)
        Me.Gprogress.TabIndex = 0
        Me.Gprogress.Value = 80
        '
        'Timerlogin
        '
        Me.Timerlogin.Enabled = True
        '
        'LabelLoading
        '
        Me.LabelLoading.AutoSize = True
        Me.LabelLoading.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LabelLoading.Location = New System.Drawing.Point(238, 304)
        Me.LabelLoading.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLoading.Name = "LabelLoading"
        Me.LabelLoading.Size = New System.Drawing.Size(144, 31)
        Me.LabelLoading.TabIndex = 1
        Me.LabelLoading.Text = "Loading..."
        '
        'loginbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.LabelLoading)
        Me.Controls.Add(Me.Gprogress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "loginbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginbill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gprogress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timerlogin As Timer
    Friend WithEvents LabelLoading As Label
End Class
