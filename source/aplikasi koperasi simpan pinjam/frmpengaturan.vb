Imports MySql.Data.MySqlClient
Public Class frmpengaturan

    Sub getData()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblaturan", conn)
        reader = cmd.ExecuteReader
        reader.Read()
        txtpokok.Text = reader.Item("simpanan_pokok")
        txtwajib.Text = reader.Item("simpanan_wajib")
        txtsukarela.Text = reader.Item("simpanan_sukarela")
        txtdenda.Text = reader.Item("denda")
        txtmaksimalpinjam.Text = reader.Item("maksimal_peminjaman")
        txtminimalsaldo.Text = reader.Item("minimal_saldo")
    End Sub

    Private Sub frmpengaturan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getData()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtpokok.Text = "" Or txtwajib.Text = "" Or txtsukarela.Text = "" Or txtdenda.Text = "" Or txtmaksimalpinjam.Text = "" Or txtminimalsaldo.Text = "" Then
            MessageBox.Show("Isikan semua data!")
        ElseIf IsNumeric(txtpokok.Text) = False Or IsNumeric(txtwajib.Text) = False Or IsNumeric(txtsukarela.Text) = False Or IsNumeric(txtdenda.Text) = False Or IsNumeric(txtmaksimalpinjam.Text) = False Or IsNumeric(txtminimalsaldo.Text) = False Then
            MessageBox.Show("Isikan data hanya menggunakan angka!")
        Else
            Dim pokok, wajib, sukarela, denda, maks, min, query As String
            pokok = txtpokok.Text
            wajib = txtwajib.Text
            sukarela = txtsukarela.Text
            denda = txtdenda.Text
            maks = txtmaksimalpinjam.Text
            min = txtminimalsaldo.Text

            conn.Close()
            conn.Open()
            query = "UPDATE tblaturan SET simpanan_pokok = '" & pokok & "', " _
                + "simpanan_wajib = '" & wajib & "', simpanan_sukarela = '" & sukarela & "', denda = '" & denda & "'," _
                + "maksimal_peminjaman = '" & maks & "', minimal_saldo = '" & min & "'"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sukses")
            Me.Close()
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub
End Class