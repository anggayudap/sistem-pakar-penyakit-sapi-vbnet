Imports System.Data.OleDb
Public Class LoginForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "X"

        Call Koneksi()
        Cmd = New OleDbCommand("select * from TB_USER where current_login = 1", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows Then
            NameUser = Rd(1).ToString()
            EmailUser = Rd(3).ToString()
            AdminLevel = Rd(5).ToString()

            MainmenuForm.Show()
            Me.Close()
        Else
            NameUser = ""
            EmailUser = ""
            AdminLevel = ""
        End If
        'MsgBox(NameUser)
        'MsgBox(EmailUser)
        'MsgBox(AdminLevel)

        Rd.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "X"
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Email or Password field still empty!")
        Else
            Call Koneksi()
            Cmd = New OleDbCommand("select * from TB_USER where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                'MsgBox(Rd(0).ToString())
                'MsgBox(Rd(1).ToString())
                'MsgBox(Rd(2).ToString())
                'MsgBox(Rd(3).ToString())
                'MsgBox(Rd(4).ToString())
                'MsgBox(Rd(5).ToString())
                'MsgBox(Rd(6).ToString())
                UserID = Rd(0).ToString()
                NameUser = Rd(1).ToString()
                EmailUser = Rd(3).ToString()
                AdminLevel = Rd(5).ToString()

                Call Koneksi()
                Cmd = New OleDbCommand("update TB_USER set current_login = 1 where user_id = " & UserID & "", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                Me.Hide()
                MainmenuForm.Show()
            Else
                MsgBox("Login failed. Wrong Email or Password!")
            End If
            Rd.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub
End Class