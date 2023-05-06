Imports System.Data.SqlClient

Public Class Record_POS
    Private Sub GPanelTopS_Paint(sender As Object, e As PaintEventArgs) Handles GPanelTopS.Paint

    End Sub

    Private Sub GBtnTS1_Click(sender As Object, e As EventArgs) Handles GBtnTS1.Click
        Try
            DBCon.Open()
            query = "select productid,productname,amount,quantity from sellhistory where date between '" & GDTPTSD1.Value & "' and '" & GDTPTSD2.Value & "' order by amount desc"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            GDataGridVTS.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            DBCon.Close()
        End Try
    End Sub

    Private Sub GBtnSILoad_Click(sender As Object, e As EventArgs) Handles GBtnSILoad.Click
        Try
            DBCon.Open()
            query = "select productid,productname,quantity,amount,date,cashier from sellhistory where date between '" & GDTPSID1.Value & "' and '" & GDTPSiD2.Value & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            GDataGridVSI.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            DBCon.Close()
        End Try
    End Sub
End Class