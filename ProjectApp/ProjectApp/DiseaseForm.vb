Public Class DiseaseForm
    Private Sub DiseaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_AplikasiaccdbDataSet.TB_DISEASE' table. You can move, or remove it, as needed.
        Me.TB_DISEASETableAdapter.Fill(Me.DB_AplikasiaccdbDataSet.TB_DISEASE)

    End Sub
End Class