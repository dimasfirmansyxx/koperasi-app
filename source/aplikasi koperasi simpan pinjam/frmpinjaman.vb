Imports MySql.Data.MySqlClient
Public Class frmpinjaman

    Dim kode, tgltempo, makspinjaman As Integer
    Dim tgl, bln, thn As String

    Sub getCode()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblpinjaman ORDER BY id DESC", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kode = reader.Item("id") + 1
        Else
            kode = 40001
        End If
    End Sub

    Sub setDgv()
        dgv.Columns(0).Width = 110
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 145
        dgv.Columns(4).Width = 100
        dgv.Columns(5).Width = 100
        dgv.Columns(6).Width = 100
        dgv.Columns(7).Visible = False
        dgv.Columns(8).Visible = False
        dgv.Columns(9).Visible = False
        dgv.Columns(10).Visible = False
        dgv.Columns(11).Visible = False

        dgv.Columns(0).HeaderText = "Kode Pinjaman"
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Kode Anggota"
        dgv.Columns(3).HeaderText = "Nama"
        dgv.Columns(4).HeaderText = "Bunga"
        dgv.Columns(5).HeaderText = "Lama Cicilan"
        dgv.Columns(6).HeaderText = "Jumlah"
    End Sub

    Sub getDgv()
        conn.Close()
        conn.Open()
        adapter = New MySqlDataAdapter("SELECT * FROM tblpinjaman ORDER BY id DESC", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblpinjaman")
        dgv.DataSource = dataset.Tables("tblpinjaman")
    End Sub

    Sub getDate()
        Dim tglnow As Integer
        txttanggal.Text = Format(Now, "dd/MM/yyyy")
        tglnow = Format(Now, "dd")
        If tglnow = 29 Or tglnow = 30 Then
            tgltempo = 28
        Else
            tgltempo = tglnow
        End If
    End Sub

    Sub getMaxPinjam()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblaturan", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        makspinjaman = reader.Item("maksimal_peminjaman")
    End Sub

    Private Sub frmpinjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getCode()
        Call getDgv()
        Call setDgv()
        Call getDate()
        txtkode.Text = kode
        tgl = Format(Now, "dd")
        bln = Format(Now, "MM")
        thn = Format(Now, "yyyy")
    End Sub

    Private Sub txtkodeanggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodeanggota.TextChanged
        Call getMaxPinjam()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE id = '" & txtkodeanggota.Text & "'", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            txtnama.Text = reader.Item("nama")
            txtsaldo.Text = reader.Item("saldo")
            txtjumlah.Text = txtsaldo.Text * makspinjaman
        Else
            txtnama.Clear()
            txtsaldo.Clear()
            txtjumlah.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not txtbunga.Text = "" And Not txtlama.Text = "" And Not txtjumlah.Text = "" Then
            Dim bunga, pokok As Integer
            pokok = txtjumlah.Text / txtlama.Text
            bunga = (txtjumlah.Text * txtbunga.Text / 100) / txtlama.Text
            txtangsuran.Text = pokok + bunga
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtnama.Text = "" Or txtangsuran.Text = "" Then
            MessageBox.Show("Isikan Seluruh data!")
        Else
            Dim kode, tanggal, anggota, nama, query As String
            Dim bunga, lama, jumlah, angsuran, total As Integer
            kode = txtkode.Text
            tanggal = txttanggal.Text
            anggota = txtkodeanggota.Text
            nama = txtnama.Text
            bunga = txtbunga.Text
            lama = txtlama.Text
            jumlah = txtjumlah.Text
            angsuran = txtangsuran.Text
            total = angsuran * lama

            conn.Close()
            conn.Open()
            query = "SELECT * FROM tblpinjaman WHERE kode_anggota = '" & anggota & "' AND status = 'Belum Lunas'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                MessageBox.Show("Anggota ini sudah pernah meminjam dan belum lunas")
            Else
                conn.Close()
                conn.Open()
                query = " INSERT INTO tblpinjaman VALUES (" _
                    + " '" & kode & "', '" & tanggal & "', '" & anggota & "', '" & nama & "', " _
                    + " '" & bunga & "', '" & lama & "', '" & jumlah & "', '" & angsuran & "', " _
                    + " '0','" & total & "', 'Belum Lunas', '" & tgltempo & "', '" & tgl & "','" & bln & "','" & thn & "' " _
                    + ")"
                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Sukses. Jatuh tempo pembayaran setiap tanggal " + CStr(tgltempo))

                txtkode.Text = txtkode.Text + +1
                Call getDgv()
                txtnama.Clear()
                txtbunga.Clear()
                txtlama.Clear()
                txtjumlah.Clear()
            End If
        End If
    End Sub
End Class