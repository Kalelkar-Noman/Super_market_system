Imports System.Data.SqlClient

Public Class Form1
    Dim pdn As String = ""
    Dim pid As Integer = 0
    Dim amt As Integer = 0
    Dim dist As Integer = 0


    Private Sub PictureBQr_Click(sender As Object, e As EventArgs) Handles PictureBQr.Click
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
        Try
            DBCon.Open()
            query = "insert into sellhistory values('" & GTbEBEBN.Text & "','" & GTbEBEMN.Text & "','" & pid & "','" & GTbEBEPN.Text & "','" & GTbEBEQty.Text & "','" & GTbEBECA.Text & "','" & GTbEBETM.Text & "','" & dist & "')"
            Dim cmd As New SqlCommand(query, DBCon)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBCon.Close()
        End Try
        listproduct()
    End Sub

End Class
