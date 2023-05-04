Imports System.Data.SqlClient

Public Class Stock_Record
    Private Sub GBtnSR_Click(sender As Object, e As EventArgs) Handles GBtnSR.Click
        DBCon.Open()
        query = "select pid,product_name,quantity,date from products where date between '" & GDTPSRD1.Value & "' and '" & GDTPSrD2.Value & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        Guna2DataGridView1.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub GLabelRecordTo_Click(sender As Object, e As EventArgs) Handles GLabelRecordTo.Click

    End Sub

    Private Sub GLabelRecordF_Click(sender As Object, e As EventArgs) Handles GLabelRecordF.Click

    End Sub
End Class