<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendEmail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEmail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTNminimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.EXITbtn = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.TxtToMail = New System.Windows.Forms.TextBox()
        Me.TxtMailSubject = New System.Windows.Forms.TextBox()
        Me.TxtMailMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileLabel = New System.Windows.Forms.Label()
        Me.BTNsendEmail = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNfile = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BTNclear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(80, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 54)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Contact a"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(261, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 54)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Student"
        '
        'BTNminimize
        '
        Me.BTNminimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNminimize.BackColor = System.Drawing.Color.White
        Me.BTNminimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.BTNminimize.FillColor = System.Drawing.Color.Transparent
        Me.BTNminimize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BTNminimize.HoverState.IconColor = System.Drawing.Color.White
        Me.BTNminimize.IconColor = System.Drawing.Color.Black
        Me.BTNminimize.Location = New System.Drawing.Point(801, 12)
        Me.BTNminimize.Name = "BTNminimize"
        Me.BTNminimize.PressedColor = System.Drawing.Color.White
        Me.BTNminimize.Size = New System.Drawing.Size(26, 21)
        Me.BTNminimize.TabIndex = 55
        '
        'EXITbtn
        '
        Me.EXITbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EXITbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.EXITbtn.CustomClick = True
        Me.EXITbtn.CustomIconSize = 50.0!
        Me.EXITbtn.FillColor = System.Drawing.Color.Transparent
        Me.EXITbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EXITbtn.HoverState.IconColor = System.Drawing.Color.White
        Me.EXITbtn.IconColor = System.Drawing.Color.White
        Me.EXITbtn.Location = New System.Drawing.Point(834, 12)
        Me.EXITbtn.Name = "EXITbtn"
        Me.EXITbtn.Size = New System.Drawing.Size(26, 21)
        Me.EXITbtn.TabIndex = 54
        '
        'TxtToMail
        '
        Me.TxtToMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtToMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtToMail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtToMail.ForeColor = System.Drawing.Color.Black
        Me.TxtToMail.Location = New System.Drawing.Point(120, 26)
        Me.TxtToMail.Multiline = True
        Me.TxtToMail.Name = "TxtToMail"
        Me.TxtToMail.Size = New System.Drawing.Size(240, 20)
        Me.TxtToMail.TabIndex = 56
        '
        'TxtMailSubject
        '
        Me.TxtMailSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtMailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMailSubject.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtMailSubject.ForeColor = System.Drawing.Color.Black
        Me.TxtMailSubject.Location = New System.Drawing.Point(120, 65)
        Me.TxtMailSubject.Multiline = True
        Me.TxtMailSubject.Name = "TxtMailSubject"
        Me.TxtMailSubject.Size = New System.Drawing.Size(240, 20)
        Me.TxtMailSubject.TabIndex = 57
        '
        'TxtMailMessage
        '
        Me.TxtMailMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtMailMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMailMessage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtMailMessage.ForeColor = System.Drawing.Color.Black
        Me.TxtMailMessage.Location = New System.Drawing.Point(120, 106)
        Me.TxtMailMessage.Multiline = True
        Me.TxtMailMessage.Name = "TxtMailMessage"
        Me.TxtMailMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMailMessage.Size = New System.Drawing.Size(259, 132)
        Me.TxtMailMessage.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "To : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Subject : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Message : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(94, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Get to know by connecting with students "
        '
        'FileLabel
        '
        Me.FileLabel.AutoSize = True
        Me.FileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FileLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FileLabel.Location = New System.Drawing.Point(51, 462)
        Me.FileLabel.Name = "FileLabel"
        Me.FileLabel.Size = New System.Drawing.Size(26, 12)
        Me.FileLabel.TabIndex = 63
        Me.FileLabel.Text = "Path"
        '
        'BTNsendEmail
        '
        Me.BTNsendEmail.AutoRoundedCorners = True
        Me.BTNsendEmail.BackColor = System.Drawing.Color.Transparent
        Me.BTNsendEmail.BorderColor = System.Drawing.Color.Transparent
        Me.BTNsendEmail.BorderRadius = 19
        Me.BTNsendEmail.BorderThickness = 1
        Me.BTNsendEmail.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BTNsendEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNsendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNsendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNsendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNsendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNsendEmail.FillColor = System.Drawing.Color.White
        Me.BTNsendEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNsendEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BTNsendEmail.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNsendEmail.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTNsendEmail.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BTNsendEmail.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNsendEmail.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNsendEmail.Location = New System.Drawing.Point(338, 494)
        Me.BTNsendEmail.Name = "BTNsendEmail"
        Me.BTNsendEmail.PressedColor = System.Drawing.Color.White
        Me.BTNsendEmail.ShadowDecoration.BorderRadius = 20
        Me.BTNsendEmail.ShadowDecoration.Depth = 5
        Me.BTNsendEmail.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNsendEmail.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.BTNsendEmail.Size = New System.Drawing.Size(107, 40)
        Me.BTNsendEmail.TabIndex = 64
        Me.BTNsendEmail.Text = "Send Email"
        '
        'BTNfile
        '
        Me.BTNfile.BackColor = System.Drawing.Color.Transparent
        Me.BTNfile.BorderColor = System.Drawing.Color.Transparent
        Me.BTNfile.BorderRadius = 15
        Me.BTNfile.BorderThickness = 1
        Me.BTNfile.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BTNfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNfile.FillColor = System.Drawing.Color.White
        Me.BTNfile.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BTNfile.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BTNfile.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNfile.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNfile.Location = New System.Drawing.Point(216, 494)
        Me.BTNfile.Name = "BTNfile"
        Me.BTNfile.PressedColor = System.Drawing.Color.White
        Me.BTNfile.ShadowDecoration.BorderRadius = 20
        Me.BTNfile.ShadowDecoration.Depth = 20
        Me.BTNfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNfile.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(20)
        Me.BTNfile.Size = New System.Drawing.Size(107, 40)
        Me.BTNfile.TabIndex = 65
        Me.BTNfile.Text = "Attach File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BTNclear
        '
        Me.BTNclear.BackColor = System.Drawing.Color.Transparent
        Me.BTNclear.BorderColor = System.Drawing.Color.Transparent
        Me.BTNclear.BorderRadius = 15
        Me.BTNclear.BorderThickness = 1
        Me.BTNclear.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BTNclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNclear.FillColor = System.Drawing.Color.White
        Me.BTNclear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BTNclear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BTNclear.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNclear.HoverState.ForeColor = System.Drawing.Color.White
        Me.BTNclear.Location = New System.Drawing.Point(94, 494)
        Me.BTNclear.Name = "BTNclear"
        Me.BTNclear.PressedColor = System.Drawing.Color.White
        Me.BTNclear.ShadowDecoration.BorderRadius = 20
        Me.BTNclear.ShadowDecoration.Depth = 5
        Me.BTNclear.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNclear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.BTNclear.Size = New System.Drawing.Size(107, 40)
        Me.BTNclear.TabIndex = 66
        Me.BTNclear.Text = "Clear Field"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.BorderRadius = 5
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtMailSubject)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtToMail)
        Me.Guna2GradientPanel2.Controls.Add(Me.TxtMailMessage)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(51, 163)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.BorderRadius = 20
        Me.Guna2GradientPanel2.ShadowDecoration.Depth = 5
        Me.Guna2GradientPanel2.ShadowDecoration.Enabled = True
        Me.Guna2GradientPanel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(15, 5, 5, 18)
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(409, 266)
        Me.Guna2GradientPanel2.TabIndex = 67
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(451, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 493)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'SendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(872, 567)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.BTNclear)
        Me.Controls.Add(Me.BTNfile)
        Me.Controls.Add(Me.BTNsendEmail)
        Me.Controls.Add(Me.FileLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNminimize)
        Me.Controls.Add(Me.EXITbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SendEmail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SendEmail"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BTNminimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents EXITbtn As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents TxtToMail As TextBox
    Friend WithEvents TxtMailSubject As TextBox
    Friend WithEvents TxtMailMessage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FileLabel As Label
    Friend WithEvents BTNsendEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BTNclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
