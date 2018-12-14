namespace koperasi_app
{
    partial class ucAnggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAnggota));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telepon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ktp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKode = new DevExpress.XtraEditors.TextEdit();
            this.gbxForm = new System.Windows.Forms.GroupBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtKTP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelepon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTipe = new DevExpress.XtraEditors.LabelControl();
            this.gbxManageUser = new DevExpress.XtraEditors.GroupControl();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKode.Properties)).BeginInit();
            this.gbxForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxManageUser)).BeginInit();
            this.gbxManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(800, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(719, 133);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnHapus.Appearance.Options.UseFont = true;
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.Location = new System.Drawing.Point(369, 235);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(174, 40);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.TabStop = false;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgv
            // 
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 285);
            this.dgv.MainView = this.gridViewData;
            this.dgv.Name = "dgv";
            this.dgv.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.dgv.Size = new System.Drawing.Size(922, 420);
            this.dgv.TabIndex = 5;
            this.dgv.TabStop = false;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.kode,
            this.nama,
            this.alamat,
            this.telepon,
            this.ktp,
            this.saldo});
            this.gridViewData.GridControl = this.dgv;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            // 
            // kode
            // 
            this.kode.Caption = "Kode Anggota";
            this.kode.FieldName = "kode";
            this.kode.Name = "kode";
            this.kode.Visible = true;
            this.kode.VisibleIndex = 0;
            // 
            // nama
            // 
            this.nama.Caption = "Nama";
            this.nama.FieldName = "nama";
            this.nama.Name = "nama";
            this.nama.Visible = true;
            this.nama.VisibleIndex = 1;
            // 
            // alamat
            // 
            this.alamat.Caption = "Alamat";
            this.alamat.FieldName = "alamat";
            this.alamat.Name = "alamat";
            this.alamat.Visible = true;
            this.alamat.VisibleIndex = 2;
            // 
            // telepon
            // 
            this.telepon.Caption = "Telepon";
            this.telepon.FieldName = "telepon";
            this.telepon.Name = "telepon";
            this.telepon.Visible = true;
            this.telepon.VisibleIndex = 3;
            // 
            // ktp
            // 
            this.ktp.Caption = "KTP";
            this.ktp.FieldName = "ktp";
            this.ktp.Name = "ktp";
            this.ktp.Visible = true;
            this.ktp.VisibleIndex = 4;
            // 
            // saldo
            // 
            this.saldo.Caption = "Saldo";
            this.saldo.DisplayFormat.FormatString = "c2";
            this.saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.saldo.FieldName = "saldo";
            this.saldo.Name = "saldo";
            this.saldo.Visible = true;
            this.saldo.VisibleIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(189, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 40);
            this.btnEdit.TabIndex = 1;
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
            this.btnTambah.Location = new System.Drawing.Point(9, 235);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(174, 40);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.TabStop = false;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(68, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(113, 92);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(335, 20);
            this.txtNama.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(74, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kode";
            // 
            // txtKode
            // 
            this.txtKode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKode.Enabled = false;
            this.txtKode.Location = new System.Drawing.Point(113, 63);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(97, 20);
            this.txtKode.TabIndex = 1;
            this.txtKode.TabStop = false;
            // 
            // gbxForm
            // 
            this.gbxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxForm.Controls.Add(this.txtAlamat);
            this.gbxForm.Controls.Add(this.txtKTP);
            this.gbxForm.Controls.Add(this.labelControl6);
            this.gbxForm.Controls.Add(this.txtTelepon);
            this.gbxForm.Controls.Add(this.labelControl4);
            this.gbxForm.Controls.Add(this.labelControl5);
            this.gbxForm.Controls.Add(this.cmbTipe);
            this.gbxForm.Controls.Add(this.lblTipe);
            this.gbxForm.Controls.Add(this.btnCancel);
            this.gbxForm.Controls.Add(this.btnSubmit);
            this.gbxForm.Controls.Add(this.txtNama);
            this.gbxForm.Controls.Add(this.labelControl2);
            this.gbxForm.Controls.Add(this.txtKode);
            this.gbxForm.Controls.Add(this.labelControl1);
            this.gbxForm.Enabled = false;
            this.gbxForm.Location = new System.Drawing.Point(9, 38);
            this.gbxForm.Name = "gbxForm";
            this.gbxForm.Size = new System.Drawing.Size(908, 182);
            this.gbxForm.TabIndex = 8;
            this.gbxForm.TabStop = false;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(544, 33);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(335, 49);
            this.txtAlamat.TabIndex = 3;
            // 
            // txtKTP
            // 
            this.txtKTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKTP.Enabled = false;
            this.txtKTP.Location = new System.Drawing.Point(113, 121);
            this.txtKTP.Name = "txtKTP";
            this.txtKTP.Size = new System.Drawing.Size(335, 20);
            this.txtKTP.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.Location = new System.Drawing.Point(31, 120);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Nomor KTP";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelepon.Enabled = false;
            this.txtTelepon.Location = new System.Drawing.Point(544, 88);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(335, 20);
            this.txtTelepon.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.Location = new System.Drawing.Point(486, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 18);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Telepon";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.Location = new System.Drawing.Point(493, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Alamat";
            // 
            // cmbTipe
            // 
            this.cmbTipe.EditValue = "-- Pilih Tipe Anggota --";
            this.cmbTipe.Location = new System.Drawing.Point(113, 34);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Properties.AutoComplete = false;
            this.cmbTipe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipe.Properties.DropDownRows = 3;
            this.cmbTipe.Properties.Items.AddRange(new object[] {
            "Anggota",
            "Pengurus",
            "Pendiri"});
            this.cmbTipe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTipe.Size = new System.Drawing.Size(143, 20);
            this.cmbTipe.TabIndex = 0;
            this.cmbTipe.SelectedIndexChanged += new System.EventHandler(this.cmbTipe_SelectedIndexChanged);
            // 
            // lblTipe
            // 
            this.lblTipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipe.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTipe.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTipe.Location = new System.Drawing.Point(20, 33);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(87, 18);
            this.lblTipe.TabIndex = 4;
            this.lblTipe.Text = "Tipe Anggota";
            // 
            // gbxManageUser
            // 
            this.gbxManageUser.Controls.Add(this.btnHapus);
            this.gbxManageUser.Controls.Add(this.btnEdit);
            this.gbxManageUser.Controls.Add(this.btnTambah);
            this.gbxManageUser.Controls.Add(this.gbxForm);
            this.gbxManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxManageUser.Location = new System.Drawing.Point(0, 0);
            this.gbxManageUser.Name = "gbxManageUser";
            this.gbxManageUser.Size = new System.Drawing.Size(922, 705);
            this.gbxManageUser.TabIndex = 6;
            this.gbxManageUser.Text = "Manajemen Anggota";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ucAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbxManageUser);
            this.Name = "ucAnggota";
            this.Size = new System.Drawing.Size(922, 705);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKode.Properties)).EndInit();
            this.gbxForm.ResumeLayout(false);
            this.gbxForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxManageUser)).EndInit();
            this.gbxManageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKode;
        private System.Windows.Forms.GroupBox gbxForm;
        private DevExpress.XtraEditors.GroupControl gbxManageUser;
        private DevExpress.XtraGrid.Columns.GridColumn kode;
        private DevExpress.XtraGrid.Columns.GridColumn nama;
        private DevExpress.XtraGrid.Columns.GridColumn alamat;
        private DevExpress.XtraGrid.Columns.GridColumn telepon;
        private DevExpress.XtraGrid.Columns.GridColumn ktp;
        private DevExpress.XtraGrid.Columns.GridColumn saldo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipe;
        private DevExpress.XtraEditors.LabelControl lblTipe;
        private DevExpress.XtraEditors.TextEdit txtKTP;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTelepon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtAlamat;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}
