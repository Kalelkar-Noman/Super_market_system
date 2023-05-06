Public Class loginbill


    Private Sub loginbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gprogress.Value = 0
        LabelLoading.Visible = False
    End Sub

    Private Sub Timerlogin_Tick(sender As Object, e As EventArgs) Handles Timerlogin.Tick
        Gprogress.Increment(2)

        Gprogress.Value += 1
        Gprogress.Animated = True
        LabelLoading.Visible = True
        Gprogress.Text = Gprogress.Value.ToString() + "%"
        If (Gprogress.Value = 100) Then

            Timerlogin.Enabled = False

            sign_in_bill.Show()
            Me.Close()

        End If
    End Sub
End Class