Imports System.Data.SqlClient
Module SMPModule
    Public DBCon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MY_FILES\REPOS\Sybca_BillingSystem\DATABASE\SMDB.mdf;Integrated Security=True;Connect Timeout=30")
    Public query As String
    Public sltcell As Integer = -2
    Public ssltcell As String = ""
    Public usrcell As String = ""

    Public listap As Integer
    Public slistap As Integer
    Public usrtap As Integer

    Public Sub panelview(ByRef pan_v As Object)
        pan_v.TopLevel = False
        pan_v.WindowState = FormWindowState.Maximized
        pan_v.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        pan_v.Dock = DockStyle.Fill
        pan_v.WindowState = FormWindowState.Normal
        pan_v.Visible = True
        MainAdim.PanelMain.Controls.Add(pan_v)
        MainAdim.GLTitle.Text = pan_v.GetType().Name
    End Sub
    Sub listmod(ByVal a As Integer)
        listap = a
    End Sub
    Sub slistmod(ByVal a As Integer)
        slistap = a
    End Sub
End Module
