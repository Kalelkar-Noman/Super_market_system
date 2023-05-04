Public Class LOGIN
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Lblreportprogress.Text = PBloading1.Value & "%"
        PBloading1.Value += 5

        If PBloading1.Value > 10 Then
            Lblstatustext.Text = "Please Wait..."
        End If

        If PBloading1.Value > 35 Then
            Lblstatustext.Text = "Processing..."
        End If

        If PBloading1.Value > 65 Then
            Lblstatustext.Text = "Few Minute is remining..."
        End If

        If PBloading1.Value > 95 Then
            Lblstatustext.Text = "Thanks For Waiting..."
        End If

        If PBloading1.Value > 100 Then
            Lblstatustext.Text = "Lauching Application..."
            User_Signin.Show()
            Me.Hide()
            Timer1.Dispose()

        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class
