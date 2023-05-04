<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PBloading1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lblreportprogress = New System.Windows.Forms.Label()
        Me.Lblstatustext = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(454, 188)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PBloading1
        '
        Me.PBloading1.BackColor = System.Drawing.SystemColors.Menu
        Me.PBloading1.Location = New System.Drawing.Point(26, 380)
        Me.PBloading1.Maximum = 120
        Me.PBloading1.Name = "PBloading1"
        Me.PBloading1.Size = New System.Drawing.Size(746, 23)
        Me.PBloading1.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Lblreportprogress
        '
        Me.Lblreportprogress.BackColor = System.Drawing.Color.Transparent
        Me.Lblreportprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblreportprogress.Location = New System.Drawing.Point(772, 384)
        Me.Lblreportprogress.Name = "Lblreportprogress"
        Me.Lblreportprogress.Size = New System.Drawing.Size(32, 18)
        Me.Lblreportprogress.TabIndex = 10
        Me.Lblreportprogress.Text = "0%"
        '
        'Lblstatustext
        '
        Me.Lblstatustext.AutoSize = True
        Me.Lblstatustext.BackColor = System.Drawing.Color.Transparent
        Me.Lblstatustext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstatustext.Location = New System.Drawing.Point(26, 406)
        Me.Lblstatustext.Name = "Lblstatustext"
        Me.Lblstatustext.Size = New System.Drawing.Size(170, 13)
        Me.Lblstatustext.TabIndex = 11
        Me.Lblstatustext.Text = "Launching the application...."
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblstatustext)
        Me.Controls.Add(Me.Lblreportprogress)
        Me.Controls.Add(Me.PBloading1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "LOGIN"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PBloading1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lblreportprogress As Label
    Friend WithEvents Lblstatustext As Label
End Class
