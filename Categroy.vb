Imports System.Data.SqlClient

Public Class Categroy
    Private Sub GDataGridVCat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridVCat.CellContentClick

    End Sub
    Sub listproduct()
        DBCon.Open()
        query = "select CATEGORY,count(PRODUCT_NAME) as PCOUNT from PRODUCTS group by CATEGORY"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        GDataGridVCat.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub Categroy_Load(sender As Object, e As EventArgs) Handles Me.Load
        listproduct()
    End Sub

    Private Sub GBtnPLaddfresh_Click(sender As Object, e As EventArgs) Handles GBtnPLaddfresh.Click
        listproduct()
    End Sub
End Class