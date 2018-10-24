Imports MySql.Data.MySqlClient
Public Class frmanggota

    Dim kode As Integer

    Sub getCode()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblanggota ORDER BY id DESC", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kode = reader.Item("id") + 1
        Else
            kode = 20001
        End If
    End Sub

    Sub setDGV()
        dgv.Columns(0).Width = 90
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 250
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Width = 100
        dgv.Columns(0).HeaderText = "Kode Anggota"
        dgv.Columns(1).HeaderText = "Nama"
        dgv.Columns(2).HeaderText = "Alamat"
        dgv.Columns(3).HeaderText = "Nomor Telepon"
        dgv.Columns(4).HeaderText = "Nomor KTP"
        dgv.Columns(5).HeaderText = "Saldo"
    End Sub

    Sub getDGV()
        adapter = New MySqlDataAdapter("SELECT * FROM tblanggota", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblanggota")
        dgv.DataSource = dataset.Tables("tblanggota")
    End Sub

    Private Sub frmanggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getDGV()
        Call setDGV()
        txthp.MaxLength = 12
        txtktp.MaxLength = 16
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtkode.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txthp.Clear()
        txtktp.Clear()
        Call getCode()
        gbxbox.Enabled = True
        gbxbox.Text = "Tambah Anggota"
        btnaksi.Text = "Tambah"
        btnaksi.Visible = True
        btnbatal.Visible = True
        txtkode.Text = kode
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        gbxbox.Enabled = False
        gbxbox.Text = ""
        btnaksi.Visible = False
        btnbatal.Visible = False
        txtkode.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txthp.Clear()
        txtktp.Clear()
    End Sub

    Private Sub btnaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaksi.Click
        If btnaksi.Text = "Tambah" Then
            Dim nama, alamat, hp, ktp As String
            If txtnama.Text = "" Or txtalamat.Text = "" Or txthp.Text = "" Or txtktp.Text = "" Then
                MessageBox.Show("Isikan semua data")
            Else
                kode = txtkode.Text
                nama = txtnama.Text
                alamat = txtalamat.Text
                hp = txthp.Text
                ktp = txtktp.Text
                If IsNumeric(hp) = False Then
                    MessageBox.Show("Isikan nomor hp hanya dengan angka")
                ElseIf IsNumeric(ktp) = False Then
                    MessageBox.Show("Isikan nomor KTP hanya dengan angka")
                Else
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE ktp = '" & ktp & "'", conn)
                    reader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        MessageBox.Show("Anggota ini sudah terdaftar")
                    Else
                        conn.Close()
                        conn.Open()
                        cmd = New MySqlCommand("INSERT INTO tblanggota VALUES ('" & kode & "','" & nama & "','" & alamat & "','" & hp & "','" & ktp & "', '0')", conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Anggota Berhasil ditambah")
                        txtkode.Text = txtkode.Text + +1
                        txtnama.Clear()
                        txtalamat.Clear()
                        txthp.Clear()
                        txtktp.Clear()
                        Call getDGV()
                    End If
                End If
            End If
        ElseIf btnaksi.Text = "Edit" Then
            Dim nama, alamat, hp, ktp, query As String
            If txtnama.Text = "" Or txtalamat.Text = "" Or txthp.Text = "" Or txtktp.Text = "" Then
                MessageBox.Show("Isikan semua data")
            Else
                kode = txtkode.Text
                nama = txtnama.Text
                alamat = txtalamat.Text
                hp = txthp.Text
                ktp = txtktp.Text
                If IsNumeric(hp) = False Then
                    MessageBox.Show("Isikan nomor hp hanya dengan angka")
                ElseIf IsNumeric(ktp) = False Then
                    MessageBox.Show("Isikan nomor KTP hanya dengan angka")
                Else
                    conn.Close()
                    conn.Open()
                    query = "UPDATE tblanggota SET nama = '" & nama & "', alamat = '" & alamat & "', telepon = '" & hp & "', ktp = '" & ktp & "' WHERE id = '" & kode & "'"
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Anggota dengan kode " + CStr(kode) + " berhasil di edit")
                    Call getDGV()
                    btnbatal.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtkode.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txthp.Clear()
        txtktp.Clear()
        Dim input As String
        input = InputBox("Masukkan kode anggota")
        If input = "" Then
            MessageBox.Show("Masukkan Kode anggota!")
            btnbatal.PerformClick()
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE id = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                gbxbox.Enabled = True
                gbxbox.Text = "Edit Anggota"
                btnaksi.Text = "Edit"
                btnaksi.Visible = True
                btnbatal.Visible = True
                txtkode.Text = input
                txtnama.Text = reader.Item("nama")
                txtalamat.Text = reader.Item("alamat")
                txthp.Text = reader.Item("telepon")
                txtktp.Text = reader.Item("ktp")
            Else
                MessageBox.Show("Anggota dengan kode " + input + " tidak ditemukan")
                btnbatal.PerformClick()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim input As String
        input = InputBox("Masukkan kode anggota yang ingin dihapus")
        If input = "" Then
            MessageBox.Show("Masukkan kode anggota!")
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE id = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If MessageBox.Show("Yakin ingin menghapus anggota dengan kode " + input + " ?", "Yakin?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM tblanggota WHERE id = '" & input & "'", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Anggota dengan kode " + input + ", berhasil dihapus")
                    Call getDGV()
                End If
            Else
                MessageBox.Show("Anggota tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        adapter = New MySqlDataAdapter("SELECT * FROM tblanggota WHERE id LIKE '%" & txtcari.Text & "%' OR nama LIKE '%" & txtcari.Text & "%' OR ktp LIKE '%" & txtcari.Text & "%'", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblanggota")
        dgv.DataSource = dataset.Tables("tblanggota")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class