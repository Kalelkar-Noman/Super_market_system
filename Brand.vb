Imports System.Data.SqlClient
Public Class Brand
    Sub listproduct()
        DBCon.Open()
        query = "select BRAND ,count(CATEGORY) as PCOUNT from PRODUCTS group by BRAND"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        GDataGridVBrand.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub Brand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listproduct()
    End Sub
    Private Sub GBtnPLaddrefresh_Click(sender As Object, e As EventArgs) Handles GBtnPLaddrefresh.Click
        listproduct()
    End Sub
    Private Sub GDataGridVBrand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridVBrand.CellContentClick
    End Sub
End Class