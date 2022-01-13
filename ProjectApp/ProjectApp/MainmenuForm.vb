Imports System.Data.OleDb
Public Class MainmenuForm
    Private Sub DiagnosisReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosisReportToolStripMenuItem.Click
        ReportForm.MdiParent = Me
        ReportForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.MdiParent = Me
        AboutForm.Show()
    End Sub

    Private Sub FormMenuUtama_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim childFrm As New SymptomForm
        childFrm.MdiParent = Me

    End Sub



    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim result = MessageBox.Show(NameUser & ", Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result = MessageBox.Show(NameUser & ", Are you sure you want to Logout", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Call Koneksi()
            Cmd = New OleDbCommand("update TB_USER set current_login = 0 ", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Close()
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        If AdminLevel = "admin" Then
            User2Form.MdiParent = Me
            User2Form.Show()
        End If
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If AdminLevel = "admin" Then
        'Me.MasterToolStripMenuItem.Visible = False
        'End If
    End Sub

    Private Sub DiseaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiseaseToolStripMenuItem.Click
        If AdminLevel = "admin" Then
            DiseaseForm.MdiParent = Me
            DiseaseForm.Show()
        End If
    End Sub

    Private Sub KnowledgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KnowledgeToolStripMenuItem.Click
        If AdminLevel = "admin" Then
            KnowledgeForm.MdiParent = Me
            KnowledgeForm.Show()
        End If
    End Sub

    Private Sub SymptomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymptomToolStripMenuItem.Click
        If AdminLevel = "admin" Then
            SymptomForm.MdiParent = Me
            SymptomForm.Show()
        End If
    End Sub

    Private Sub NewDiagnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDiagnoToolStripMenuItem.Click
        DiagnosisForm.MdiParent = Me
        DiagnosisForm.Show()
    End Sub
End Class
