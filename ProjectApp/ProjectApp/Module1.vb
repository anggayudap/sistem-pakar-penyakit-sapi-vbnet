Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Dm As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Dim LokasiDB As String

    Public UserID As Integer = 0
    Public NameUser As String
    Public EmailUser As String
    Public AdminLevel As String

    Public SymptomArr As New List(Of String)()

    Public Sub Koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;data source=DB_Aplikasiaccdb.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()

    End Sub
End Module
