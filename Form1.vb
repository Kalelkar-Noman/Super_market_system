Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Form1
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Longpaper As Integer

    Dim pdn As String = ""
    Dim pid As Integer = 0
    Dim amt As Integer = 0
    Dim dist As Integer = 0
    Dim qty As Integer = 0
    Dim sltcell1 As Integer = -2
    Dim sltcell2 As Integer = -2
    Dim sltcell3 As Integer = -2
    Dim slt As Boolean = False

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
        DBCon.Open()
        query = "select * from PRODUCTS where PID='" & GTbEBEPID.Text & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            qty = dr("quantity")
        End If

        DBCon.Close()
        Try
            If GTbEBEQty.Text > qty Then
                MsgBox("quantity is greater")
            Else
                DBCon.Open()
                query = "insert into sellhistory values('" & GTbEBEBN.Text & "','" & GTbEBEMN.Text & "','" & pid & "','" & UCase(GTbEBEPN.Text) & "','" & GTbEBEQty.Text & "','" & UCase(GTbEBECA.Text) & "','" & GTbEBETM.Text & "','" & dist & "','" & GDTPEBD1.Value & "','" & UCase(LabelCash.Text) & "')"
                Dim cmd1 As New SqlCommand(query, DBCon)
                cmd1.ExecuteNonQuery()
                query = "update products set quantity=quantity - '" & GTbEBEQty.Text & "' where pid='" & pid & "'"
                Dim cmd2 As New SqlCommand(query, DBCon)
                cmd2.ExecuteNonQuery()
                query = "select quantity,productname,amount from sellhistory where billno='" & GTbEBEBN.Text & "'"
                Dim cmd3 As New SqlCommand(query, DBCon)
                Dim drr As SqlDataReader = cmd3.ExecuteReader
                Dim dtt As New DataTable
                dtt.Load(drr)
                datagriedviewPint.DataSource = dtt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (DBCon.State = ConnectionState.Open) = True Then
                DBCon.Close()
            End If
        End Try
        listproduct()
    End Sub

    Private Sub GBtnECDSearch_Click(sender As Object, e As EventArgs) Handles GBtnECDSearch.Click
        DBCon.Open()
        query = "select billno,custname from sellhistory where billno='" & GTbECDBill.Text & "' "
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVCD.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DBCon.Open()
        query = "select billno,custname from sellhistory where billno='" & GTbECDCN.Text & "' "
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVCD.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub GBtnEClear_Click(sender As Object, e As EventArgs) Handles GBtnEClear.Click
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
                qty = dr("quantity")
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

    Private Sub GBtnESearch_Click(sender As Object, e As EventArgs) Handles GBtnESearch.Click
        DBCon.Open()
        query = "select pid,product_name,quantity from products where product_name='" & UCase(GTbEStockPN.Text) & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVEStock.DataSource = dt
        DBCon.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DBCon.Open()
        query = "select pid,product_name,quantity from products where pid='" & Guna2TextB.Text & "'"
        Dim cmd As New SqlCommand(query, DBCon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        DGVEStock.DataSource = dt
        DBCon.Close()
    End Sub
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            slt = True
            Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            If row.Cells(0).Value = row.Cells(0).Value Then
                sltcell1 = row.Cells(3).Value
                sltcell2 = row.Cells(0).Value
                sltcell3 = row.Cells(5).Value
            End If
        End If
    End Sub

    Private Sub GBtnEDel_Click(sender As Object, e As EventArgs) Handles GBtnEDel.Click
        If slt = True Then
            If MessageBox.Show("do you want to delete it", "delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    DBCon.Open()
                    Dim cmd As New SqlCommand(query, DBCon)
                    query = "update products set quantity=quantity +'" & sltcell3 & "' where pid='" & pid & "'"
                    cmd.ExecuteNonQuery()
                    query = "delete from sellhistory where PID='" & sltcell1 & "' and billno='" & sltcell2 & "'"
                    Dim cmd1 As New SqlCommand(query, DBCon)
                    cmd1.ExecuteNonQuery()
                    MsgBox("data updated succesfully")
                    DBCon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    listproduct()
                End Try
            End If
            Product_Add.clears()
            slt = False
        Else
            MsgBox("Please Select a data")
        End If
    End Sub

    Private Sub GBtnESav_Click(sender As Object, e As EventArgs) Handles GBtnESav.Click
        sign_in_bill.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GBtnAdd_Click(sender As Object, e As EventArgs) Handles GBtnAdd.Click

    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        Longpaper = 0
        rowcount = datagriedviewPint.Rows.Count
        Longpaper = rowcount * 15
        Longpaper = Longpaper + 500

    End Sub

    Private Sub GBtnEPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint1.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, Longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim F8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim F10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim F10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim F14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim Centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String

        line = "------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("BIG MART", F14, Brushes.Red, Centermargin, 5, center)
        e.Graphics.DrawString("Veena Nagar, Thane west 400604", F10, Brushes.Black, Centermargin, 25, center)
        e.Graphics.DrawString("tel + 998765343", F10, Brushes.Black, Centermargin, 40, center)

        e.Graphics.DrawString("Casher", F8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", F8, Brushes.Black, 50, 60)
        e.Graphics.DrawString("Rahul Prajapati", F8, Brushes.Black, 70, 60)

        ' e.Graphics.DrawString("Casher", F8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", F8, Brushes.Black, 50, 75)
        'e.Graphics.DrawString("DEEPAK K GUPTA", F10, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Date              " & Date.Now(), F8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(line, F8, Brushes.Black, 0, 100)
        ' line = "--------------------------------------------------------------------------------------------"

        Dim Height As Integer
        Dim i As Long

        datagriedviewPint.AllowUserToAddRows = False

        For row As Integer = 0 To datagriedviewPint.RowCount - 1
            Height += 15
            e.Graphics.DrawString(datagriedviewPint.Rows(row).Cells(1).Value.ToString, F10, Brushes.Black, 0, 100 + Height)
            e.Graphics.DrawString(datagriedviewPint.Rows(row).Cells(0).Value.ToString, F10, Brushes.Black, 25, 100 + Height)

            i = datagriedviewPint.Rows(row).Cells(2).Value
            datagriedviewPint.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(datagriedviewPint.Rows(row).Cells(2).Value.ToString, F10, Brushes.Black, rightmargin, 100 + Height, right)
        Next
        Dim height2 As Integer

        height2 = 110 + Height

        Sumprice()
        line = "--------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(line, F8, Brushes.Black, 0, Height)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), F10, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString(t_qty, F10, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString("...................Thanks For Shopping....................", F10, Brushes.Black, Centermargin, 35 + height2, center)
        ' e.Graphics.DrawString("BIG MART", F10, Brushes.Black, Centermargin, 35 + height2, center)

    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub Sumprice()
        Dim countprice As Long = 0

        For rowitem As Long = 0 To datagriedviewPint.RowCount - 1
            countprice = countprice + Val(datagriedviewPint.Rows(rowitem).Cells(2).Value * datagriedviewPint.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice

        Dim countqty As Long = 0
        For rowitem As Long = 0 To datagriedviewPint.RowCount - 1
            countqty = countqty + datagriedviewPint.Rows(rowitem).Cells(1).Value
        Next
        t_qty = countqty
    End Sub

    Private Sub GBtnERes_Click(sender As Object, e As EventArgs) Handles GBtnERes.Click

    End Sub
End Class
