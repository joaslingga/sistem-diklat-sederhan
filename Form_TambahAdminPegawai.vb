Imports System.Data.OleDb
Public Class Form_TambahAdminPegawai

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TextBox1.Focus()
            Exit Sub
        Else

            Try
                Dim com As New OleDbCommand
                com.Connection = Conn
                com.CommandText = "insert into Login values('" & TextBox1.Text & "' ,'" & TextBox2.Text & "' ,'" & TextBox3.Text & "', '" & TextBox4.Text & "')"
                com.ExecuteNonQuery()

                MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call koneksi()
                Bersih()

            Catch exp As Exception
                MsgBox(exp.ToString())
            End Try
        End If
    End Sub
    Public Sub Bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Form_TambahPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Frm_login.Show()
    End Sub
End Class