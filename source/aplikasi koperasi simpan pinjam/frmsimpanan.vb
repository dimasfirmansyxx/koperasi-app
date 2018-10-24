Imports MySql.Data.MySqlClient
Public Class frmsimpanan

    Dim kode As Integer
    Dim tanggal, tgl, bln, thn As String

    Sub setDgv()
        dgv.Columns(0).Width = 120
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 120
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 120
        dgv.Columns(5).Width = 100
        dgv.Columns(6).Visible = False
        dgv.Columns(7).Visible = False
        dgv.Columns(8).Visible = False
        dgv.Columns(0).HeaderText = "Kode Transaksi"
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Kode Anggota"
        dgv.Columns(3).HeaderText = "Nama"
        dgv.Columns(4).HeaderText = "Jenis Simpanan"
        dgv.Columns(5).HeaderText = "Jumlah"
    End Sub

    Sub getDgv()
        adapter = New MySqlDataAdapter("SELECT * FROM tblsimpanan ORDER BY id DESC", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblsimpanan")
        dgv.DataSource = dataset.Tables("tblsimpanan")
    End Sub

    Sub getCode()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblsimpanan ORDER BY id DESC", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kode = reader.Item("id") + 1
        Else
            kode = 1000000001
        End If
    End Sub

    Private Sub frmsimpanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getDgv()
        Call setDgv()
        tanggal = Format(Now, "dd/MM/yyyy")
        tgl = Format(Now, "dd")
        bln = Format(Now, "MM")
        thn = Format(Now, "yyyy")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gbxbox.Text = "Tambah Simpanan"
        gbxbox.Enabled = True
        btnaksi.Visible = True
        btnaksi.Text = "Tambah"
        btnbatal.Visible = True
        Call getCode()
        txtkode.Text = kode
        txttanggal.Text = tanggal
    End Sub

    Private Sub txtkodeanggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodeanggota.TextChanged
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE id = '" & txtkodeanggota.Text & "'", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            txtnama.Text = reader.Item("nama")
        Else
            txtnama.Clear()
        End If
    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjenis.SelectedIndexChanged
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblaturan", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If cmbjenis.Text = "Wajib" Then
            txtjumlah.Text = reader.Item("simpanan_wajib")
            txtjumlah.ReadOnly = True
        ElseIf cmbjenis.Text = "Pokok" Then
            txtjumlah.Text = reader.Item("simpanan_pokok")
            txtjumlah.ReadOnly = True
        ElseIf cmbjenis.Text = "Sukarela" Then
            txtjumlah.Clear()
            txtjumlah.ReadOnly = False
        End If
    End Sub

    Private Sub btnaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaksi.Click
        If btnaksi.Text = "Tambah" Then
            If txtnama.Text = "" Or txtjumlah.Text = "" Then
                MessageBox.Show("Isikan Seluruh Data")
            Else
                Dim kode, tanggal, kode_anggota, nama, jenis, jumlah As String
                kode = txtkode.Text
                tanggal = txttanggal.Text
                kode_anggota = txtkodeanggota.Text
                nama = txtnama.Text
                jenis = cmbjenis.Text
                jumlah = txtjumlah.Text
                If jenis = "Pokok" Then
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("SELECT * FROM tblsimpanan WHERE kode_anggota = '" & kode_anggota & "' AND jenis_simpanan = 'Pokok'", conn)
                    reader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        MessageBox.Show("Anggota ini sudah membayar Simpanan Pokok")
                        Return
                    End If
                ElseIf jenis = "Wajib" Then
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("SELECT * FROM tblsimpanan WHERE kode_anggota = '" & kode_anggota & "' AND jenis_simpanan = 'Wajib' AND bln = '" & bln & "' AND thn = '" & thn & "'", conn)
                    reader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        MessageBox.Show("Anggota ini sudah membayar Simpanan Wajib bulan ini")
                        Return
                    End If
                ElseIf jenis = "Sukarela" Then
                    If IsNumeric(txtjumlah.Text) = False Then
                        MessageBox.Show("Isikan hanya dengan angka")
                        Return
                    End If
                End If

                Dim query, saldo As String
                query = "INSERT INTO tblsimpanan VALUES ('" & kode & "','" & tanggal & "','" & kode_anggota & "', " _
                    + "'" & nama & "','" & jenis & "','" & jumlah & "','" & tgl & "','" & bln & "','" & thn & "')"
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Open()
                query = "SELECT * FROM tblanggota WHERE id = '" & kode_anggota & "'"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader
                reader.Read()
                saldo = reader.Item("saldo")
                saldo = saldo + +jumlah

                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("UPDATE tblanggota SET saldo = '" & saldo & "' WHERE id = '" & kode_anggota & "'", conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Berhasil")
                Call getDgv()
                txtkode.Text = txtkode.Text + +1
                txtkodeanggota.Clear()
                cmbjenis.SelectedIndex = -1
                txtjumlah.Clear()
                txtjumlah.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        txtkode.Clear()
        txtkodeanggota.Clear()
        cmbjenis.SelectedIndex = -1
        txtjumlah.Clear()
        txttanggal.Clear()
        txtnama.Clear()
        gbxbox.Text = ""
        gbxbox.Enabled = False
        btnaksi.Visible = False
        btnbatal.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        btnbatal.PerformClick()
        Dim input As String
        input = InputBox("Masukkan kode Transaksi yang akan dihapus")
        If input = "" Then
            MessageBox.Show("Masukkan kode Transaksi!")
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblsimpanan WHERE id = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If MessageBox.Show("Yakin ingin dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim query, kode_anggota, jumlah As String

                    conn.Close()
                    conn.Open()
                    query = "SELECT * FROM tblsimpanan WHERE id = '" & input & "'"
                    cmd = New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    reader.Read()

                    kode_anggota = reader.Item("kode_anggota")
                    jumlah = reader.Item("jumlah")

                    conn.Close()
                    conn.Open()
                    query = "DELETE FROM tblsimpanan WHERE id = '" & input & "'"
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()

                    conn.Close()
                    conn.Open()
                    query = "SELECT * FROM tblanggota WHERE id = '" & kode_anggota & "'"
                    cmd = New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    reader.Read()

                    jumlah = reader.Item("saldo") - jumlah

                    conn.Close()
                    conn.Open()
                    query = "UPDATE tblanggota SET saldo = '" & jumlah & "' WHERE id = '" & kode_anggota & "'"
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Berhasil")
                    Call getDgv()
                End If
            Else
                MessageBox.Show("Kode Transaksi Tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class