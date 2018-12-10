Public Class frmmaster

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        Me.Close()
        frmlogin.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Dim form As New frmuser
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form As New frmanggota
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengaturanToolStripMenuItem.Click
        Dim form As New frmpengaturan
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub SimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpananToolStripMenuItem.Click
        Dim form As New frmsimpanan
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengembalianToolStripMenuItem.Click
        Dim form As New frmpengambilan
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PinjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PinjamanToolStripMenuItem.Click
        Dim form As New frmpinjaman
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembayaranToolStripMenuItem.Click
        Dim form As New frmpembayaran
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub LaporanSimpananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanSimpananToolStripMenuItem.Click
        Dim form As New frmrptsimpanan
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PengambilanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengambilanToolStripMenuItem.Click
        Dim form As New frmrptpengambilan
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub LaporanPinjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPinjamanToolStripMenuItem.Click
        Dim form As New frmrptpinjaman
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub LaporanPembayaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembayaranToolStripMenuItem.Click
        Dim form As New frmrptpembayaran
        form.MdiParent = Me
        form.Show()
    End Sub

End Class
