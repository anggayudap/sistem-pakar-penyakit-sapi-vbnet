Imports System.Data.OleDb
Public Class User2Form

    Sub KondisiAwal()
        Call Koneksi()
        Dm = New OleDbDataAdapter("Select * from TB_USER", Conn)
        Ds = New DataSet
        Ds.Clear()
        Dm.Fill(Ds, "TB_USER")
        DataGridView1.DataSource = (Ds.Tables("TB_USER"))
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        'TextBox3.Text = ""
        'TextBox4.Text = ""
        'ComboBox1.Items.Clear()
        'ComboBox1.Items.Add("PCS")
        'ComboBox1.Items.Add("BOX")
        'ComboBox1.Items.Add("BOTOL")
    End Sub
    Private Sub User2Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_AplikasiaccdbDataSet.TB_USER' table. You can move, or remove it, as needed.
        'Me.TB_USERTableAdapter.Fill(Me.DB_AplikasiaccdbDataSet.TB_USER)
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class