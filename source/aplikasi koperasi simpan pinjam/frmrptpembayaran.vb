Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmrptpembayaran

    Sub setDgv()
        dgv.Columns(0).Width = 120
        dgv.Columns(1).Width = 120
        dgv.Columns(2).Width = 120
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 120
        dgv.Columns(5).Visible = 120
        dgv.Columns(6).Visible = False
        dgv.Columns(7).Visible = False
        dgv.Columns(8).Visible = False

        dgv.Columns(0).HeaderText = "Kode Transaksi"
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Kode Pinjaman"
        dgv.Columns(3).HeaderText = "Kode Anggota"
        dgv.Columns(4).HeaderText = "Nama"
        dgv.Columns(5).HeaderText = "Jumlah"
    End Sub

    Sub getDgv()
        conn.Close()
        conn.Open()
        adapter = New MySqlDataAdapter("SELECT * FROM tblpembayaran ORDER BY id DESC", conn)
        dataset = New DataSet
        adapter.Fill(dataset, "tblpembayaran")
        dgv.DataSource = dataset.Tables("tblpembayaran")
        dgv.ReadOnly = True
        For kolom As Integer = 5 To dgv.ColumnCount - 1
            Dim total As Integer = 0
            Dim max As Integer = dgv.Rows.Count - 1
            For Each row As DataGridViewRow In dgv.Rows
                total = total + row.Cells(kolom).Value
            Next
            dgv.Rows(max).Cells(0).Value = 0
            dgv.Rows(max).Cells(1).Value = ""
            dgv.Rows(max).Cells(2).Value = ""
            dgv.Rows(max).Cells(3).Value = ""
            dgv.Rows(max).Cells(4).Value = "Total >"
            dgv.Rows(max).Cells(kolom).Value = total
        Next
    End Sub

    Sub getYear()
        conn.Close()
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM tblpembayaran", conn)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                If cmbtahun.Items.Contains(reader.Item("thn")) = False Then
                    cmbtahun.Items.Add(reader.Item("thn"))
                End If
                If cmbpertahun.Items.Contains(reader.Item("thn")) = False Then
                    cmbpertahun.Items.Add(reader.Item("thn"))
                End If
            End While
        End If
    End Sub

    Private Sub frmrptsimpanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call getDgv()
        Call setDgv()
        Call getYear()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Microsoft Excel File (*.xls)|*.xls"
        If sfd.ShowDialog = DialogResult.OK Then
            If Me.dgv.Rows.Count > 0 Then
                Try
                    Dim dt As New DataTable()
                    For Each col As DataGridViewColumn In Me.dgv.Columns
                        dt.Columns.Add(col.HeaderText, col.ValueType)
                    Next
                    Dim count As Integer = 0
                    For Each row As DataGridViewRow In Me.dgv.Rows
                        If count < Me.dgv.Rows.Count - 1 Then
                            dt.Rows.Add()
                            For Each cell As DataGridViewCell In row.Cells
                                dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
                            Next
                        End If
                        count += 1
                    Next

                    Dim wr As New IO.StreamWriter(sfd.FileName)

                    For i As Integer = 0 To dt.Columns.Count - 1
                        wr.Write(dt.Columns(i).ToString().ToUpper() & vbTab)
                    Next
                    wr.WriteLine()

                    For i As Integer = 0 To (dt.Rows.Count) - 1
                        For j As Integer = 0 To dt.Columns.Count - 1
                            If dt.Rows(i)(j) IsNot Nothing Then
                                wr.Write(Convert.ToString(dt.Rows(i)(j)) & vbTab)
                            Else
                                wr.Write(vbTab)
                            End If
                        Next
                        wr.WriteLine()
                    Next
                    wr.Close()
                    MsgBox("Data berhasil diexport ke excel!", MsgBoxStyle.Information, "Information")
                Catch ex As Exception
                    Throw ex
                End Try
            End If
        End If
    End Sub

    Private Sub btnviewbln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewbln.Click
        If cmbbulan.Text = "" Or cmbtahun.Text = "" Then
            Exit Sub
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblpembayaran WHERE bln = '" & cmbbulan.Text & "' AND thn = '" & cmbtahun.Text & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                conn.Close()
                conn.Open()
                adapter = New MySqlDataAdapter("SELECT * FROM tblpembayaran WHERE bln = '" & cmbbulan.Text & "' AND thn = '" & cmbtahun.Text & "' ORDER BY id DESC", conn)
                dataset = New DataSet
                adapter.Fill(dataset, "tblpembayaran")
                dgv.DataSource = dataset.Tables("tblpembayaran")
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btnviewthn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewthn.Click
        If cmbpertahun.Text = "" Then
            Exit Sub
        Else
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblpembayaran WHERE thn = '" & cmbtahun.Text & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                conn.Close()
                conn.Open()
                adapter = New MySqlDataAdapter("SELECT * FROM tblpembayaran thn = '" & cmbtahun.Text & "' ORDER BY id DESC", conn)
                dataset = New DataSet
                adapter.Fill(dataset, "tblpembayaran")
                dgv.DataSource = dataset.Tables("tblpembayaran")
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call getDgv()
        txtcari.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            Call getDgv()
        Else
            Dim keyword As String
            keyword = txtcari.Text
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblpembayaran WHERE id = '" & keyword & "' OR kode_anggota = '" & keyword & "' OR nama_anggota = '" & keyword & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                conn.Close()
                conn.Open()
                adapter = New MySqlDataAdapter("SELECT * FROM tblpembayaran WHERE id = '" & keyword & "' OR kode_anggota = '" & keyword & "' OR nama_anggota = '" & keyword & "'", conn)
                dataset = New DataSet
                adapter.Fill(dataset, "tblpembayaran")
                dgv.DataSource = dataset.Tables("tblpembayaran")
            Else
                Call getDgv()
            End If
        End If
    End Sub
End Class