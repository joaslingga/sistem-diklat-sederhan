Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public str As String
    Public Sub koneksi()
        str = "provider=microsoft.jet.oledb.4.0;data source=db_hotel.mdb"
        Conn = New OleDbConnection(str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()

        End If
        MsgBox("Koneksi Berhasil, silakan tekan OK ")

    End Sub
End Module
