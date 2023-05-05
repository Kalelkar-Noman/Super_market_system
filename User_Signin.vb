Imports System.Data.SqlClient
Public Class User_Signin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DBCon.Open()
        Try
            query = "select * from Logins where username='" & TextBox1.Text & "'"
            Dim cmd As New SqlCommand(query, DBCon)
            Dim Cmdread As SqlDataReader = cmd.ExecuteReader
            Dim a1 As Boolean = False

            While Cmdread.Read()
                If TextBox2.Text = Cmdread("password") And TextBox1.Text = Cmdread("username") Then
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
