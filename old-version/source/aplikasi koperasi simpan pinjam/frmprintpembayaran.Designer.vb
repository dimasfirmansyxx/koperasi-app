<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprintpembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAngsuran = New System.Windows.Forms.Label()
        Me.lblJmlPinjaman = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblJmlPembayaran = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAngsuran
        '
        Me.lblAngsuran.AutoSize = True
        Me.lblAngsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngsuran.Location = New System.Drawing.Point(166, 169)
        Me.lblAngsuran.Name = "lblAngsuran"
        Me.lblAngsuran.Size = New System.Drawing.Size(12, 17)
        Me.lblAngsuran.TabIndex = 17
        Me.lblAngsuran.Text = ":"
        '
        'lblJmlPinjaman
        '
        Me.lblJmlPinjaman.AutoSize = True
        Me.lblJmlPinjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlPinjaman.Location = New System.Drawing.Point(166, 152)
        Me.lblJmlPinjaman.Name = "lblJmlPinjaman"
        Me.lblJmlPinjaman.Size = New System.Drawing.Size(55, 17)
        Me.lblJmlPinjaman.TabIndex = 16
        Me.lblJmlPinjaman.Text = ": Pokok"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(166, 135)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(132, 17)
        Me.lblNama.TabIndex = 15
        Me.lblNama.Text = ": Dimas Firmansyah"
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(166, 118)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(49, 17)
        Me.lblKode.TabIndex = 14
        Me.lblKode.Text = ": 001P"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(166, 101)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(88, 17)
        Me.lblTanggal.TabIndex = 13
        Me.lblTanggal.Text = ": 20/12/2019"
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.Location = New System.Drawing.Point(166, 84)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(96, 17)
        Me.lblTransaksi.TabIndex = 12
        Me.lblTransaksi.Text = ": 2019293123"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 136)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "No. Transaksi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tanggal         " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kode Pinjaman" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nama" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jumlah Pinjaman" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angsuran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Jumlah Pembayaran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keterangan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "STRUK TRANSAKSI PEMBAYARAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "KOPERASI KSPN GRAND BEST"
        '
        'lblJmlPembayaran
        '
        Me.lblJmlPembayaran.AutoSize = True
        Me.lblJmlPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlPembayaran.Location = New System.Drawing.Point(166, 186)
        Me.lblJmlPembayaran.Name = "lblJmlPembayaran"
        Me.lblJmlPembayaran.Size = New System.Drawing.Size(12, 17)
        Me.lblJmlPembayaran.TabIndex = 18
        Me.lblJmlPembayaran.Text = ":"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(166, 205)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(12, 17)
        Me.lblKeterangan.TabIndex = 19
        Me.lblKeterangan.Text = ":"
        '
        'frmprintpembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 430)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblJmlPembayaran)
        Me.Controls.Add(Me.lblAngsuran)
        Me.Controls.Add(Me.lblJmlPinjaman)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblTransaksi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmprintpembayaran"
        Me.Text = "Print : Transaksi Pembayaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAngsuran As Label
    Friend WithEvents lblJmlPinjaman As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTransaksi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblJmlPembayaran As Label
    Friend WithEvents lblKeterangan As Label
End Class
