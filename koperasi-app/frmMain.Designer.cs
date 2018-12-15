namespace koperasi_app
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgMaster = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiUser = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiAnggota = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPengaturan = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgTransaksi = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiSimpanan = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPengambilan = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPinjaman = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPembayaran = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgReport = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiReportSimpanan = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportPengambilan = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportPinjaman = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportPembayaran = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgLogout = new DevExpress.XtraNavBar.NavBarGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBussinesUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBusinessUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsernameLogged = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgMaster;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMaster,
            this.nbgTransaksi,
            this.nbgReport,
            this.nbgLogout});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiUser,
            this.nbiAnggota,
            this.nbiPengaturan,
            this.nbiSimpanan,
            this.nbiPengambilan,
            this.nbiPinjaman,
            this.nbiPembayaran,
            this.nbiReportSimpanan,
            this.nbiReportPengambilan,
            this.nbiReportPinjaman,
            this.nbiReportPembayaran});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 173;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(173, 507);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Metropolis Dark");
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // nbgMaster
            // 
            this.nbgMaster.Caption = "Master";
            this.nbgMaster.Expanded = true;
            this.nbgMaster.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAnggota),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPengaturan)});
            this.nbgMaster.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgMaster.LargeImage")));
            this.nbgMaster.LargeImageIndex = -3;
            this.nbgMaster.Name = "nbgMaster";
            // 
            // nbiUser
            // 
            this.nbiUser.Caption = "User";
            this.nbiUser.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiUser.LargeImage")));
            this.nbiUser.Name = "nbiUser";
            this.nbiUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUser_LinkClicked);
            // 
            // nbiAnggota
            // 
            this.nbiAnggota.Caption = "Anggota";
            this.nbiAnggota.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiAnggota.LargeImage")));
            this.nbiAnggota.Name = "nbiAnggota";
            this.nbiAnggota.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAnggota_LinkClicked);
            // 
            // nbiPengaturan
            // 
            this.nbiPengaturan.Caption = "Pengaturan";
            this.nbiPengaturan.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiPengaturan.LargeImage")));
            this.nbiPengaturan.Name = "nbiPengaturan";
            this.nbiPengaturan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPengaturan_LinkClicked);
            // 
            // nbgTransaksi
            // 
            this.nbgTransaksi.Caption = "Transaksi";
            this.nbgTransaksi.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSimpanan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPengambilan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPinjaman),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPembayaran)});
            this.nbgTransaksi.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgTransaksi.LargeImage")));
            this.nbgTransaksi.Name = "nbgTransaksi";
            // 
            // nbiSimpanan
            // 
            this.nbiSimpanan.Caption = "Simpanan";
            this.nbiSimpanan.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiSimpanan.LargeImage")));
            this.nbiSimpanan.Name = "nbiSimpanan";
            // 
            // nbiPengambilan
            // 
            this.nbiPengambilan.Caption = "Pengambilan";
            this.nbiPengambilan.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiPengambilan.LargeImage")));
            this.nbiPengambilan.Name = "nbiPengambilan";
            // 
            // nbiPinjaman
            // 
            this.nbiPinjaman.Caption = "Pinjaman";
            this.nbiPinjaman.Name = "nbiPinjaman";
            // 
            // nbiPembayaran
            // 
            this.nbiPembayaran.Caption = "Pembayaran";
            this.nbiPembayaran.Name = "nbiPembayaran";
            // 
            // nbgReport
            // 
            this.nbgReport.Caption = "Laporan";
            this.nbgReport.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportSimpanan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportPengambilan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportPinjaman),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportPembayaran)});
            this.nbgReport.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgReport.LargeImage")));
            this.nbgReport.Name = "nbgReport";
            // 
            // nbiReportSimpanan
            // 
            this.nbiReportSimpanan.Caption = "Laporan Simpanan";
            this.nbiReportSimpanan.Name = "nbiReportSimpanan";
            // 
            // nbiReportPengambilan
            // 
            this.nbiReportPengambilan.Caption = "Laporan Pengambilan";
            this.nbiReportPengambilan.Name = "nbiReportPengambilan";
            // 
            // nbiReportPinjaman
            // 
            this.nbiReportPinjaman.Caption = "Laporan Pinjaman";
            this.nbiReportPinjaman.Name = "nbiReportPinjaman";
            // 
            // nbiReportPembayaran
            // 
            this.nbiReportPembayaran.Caption = "Laporan Pembayaran";
            this.nbiReportPembayaran.Name = "nbiReportPembayaran";
            // 
            // nbgLogout
            // 
            this.nbgLogout.Caption = "Keluar";
            this.nbgLogout.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgLogout.LargeImage")));
            this.nbgLogout.Name = "nbgLogout";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBussinesUnit,
            this.lblBusinessUnit,
            this.lblUsernameLogged});
            this.statusStrip1.Location = new System.Drawing.Point(173, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBussinesUnit
            // 
            this.lblBussinesUnit.Name = "lblBussinesUnit";
            this.lblBussinesUnit.Size = new System.Drawing.Size(0, 17);
            // 
            // lblBusinessUnit
            // 
            this.lblBusinessUnit.Name = "lblBusinessUnit";
            this.lblBusinessUnit.Size = new System.Drawing.Size(52, 17);
            this.lblBusinessUnit.Text = "Koperasi";
            // 
            // lblUsernameLogged
            // 
            this.lblUsernameLogged.Name = "lblUsernameLogged";
            this.lblUsernameLogged.Size = new System.Drawing.Size(60, 17);
            this.lblUsernameLogged.Text = "Username";
            // 
            // ucArea
            // 
            this.ucArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucArea.Location = new System.Drawing.Point(173, 0);
            this.ucArea.Name = "ucArea";
            this.ucArea.Size = new System.Drawing.Size(678, 485);
            this.ucArea.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 507);
            this.Controls.Add(this.ucArea);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgTransaksi;
        private DevExpress.XtraNavBar.NavBarItem nbiSimpanan;
        private DevExpress.XtraNavBar.NavBarItem nbiPengambilan;
        private DevExpress.XtraNavBar.NavBarItem nbiPinjaman;
        private DevExpress.XtraNavBar.NavBarItem nbiPembayaran;
        private DevExpress.XtraNavBar.NavBarGroup nbgMaster;
        private DevExpress.XtraNavBar.NavBarItem nbiUser;
        private DevExpress.XtraNavBar.NavBarItem nbiAnggota;
        private DevExpress.XtraNavBar.NavBarItem nbiPengaturan;
        private DevExpress.XtraNavBar.NavBarGroup nbgReport;
        private DevExpress.XtraNavBar.NavBarItem nbiReportSimpanan;
        private DevExpress.XtraNavBar.NavBarItem nbiReportPengambilan;
        private DevExpress.XtraNavBar.NavBarItem nbiReportPinjaman;
        private DevExpress.XtraNavBar.NavBarItem nbiReportPembayaran;
        private DevExpress.XtraNavBar.NavBarGroup nbgLogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBussinesUnit;
        private System.Windows.Forms.ToolStripStatusLabel lblBusinessUnit;
        private System.Windows.Forms.ToolStripStatusLabel lblUsernameLogged;
        private System.Windows.Forms.Panel ucArea;
    }
}

