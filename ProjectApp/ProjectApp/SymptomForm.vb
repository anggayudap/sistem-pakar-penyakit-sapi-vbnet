Public Class SymptomForm
    Private Sub SymptomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_AplikasiaccdbDataSet.TB_SYMPTOM' table. You can move, or remove it, as needed.
        Me.TB_SYMPTOMTableAdapter.Fill(Me.DB_AplikasiaccdbDataSet.TB_SYMPTOM)

    End Sub
End Class