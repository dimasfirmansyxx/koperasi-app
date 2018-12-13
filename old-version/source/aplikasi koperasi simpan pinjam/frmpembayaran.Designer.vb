<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpembayaran
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtangsuran = New System.Windows.Forms.TextBox()
        Me.txtjumlahpinjaman = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtkodepinjaman = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsisalalu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttempo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtterlambat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdenda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsisasekarang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 208)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(823, 270)
        Me.dgv.TabIndex = 49
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(639, 168)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 48
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(558, 168)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 47
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(477, 168)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 46
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtangsuran
        '
        Me.txtangsuran.Location = New System.Drawing.Point(198, 142)
        Me.txtangsuran.Name = "txtangsuran"
        Me.txtangsuran.ReadOnly = True
        Me.txtangsuran.Size = New System.Drawing.Size(198, 20)
        Me.txtangsuran.TabIndex = 42
        Me.txtangsuran.TabStop = False
        '
        'txtjumlahpinjaman
        '
        Me.txtjumlahpinjaman.Location = New System.Drawing.Point(198, 116)
        Me.txtjumlahpinjaman.Name = "txtjumlahpinjaman"
        Me.txtjumlahpinjaman.ReadOnly = True
        Me.txtjumlahpinjaman.Size = New System.Drawing.Size(198, 20)
        Me.txtjumlahpinjaman.TabIndex = 40
        Me.txtjumlahpinjaman.TabStop = False
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(198, 90)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(198, 20)
        Me.txtnama.TabIndex = 39
        Me.txtnama.TabStop = False
        '
        'txtkodepinjaman
        '
        Me.txtkodepinjaman.Location = New System.Drawing.Point(198, 64)
        Me.txtkodepinjaman.Name = "txtkodepinjaman"
        Me.txtkodepinjaman.Size = New System.Drawing.Size(198, 20)
        Me.txtkodepinjaman.TabIndex = 1
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(198, 38)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.Size = New System.Drawing.Size(198, 20)
        Me.txttanggal.TabIndex = 37
        Me.txttanggal.TabStop = False
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(198, 12)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.ReadOnly = True
        Me.txtkode.Size = New System.Drawing.Size(198, 20)
        Me.txtkode.TabIndex = 36
        Me.txtkode.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Angsuran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Jumlah Pinjaman"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nama Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Kode Pinjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Pembayaran"
        '
        'txtsisalalu
        '
        Me.txtsisalalu.Location = New System.Drawing.Point(198, 168)
        Me.txtsisalalu.Name = "txtsisalalu"
        Me.txtsisalalu.ReadOnly = True
        Me.txtsisalalu.Size = New System.Drawing.Size(198, 20)
        Me.txtsisalalu.TabIndex = 51
        Me.txtsisalalu.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(142, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Sisa Lalu"
        '
        'txttempo
        '
        Me.txttempo.Location = New System.Drawing.Point(516, 12)
        Me.txttempo.Name = "txttempo"
        Me.txttempo.ReadOnly = True
        Me.txttempo.Size = New System.Drawing.Size(198, 20)
        Me.txttempo.TabIndex = 53
        Me.txttempo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Jatuh Tempo"
        '
        'txtterlambat
        '
        Me.txtterlambat.Location = New System.Drawing.Point(516, 38)
        Me.txtterlambat.Name = "txtterlambat"
        Me.txtterlambat.ReadOnly = True
        Me.txtterlambat.Size = New System.Drawing.Size(198, 20)
        Me.txtterlambat.TabIndex = 55
        Me.txtterlambat.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(456, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Terlambat"
        '
        'txtdenda
        '
        Me.txtdenda.Location = New System.Drawing.Point(516, 64)
        Me.txtdenda.Name = "txtdenda"
        Me.txtdenda.ReadOnly = True
        Me.txtdenda.Size = New System.Drawing.Size(198, 20)
        Me.txtdenda.TabIndex = 57
        Me.txtdenda.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(471, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Denda"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(516, 90)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(198, 20)
        Me.txtjumlah.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(408, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Jumlah Pembayaran"
        '
        'txtsisasekarang
        '
        Me.txtsisasekarang.Location = New System.Drawing.Point(516, 116)
        Me.txtsisasekarang.Name = "txtsisasekarang"
        Me.txtsisasekarang.ReadOnly = True
        Me.txtsisasekarang.Size = New System.Drawing.Size(198, 20)
        Me.txtsisasekarang.TabIndex = 61
        Me.txtsisasekarang.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(434, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Sisa Sekarang"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(516, 142)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(198, 20)
        Me.txtketerangan.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(448, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Keterangan"
        '
        'frmpembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 495)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtsisasekarang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdenda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtterlambat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttempo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsisalalu)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtangsuran)
        Me.Controls.Add(Me.txtjumlahpinjaman)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkodepinjaman)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmpembayaran"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtangsuran As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlahpinjaman As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtkodepinjaman As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsisalalu As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttempo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtterlambat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdenda As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtsisasekarang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
