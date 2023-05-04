Imports System.Data.SqlClient

Public Class ResetPass
    Sub clears()

        GTbRPPass.Clear()
        GTbRPRT.Clear()
        GTbRPU.Clear()
    End Sub
    Private Sub GBtnRPClear_Click(sender As Object, e As EventArgs) Handles GBtnRPClear.Click
        clears()
    End Sub

    Private Sub GTbRPU_TextChanged(sender As Object, e As EventArgs) Handles GTbRPU.TextChanged

    End Sub
    Sub update_prls()
        Try
            DBCon.Open()
            query = "update Logins set username='" & GTbRPU.Text & "',password='" & GTbRPPass.Text & "' where username='" & usrcell & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            cmd.ExecuteNonQuery()
            MsgBox("data updated succesfully")
            clears()
            DBCon.Close()
            Uservb.listproduct()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        Me.Hide()
    End Sub
    Private Sub GBtnRPsave_Click(sender As Object, e As EventArgs) Handles GBtnRPsave.Click
        If GTbRPPass.Text = GTbRPRT.Text Then
            update_prls()
            clears()
        Else
            MsgBox("passwords not matched")
        End If
    End Sub

    Private Sub ResetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GBtnRPX1_Click(sender As Object, e As EventArgs) Handles GBtnRPX1.Click
        Me.Hide()
    End Sub
End Class