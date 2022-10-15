Imports System.Net.Mail

Public Class SendEmail
    Private Sub BTNfile_Click(sender As Object, e As EventArgs) Handles BTNfile.Click
        OpenFileDialog1.ShowDialog()
        FileLabel.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub BTNsendEmail_Click(sender As Object, e As EventArgs) Handles BTNsendEmail.Click
        Try
            Dim smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Dim attach As System.Net.Mail.Attachment

            smtp_Server.UseDefaultCredentials = False
            smtp_Server.Credentials = New Net.NetworkCredential("watanabetoshiro47@gmail.com", "zgnriuvarwksdxic")
            smtp_Server.Port = 587
            smtp_Server.EnableSsl = True
            smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("watanabetoshiro47@gmail.com")
            e_mail.To.Add(TxtToMail.Text)
            e_mail.Subject = TxtMailSubject.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = TxtMailMessage.Text
            attach = New System.Net.Mail.Attachment(FileLabel.Text)
            e_mail.Attachments.Add(attach)
            smtp_Server.Send(e_mail)
            MessageBox.Show("Email sent successfully", "Contact a Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            ' MessageBox.Show("Failed to send message," & vbCrLf & "please try again", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNclear_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        TxtToMail.Text = ""
        TxtMailSubject.Text = ""
        TxtMailMessage.Text = ""
        FileLabel.Text = "Path"
    End Sub


    Private Sub EXITbtn_Click(sender As Object, e As EventArgs) Handles EXITbtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to close the form?", "Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then Close()
    End Sub



    'MOVE BORDERLESS FORM
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub SendEmail_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub SendEmail_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub SendEmail_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub


End Class