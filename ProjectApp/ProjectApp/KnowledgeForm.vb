Public Class KnowledgeForm
    Private Sub KnowledgeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_AplikasiaccdbDataSet.TB_KNOWLEDGE' table. You can move, or remove it, as needed.
        Me.TB_KNOWLEDGETableAdapter.Fill(Me.DB_AplikasiaccdbDataSet.TB_KNOWLEDGE)

    End Sub
End Class