Imports System.Data.SqlClient

Public Class UserUpdatevb
    Sub clears()
        GTbAdd.Clear()
        GTbUname.Clear()
        GTbUPass.Clear()
        GTbURt.Clear()
    End Sub
    Sub update_prls()
        Try
            DBCon.Open()
            query = "update Logins set username='" & GTbUname.Text & "',password='" & GTbUPass.Text & "',role='" & GComboUr.SelectedItem & "',address='" & GTbAdd.Text & "',status ='" & GComboUAc.SelectedItem & "' where username='" & usrcell & "'"
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
    Private Sub GBtnUsave_Click(sender As Object, e As EventArgs) Handles GBtnUsave.Click

        If GTbUPass.Text = GTbURt.Text Then
            update_prls()
            clears()
        Else
            MsgBox("passwords not matched")
        End If

    End Sub

    Private Sub GBtnUX1_Click(sender As Object, e As EventArgs) Handles GBtnUX1.Click
        Me.Close()
    End Sub
End Class