namespace koperasi_app
{
    partial class ucRptSimpanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRptSimpanan));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxManageUser = new DevExpress.XtraEditors.GroupControl();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.btnTampil = new DevExpress.XtraEditors.SimpleButton();
            this.dateSampai = new DevExpress.XtraEditors.DateEdit();
            this.dateDari = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tanggal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kode_anggota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nama_anggota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jenis_simpanan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jumlah = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbxManageUser)).BeginInit();
            this.gbxManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSampai.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSampai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDari.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // gbxManageUser
            // 
            this.gbxManageUser.Controls.Add(this.btnCetak);
            this.gbxManageUser.Controls.Add(this.btnTampil);
            this.gbxManageUser.Controls.Add(this.dateSampai);
            this.gbxManageUser.Controls.Add(this.dateDari);
            this.gbxManageUser.Controls.Add(this.labelControl2);
            this.gbxManageUser.Controls.Add(this.labelControl1);
            this.gbxManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxManageUser.Location = new System.Drawing.Point(0, 0);
            this.gbxManageUser.Name = "gbxManageUser";
            this.gbxManageUser.Size = new System.Drawing.Size(787, 686);
            this.gbxManageUser.TabIndex = 7;
            this.gbxManageUser.Text = "Manajemen User";
            // 
            // btnCetak
            // 
            this.btnCetak.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCetak.Appearance.Options.UseFont = true;
            this.btnCetak.Enabled = false;
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.Location = new System.Drawing.Point(267, 100);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(89, 29);
            this.btnCetak.TabIndex = 5;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTampil.Appearance.Options.UseFont = true;
            this.btnTampil.Image = ((System.Drawing.Image)(resources.GetObject("btnTampil.Image")));
            this.btnTampil.Location = new System.Drawing.Point(172, 100);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(89, 29);
            this.btnTampil.TabIndex = 4;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // dateSampai
            // 
            this.dateSampai.EditValue = null;
            this.dateSampai.Location = new System.Drawing.Point(121, 72);
            this.dateSampai.Name = "dateSampai";
            this.dateSampai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSampai.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSampai.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateSampai.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateSampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateSampai.Size = new System.Drawing.Size(235, 20);
            this.dateSampai.TabIndex = 3;
            // 
            // dateDari
            // 
            this.dateDari.EditValue = null;
            this.dateDari.Location = new System.Drawing.Point(121, 41);
            this.dateDari.Name = "dateDari";
            this.dateDari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDari.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDari.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateDari.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateDari.Size = new System.Drawing.Size(235, 20);
            this.dateDari.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(22, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Sampai Tanggal";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(42, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Dari Tanggal";
            // 
            // dgv
            // 
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 155);
            this.dgv.MainView = this.gridViewData;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(787, 531);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
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
            // tanggal
            // 
            this.tanggal.Caption = "Tanggal";
            this.tanggal.FieldName = "tanggal";
            this.tanggal.Name = "tanggal";
            this.tanggal.Visible = true;
            this.tanggal.VisibleIndex = 1;
            // 
            // kode_anggota
            // 
            this.kode_anggota.Caption = "Kode Anggota";
            this.kode_anggota.FieldName = "kode_anggota";
            this.kode_anggota.Name = "kode_anggota";
            this.kode_anggota.Visible = true;
            this.kode_anggota.VisibleIndex = 2;
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
            // ucRptSimpanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbxManageUser);
            this.Name = "ucRptSimpanan";
            this.Size = new System.Drawing.Size(787, 686);
            ((System.ComponentModel.ISupportInitialize)(this.gbxManageUser)).EndInit();
            this.gbxManageUser.ResumeLayout(false);
            this.gbxManageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSampai.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSampai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDari.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.GroupControl gbxManageUser;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn tanggal;
        private DevExpress.XtraGrid.Columns.GridColumn kode_anggota;
        private DevExpress.XtraGrid.Columns.GridColumn nama_anggota;
        private DevExpress.XtraGrid.Columns.GridColumn jenis_simpanan;
        private DevExpress.XtraGrid.Columns.GridColumn jumlah;
        private DevExpress.XtraEditors.DateEdit dateSampai;
        private DevExpress.XtraEditors.DateEdit dateDari;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton btnTampil;
    }
}
