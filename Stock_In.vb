Imports System.Data.SqlClient

Public Class Stock_In
    Dim ap As Boolean = False
    Dim ppid As Integer = 0
    Sub productlist()
        Try
            DBCon.Open()
            query = "select PRODUCTS.PID,PRODUCTS.PRODUCT_NAME,PRODUCTS.QUANTITY,PRODUCTS.DATE,SUPPLIER.STOCKINBY,SUPPLIER.SPNAME from PRODUCTS,SUPPLIER WHERE PID=' " & GTBSEpID.Text & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If (dr.Read()) Then
                ppid = dr("pid")
            End If
            Dim dt As New DataTable
            dt.Load(dr)
            GDataGridStockEn.DataSource = dt
            DBCon.Close()
        Catch ex As Exception
        Finally

            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
    End Sub

    Private Sub LinkSe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSe.LinkClicked
        ap = True
        productlist()
    End Sub

    Private Sub GBtnSEAdd_Click(sender As Object, e As EventArgs) Handles GBtnSEAdd.Click
        Try
            DBCon.Open()
            query = "update products set quantity+=' " & GTBSEQty.Text & " ',DATE='" & GDTPSE.Value & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            ' Dim d1 As DateTime = GDTPSE.Value
            cmd.ExecuteNonQuery()
            query = "update supplier set PPID='" & ppid & "', stockinby='" & UCase(GTBSeSib.Text) & "', spname='" & UCase(GTBSESupp.Text) & "'"
            Dim cmd2 As New SqlCommand(query, DBCon)
            cmd2.ExecuteNonQuery()
            MsgBox("data updated succesfully")
            'clears()
            DBCon.Close()
            productlist()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
    End Sub
    Private Sub GDataGridStockLis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridStockLis.CellContentClick
    End Sub
    Private Sub GDataGridStockEn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridStockEn.CellContentClick
    End Sub
    Sub listproduct()
        DBCon.Open()
        query = "select pid ,product_name,price,quantity from PRODUCTS"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        GDataGridStockLis.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Stock_In_Load(sender As Object, e As EventArgs) Handles Me.Load
        listproduct()
    End Sub

    Private Sub GBtnSLAdd_Click(sender As Object, e As EventArgs) Handles GBtnSLAdd.Click
        listproduct()
    End Sub
End Class