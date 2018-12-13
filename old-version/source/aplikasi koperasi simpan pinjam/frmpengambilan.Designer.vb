<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpengambilan
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
        Me.gbxbox = New System.Windows.Forms.GroupBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnaksi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkodeanggota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.gbxbox.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxbox
        '
        Me.gbxbox.Controls.Add(Me.txtsaldo)
        Me.gbxbox.Controls.Add(Me.txttanggal)
        Me.gbxbox.Controls.Add(Me.txtjumlah)
        Me.gbxbox.Controls.Add(Me.Label5)
        Me.gbxbox.Controls.Add(Me.Label6)
        Me.gbxbox.Controls.Add(Me.btnbatal)
        Me.gbxbox.Controls.Add(Me.btnaksi)
        Me.gbxbox.Controls.Add(Me.Label1)
        Me.gbxbox.Controls.Add(Me.Label2)
        Me.gbxbox.Controls.Add(Me.txtnama)
        Me.gbxbox.Controls.Add(Me.Label3)
        Me.gbxbox.Controls.Add(Me.txtkodeanggota)
        Me.gbxbox.Controls.Add(Me.Label4)
        Me.gbxbox.Controls.Add(Me.txtkode)
        Me.gbxbox.Location = New System.Drawing.Point(12, 12)
        Me.gbxbox.Name = "gbxbox"
        Me.gbxbox.Size = New System.Drawing.Size(580, 240)
        Me.gbxbox.TabIndex = 35
        Me.gbxbox.TabStop = False
        Me.gbxbox.Text = "Pengambilan"
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(115, 64)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.Size = New System.Drawing.Size(153, 20)
        Me.txttanggal.TabIndex = 17
        Me.txttanggal.TabStop = False
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(396, 170)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(161, 20)
        Me.txtjumlah.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Jumlah Pengambilan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Saldo"
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(445, 204)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(112, 23)
        Me.btnbatal.TabIndex = 13
        Me.btnbatal.TabStop = False
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnaksi
        '
        Me.btnaksi.Location = New System.Drawing.Point(327, 204)
        Me.btnaksi.Name = "btnaksi"
        Me.btnaksi.Size = New System.Drawing.Size(112, 23)
        Me.btnaksi.TabIndex = 12
        Me.btnaksi.Text = "Simpan"
        Me.btnaksi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(115, 136)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(442, 20)
        Me.txtnama.TabIndex = 7
        Me.txtnama.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Anggota"
        '
        'txtkodeanggota
        '
        Me.txtkodeanggota.Location = New System.Drawing.Point(115, 101)
        Me.txtkodeanggota.Name = "txtkodeanggota"
        Me.txtkodeanggota.Size = New System.Drawing.Size(442, 20)
        Me.txtkodeanggota.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Anggota"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(115, 26)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.ReadOnly = True
        Me.txtkode.Size = New System.Drawing.Size(153, 20)
        Me.txtkode.TabIndex = 4
        Me.txtkode.TabStop = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 258)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(781, 258)
        Me.dgv.TabIndex = 34
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(625, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 58)
        Me.Button5.TabIndex = 38
        Me.Button5.TabStop = False
        Me.Button5.Text = "Tutup"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(115, 170)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.Size = New System.Drawing.Size(165, 20)
        Me.txtsaldo.TabIndex = 18
        Me.txtsaldo.TabStop = False
        '
        'frmpengambilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 527)
        Me.Controls.Add(Me.gbxbox)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Button5)
        Me.MaximizeBox = False
        Me.Name = "frmpengambilan"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengambilan"
        Me.gbxbox.ResumeLayout(False)
        Me.gbxbox.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxbox As System.Windows.Forms.GroupBox
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnaksi As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtkodeanggota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
End Class
