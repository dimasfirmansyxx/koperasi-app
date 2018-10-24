<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmanggota
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxbox = New System.Windows.Forms.GroupBox()
        Me.txtktp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.btnaksi = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gbxbox.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(51, 241)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(440, 20)
        Me.txtcari.TabIndex = 23
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(333, 189)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(112, 23)
        Me.btnbatal.TabIndex = 13
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        Me.btnbatal.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(573, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 58)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Hapus Anggota"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(686, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 58)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Edit Anggota"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 58)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Tambah Anggota"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbxbox
        '
        Me.gbxbox.Controls.Add(Me.txtktp)
        Me.gbxbox.Controls.Add(Me.Label6)
        Me.gbxbox.Controls.Add(Me.btnbatal)
        Me.gbxbox.Controls.Add(Me.txtnama)
        Me.gbxbox.Controls.Add(Me.btnaksi)
        Me.gbxbox.Controls.Add(Me.Label1)
        Me.gbxbox.Controls.Add(Me.Label2)
        Me.gbxbox.Controls.Add(Me.txthp)
        Me.gbxbox.Controls.Add(Me.Label3)
        Me.gbxbox.Controls.Add(Me.txtalamat)
        Me.gbxbox.Controls.Add(Me.Label4)
        Me.gbxbox.Controls.Add(Me.txtkode)
        Me.gbxbox.Enabled = False
        Me.gbxbox.Location = New System.Drawing.Point(23, 12)
        Me.gbxbox.Name = "gbxbox"
        Me.gbxbox.Size = New System.Drawing.Size(476, 223)
        Me.gbxbox.TabIndex = 18
        Me.gbxbox.TabStop = False
        '
        'txtktp
        '
        Me.txtktp.Location = New System.Drawing.Point(76, 160)
        Me.txtktp.Name = "txtktp"
        Me.txtktp.Size = New System.Drawing.Size(369, 20)
        Me.txtktp.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nomor KTP"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(76, 54)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(369, 20)
        Me.txtnama.TabIndex = 5
        '
        'btnaksi
        '
        Me.btnaksi.Location = New System.Drawing.Point(215, 189)
        Me.btnaksi.Name = "btnaksi"
        Me.btnaksi.Size = New System.Drawing.Size(112, 23)
        Me.btnaksi.TabIndex = 12
        Me.btnaksi.UseVisualStyleBackColor = True
        Me.btnaksi.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'txthp
        '
        Me.txthp.Location = New System.Drawing.Point(76, 126)
        Me.txthp.Name = "txthp"
        Me.txthp.Size = New System.Drawing.Size(369, 20)
        Me.txthp.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(76, 91)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(369, 20)
        Me.txtalamat.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telepon"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(76, 16)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.ReadOnly = True
        Me.txtkode.Size = New System.Drawing.Size(153, 20)
        Me.txtkode.TabIndex = 4
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(23, 278)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(993, 243)
        Me.dgv.TabIndex = 17
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(686, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 57)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Tutup"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmanggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 533)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbxbox)
        Me.Controls.Add(Me.dgv)
        Me.MaximizeBox = False
        Me.Name = "frmanggota"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anggota"
        Me.gbxbox.ResumeLayout(False)
        Me.gbxbox.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbxbox As System.Windows.Forms.GroupBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents btnaksi As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txthp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtktp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
