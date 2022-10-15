Public Class Login
    Private Sub BTNlogin_Click(sender As Object, e As EventArgs) Handles BTNlogin.Click


        'Admin
        'Superintendent
        'Principal
        'Dim count As Integer = 0

        Try
            Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\VB.NET PROJECS\CRUDSMSbambam\Database\StudentManagementSystem.accdb")
            Dim query As String = "SELECT * FROM LoginAdminTbl WHERE USERNAME = '" & TextBoxUser.Text & "' AND PASSWORD = '" & TextBoxPass.Text & "' AND USERTYPE = '" & ComboBox.SelectedItem & "'"
            Dim dt As New DataTable
            Dim cmd As New OleDb.OleDbCommand(query, con) With {
                .Connection = con,
                .CommandText = query
            }

            con.Open()
            Dim sqlRead As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If sqlRead.Read() Then

                'If dt.Rows.Count > 0 Then

                If ComboBox.SelectedIndex = 0 Then
                    MessageBox.Show("You are now logged in as Admin", "Database Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Form1.Show()
                ElseIf ComboBox.SelectedIndex = 1 Then
                    MessageBox.Show("You are now logged in as Teacher", "Database Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Form1.Show()
                End If
                'End If

            ElseIf TextBoxUser.Text = "" And TextBoxPass.Text = "" Then
                MessageBox.Show("Please enter username and password", "Logged in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf TextBoxUser.Text = "" Then
                MessageBox.Show("Please enter username textfield", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf TextBoxPass.Text = "" Then
                MessageBox.Show("Please enter password textfield", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Username and Password do not match", "Logged in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBoxPass.Text = ""
                TextBoxUser.Clear()
                TextBoxUser.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to database", "AUTHENTICATION ERROR",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EXITbtn_Click(sender As Object, e As EventArgs) Handles EXITbtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to close the form?",
"Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub


    'MOVE BORDERLESS FORM
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub ToggleSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleSwitch.CheckedChanged
        If ToggleSwitch.Checked Then
            TextBoxPass.PasswordChar = ""
        Else
            TextBoxPass.PasswordChar = "•"
        End If
    End Sub


End Class















'Try
'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\VB.NET PROJECS\CRUDSMSbambam\Database\StudentManagementSystem.accdb")
'Dim query As String = "SELECT * FROM LoginAdminTbl WHERE USERNAME='" & TextBoxUser.Text & "' AND PASSWORD = '" & TextBoxPass.Text & "' "
'Dim cmd As New OleDb.OleDbCommand(query, con) With {
'                .Connection = con,
'                .CommandText = query
'            }

'con.Open()
'Dim sqlRead As OleDb.OleDbDataReader = cmd.ExecuteReader()
'If sqlRead.Read() Then

'If ComboBox.SelectedItem = 1 Then

'End If


'MessageBox.Show("You are now logged in", "Database Login Successfuly",
'                MessageBoxButtons.OK, MessageBoxIcon.Information)
'Me.Hide()
'Form1.Show()
'ElseIf TextBoxUser.Text = "" And TextBoxPass.Text = "" Then
'MessageBox.Show("Please enter username and password", "Logged in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'ElseIf TextBoxUser.Text = "" Then
'MessageBox.Show("Please enter username textfield", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'ElseIf TextBoxPass.Text = "" Then
'MessageBox.Show("Please enter password textfield", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'ElseIf TextBoxUser.Text <> "jdpadmin" Then
'MessageBox.Show("Username did not match", "Logged in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'TextBoxPass.Text = ""
'TextBoxUser.Clear()
'TextBoxUser.Focus()
'ElseIf TextBoxPass.Text <> "jdpadmin8000" Then
'MessageBox.Show("Password did not match", "Logged in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'TextBoxPass.Text = ""
'TextBoxUser.Clear()
'TextBoxUser.Focus()
'Else
'MessageBox.Show("Username and Password do not match", "Logged in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'TextBoxPass.Text = ""
'TextBoxUser.Clear()
'TextBoxUser.Focus()
'End If
'Catch ex As Exception
'MessageBox.Show("Failed to connect to database", "AUTHENTICATION ERROR",
'            MessageBoxButtons.OK, MessageBoxIcon.Error)
'End Try
'End Sub