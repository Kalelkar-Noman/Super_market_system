Imports System.Data.SqlClient

Public Class Supplier
    Dim slt As Boolean = False
    Private Sub GDataGridVSupp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridVSupp.CellContentClick

    End Sub
    Sub listproduct()
        DBCon.Open()
        query = "select SPNAME,SADDRESS,SCATEGORY,SPHONE,SEMAIL from SUPPLIER"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        GDataGridVSupp.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        listproduct()
    End Sub

    Private Sub GBtnSupAd_Click(sender As Object, e As EventArgs) Handles GBtnSupAd.Click
        slistmod(1)
        If Application.OpenForms().OfType(Of Supplier_mod).Any Then
            Supplier_mod.Close()
        End If
        Supplier_mod.Show()
    End Sub

    Private Sub GBtnSUPUp_Click(sender As Object, e As EventArgs) Handles GBtnSUPUp.Click
        If slt = True Then
            slistmod(2)
            slt = False
            If Application.OpenForms().OfType(Of Supplier_mod).Any Then
                Supplier_mod.Hide()
            End If
            Supplier_mod.Show()
        Else
            MsgBox("Please Select a SUPPPLIER NAME ")
        End If
    End Sub

    Private Sub GDataGridVSupp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDataGridVSupp.CellClick
        If e.RowIndex >= 0 Then
            slt = True
            Dim row As DataGridViewRow = GDataGridVSupp.Rows(e.RowIndex)
            If row.Cells(0).Value = row.Cells(0).Value Then
                ssltcell = row.Cells(0).Value
                Supplier_mod.GTbSMSN.Text = row.Cells(0).Value
                Supplier_mod.GTbSMAdd.Text = row.Cells(1).Value
                Supplier_mod.GTbSMCat.Text = row.Cells(2).Value
                Supplier_mod.GTbSMPNo.Text = row.Cells(3).Value
                Supplier_mod.GTbSMEid.Text = row.Cells(4).Value
            End If
        End If
    End Sub

    Private Sub Guna2BDELETE_Click(sender As Object, e As EventArgs) Handles Guna2BDELETE.Click
        If slt = True Then
            If MessageBox.Show("do you want to delete it", "delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    DBCon.Open()
                    query = "delete from SUPPLIER where SPNAME= '" & ssltcell & "'"
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
            Supplier_mod.clears()
        Else
            MsgBox("Please Select a data")
        End If
    End Sub
End Class