Public Class Frm_MenuUtama
    Dim tulisan(3) As String
    Dim i, j As Integer
    Private Sub Frm_MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tulisan(0) = "Selamat Datang Di Asrma P4TK bbl Medan"
        tulisan(1) = "Silakan Pilih Home... "
        tulisan(2) = "Pilih Yg di Perlukan....!! "
        tulisan(3) = "Terima kasih....  "
        Label1.Text = tulisan(j)
        Timer1.Start()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.ForeColor = Color.White Then
            Label1.ForeColor = Color.White

        ElseIf Label1.ForeColor = Color.White Then
            Label1.ForeColor = Color.White
        ElseIf Label1.ForeColor = Color.White Then
            Label1.ForeColor = Color.White

        End If
        If i.Equals(tulisan(j).Length) Then
            Me.Label1.Text = ""
            If j < tulisan.Length - 1 Then
                j = j + 1
            Else
                j = 0
            End If
            i = 0
        End If
        Label1.Text = tulisan(j).Substring(0, i)
        i = i + 1
    End Sub

    Private Sub CEKINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEKINToolStripMenuItem.Click
        Me.Hide()
        Form_cekIn.Show()
    End Sub

    Private Sub CEKOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEKOUTToolStripMenuItem.Click
        Me.Hide()
        Form_cekOut.Show()
    End Sub

    Private Sub DAFTARPENGUNJUNGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAFTARPENGUNJUNGToolStripMenuItem.Click
        Me.Hide()
        Pengunjung.Show()
    End Sub

    Private Sub DAFYARPEGAWAIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAFYARPEGAWAIToolStripMenuItem.Click
        Me.Hide()
        Pegawai.Show()
    End Sub

    Private Sub MYPROFILToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MYPROFILToolStripMenuItem.Click
        Me.Hide()
        Form_profil.Show()
    End Sub

    Private Sub DAFTARADMINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAFTARADMINToolStripMenuItem.Click
        Me.Hide()
        Form_TambahAdminPegawai.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class