<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridViewForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BTNexit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BTNminimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.EXITbtn = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.jdpnhs = New System.Windows.Forms.Label()
        Me.BTNrefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Label_Connection = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.BTNexit)
        Me.Panel1.Controls.Add(Me.BTNminimize)
        Me.Panel1.Controls.Add(Me.EXITbtn)
        Me.Panel1.Controls.Add(Me.jdpnhs)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1446, 48)
        Me.Panel1.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1362, 14)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(26, 21)
        Me.Guna2ControlBox1.TabIndex = 67
        '
        'BTNexit
        '
        Me.BTNexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BTNexit.CustomClick = True
        Me.BTNexit.CustomIconSize = 50.0!
        Me.BTNexit.FillColor = System.Drawing.Color.Transparent
        Me.BTNexit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNexit.HoverState.IconColor = System.Drawing.Color.White
        Me.BTNexit.IconColor = System.Drawing.Color.White
        Me.BTNexit.Location = New System.Drawing.Point(1395, 14)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(26, 21)
        Me.BTNexit.TabIndex = 66
        '
        'BTNminimize
        '
        Me.BTNminimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNminimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BTNminimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.BTNminimize.FillColor = System.Drawing.Color.Transparent
        Me.BTNminimize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BTNminimize.HoverState.IconColor = System.Drawing.Color.White
        Me.BTNminimize.IconColor = System.Drawing.Color.White
        Me.BTNminimize.Location = New System.Drawing.Point(2428, 14)
        Me.BTNminimize.Name = "BTNminimize"
        Me.BTNminimize.Size = New System.Drawing.Size(26, 21)
        Me.BTNminimize.TabIndex = 65
        '
        'EXITbtn
        '
        Me.EXITbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EXITbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.EXITbtn.CustomClick = True
        Me.EXITbtn.CustomIconSize = 50.0!
        Me.EXITbtn.FillColor = System.Drawing.Color.Transparent
        Me.EXITbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EXITbtn.HoverState.IconColor = System.Drawing.Color.White
        Me.EXITbtn.IconColor = System.Drawing.Color.White
        Me.EXITbtn.Location = New System.Drawing.Point(2461, 14)
        Me.EXITbtn.Name = "EXITbtn"
        Me.EXITbtn.Size = New System.Drawing.Size(26, 21)
        Me.EXITbtn.TabIndex = 64
        '
        'jdpnhs
        '
        Me.jdpnhs.AutoSize = True
        Me.jdpnhs.BackColor = System.Drawing.Color.Transparent
        Me.jdpnhs.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.jdpnhs.ForeColor = System.Drawing.SystemColors.Control
        Me.jdpnhs.Location = New System.Drawing.Point(22, 14)
        Me.jdpnhs.Name = "jdpnhs"
        Me.jdpnhs.Size = New System.Drawing.Size(280, 21)
        Me.jdpnhs.TabIndex = 63
        Me.jdpnhs.Text = "Jesus Dela Peña National High School"
        '
        'BTNrefresh
        '
        Me.BTNrefresh.BackColor = System.Drawing.Color.Transparent
        Me.BTNrefresh.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BTNrefresh.BorderRadius = 15
        Me.BTNrefresh.BorderThickness = 2
        Me.BTNrefresh.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BTNrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNrefresh.FillColor = System.Drawing.Color.Transparent
        Me.BTNrefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNrefresh.ForeColor = System.Drawing.Color.White
        Me.BTNrefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BTNrefresh.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTNrefresh.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BTNrefresh.Location = New System.Drawing.Point(1301, 78)
        Me.BTNrefresh.Name = "BTNrefresh"
        Me.BTNrefresh.PressedColor = System.Drawing.Color.White
        Me.BTNrefresh.ShadowDecoration.BorderRadius = 20
        Me.BTNrefresh.ShadowDecoration.Depth = 5
        Me.BTNrefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNrefresh.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.BTNrefresh.Size = New System.Drawing.Size(86, 32)
        Me.BTNrefresh.TabIndex = 67
        Me.BTNrefresh.Text = "REFRESH"
        '
        'Label_Connection
        '
        Me.Label_Connection.AutoSize = True
        Me.Label_Connection.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Connection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Connection.Location = New System.Drawing.Point(146, 78)
        Me.Label_Connection.Name = "Label_Connection"
        Me.Label_Connection.Size = New System.Drawing.Size(82, 20)
        Me.Label_Connection.TabIndex = 66
        Me.Label_Connection.Text = "Connected"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Database Status :"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(26, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1391, 692)
        Me.DataGridView1.TabIndex = 68
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 25
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1078, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 54)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "System"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(681, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(414, 54)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Student Management"
        '
        'DataGridViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1442, 860)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNrefresh)
        Me.Controls.Add(Me.Label_Connection)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "DataGridViewForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNminimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents EXITbtn As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents jdpnhs As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BTNexit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label_Connection As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTNrefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
End Class
