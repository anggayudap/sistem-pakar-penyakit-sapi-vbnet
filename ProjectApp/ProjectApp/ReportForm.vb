Imports System.Data.OleDb
Public Class ReportForm
    Sub KondisiAwal()
        Call Koneksi()
        Cmd = New OleDbCommand(" select a.diagnosis_id, a.user_id, a.diagnosis_date, b.diase_name, b.diase_description, b.diase_solution  
from (TB_DIAGNOSIS a
inner join TB_DISEASE b on a.disease=b.diase_code)
where a.user_id = '" & UserID & "'

 ", Conn)
        Dm = New OleDbDataAdapter
        Dm.SelectCommand = Cmd

        Dim table1 As New DataTable

        table1.Clear()

        Dm.Fill(table1)

        DataGridView1.DataSource = table1

        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "User ID"
        DataGridView1.Columns(2).HeaderText = "Date"
        DataGridView1.Columns(3).HeaderText = "Diase Name"
        DataGridView1.Columns(4).HeaderText = "Disease Description"
        DataGridView1.Columns(5).HeaderText = "Disease Solution"


        Conn.Close()

    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name.ToString = "diase_name" Then
            'SymptomArr.Add(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
            MsgBox(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name.ToString = "diase_description" Then
            'SymptomArr.Add(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
            MsgBox(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name.ToString = "diase_solution" Then
            'SymptomArr.Add(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
            MsgBox(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
        End If
    End Sub
End Class