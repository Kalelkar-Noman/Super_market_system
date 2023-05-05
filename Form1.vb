Imports System.Data.SqlClient

Public Class Form1
    Dim pdn As String = ""
    Dim pid As Integer = 0
    Dim amt As Integer = 0
    Dim dist As Integer = 0
    Dim qty As Integer = 0
    Dim sltcell1 As Integer = -2
    Dim sltcell2 As Integer = -2
    Dim sltcell3 As Integer = -2
    Dim slt As Boolean = False
    Private Sub PictureBQr_Click(sender As Object, e As EventArgs) Handles PictureBQr.Click


    End Sub

    Private Sub GTbEBEQty_TextChanged(sender As Object, e As EventArgs) Handles GTbEBEQty.TextChanged
        If GTbEBEQty.Text = "0" Or GTbEBEQty.Text = "1" Then
            GTbEBETM.Text = GTbEBEAmt.Text
        Else
            If GTbEBEQty.Text > "1" Then
                GTbEBETM.Text = amt * Val(GTbEBEQty.Text)
            End If

        End If
    End Sub
    Sub listproduct()
        Try
            DBCon.Open()
            query = "select * from sellhistory where billno='" & GTbEBEBN.Text & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            Guna2DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBCon.Close()
        End Try


    End Sub
    Private Sub GBtnEAdd_Click(sender As Object, e As EventArgs) Handles GBtnEAdd.Click
        DBCon.Open()
        query = "select * from PRODUCTS where PID='" & GTbEBEPID.Text & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            qty = dr("quantity")
        End If
        DBCon.Close()

        Try
            If GTbEBEQty.Text > qty Then
                MsgBox("quantity is greater")
            Else
                DBCon.Open()
                query = "insert into sellhistory values('" & GTbEBEBN.Text & "','" & GTbEBEMN.Text & "','" & pid & "','" & GTbEBEPN.Text & "','" & GTbEBEQty.Text & "','" & GTbEBECA.Text & "','" & GTbEBETM.Text & "','" & dist & "')"

                cmd.ExecuteNonQuery()
                query = "update products set quantity=quantity - '" & GTbEBEQty.Text & "' where pid='" & pid & "'"
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        listproduct()
    End Sub

    Private Sub GBtnECDSearch_Click(sender As Object, e As EventArgs) Handles GBtnECDSearch.Click
        DBCon.Open()
        query = "select billno,custname from sellhistory where billno='" & GTbECDBill.Text & "' "
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVCD.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DBCon.Open()
        query = "select billno,custname from sellhistory where billno='" & GTbECDCN.Text & "' "
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVCD.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GBtnEClear_Click(sender As Object, e As EventArgs) Handles GBtnEClear.Click
        Try
            DBCon.Open()
            query = "select * from PRODUCTS where PID='" & GTbEBEPID.Text & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                pdn = dr("PRODUCT_NAME")
                pid = dr("pid")
                dist = dr("discount")
                amt = dr("price")
                qty = dr("quantity")
            Else
                MsgBox("data not found")
            End If
            GTbEBEPN.Text = pdn
            GTbEBEDis.Text = dist
            GTbEBEAmt.Text = amt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBCon.Close()
        End Try
    End Sub

    Private Sub GBtnESearch_Click(sender As Object, e As EventArgs) Handles GBtnESearch.Click
        DBCon.Open()
        query = "select pid,product_name,quantity from products where product_name='" & UCase(GTbEStockPN.Text) & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVEStock.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DBCon.Open()
        query = "select pid,product_name,quantity from products where pid='" & Guna2TextB.Text & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVEStock.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            slt = True
            Dim row As DataGridViewRow = Guna2DataGridView1 .Rows(e.RowIndex)
            If row.Cells(0).Value = row.Cells(0).Value Then
                sltcell1 = row.Cells(3).Value
                sltcell2 = row.Cells(0).Value
                sltcell3 = row.Cells(5).Value
            End If
        End If
    End Sub

    Private Sub GBtnEDel_Click(sender As Object, e As EventArgs) Handles GBtnEDel.Click
        If slt = True Then
            If MessageBox.Show("do you want to delete it", "delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    DBCon.Open()
                    Dim cmd As New SqlCommand(query, DBCon)
                    query = "update products set quantity=quantity +'" & sltcell3 & "' where pid='" & pid & "'"
                    cmd.ExecuteNonQuery()
                    query = "delete from sellhistory where PID='" & sltcell1 & "' and billno='" & sltcell2 & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("data updated succesfully")
                    DBCon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    listproduct()
                End Try
            End If
            Product_Add.clears()
            slt = False
        Else
            MsgBox("Please Select a data")
        End If
    End Sub
End Class
