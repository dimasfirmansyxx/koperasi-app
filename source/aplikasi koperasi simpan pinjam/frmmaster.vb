Public Class frmmaster

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        Me.Close()
        frmlogin.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        frmuser.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        frmanggota.Show()
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengaturanToolStripMenuItem.Click
        frmpengaturan.Show()
    End Sub

    Private Sub SimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpananToolStripMenuItem.Click
        frmsimpanan.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengembalianToolStripMenuItem.Click
        frmpengambilan.Show()
    End Sub

    Private Sub PinjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PinjamanToolStripMenuItem.Click
        frmpinjaman.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembayaranToolStripMenuItem.Click
        frmpembayaran.Show()
    End Sub

    Private Sub LaporanSimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanSimpananToolStripMenuItem.Click
        frmrptsimpanan.Show()
    End Sub

    Private Sub PengambilanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengambilanToolStripMenuItem.Click
        frmrptpengambilan.show()
    End Sub

    Private Sub LaporanPinjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPinjamanToolStripMenuItem.Click
        frmrptpinjaman.Show()
    End Sub

    Private Sub LaporanPembayaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembayaranToolStripMenuItem.Click
        frmrptpembayaran.Show()
    End Sub
End Class
