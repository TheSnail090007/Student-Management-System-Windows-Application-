<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressIndicator = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressIndicator
        '
        Me.ProgressIndicator.AutoStart = True
        Me.ProgressIndicator.Location = New System.Drawing.Point(159, 173)
        Me.ProgressIndicator.Name = "ProgressIndicator"
        Me.ProgressIndicator.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ProgressIndicator.Size = New System.Drawing.Size(92, 117)
        Me.ProgressIndicator.TabIndex = 57
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 6000
        Me.Timer1.Tag = ""
        '
        'TextStatus
        '
        Me.TextStatus.AutoSize = True
        Me.TextStatus.BackColor = System.Drawing.Color.Transparent
        Me.TextStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.TextStatus.Location = New System.Drawing.Point(74, 458)
        Me.TextStatus.Name = "TextStatus"
        Me.TextStatus.Size = New System.Drawing.Size(280, 21)
        Me.TextStatus.TabIndex = 58
        Me.TextStatus.Text = "Jesus Dela Peña National High School"
        Me.TextStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 522)
        Me.Controls.Add(Me.TextStatus)
        Me.Controls.Add(Me.ProgressIndicator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadingForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressIndicator As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextStatus As Label
End Class
