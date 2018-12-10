Imports MySql.Data.MySqlClient
Public Class frmpengambilan

    Dim kode As Integer
    Dim tgl, bln, thn As String

    Sub getCode()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblpengambilan ORDER BY id DESC", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            kode = reader.Item("id") + 1
        Else
            kode = 1000000001
        End If
    End Sub

    Sub setDgv()
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 120
        dgv.Columns(2).Width = 150
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.Columns(5).Visible = False
        dgv.Columns(6).Visible = False
        dgv.Columns(7).Visible = False
        dgv.Columns(0).HeaderText = "Kode Transaksi"
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Kode Anggota"
        dgv.Columns(3).HeaderText = "Nama"
        dgv.Columns(4).HeaderText = "Jumlah"
    End Sub

    Sub getDgv()
        conn.Close()
        conn.Open()
        adapter = New MySqlDataAdapter("SELECT * FROM tblpengambilan ORDER BY id DESC", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblpengambilan")
        dgv.DataSource = dataset.Tables("tblpengambilan")
    End Sub

    Sub getDate()
        txttanggal.Text = Format(Now, "dd/MM/yyyy")
        tgl = Format(Now, "dd")
        bln = Format(Now, "MM")
        thn = Format(Now, "yyyy")
    End Sub

    Private Sub frmpengambilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getCode()
        Call getDgv()
        Call setDgv()
        Call getDate()
        txtkode.Text = kode
    End Sub

    Private Sub btnaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaksi.Click
        Dim query As String
        Dim sisasaldo, minsaldo As Integer
        If txtnama.Text = "" Or txtjumlah.Text = "" Then
            MessageBox.Show("Isikan Seluruh data!")
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblaturan", conn)
            reader = cmd.ExecuteReader
            reader.Read()

            minsaldo = CInt(reader.Item("minimal_saldo"))
            sisasaldo = CInt(txtsaldo.Text) - CInt(txtjumlah.Text)
            If sisasaldo < minsaldo Then
                MessageBox.Show("Saldo yang ada harus tidak kurang dari " + CStr(minsaldo))
            Else
                conn.Close()
                conn.Open()
                query = "INSERT INTO tblpengambilan VALUES ('" & txtkode.Text & "', '" & txttanggal.Text & "', '" & txtkodeanggota.Text.ToUpper & "', '" & txtnama.Text & "', '" & txtjumlah.Text & "', '" & tgl & "', '" & bln & "', '" & thn & "')"
                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("UPDATE tblanggota SET saldo = '" & CStr(sisasaldo) & "' WHERE kode = '" & txtkodeanggota.Text & "'", conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Sukses")
                Call getDgv()
            End If
        End If
    End Sub

    Private Sub txtkodeanggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodeanggota.TextChanged
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblanggota WHERE kode = '" & txtkodeanggota.Text & "'", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            txtnama.Text = reader.Item("nama")
            txtsaldo.Text = reader.Item("saldo")
        Else
            txtnama.Clear()
            txtsaldo.Clear()
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        txtkodeanggota.Clear()
        txtnama.Clear()
        txtsaldo.Clear()
        txtjumlah.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class