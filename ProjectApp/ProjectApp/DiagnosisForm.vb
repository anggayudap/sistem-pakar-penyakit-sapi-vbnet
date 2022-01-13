Imports System.Data.OleDb
Public Class DiagnosisForm
    Dim source As New BindingSource

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub DiagnosisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_AplikasiaccdbDataSet.TB_SYMPTOM' table. You can move, or remove it, as needed.
        Me.TB_SYMPTOMTableAdapter.Fill(Me.DB_AplikasiaccdbDataSet.TB_SYMPTOM)
        'Dim strings() As String = {}

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Dim list As New List(Of String)()
        If DataGridView1.Columns(e.ColumnIndex).Name.ToString = "checklist" Then
            'list.Add("ass")
            SymptomArr.Add(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(SymptomArr(0))
        Dim Symp As String = SymptomArr(SymptomArr.Count - 1)
        'Dim lngth As Integer = SymptomArr.Count()

        Call Koneksi()
        Cmd = New OleDbCommand("select * from TB_KNOWLEDGE where diase_code = '" & Symp & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows Then
            'MsgBox(Rd(2).ToString())
            Dim DiseaseSelected As String = Rd(2).ToString()
            Call Koneksi()
            Cmd = New OleDbCommand("insert into TB_DIAGNOSIS values (" & GetRandom(5, 30) & ", '" & UserID & "','" & DiseaseSelected & "','" & GetRandom(40, 80) & "', '04/24/2021')", Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Success! See result in Diagnosis Report.")
            Me.Close()

        End If
    End Sub
End Class