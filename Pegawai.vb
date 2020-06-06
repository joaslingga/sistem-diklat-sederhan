Imports System.Data.OleDb
Public Class Pegawai
    Public Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Frm_MenuUtama.Show()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Pegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TAMPIL()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("Laki Laki ")
        Me.ComboBox1.Items.Add("Perempuan ")
    End Sub
    Public Sub TAMPIL()
        da = New OleDbDataAdapter("Select * from Pegawai", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pegawai")
        DataGridView1.DataSource = (ds.Tables("Pegawai"))
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TextBox1.Focus()
            Exit Sub
        Else
            Try
                Dim com As New OleDbCommand

                com.Connection = Conn


                com.CommandText = "insert into Pegawai values('" & TextBox1.Text & " ' ,'" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
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

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ole As String
        ole = "UPDATE Pegawai SET Nama=" & _
            "'" & TextBox2.Text & "' ,Alamat='" & TextBox3.Text & "',Jenis_kelamin='" & ComboBox1.Text & "',No_tlp='" & TextBox5.Text & "',Jabatan='" & TextBox5.Text & "'Where NIP= '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(ole, Conn)
        cmd.ExecuteNonQuery()
        TAMPIL()
        bersih()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ole As String
        Dim PSN As String
        PSN = MsgBox("APAKAH YAKIN DIHAPUS", vbQuestion + vbYesNo, "KONFIRMASI")
        If PSN = vbYes Then
            ole = "DELETE FROM Pegawai WHERE NIP='" & TextBox1.Text & "'"
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

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r As String
        r = InputBox("Masukkan NIP : ", "PENCARIAN")

        cmd = New OleDbCommand("SELECT * FROM Pegawai WHERE NIP= '" & r & "'", Conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox1.Text = rd.Item("NIP")
            TextBox2.Text = rd.Item("Nama")
            TextBox3.Text = rd.Item("Alamat")
            ComboBox1.Text = rd.Item("Jenis_kelamin")
            TextBox5.Text = rd.Item("No_tlp")
            TextBox6.Text = rd.Item("Jabatan")
        Else
            MsgBox("DATA TIDAK DITEMUKAN")
        End If
        rd.Close()
       
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class