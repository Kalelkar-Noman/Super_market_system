Imports System.Data.SqlClient

Public Class Product_List

    Dim slt As Boolean = False

    Sub listproduct()
        DBCon.Open()
        query = "select PID,PRODUCT_NAME,BRAND,CATEGORY,DISCOUNT,PRICE from PRODUCTS"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        GDataGridVPL.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles GBtnPLEd.Click
        If slt = True Then
            listmod(2)
            slt = False
            If Application.OpenForms().OfType(Of Product_Add).Any Then
                Product_Add.Close()
            End If
            Product_Add.Show()
        Else
            MsgBox("Please Select a PID ")
        End If

    End Sub

    Private Sub GDataGridVPL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridVPL.CellContentClick

    End Sub

    Private Sub Product_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listproduct()
    End Sub

    Private Sub GBtnPLadd_Click(sender As Object, e As EventArgs) Handles GBtnPLadd.Click

        listmod(1)
        If Application.OpenForms().OfType(Of Product_Add).Any Then
            Product_Add.Hide()
        End If
        Product_Add.Show()
    End Sub

    Private Sub GDataGridVPL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridVPL.CellClick
        If e.RowIndex >= 0 Then
            slt = True
            Dim row As DataGridViewRow = GDataGridVPL.Rows(e.RowIndex)
            If row.Cells(0).Value = row.Cells(0).Value Then
                sltcell = row.Cells(0).Value
                Product_Add.GTbPAID.Text = row.Cells(0).Value
                Product_Add.GTbPAPN.Text = row.Cells(1).Value
                Product_Add.GTbPABrand.Text = row.Cells(2).Value
                Product_Add.GTbPACat.Text = row.Cells(3).Value
                Product_Add.GTbPADis.Text = row.Cells(4).Value
                Product_Add.GTbPAPrice.Text = row.Cells(5).Value
            End If
        End If

    End Sub

    Private Sub GBtnPLDel_Click(sender As Object, e As EventArgs) Handles GBtnPLDel.Click
        If slt = True Then
            If MessageBox.Show("do you want to delete it", "delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    DBCon.Open()
                    query = "delete from PRODUCTS where PID='" & sltcell & "'"
                    Dim cmd As New SqlCommand(query, DBCon)
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