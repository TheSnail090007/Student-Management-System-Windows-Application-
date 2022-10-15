
Imports System.Data.OleDb
Public Class Form1
    'DATA CONNECTION
    Dim query As String 'SQL STATEMENTS INSERT, SEARCH, DELETE, UPDATE
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\VB.NET PROJECS\CRUDSMSbambam\Database\StudentManagementSystem.accdb")
    Dim cmd As New OleDbCommand(query, con)
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter()
    Dim dt As New DataTable()
    Dim dset As New DataSet
    Dim bytImage() As Byte


    Public Sub ClearTextBox()
        TextBoxLRN.Text = ""
        TextBoxFullName.Text = ""
        ComboBoxGen.SelectedIndex = Nothing
        TextBoxAge.Text = ""
        ' DateTimePicker.Value = Nothing
        TextBoxCourse.Text = ""
        TextBoxSection.Text = ""
        PictureBox.Image = Nothing
        TextBoxLRN.Focus()

    End Sub

    Public Sub BindData()

        da = New OleDbDataAdapter("Select * FROM StudentInfoTbl", con)
        dset = New DataSet
        da.Fill(dset, "StudentInfoTbl")
        DataGridView1.DataSource = dset.Tables("StudentInfoTbl").DefaultView
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = True
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        con.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            Label_Connection.Text = "Connected"
            'BindData()
            Label_Connection.ForeColor = Color.FromArgb(77, 200, 135)

            con.Close()
        Catch ex As Exception
            Label_Connection.Text = "Disconnected"
            Label_Connection.ForeColor = Color.Red
            MessageBox.Show("Database connection failed" & vbCrLf & "Please contact the admin", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'con.Close()
    End Sub

    Private Sub BTNinsert_Click(sender As Object, e As EventArgs) Handles BTNinsert.Click

        If TextBoxLRN.Text = "" Or TextBoxFullName.Text = "" Or TextBoxAge.Text = "" Or TextBoxCourse.Text = "" Or TextBoxSection.Text = "" Then
            MessageBox.Show("Please fill the required fields", "Insert data", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        ElseIf con.State = ConnectionState.Closed Then

            Dim ms As New System.IO.MemoryStream
            Dim bmpImage As New Bitmap(PictureBox.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            bytImage = ms.ToArray()
            ms.Close()

            con.Open()
            query = "INSERT INTO StudentInfoTbl ([LRN], [FULLNAME], [GENDER], [AGE], [BIRTHDAY], [COURSE], [SECTION], [IMAGE]) 
                 VALUES (@lrn, @FullName, @Gender, @Age, @Birthday, @Course, @Section, @Image)"

            cmd.Connection = con
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@Lrn", TextBoxLRN.Text)
            cmd.Parameters.AddWithValue("@FullName", TextBoxFullName.Text)
            cmd.Parameters.AddWithValue("@Gender", ComboBoxGen.SelectedItem)
            cmd.Parameters.AddWithValue("@Age", TextBoxAge.Text)
            cmd.Parameters.AddWithValue("@Birthday", DateTimePicker.Value)
            cmd.Parameters.AddWithValue("@Course", TextBoxCourse.Text)
            cmd.Parameters.AddWithValue("@Section", TextBoxSection.Text)
            cmd.Parameters.AddWithValue("@Image", bytImage)

            cmd.ExecuteNonQuery()
            MessageBox.Show("New record has been successfully saved!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearTextBox()
            BindData()
            con.Close()
            cmd.Dispose()

        Else 'AYAW GUMANA  (GUMAMIT NG SELECT CLAUSE) 
            '    If dt.Rows.Count > 0 Then
            MessageBox.Show("Record already exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        con.Close()
            '    End If

        End If

    End Sub

    Private Sub BTNupdate_Click(sender As Object, e As EventArgs) Handles BTNupdate.Click

        If TextBoxLRN.Text = "" Or TextBoxFullName.Text = "" Or TextBoxAge.Text = "" Or TextBoxCourse.Text = "" Or TextBoxSection.Text = "" Then
            MessageBox.Show("Please fill the required fields", "Insert data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Try
            Dim Lrn As Integer = TextBoxLRN.Text
            Dim FullName As String = TextBoxFullName.Text
            Dim Gender As String = ComboBoxGen.SelectedItem
            Dim Age As String = TextBoxAge.Text
            Dim Birthday As Date = DateTimePicker.Value
            Dim Course As String = TextBoxCourse.Text
            Dim Section As String = TextBoxSection.Text
            Dim bytImage() As Byte

            Dim ms As New System.IO.MemoryStream
            Dim bmpImage As New Bitmap(PictureBox.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            bytImage = ms.ToArray()
            ms.Close()

            con.Open()
            query = "UPDATE StudentInfoTbl 
                 SET [FULLNAME]=@FullName, [GENDER]=@Gender, [AGE]=@Age, [BIRTHDAY]=@Birthday, [COURSE]=@Course, [SECTION]=@Section, [IMAGE]=@Image
                 WHERE [LRN]=@Lrn"

            cmd.Connection = con
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@FullName", FullName)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Age", Age)
            cmd.Parameters.AddWithValue("@Birthday", Birthday)
            cmd.Parameters.AddWithValue("@Course", Course)
            cmd.Parameters.AddWithValue("@Section", Course)
            cmd.Parameters.AddWithValue("@Image", bytImage)
            cmd.Parameters.AddWithValue("@Lrn", Lrn)

            cmd.ExecuteNonQuery()
            MessageBox.Show(TextBoxLRN.Text & "Record has been successfully updated!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearTextBox()
            BindData()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub BTNdelete_Click(sender As Object, e As EventArgs) Handles BTNdelete.Click
        If TextBoxLRN.Text = "" Or TextBoxFullName.Text = "" Or TextBoxAge.Text = "" Or TextBoxCourse.Text = "" Or TextBoxSection.Text = "" Then
            MessageBox.Show("Please fill the required fields", "Insert data", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        Dim LRN As Integer = TextBoxLRN.Text

        con.Open()
        query = "DELETE FROM StudentInfoTbl WHERE [LRN] = @LRN"
        cmd.Connection = con
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@LRN", LRN)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show(TextBoxLRN.Text & "Record has been successfully deleted!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearTextBox()
        BindData()
        cmd.Dispose()
    End Sub

    Private Sub BTNsearch_Click(sender As Object, e As EventArgs) Handles BTNsearch.Click

        'Dim img() As Byte
        Try

            Dim IBsearch As String = InputBox("Jesus Dela Peña National High School - Student Information System",
                                      "DepEd Learning Reference Number (LRN)",
                                      "Enter Student's LRN to search name")




            con.Open()
            query = "SELECT * FROM StudentInfoTbl WHERE LRN=" & CInt(IBsearch)
            cmd.Connection = con
            cmd.CommandText = query
            dr = cmd.ExecuteReader


            If dr.Read() Then


                TextBoxLRN.Text = dr("LRN").ToString
                TextBoxFullName.Text = dr("FULLNAME").ToString
                ComboBoxGen.SelectedItem = dr("GENDER").ToString
                TextBoxAge.Text = dr("AGE").ToString
                DateTimePicker.Value = dr("BIRTHDAY").ToString
                TextBoxCourse.Text = dr("COURSE").ToString
                TextBoxSection.Text = dr("SECTION").ToString
                Dim data As Byte() = dr("IMAGE")
                Using ms As New IO.MemoryStream(data)
                    PictureBox.Image = Image.FromStream(ms)
                End Using

                BindData()
                con.Close()


                'https://www.youtube.com/watch?v=49sb8PCnAS4
                'mstream.Close()

                'ETO PANOORIN MO ULIT https://www.youtube.com/watch?v=zFdjp39mfhQ

            ElseIf dr.Read = False Then
                MessageBox.Show("Student LRN not found.",
            "Please enter valid information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
                dr.Close()
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        cmd.Dispose()

    End Sub

    Private Sub BTNclear_Click(sender As Object, e As EventArgs) Handles BTNclear.Click
        ClearTextBox()
    End Sub

    Private Sub BTNrefresh_Click(sender As Object, e As EventArgs) Handles BTNrefresh.Click
        BindData()
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

    Private Sub EXITbtn_Click(sender As Object, e As EventArgs) Handles EXITbtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to close the form?", "STUDENT INFORMATION SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Close()
            DataGridViewForm.Close()
            SendEmail.Close()
        End If
    End Sub

    Private Sub BTNemailadmin_Click(sender As Object, e As EventArgs) Handles BTNemailadmin.Click
        SendEmail.Show()
    End Sub

    Private Sub BTNshow_Click(sender As Object, e As EventArgs) Handles BTNshow.Click
        DataGridViewForm.Show()
    End Sub

    Private Sub BTNbrowse_Click(sender As Object, e As EventArgs) Handles BTNbrowse.Click

        Try
            Dim imgpath As String
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox.Image = Image.FromFile(dialog.FileName)
                imgpath = dialog.FileName
                PictureBox.ImageLocation = imgpath
            Else
                MessageBox.Show("Nothing was selected.", "Student Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            dialog = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub






    'Private Sub BTNbrowse_Click(sender As Object, e As EventArgs) Handles BTNbrowse.Click

    '    'https://itsourcecode.com/free-projects/vb-net/insert-image-access-database-vb-net/
    '    Try

    '        Dim OFD As FileDialog = New OpenFileDialog()

    '        OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

    '        If OFD.ShowDialog() = DialogResult.OK Then
    '            imgpath = OFD.FileName
    '            PictureBox.ImageLocation = imgpath
    '        Else
    '            MessageBox.Show("Nnthing was selected.", "Student Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    '        End If

    '        OFD = Nothing

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString())
    '    End Try

    'End Sub
End Class


'da.SelectCommand = cmd
'da.Fill(dt)
'DataGridView1.DataSource = dt
