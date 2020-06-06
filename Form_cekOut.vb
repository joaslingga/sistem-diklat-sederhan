Imports System.Data.OleDb
Public Class Form_cekOut

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TextBox1.Focus()
            Exit Sub
        Else
            Try
                Dim com As New OleDbCommand

                com.Connection = Conn


                com.CommandText = "insert into cek_in values('" & TextBox1.Text & " ' ,'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
                com.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call koneksi()
                Call TAMPIL()
                bersih()
            Catch exp As Exception
                MsgBox(exp.ToString())
            End Try
        End If
    End Sub

    Private Sub Form_cekOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TAMPIL()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ole As String
        ole = "UPDATE cek_out SET Nama=" & _
            "'" & TextBox2.Text & "' ,kode_pengunjung='" & TextBox3.Text & "',nama_pengunjung='" & TextBox4.Text & "',nama2='" & TextBox5.Text & "',nama3='" & TextBox6.Text & "',tgl_keluar ='" & TextBox7.Text & "',Instansi='" & TextBox8.Text & "'keterangan ='" & TextBox9.Text & "', status='" & TextBox10.Text & "' Where NIK= '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(ole, Conn)
        cmd.ExecuteNonQuery()
        TAMPIL()
        bersih()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ole As String
        Dim PSN As String
        PSN = MsgBox("APAKAH YAKIN DIHAPUS", vbQuestion + vbYesNo, "KONFIRMASI")
        If PSN = vbYes Then
            ole = "DELETE FROM cek_in WHERE no_kamar='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(ole, Conn)
            Dim a As Integer = cmd.ExecuteNonQuery
            If a = 1 Then
                MessageBox.Show("DATA BERHASIL DIHAPUS")
            Else
                MessageBox.Show("GAGAL HAPUS DATA")
            End If

            Call TAMPIL()
            bersih()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox9.Clear()
        TextBox10.Clear()

    End Sub
    Public Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

    End Sub
    Public Sub TAMPIL()
        da = New OleDbDataAdapter("Select * from cek_in", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "cek_in")
        DataGridView1.DataSource = (ds.Tables("cek_in"))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim r As String
        r = InputBox("Masukkan Kode pengunjung : ", "PENCARIAN")

        cmd = New OleDbCommand("SELECT * FROM cek_in WHERE kode_pengunjung= '" & r & "'", Conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox1.Text = rd.Item("no_kamar")
            TextBox2.Text = rd.Item("kode_pengunjung")
            TextBox3.Text = rd.Item("nama_pengunjung")
            TextBox4.Text = rd.Item("nama2")
            TextBox5.Text = rd.Item("nama3")
            TextBox6.Text = rd.Item("tgl_masuk")
            TextBox7.Text = rd.Item("tgl_keluar")
            TextBox8.Text = rd.Item("Instansi")
            TextBox9.Text = rd.Item("keterangan")
            TextBox10.Text = rd.Item("status")

        Else
            MsgBox("DATA TIDAK DITEMUKAN")
        End If
        rd.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Frm_MenuUtama.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class