namespace koperasi_app
{
    partial class frmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.panelInitialize = new DevExpress.XtraEditors.PanelControl();
            this.panelLog = new DevExpress.XtraEditors.PanelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnUnlock = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInitialize)).BeginInit();
            this.panelInitialize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Location = new System.Drawing.Point(13, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Location = new System.Drawing.Point(33, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Username";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Location = new System.Drawing.Point(37, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(127, 24);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(230, 20);
            this.txtServer.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(127, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(230, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnTest
            // 
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.Location = new System.Drawing.Point(127, 143);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(230, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test Connection";
            this.btnTest.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Location = new System.Drawing.Point(127, 193);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDatabase.Size = new System.Drawing.Size(230, 20);
            this.cmbDatabase.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl5.Location = new System.Drawing.Point(37, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 21);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Database";
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.Enabled = false;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(142, 233);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 39);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect!";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panelInitialize
            // 
            this.panelInitialize.Controls.Add(this.panelLog);
            this.panelInitialize.Controls.Add(this.btnConnect);
            this.panelInitialize.Controls.Add(this.labelControl5);
            this.panelInitialize.Controls.Add(this.cmbDatabase);
            this.panelInitialize.Controls.Add(this.btnTest);
            this.panelInitialize.Controls.Add(this.txtPassword);
            this.panelInitialize.Controls.Add(this.txtUsername);
            this.panelInitialize.Controls.Add(this.txtServer);
            this.panelInitialize.Controls.Add(this.labelControl3);
            this.panelInitialize.Controls.Add(this.labelControl2);
            this.panelInitialize.Controls.Add(this.labelControl1);
            this.panelInitialize.Location = new System.Drawing.Point(12, 78);
            this.panelInitialize.Name = "panelInitialize";
            this.panelInitialize.Size = new System.Drawing.Size(408, 297);
            this.panelInitialize.TabIndex = 12;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.btnUnlock);
            this.panelLog.Controls.Add(this.txtPass);
            this.panelLog.Controls.Add(this.txtUname);
            this.panelLog.Controls.Add(this.labelControl6);
            this.panelLog.Controls.Add(this.labelControl4);
            this.panelLog.Location = new System.Drawing.Point(0, 0);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(408, 297);
            this.panelLog.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(125, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(230, 20);
            this.txtPass.TabIndex = 15;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(125, 69);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(230, 20);
            this.txtUname.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Location = new System.Drawing.Point(35, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 21);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Password";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Location = new System.Drawing.Point(31, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 21);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Username";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnUnlock.Appearance.Options.UseFont = true;
            this.btnUnlock.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlock.Image")));
            this.btnUnlock.Location = new System.Drawing.Point(141, 159);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(141, 39);
            this.btnUnlock.TabIndex = 12;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::koperasi_app.Properties.Resources.Splash_initialize;
            this.ClientSize = new System.Drawing.Size(437, 470);
            this.Controls.Add(this.panelInitialize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Initialize";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInitialize)).EndInit();
            this.panelInitialize.ResumeLayout(false);
            this.panelInitialize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.PanelControl panelInitialize;
        private DevExpress.XtraEditors.PanelControl panelLog;
        private DevExpress.XtraEditors.SimpleButton btnUnlock;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUname;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}