Imports System.Data.SqlClient

Public Class Sale_History
    Private Sub GBtnSH_Click(sender As Object, e As EventArgs) Handles GBtnSH.Click

        Try
            DBCon.Open()
            query = "select productid,productname,amount,quantity,discount,date,cashier from sellhistory where date between '" & GDTPSHD1.Value & "' and '" & GDTPSHD2.Value & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            Guna2DidView1.DataSource = dt
            query = "select SUM(amount) as total from sellhistory where date between '" & GDTPSHD1.Value & "' and '" & GDTPSHD2.Value & "'"
            Dim cmd1 As New SqlCommand(query, DBCon)
            Dim dr1 As SqlDataReader = cmd1.ExecuteReader()
            If dr1.Read() Then
                GTBSHTS.Text = dr1("total")
            End If


        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            DBCon.Close()
        End Try

    End Sub

    Private Sub Guna2DidView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DidView1.CellContentClick

    End Sub

    Private Sub Gcashierl_Click(sender As Object, e As EventArgs) Handles Gcashierl.Click
        Try
            DBCon.Open()
            query = "select productid,productname,amount,quantity,discount,date,cashier from sellhistory where cashier='" & UCase(GTBSHC.Text) & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            Guna2DidView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            DBCon.Close()
        End Try

    End Sub
End Class