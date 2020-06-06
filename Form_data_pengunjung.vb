Imports System.Data.OleDb
Public Class Form_data_pengunjung
        Public Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

        End Sub
        Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        End Sub

        Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        End Sub

        Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

        End Sub

        Private Sub Form_data_pengunjung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TAMPIL()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("Laki Laki ")
        Me.ComboBox1.Items.Add("Perempuan ")
    End Sub
    Public Sub TAMPIL()
        da = New OleDbDataAdapter("Select * from daftar_pengunjung", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "daftar_pengunjung")
        DataGridView1.DataSource = (ds.Tables("daftar_pengunjung"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TextBox1.Focus()
            Exit Sub
        Else
            Try
                Dim com As New OleDbCommand

                com.Connection = Conn


                com.CommandText = "insert into daftar_pengunjung values('" & TextBox1.Text & "' ,'" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ole As String
        ole = "UPDATE daftar_pengunjung SET Nama=" & _
            "'" & TextBox2.Text & "' ,Jenis_kelamin='" & ComboBox1.Text & "',Alamat='" & TextBox3.Text & "',No_kamar='" & TextBox4.Text & "',tgl_masuk='" & TextBox5.Text & "',tgl_keluar ='" & TextBox6.Text & "',Instansi='" & TextBox7.Text & "',Keterangan ='" & TextBox8.Text & "' Where NIK= '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(ole, Conn)
        cmd.ExecuteNonQuery()
        TAMPIL()
        bersih()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r As String
        r = InputBox("Masukkan NIK : ", "PENCARIAN")

        cmd = New OleDbCommand("SELECT * FROM daftar_pengunjung WHERE NIK= '" & r & "'", Conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox1.Text = rd.Item("NIK")
            TextBox2.Text = rd.Item("Nama")
            ComboBox1.Text = rd.Item("Jenis_kelamin")
            TextBox3.Text = rd.Item("Alamat")
            TextBox4.Text = rd.Item("No_kamar")
            TextBox5.Text = rd.Item("tgl_masuk")
            TextBox6.Text = rd.Item("tgl_keluar")
            TextBox7.Text = rd.Item("Instansi")
            TextBox8.Text = rd.Item("Keterangan")
            TextBox9.Text = rd.Item("Status")
        Else
            MsgBox("DATA TIDAK DITEMUKAN")
        End If
        rd.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ole As String
        Dim PSN As String
        PSN = MsgBox("APAKAH YAKIN DIHAPUS", vbQuestion + vbYesNo, "KONFIRMASI")
        If PSN = vbYes Then
            ole = "DELETE FROM daftar_pengunjung WHERE NIK='" & TextBox1.Text & "'"
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
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Frm_MenuUtama.Show()
    End Sub
End Class