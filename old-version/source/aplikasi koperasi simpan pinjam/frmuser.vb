Imports MySql.Data.MySqlClient
Public Class frmuser
    Dim kode As Integer

    Sub getCode()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tbluser ORDER BY id DESC", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kode = reader.Item("id") + 1
        Else
            kode = 10001
        End If
        conn.Close()
    End Sub

    Sub setDGV()
        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 300
        dgv.Columns(2).Width = 300
        dgv.Columns(3).Visible = False
        dgv.Columns(0).HeaderText = "Kode User"
        dgv.Columns(1).HeaderText = "Nama"
        dgv.Columns(2).HeaderText = "Username"
    End Sub

    Sub getDGV()
        adapter = New MySqlDataAdapter("SELECT * FROM tbluser", conn)
        dataset = New DataSet()
        adapter.Fill(dataset, "tbluser")
        dgv.DataSource = dataset.Tables("tbluser")
    End Sub

    Private Sub frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getDGV()
        Call setDGV()
        txtuname.MaxLength = 16
        txtpass.MaxLength = 16
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtkode.Clear()
        txtnama.Clear()
        txtuname.Clear()
        txtpass.Clear()
        Call getCode()
        gbxbox.Enabled = True
        gbxbox.Text = "Tambah User"
        btnaksi.Text = "Tambah"
        btnaksi.Visible = True
        btnbatal.Visible = True
        Label3.Visible = True
        txtuname.Visible = True
        txtkode.Text = kode
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        gbxbox.Enabled = False
        gbxbox.Text = ""
        txtuname.Visible = True
        Label3.Visible = True
        btnaksi.Visible = False
        btnbatal.Visible = False
        txtkode.Clear()
        txtnama.Clear()
        txtuname.Clear()
        txtpass.Clear()
    End Sub

    Private Sub btnaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaksi.Click
        If btnaksi.Text = "Tambah" Then
            Dim nama, username, password As String
            If txtnama.Text = "" Or txtuname.Text = "" Or txtpass.Text = "" Then
                MessageBox.Show("Isi semua data!")
            Else
                kode = txtkode.Text
                nama = txtnama.Text
                username = txtuname.Text
                password = txtpass.Text

                conn.Close()
                conn.Open()
                conn.Close()

                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tbluser WHERE username = '" & username & "'", conn)
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    MessageBox.Show("Username sudah ada!")
                Else
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("INSERT INTO tbluser VALUES ('" & kode & "', '" & nama & "', '" & username & "', '" & password & "')", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User dengan kode " + CStr(kode) + " berhasil didaftarkan")
                    txtnama.Clear()
                    txtuname.Clear()
                    txtpass.Clear()
                    txtkode.Text = txtkode.Text + +1
                End If
            End If
        ElseIf btnaksi.Text = "Edit" Then
            Dim nama, password As String
            If txtnama.Text = "" Or txtpass.Text = "" Then
                MessageBox.Show("Isi semua data!")
            Else
                kode = txtkode.Text
                nama = txtnama.Text
                password = txtpass.Text

                conn.Close()
                conn.Open()

                cmd = New MySqlCommand("UPDATE tbluser SET nama = '" & nama & "', password = '" & password & "' WHERE id = '" & kode & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("User dengan kode " + CStr(kode) + " berhasil diubah")
                txtnama.Clear()
                txtuname.Clear()
                txtpass.Clear()
                txtkode.Clear()

                btnbatal.PerformClick()
            End If
        End If
        Call getDGV()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim input As String
        input = InputBox("Masukkan Kode/ID User yang akan di edit")
        If input = "" Then
            MessageBox.Show("Masukkan kode user!")
        Else
            conn.Close()
            conn.Open()
            conn.Close()

            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tbluser WHERE id = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                gbxbox.Enabled = True
                gbxbox.Text = "Edit User"
                btnaksi.Text = "Edit"
                btnaksi.Visible = True
                btnbatal.Visible = True
                txtkode.Text = input
                txtnama.Text = reader.Item("nama")
                txtuname.Visible = False
                Label3.Visible = False
            Else
                MessageBox.Show("User dengan kode " + input + " tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim input As String
        input = InputBox("Masukkan kode user yang ingin dihapus")
        If input = "" Then
            MessageBox.Show("Isikan kode!")
        Else
            conn.Close()
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM tbluser WHERE id = '" & input & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If MessageBox.Show("Apakah user dengan kode " + input + " ingin dihapus?", "Yakin?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    conn.Close()
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM tbluser WHERE id = '" & input & "'", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User dengan kode " + input + ", berhasil dihapus")
                End If
            Else
                MessageBox.Show("User dengan kode " + input + " tidak ditemukan")
            End If
        End If
        Call getDGV()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        adapter = New MySqlDataAdapter("SELECT * FROM tbluser WHERE id LIKE '%" & txtcari.Text & "%' OR nama LIKE '%" & txtcari.Text & "%' OR username LIKE '%" & txtcari.Text & "%'", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tbluser")
        dgv.DataSource = dataset.Tables("tbluser")
    End Sub
End Class