
Imports System.Data.OleDb
Public Class Pengunjung
    Private Sub Pengunjung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TAMPIL()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        edit_pengunjung.Show()
    End Sub
    Public Sub TAMPIL()
        da = New OleDbDataAdapter("Select * from cek_in", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "cek_in")
        DataGridView1.DataSource = (ds.Tables("cek_in"))
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Frm_MenuUtama.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class