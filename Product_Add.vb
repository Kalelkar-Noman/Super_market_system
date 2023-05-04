Imports System.Data.SqlClient

Public Class Product_Add
    Sub clears()
        GTbPABrand.Clear()
        GTbPACat.Clear()
        GTbPADis.Clear()
        GTbPAID.Clear()
        GTbPAPN.Clear()
        GTbPAPrice.Clear()
    End Sub
    Sub update_prls()
        Try
            DBCon.Open()
            query = "update products set PID='" & GTbPAID.Text & "',PRODUCT_NAME='" & UCase(GTbPAPN.Text) & "',BRAND='" & UCase(GTbPABrand.Text) & "',CATEGORY='" & UCase(GTbPACat.Text) & "',DISCOUNT ='" & GTbPADis.Text & "',PRICE='" & GTbPAPrice.Text & "' where PID='" & sltcell & "' "
            Dim cmd As New SqlCommand(query, DBCon)
            cmd.ExecuteNonQuery()
            MsgBox("data updated succesfully")
            clears()
            DBCon.Close()
            Product_List.listproduct()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        Me.Hide()
    End Sub
    Sub insrt_prls()
        Try
            DBCon.Open()
            query = "insert into PRODUCTS values('" & GTbPAID.Text & "','" & UCase(GTbPAPN.Text) & "','" & UCase(GTbPABrand.Text) & "','" & UCase(GTbPACat.Text) & "','" & GTbPADis.Text & "','" & GTbPAPrice.Text & "','','')"
            Dim cmd As New SqlCommand(query, DBCon)
            cmd.ExecuteNonQuery()
            DBCon.Close()
            Product_List.listproduct()
            MsgBox("saved successfully")
            clears()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        Me.Hide()
    End Sub
    Private Sub GBtnPASave_Click(sender As Object, e As EventArgs) Handles GBtnPASave.Click
        If listap = 1 Then
            insrt_prls()
        ElseIf listap = 2 Then
            update_prls()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub

    Private Sub GBtnPACle_Click(sender As Object, e As EventArgs) Handles GBtnPACle.Click
        clears()
    End Sub

    Private Sub Product_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GLablePAPId_Click(sender As Object, e As EventArgs) Handles GLablePAPId.Click

    End Sub

    Private Sub GLablePADis_Click(sender As Object, e As EventArgs) Handles GLablePADis.Click

    End Sub

    Private Sub GLablePACat_Click(sender As Object, e As EventArgs) Handles GLablePACat.Click

    End Sub
End Class