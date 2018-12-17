namespace koperasi_app
{
    partial class ucSimpanan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSimpanan));
            this.gbxManageUser = new DevExpress.XtraEditors.GroupControl();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
            this.txtJumlah = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbJenis = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamaAnggota = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKodeTransaksi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKodeAnggota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.kode_anggota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nama_anggota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jenis_simpanan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jumlah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbxManageUser)).BeginInit();
            this.gbxManageUser.SuspendLayout();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJenis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamaAnggota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeTransaksi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeAnggota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxManageUser
            // 
            this.gbxManageUser.Controls.Add(this.btnHapus);
            this.gbxManageUser.Controls.Add(this.btnEdit);
            this.gbxManageUser.Controls.Add(this.btnTambah);
            this.gbxManageUser.Controls.Add(this.labelControl6);
            this.gbxManageUser.Controls.Add(this.gbx);
            this.gbxManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxManageUser.Location = new System.Drawing.Point(0, 0);
            this.gbxManageUser.Name = "gbxManageUser";
            this.gbxManageUser.Size = new System.Drawing.Size(872, 287);
            this.gbxManageUser.TabIndex = 6;
            this.gbxManageUser.Text = "Manajemen User";
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnHapus.Appearance.Options.UseFont = true;
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.Location = new System.Drawing.Point(379, 231);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(174, 40);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.TabStop = false;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(199, 231);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 40);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Appearance.Options.UseFont = true;
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.Location = new System.Drawing.Point(19, 231);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(174, 40);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.TabStop = false;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(31, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(100, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Kode Transaksi";
            // 
            // gbx
            // 
            this.gbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbx.Controls.Add(this.txtTanggal);
            this.gbx.Controls.Add(this.txtJumlah);
            this.gbx.Controls.Add(this.labelControl8);
            this.gbx.Controls.Add(this.cmbJenis);
            this.gbx.Controls.Add(this.labelControl7);
            this.gbx.Controls.Add(this.txtNamaAnggota);
            this.gbx.Controls.Add(this.btnCancel);
            this.gbx.Controls.Add(this.btnSubmit);
            this.gbx.Controls.Add(this.labelControl3);
            this.gbx.Controls.Add(this.txtKodeTransaksi);
            this.gbx.Controls.Add(this.labelControl5);
            this.gbx.Controls.Add(this.txtKodeAnggota);
            this.gbx.Controls.Add(this.labelControl4);
            this.gbx.Enabled = false;
            this.gbx.Location = new System.Drawing.Point(15, 34);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(701, 182);
            this.gbx.TabIndex = 20;
            this.gbx.TabStop = false;
            // 
            // txtTanggal
            // 
            this.txtTanggal.EditValue = null;
            this.txtTanggal.Location = new System.Drawing.Point(122, 56);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.txtTanggal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtTanggal.Size = new System.Drawing.Size(133, 20);
            this.txtTanggal.TabIndex = 1;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtJumlah.Enabled = false;
            this.txtJumlah.Location = new System.Drawing.Point(468, 82);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(200, 20);
            this.txtJumlah.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.Location = new System.Drawing.Point(350, 81);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(113, 18);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Jumlah Simpanan";
            // 
            // cmbJenis
            // 
            this.cmbJenis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbJenis.Location = new System.Drawing.Point(467, 56);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbJenis.Properties.Items.AddRange(new object[] {
            "Pokok",
            "Wajib",
            "Sukarela"});
            this.cmbJenis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbJenis.Size = new System.Drawing.Size(201, 20);
            this.cmbJenis.TabIndex = 4;
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.cmbJenis_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(364, 55);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 18);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Jenis Simpanan";
            // 
            // txtNamaAnggota
            // 
            this.txtNamaAnggota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNamaAnggota.Enabled = false;
            this.txtNamaAnggota.Location = new System.Drawing.Point(468, 30);
            this.txtNamaAnggota.Name = "txtNamaAnggota";
            this.txtNamaAnggota.Size = new System.Drawing.Size(200, 20);
            this.txtNamaAnggota.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(593, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(501, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(364, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 18);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Nama Anggota";
            // 
            // txtKodeTransaksi
            // 
            this.txtKodeTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKodeTransaksi.Enabled = false;
            this.txtKodeTransaksi.Location = new System.Drawing.Point(122, 30);
            this.txtKodeTransaksi.Name = "txtKodeTransaksi";
            this.txtKodeTransaksi.Size = new System.Drawing.Size(133, 20);
            this.txtKodeTransaksi.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(12, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 18);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Tanggal Simpan";
            // 
            // txtKodeAnggota
            // 
            this.txtKodeAnggota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKodeAnggota.Enabled = false;
            this.txtKodeAnggota.Location = new System.Drawing.Point(122, 82);
            this.txtKodeAnggota.Name = "txtKodeAnggota";
            this.txtKodeAnggota.Size = new System.Drawing.Size(200, 20);
            this.txtKodeAnggota.TabIndex = 2;
            this.txtKodeAnggota.EditValueChanged += new System.EventHandler(this.txtKodeAnggota_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(24, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 18);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Kode Anggota";
            // 
            // kode_anggota
            // 
            this.kode_anggota.Caption = "Kode Anggota";
            this.kode_anggota.FieldName = "kode_anggota";
            this.kode_anggota.Name = "kode_anggota";
            this.kode_anggota.Visible = true;
            this.kode_anggota.VisibleIndex = 2;
            // 
            // tanggal
            // 
            this.tanggal.Caption = "Tanggal";
            this.tanggal.FieldName = "tanggal";
            this.tanggal.Name = "tanggal";
            this.tanggal.Visible = true;
            this.tanggal.VisibleIndex = 1;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.tanggal,
            this.kode_anggota,
            this.nama_anggota,
            this.jenis_simpanan,
            this.jumlah});
            this.gridViewData.GridControl = this.dgv;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            // 
            // id
            // 
            this.id.Caption = "Kode Transaksi";
            this.id.FieldName = "id";
            this.id.MinWidth = 10;
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // nama_anggota
            // 
            this.nama_anggota.Caption = "Nama";
            this.nama_anggota.FieldName = "nama_anggota";
            this.nama_anggota.Name = "nama_anggota";
            this.nama_anggota.Visible = true;
            this.nama_anggota.VisibleIndex = 3;
            // 
            // jenis_simpanan
            // 
            this.jenis_simpanan.Caption = "Jenis";
            this.jenis_simpanan.FieldName = "jenis_simpanan";
            this.jenis_simpanan.Name = "jenis_simpanan";
            this.jenis_simpanan.Visible = true;
            this.jenis_simpanan.VisibleIndex = 4;
            // 
            // jumlah
            // 
            this.jumlah.Caption = "Jumlah";
            this.jumlah.FieldName = "jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.Visible = true;
            this.jumlah.VisibleIndex = 5;
            // 
            // dgv
            // 
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 287);
            this.dgv.MainView = this.gridViewData;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(872, 420);
            this.dgv.TabIndex = 5;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucSimpanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxManageUser);
            this.Controls.Add(this.dgv);
            this.Name = "ucSimpanan";
            this.Size = new System.Drawing.Size(872, 707);
            ((System.ComponentModel.ISupportInitialize)(this.gbxManageUser)).EndInit();
            this.gbxManageUser.ResumeLayout(false);
            this.gbxManageUser.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJenis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamaAnggota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeTransaksi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodeAnggota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gbxManageUser;
        private DevExpress.XtraGrid.Columns.GridColumn kode_anggota;
        private DevExpress.XtraGrid.Columns.GridColumn tanggal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKodeAnggota;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtKodeTransaksi;
        private System.Windows.Forms.GroupBox gbx;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.TextEdit txtJumlah;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cmbJenis;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNamaAnggota;
        private DevExpress.XtraGrid.Columns.GridColumn nama_anggota;
        private DevExpress.XtraGrid.Columns.GridColumn jenis_simpanan;
        private DevExpress.XtraGrid.Columns.GridColumn jumlah;
        private DevExpress.XtraEditors.DateEdit txtTanggal;
        private System.Windows.Forms.Timer timer1;
    }
}
