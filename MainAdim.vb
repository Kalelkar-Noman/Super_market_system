Public Class MainAdim
    Private Sub MainAdim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customizedDesign()
    End Sub
    Private Sub customizedDesign()
        GPanelProductSub.Visible = False
        GPanelStockSub.Visible = False
        GPanelRecordSub.Visible = False
    End Sub
    Private Sub Hidesubmenu()
        If (GPanelProductSub.Visible = True) Then
            GPanelProductSub.Visible = False
        End If
        If (GPanelStockSub.Visible = True) Then
            GPanelStockSub.Visible = False
        End If
        If (GPanelRecordSub.Visible = True) Then
            GPanelRecordSub.Visible = False
        End If

    End Sub
    Private Sub showsubmenu(ByRef submenu)
        If (submenu.Visible = False) Then
            Hidesubmenu()

            submenu.Visible = True
        Else
            submenu.Visible = False

        End If
    End Sub
    Private Sub GBtnProduct_Click(sender As Object, e As EventArgs) Handles GBtnProduct.Click
        showsubmenu(GPanelProductSub)
    End Sub
    Private Sub GBtnSubPL_Click(sender As Object, e As EventArgs) Handles GBtnSubPL.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Product_List)
    End Sub
    Private Sub GBtnsubBrand_Click(sender As Object, e As EventArgs) Handles GBtnsubBrand.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Brand)
    End Sub
    Private Sub GBtnsubCat_Click(sender As Object, e As EventArgs) Handles GBtnsubCat.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Categroy)
    End Sub
    Private Sub GBtnStock_Click(sender As Object, e As EventArgs) Handles GBtnStock.Click
        showsubmenu(GPanelStockSub)
    End Sub
    Private Sub GBtnStockIn_Click(sender As Object, e As EventArgs) Handles GBtnStockIn.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Stock_In)
    End Sub
    Private Sub GBtnStocRe_Click(sender As Object, e As EventArgs) Handles GBtnStocRe.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Stock_Record)
    End Sub
    Private Sub GBtnSup_Click(sender As Object, e As EventArgs) Handles GBtnSup.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Supplier)
    End Sub
    Private Sub GBtnRecord_Click(sender As Object, e As EventArgs) Handles GBtnRecord.Click
        showsubmenu(GPanelRecordSub)
    End Sub
    Private Sub GBtnSaleHis_Click(sender As Object, e As EventArgs) Handles GBtnSaleHis.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Sale_History)
    End Sub
    Private Sub GBtnRPOS_Click(sender As Object, e As EventArgs) Handles GBtnRPOS.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Record_POS)
    End Sub
    Private Sub GBtnUser_Click(sender As Object, e As EventArgs) Handles GBtnUser.Click
        Hidesubmenu()
        If (True <> IsNothing(PanelMain)) Then
            PanelMain.Controls.Clear()
        End If
        panelview(Uservb)
    End Sub
    Private Sub GBtnLog_Click(sender As Object, e As EventArgs) Handles GBtnLog.Click
        Hidesubmenu()
        User_Signin.Show()
        Me.Close()
    End Sub
End Class