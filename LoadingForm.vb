Public Class LoadingForm
    Dim timercount As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timercount = timercount + 1

        If timercount > 1 Then
            TextStatus.Text = "Loading... Please wait"
        End If
        If timercount > 2 Then
            TextStatus.Text = "Generating dialogs"
        End If
        If timercount > 3 Then
            TextStatus.Text = "Installing dependencies"
        End If
        If timercount > 4 Then
            TextStatus.Text = "Thanks for waiting!"
        End If
        If timercount > 5 Then
            TextStatus.Text = "Launching application...."
        End If
        If timercount = 6 Then

            Me.Hide()
            Login.Show()
            Timer1.Dispose()

        End If
    End Sub


    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 6000
        Timer1.Start() 'Timer starts functioning
    End Sub
End Class