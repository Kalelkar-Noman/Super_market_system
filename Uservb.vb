Imports System.Data.SqlClient

Public Class Uservb
    Sub insrt_urs()
        Try
            DBCon.Open()
            query = "insert into Logins values('" & GTbACUserN.Text & "','" & GTbCAPass.Text & "','" & GComboCA.SelectedItem & "','" & GTbCAAdd.Text & "','Active')"
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

    End Sub
    Sub clears()
        GTbACUserN.Clear()
        GTbCAAdd.Clear()
        GTbCAPass.Clear()
        GTbCARpass.Clear()

    End Sub
    Private Sub GTBCOCan_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GComboCA.SelectedIndexChanged

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GLabelCAAdd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableUser_Click(sender As Object, e As EventArgs) Handles TableUser.Click

    End Sub

    Private Sub GBtnCASave_Click(sender As Object, e As EventArgs) Handles GBtnCASave.Click
        If GTbCAPass.Text = GTbCARpass.Text Then
            insrt_urs()
            clears()
            listproduct()
        Else
            MsgBox("passwords not matched")
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
    Sub listproduct()
        DBCon.Open()
        query = "select username,address,status,role from Logins"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        Guna2DataGridView1.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Uservb_Load(sender As Object, e As EventArgs) Handles Me.Load
        listproduct()
    End Sub
    Dim slt As Boolean = False
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            slt = True
            Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            If row.Cells(0).Value = row.Cells(0).Value Then
                usrcell = row.Cells(0).Value
                UserUpdatevb.GTbUname.Text = row.Cells(0).Value
                ResetPass.GTbRPU.Text = row.Cells(0).Value
            End If
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If slt = True Then
            If MessageBox.Show("do you want to delete it", "delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    DBCon.Open()
                    query = "delete from Logins where username='" & usrcell & "'"
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
        Else
            MsgBox("Please Select a data")
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If slt = True Then
            ResetPass.Show()
            slt = False

        End If
    End Sub

    Private Sub GBtnCAClear_Click(sender As Object, e As EventArgs) Handles GBtnCAClear.Click
        clears()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If slt = True Then
            UserUpdatevb.Show()
            slt = False

        End If
    End Sub
End Class