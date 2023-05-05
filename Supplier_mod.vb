Imports System.Data.SqlClient

Public Class Supplier_mod
    Private Sub GLabelPABr_Click(sender As Object, e As EventArgs)

    End Sub
    Sub clears()
        GTbSMSN.Clear()
        GTbSMAdd.Clear()
        GTbSMCat.Clear()
        GTbSMPNo.Clear()
        GTbSMEid.Clear()
    End Sub
    Sub insrt_prls()
        Try
            DBCon.Open()
            query = "insert into SUPPLIER values('" & UCase(GTbSMSN.Text) & "','" & UCase(GTbSMAdd.Text) & "','" & UCase(GTbSMCat.Text) & "','" & GTbSMPNo.Text & "','" & UCase(GTbSMEid.Text) & "','','','')"
            Dim cmd As New SqlCommand(query, DBCon)
            cmd.ExecuteNonQuery()
            DBCon.Close()
            Supplier.listproduct()
            MsgBox("saved successfully")
            clears()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        Me.Close()
    End Sub
    Sub update_prls()
        Try
            DBCon.Open()
            query = "update SUPPLIER set SPNAME ='" & UCase(GTbSMSN.Text) & "',SADDRESS='" & UCase(GTbSMAdd.Text) & "',SCATEGORY='" & UCase(GTbSMCat.Text) & "',SPHONE='" & GTbSMPNo.Text & "',SEMAIL ='" & UCase(GTbSMEid.Text) & "' where SPNAME ='" & ssltcell & "' "
            Dim cmd As New SqlCommand(query, DBCon)
            cmd.ExecuteNonQuery()
            MsgBox("data updated succesfully")
            clears()
            DBCon.Close()
            Supplier.listproduct()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        Me.Close()
    End Sub
    Private Sub GTbSMCat_TextChanged(sender As Object, e As EventArgs) Handles GTbSMCat.TextChanged

    End Sub

    Private Sub GBtnSMSave_Click(sender As Object, e As EventArgs) Handles GBtnSMSave.Click
        If slistap = 1 Then
            insrt_prls()
        ElseIf slistap = 2 Then
            update_prls()
        End If
    End Sub

    Private Sub Supplier_mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GBtnSMX1_Click(sender As Object, e As EventArgs) Handles GBtnSMX1.Click
        Me.Close()
    End Sub
End Class