<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptsimpanan
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
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxbulan = New System.Windows.Forms.GroupBox()
        Me.btnviewbln = New System.Windows.Forms.Button()
        Me.cmbtahun = New System.Windows.Forms.ComboBox()
        Me.cmbbulan = New System.Windows.Forms.ComboBox()
        Me.gbxtahun = New System.Windows.Forms.GroupBox()
        Me.btnviewthn = New System.Windows.Forms.Button()
        Me.cmbpertahun = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxbulan.SuspendLayout()
        Me.gbxtahun.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv.Location = New System.Drawing.Point(0, 94)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(854, 378)
        Me.dgv.TabIndex = 0
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(439, 9)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(90, 79)
        Me.btnprint.TabIndex = 1
        Me.btnprint.Text = "Export"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 79)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Tampilkan Semua"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbxbulan
        '
        Me.gbxbulan.Controls.Add(Me.btnviewbln)
        Me.gbxbulan.Controls.Add(Me.cmbtahun)
        Me.gbxbulan.Controls.Add(Me.cmbbulan)
        Me.gbxbulan.Location = New System.Drawing.Point(111, 9)
        Me.gbxbulan.Name = "gbxbulan"
        Me.gbxbulan.Size = New System.Drawing.Size(155, 79)
        Me.gbxbulan.TabIndex = 3
        Me.gbxbulan.TabStop = False
        Me.gbxbulan.Text = "Berdasarkan Bulan"
        '
        'btnviewbln
        '
        Me.btnviewbln.Location = New System.Drawing.Point(7, 50)
        Me.btnviewbln.Name = "btnviewbln"
        Me.btnviewbln.Size = New System.Drawing.Size(140, 23)
        Me.btnviewbln.TabIndex = 2
        Me.btnviewbln.Text = "Preview"
        Me.btnviewbln.UseVisualStyleBackColor = True
        '
        'cmbtahun
        '
        Me.cmbtahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtahun.FormattingEnabled = True
        Me.cmbtahun.Location = New System.Drawing.Point(61, 23)
        Me.cmbtahun.Name = "cmbtahun"
        Me.cmbtahun.Size = New System.Drawing.Size(86, 21)
        Me.cmbtahun.TabIndex = 1
        '
        'cmbbulan
        '
        Me.cmbbulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbulan.FormattingEnabled = True
        Me.cmbbulan.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbbulan.Location = New System.Drawing.Point(7, 23)
        Me.cmbbulan.Name = "cmbbulan"
        Me.cmbbulan.Size = New System.Drawing.Size(48, 21)
        Me.cmbbulan.TabIndex = 0
        '
        'gbxtahun
        '
        Me.gbxtahun.Controls.Add(Me.btnviewthn)
        Me.gbxtahun.Controls.Add(Me.cmbpertahun)
        Me.gbxtahun.Location = New System.Drawing.Point(275, 9)
        Me.gbxtahun.Name = "gbxtahun"
        Me.gbxtahun.Size = New System.Drawing.Size(155, 79)
        Me.gbxtahun.TabIndex = 4
        Me.gbxtahun.TabStop = False
        Me.gbxtahun.Text = "Berdasarkan Tahun"
        '
        'btnviewthn
        '
        Me.btnviewthn.Location = New System.Drawing.Point(7, 50)
        Me.btnviewthn.Name = "btnviewthn"
        Me.btnviewthn.Size = New System.Drawing.Size(140, 23)
        Me.btnviewthn.TabIndex = 2
        Me.btnviewthn.Text = "Preview"
        Me.btnviewthn.UseVisualStyleBackColor = True
        '
        'cmbpertahun
        '
        Me.cmbpertahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpertahun.FormattingEnabled = True
        Me.cmbpertahun.Location = New System.Drawing.Point(7, 23)
        Me.cmbpertahun.Name = "cmbpertahun"
        Me.cmbpertahun.Size = New System.Drawing.Size(140, 21)
        Me.cmbpertahun.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(610, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cari : "
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(613, 42)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(207, 20)
        Me.txtcari.TabIndex = 6
        '
        'frmrptsimpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 472)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxtahun)
        Me.Controls.Add(Me.gbxbulan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.dgv)
        Me.MaximizeBox = False
        Me.Name = "frmrptsimpanan"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Simpanan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxbulan.ResumeLayout(False)
        Me.gbxtahun.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbxtahun As System.Windows.Forms.GroupBox
    Friend WithEvents btnviewthn As System.Windows.Forms.Button
    Friend WithEvents cmbpertahun As System.Windows.Forms.ComboBox
    Friend WithEvents gbxbulan As System.Windows.Forms.GroupBox
    Friend WithEvents btnviewbln As System.Windows.Forms.Button
    Friend WithEvents cmbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
