Imports System.Data.OleDb
Public Class RegisterForm

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxFname.Text = "" Or TextBoxLname.Text = "" Or TextBoxEmail.Text = "" Or TextBoxPassword.Text = "" Then
            MsgBox("Input (name, email ord password) must be filled!")
        Else
            Call Koneksi()
            Cmd = New OleDbCommand("insert into TB_USER values (" & GetRandom(10, 30) & ", '" & TextBoxFname.Text & "','" & TextBoxLname.Text & "','" & TextBoxEmail.Text & "','" & TextBoxPassword.Text & "', 'user', 0, '04/30/2021')", Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Signup success.")

            Me.Hide()
            LoginForm.Show()
        End If
        Rd.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class