Imports MySql.Data.MySqlClient
Public Class frmpembayaran
    Dim kode As Integer
    Dim kodeanggota, tgl, bln, thn As String

    Sub getCode()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblpembayaran ORDER BY id DESC", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kode = reader.Item("id") + 1
        Else
            kode = 1000000001
        End If
    End Sub

    Sub getDate()
        tgl = Format(Now, "dd")
        bln = Format(Now, "MM")
        thn = Format(Now, "yyyy")
    End Sub

    Sub getDgv()
        conn.Close()
        conn.Open()
        adapter = New MySqlDataAdapter("SELECT * FROM tblpembayaran ORDER BY id DESC", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblpembayaran")
        dgv.DataSource = dataset.Tables("tblpembayaran")
    End Sub

    Sub setDgv()
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 120
        dgv.Columns(3).Width = 100
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Width = 100
        dgv.Columns(6).Visible = False
        dgv.Columns(7).Visible = False
        dgv.Columns(8).Visible = False

        dgv.Columns(0).HeaderText = "Kode Pembayaran"
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Kode Pinjaman"
        dgv.Columns(3).HeaderText = "Kode Anggota"
        dgv.Columns(4).HeaderText = "Nama Anggota"
        dgv.Columns(5).HeaderText = "Pembayaran"
    End Sub

    Private Sub frmpembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getCode()
        Call getDate()
        Call getDgv()
        Call setDgv()
        txtketerangan.Text = "Pembayaran bulan " + bln + " tahun " + thn
        txtkode.Text = kode
        txttanggal.Text = tgl + "/" + bln + "/" + thn
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub txtkodepinjaman_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodepinjaman.TextChanged
        Dim angsuran As String
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblpinjaman WHERE id = '" & txtkodepinjaman.Text & "'", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kodeanggota = CStr(reader.Item("kode_anggota")).ToUpper
            txtnama.Text = reader.Item("nama_anggota")
            txtjumlahpinjaman.Text = reader.Item("jumlah")
            txtangsuran.Text = reader.Item("angsuran")
            txtsisalalu.Text = reader.Item("total_dibayar") - reader.Item("telah_dibayar")
            txttempo.Text = reader.Item("tempo") + "/" + bln + "/" + thn
            If reader.Item("status") = "Lunas" Then
                MessageBox.Show("Pinjaman ini sudah Lunas")
                btnbatal.PerformClick()
                Return
            End If

            If tgl > reader.Item("tempo") Then
                txtterlambat.Text = tgl - reader.Item("tempo")
            Else
                txtterlambat.Text = 0
            End If
            angsuran = reader.Item("angsuran")
            If txtterlambat.Text > 0 Then
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblaturan", conn)
                reader = cmd.ExecuteReader
                reader.Read()
                txtdenda.Text = txtangsuran.Text * reader.Item("denda") / 100
            Else
                txtdenda.Text = 0
            End If
            txtjumlah.Text = angsuran + +txtdenda.Text
            txtsisasekarang.Text = txtsisalalu.Text - txtjumlah.Text
        Else
            txtnama.Clear()
            txtjumlahpinjaman.Clear()
            txtangsuran.Clear()
            txtsisalalu.Clear()
            txttempo.Clear()
            txtterlambat.Clear()
            txtdenda.Clear()
            txtjumlah.Clear()
            txtsisasekarang.Clear()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim kodepinjam, nama, bayar, angsuran, query As String
        If txtnama.Text = "" Or txtjumlah.Text = "" Then
            MessageBox.Show("Isikan seluruh data!")
        Else
            kodepinjam = txtkodepinjaman.Text
            nama = txtnama.Text
            bayar = txtjumlah.Text
            angsuran = txtangsuran.Text

            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblpembayaran WHERE kode_pinjaman = '" & kodepinjam & "' AND bln = '" & bln & "' AND thn = '" & thn & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                MessageBox.Show("Anggota ini sudah membayar bulan ini")
            Else
                conn.Close()
                conn.Open()
                query = "INSERT INTO tblpembayaran VALUES (" _
                    + " '" & txtkode.Text & "','" & txttanggal.Text & "','" & kodepinjam & "', '" & kodeanggota & "', '" & nama & "', " _
                    + " '" & bayar & "', '" & tgl & "', '" & bln & "', '" & thn & "' " _
                    + ")"
                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblpinjaman WHERE id = '" & kodepinjam & "'", conn)
                reader = cmd.ExecuteReader
                reader.Read()
                bayar = reader.Item("telah_dibayar") + +angsuran

                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("UPDATE tblpinjaman SET telah_dibayar = '" & bayar & "' WHERE id = '" & kodepinjam & "'", conn)
                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblpinjaman WHERE id = '" & kodepinjam & "'", conn)
                reader = cmd.ExecuteReader
                reader.Read()

                If reader.Item("telah_dibayar") >= reader.Item("total_dibayar") Then
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("UPDATE tblpinjaman SET status = 'Lunas' WHERE id = '" & kodepinjam & "'", conn)
                    cmd.ExecuteNonQuery()
                End If

                MessageBox.Show("Sukses")
                btnbatal.PerformClick()
                txtkode.Text = txtkode.Text + +1
                Call getDgv()
            End If

        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        txtnama.Clear()
        txtjumlahpinjaman.Clear()
        txtangsuran.Clear()
        txtsisalalu.Clear()
        txttempo.Clear()
        txtterlambat.Clear()
        txtdenda.Clear()
        txtjumlah.Clear()
        txtsisasekarang.Clear()
        txtkodepinjaman.Clear()
    End Sub
End Class