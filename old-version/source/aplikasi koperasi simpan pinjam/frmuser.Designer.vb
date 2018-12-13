<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnaksi = New System.Windows.Forms.Button()
        Me.gbxbox = New System.Windows.Forms.GroupBox()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(64, 16)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.ReadOnly = True
        Me.txtkode.Size = New System.Drawing.Size(153, 20)
        Me.txtkode.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(64, 54)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(369, 20)
        Me.txtnama.TabIndex = 5
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(64, 91)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(369, 20)
        Me.txtuname.TabIndex = 6
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(64, 129)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(369, 20)
        Me.txtpass.TabIndex = 7
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(13, 240)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(798, 232)
        Me.dgv.TabIndex = 8
        '
        'btnaksi
        '
        Me.btnaksi.Location = New System.Drawing.Point(203, 155)
        Me.btnaksi.Name = "btnaksi"
        Me.btnaksi.Size = New System.Drawing.Size(112, 23)
        Me.btnaksi.TabIndex = 9
        Me.btnaksi.UseVisualStyleBackColor = True
        Me.btnaksi.Visible = False
        '
        'gbxbox
        '
        Me.gbxbox.Controls.Add(Me.btnbatal)
        Me.gbxbox.Controls.Add(Me.txtnama)
        Me.gbxbox.Controls.Add(Me.btnaksi)
        Me.gbxbox.Controls.Add(Me.Label1)
        Me.gbxbox.Controls.Add(Me.Label2)
        Me.gbxbox.Controls.Add(Me.txtpass)
        Me.gbxbox.Controls.Add(Me.Label3)
        Me.gbxbox.Controls.Add(Me.txtuname)
        Me.gbxbox.Controls.Add(Me.Label4)
        Me.gbxbox.Controls.Add(Me.txtkode)
        Me.gbxbox.Enabled = False
        Me.gbxbox.Location = New System.Drawing.Point(13, 12)
        Me.gbxbox.Name = "gbxbox"
        Me.gbxbox.Size = New System.Drawing.Size(476, 184)
        Me.gbxbox.TabIndex = 10
        Me.gbxbox.TabStop = False
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(321, 155)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(112, 23)
        Me.btnbatal.TabIndex = 10
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        Me.btnbatal.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(563, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 58)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Tambah User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(676, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 58)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Edit User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(563, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 58)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Hapus User"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(676, 103)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 58)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Tutup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(49, 214)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(440, 20)
        Me.txtcari.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cari"
        '
        'frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 482)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbxbox)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmuser"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen User"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxbox.ResumeLayout(False)
        Me.gbxbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnaksi As System.Windows.Forms.Button
    Friend WithEvents gbxbox As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
