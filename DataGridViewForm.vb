Imports System.Data.OleDb
Public Class DataGridViewForm

    Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\VB.NET PROJECS\CRUDSMSbambam\Database\StudentManagementSystem.accdb"
    Dim conn As New OleDbConnection(connStr)
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Private Sub DataGridViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Label_Connection.Text = "Connected"
            Label_Connection.ForeColor = Color.FromArgb(0, 192, 0)
            conn.Close()
        Catch ex As Exception
            Label_Connection.Text = "Disconnected"
            Label_Connection.ForeColor = Color.Red
            MessageBox.Show("Database connection failed" & vbCrLf & "Please contact the admin", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        da = New OleDbDataAdapter("Select * FROM StudentInfoTbl", conn)
        dset = New DataSet
        da.Fill(dset, "StudentInfoTbl")
        DataGridView1.DataSource = dset.Tables("StudentInfoTbl").DefaultView
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = True
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub

    Private Sub BTNrefresh_Click(sender As Object, e As EventArgs) Handles BTNrefresh.Click
        da = New OleDbDataAdapter("Select * FROM StudentInfoTbl", conn)
        dset = New DataSet
        da.Fill(dset, "StudentInfoTbl")
        DataGridView1.DataSource = dset.Tables("StudentInfoTbl").DefaultView
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = True
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to close the form?", "STUDENT INFORMATION SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub




    'MOVE BORDERLESS FORM
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

End Class