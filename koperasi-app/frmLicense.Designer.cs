namespace koperasi_app
{
    partial class frmLicense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicense));
            this.lblStatusReg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLicense = new DevExpress.XtraEditors.TextEdit();
            this.txtKey = new DevExpress.XtraEditors.TextEdit();
            this.btnRegist = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtLicense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusReg
            // 
            this.lblStatusReg.AutoSize = true;
            this.lblStatusReg.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblStatusReg.Location = new System.Drawing.Point(26, 19);
            this.lblStatusReg.Name = "lblStatusReg";
            this.lblStatusReg.Size = new System.Drawing.Size(42, 17);
            this.lblStatusReg.TabIndex = 0;
            this.lblStatusReg.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "License Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(100, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Key :";
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(146, 73);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(214, 20);
            this.txtLicense.TabIndex = 3;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(146, 112);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(102, 20);
            this.txtKey.TabIndex = 4;
            // 
            // btnRegist
            // 
            this.btnRegist.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRegist.Appearance.Options.UseFont = true;
            this.btnRegist.Image = ((System.Drawing.Image)(resources.GetObject("btnRegist.Image")));
            this.btnRegist.Location = new System.Drawing.Point(146, 169);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(145, 43);
            this.btnRegist.TabIndex = 5;
            this.btnRegist.Text = "Register";
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLicense
            // 
            this.AcceptButton = this.btnRegist;
            this.ClientSize = new System.Drawing.Size(424, 246);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatusReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Register";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLicense_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtLicense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtLicense;
        private DevExpress.XtraEditors.TextEdit txtKey;
        private DevExpress.XtraEditors.SimpleButton btnRegist;
        private System.Windows.Forms.Timer timer1;
    }
}