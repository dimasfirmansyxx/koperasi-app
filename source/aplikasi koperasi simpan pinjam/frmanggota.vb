Imports MySql.Data.MySqlClient
Public Class frmanggota

    Dim code As String

    Sub getCode()
        Dim kode As Integer
        If cmbtipe.Text = "Pengurus" Or cmbtipe.Text = "Pendiri" Then
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE kode = '050P' OR kode = '050PG'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If cmbtipe.Text = "Pengurus" Then
                    MessageBox.Show("Tipe anggota untuk pengurus sudah penuh")
                ElseIf cmbtipe.Text = "Pendiri" Then
                    MessageBox.Show("Tipe anggota untuk pendiri sudah penuh")
                End If
                txtkode.Clear()
                txtnama.Clear()
                txtnama.Enabled = False
                txtalamat.Clear()
                txtalamat.Enabled = False
                txthp.Clear()
                txthp.Enabled = False
                txtktp.Clear()
                txtktp.Enabled = False
            Else
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE lvl = 'P' OR lvl = 'PG' ORDER BY id DESC", conn)
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    code = reader.Item("kode")
                    code = Strings.Left(code, 3)
                    kode = Strings.Right(code, 2)
                    kode = kode + 1
                    If cmbtipe.Text = "Pengurus" Then
                        If kode < 10 Then
                            code = "00" + CStr(kode) + "PG"
                        Else
                            code = "0" + CStr(kode) + "PG"
                        End If
                    ElseIf cmbtipe.Text = "Pendiri" Then
                        If kode < 10 Then
                            code = "00" + CStr(kode) + "P"
                        Else
                            code = "0" + CStr(kode) + "P"
                        End If
                    End If
                Else
                    If cmbtipe.Text = "Pengurus" Then
                        code = "001PG"
                    ElseIf cmbtipe.Text = "Pendiri" Then
                        code = "001P"
                    End If
                End If
            End If
        ElseIf cmbtipe.Text = "Anggota" Then
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE lvl = 'A' ORDER BY id DESC", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                code = reader.Item("kode")
                code = Strings.Left(code, 3)
                kode = Strings.Right(code, 2)
                kode = kode + 1
                If kode < 100 Then
                    code = "0" + CStr(kode) + "A"
                Else
                    code = CStr(kode) + "A"
                End If
            Else
                code = "051A"
            End If
        End If
        txtkode.Text = code
    End Sub

    Sub setDGV()
        dgv.Columns(0).Visible = False
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 250
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Width = 100
        dgv.Columns(6).Width = 100
        dgv.Columns(7).Visible = False
        dgv.Columns(1).HeaderText = "Kode Anggota"
        dgv.Columns(2).HeaderText = "Nama"
        dgv.Columns(3).HeaderText = "Alamat"
        dgv.Columns(4).HeaderText = "Nomor Telepon"
        dgv.Columns(5).HeaderText = "Nomor KTP"
        dgv.Columns(6).HeaderText = "Saldo"
    End Sub

    Sub getDGV()
        conn.Close()
        conn.Open()
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
        txtkode.Text = code
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        gbxbox.Enabled = False
        gbxbox.Text = ""
        btnaksi.Visible = False
        btnbatal.Visible = False
        lbltipe.Visible = True
        cmbtipe.Visible = True
        txtkode.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txthp.Clear()
        txtktp.Clear()
    End Sub

    Private Sub btnaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaksi.Click
        If btnaksi.Text = "Tambah" Then
            Dim nama, alamat, hp, ktp, lvl As String
            If txtnama.Text = "" Or txtalamat.Text = "" Or txthp.Text = "" Or txtktp.Text = "" Then
                MessageBox.Show("Isikan semua data")
            Else
                code = txtkode.Text
                nama = txtnama.Text
                alamat = txtalamat.Text
                hp = txthp.Text
                ktp = txtktp.Text
                lvl = cmbtipe.Text
                If lvl = "Pengurus" Then
                    lvl = "PG"
                ElseIf lvl = "Pendiri" Then
                    lvl = "P"
                ElseIf lvl = "Anggota" Then
                    lvl = "A"
                End If

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
                        cmd = New MySqlCommand("INSERT INTO tblanggota VALUES ('','" & code & "','" & nama & "','" & alamat & "','" & hp & "','" & ktp & "', '0', '" & lvl & "')", conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Anggota Berhasil ditambah")
                        Call getCode()
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
                code = txtkode.Text
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
                    query = "UPDATE tblanggota SET nama = '" & nama & "', alamat = '" & alamat & "', telepon = '" & hp & "', ktp = '" & ktp & "' WHERE kode = '" & code & "'"
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Anggota dengan kode " + code + " berhasil di edit")
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
            cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE kode = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                lbltipe.Visible = False
                cmbtipe.Visible = False
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
                txtnama.Enabled = True
                txtalamat.Enabled = True
                txthp.Enabled = True
                txtktp.Enabled = True
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
            cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE kode = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If MessageBox.Show("Yakin ingin menghapus anggota dengan kode " + input + " ?", "Yakin?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM tblanggota WHERE kode = '" & input & "'", conn)
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

    Private Sub cmbtipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipe.SelectedIndexChanged
        If cmbtipe.Text = "" Then
            txtkode.Clear()
            txtnama.Clear()
            txtnama.Enabled = False
            txtalamat.Clear()
            txtalamat.Enabled = False
            txthp.Clear()
            txthp.Enabled = False
            txtktp.Clear()
            txtktp.Enabled = False
        Else
            Call getCode()
            txtnama.Enabled = True
            txtalamat.Enabled = True
            txthp.Enabled = True
            txtktp.Enabled = True
        End If
    End Sub
End Class