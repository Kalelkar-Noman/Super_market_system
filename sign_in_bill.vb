Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class sign_in_bill
    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles GTbPassBill.TextChanged

    End Sub

    Private Sub GBtnShow_Click(sender As Object, e As EventArgs) Handles GBtnShow.Click

        If GTbPassBill.UseSystemPasswordChar = True Then
            GBtnShow.Image = My.Resources.doubleeye

            GTbPassBill.UseSystemPasswordChar = False

        Else
            GBtnShow.Image = My.Resources.close
            GTbPassBill.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub sign_in_bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GTbPassBill.UseSystemPasswordChar = True
    End Sub

    Private Sub GBTnSignIn_Click(sender As Object, e As EventArgs) Handles GBTnSignIn.Click
        DBCon.Open()
        Try
            query = "select * from Logins where username='" & GTbUserNbill.Text & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim Cmdread As SqlDataReader = cmd.ExecuteReader
            Dim a1 As Boolean = False
            While Cmdread.Read()
                If GTbPassBill.Text = Cmdread("password") And GTbUserNbill.Text = Cmdread("username") Then
                    MsgBox("login successfull")
                    a1 = True
                    If Cmdread("role") = "Admin" Then
                        MainAdim.Show()
                        MainAdim.LabelAdminU.Text = Cmdread("username")
                    Else
                        Form1.Show()
                        Form1.LabelCash.Text = Cmdread("username")
                    End If
                    Exit While

                End If
            End While
            DBCon.Close()
            If a1 = False Then
                MsgBox("invalid username or password")
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            DBCon.Close()
        End Try
    End Sub
End Class