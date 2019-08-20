Public Class frmmaster

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        Me.Close()
        frmlogin.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmuser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmanggota.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmpengaturan.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmsimpanan.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmpengambilan.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmpinjaman.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmpembayaran.Show()
    End Sub
End Class
