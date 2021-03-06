﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Web;

namespace koperasi_app
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void nbiUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucArea.Controls.Clear();
            if (!ucArea.Controls.Contains(ucUser.Instance))
            {
                ucArea.Controls.Add(ucUser.Instance);
                ucUser.Instance.Dock = DockStyle.Fill;
                ucUser.Instance.BringToFront();
            }
            else
                ucUser.Instance.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void nbiAnggota_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucArea.Controls.Clear();
            if (!ucArea.Controls.Contains(ucAnggota.Instance))
            {
                ucArea.Controls.Add(ucAnggota.Instance);
                ucAnggota.Instance.Dock = DockStyle.Fill;
                ucAnggota.Instance.BringToFront();
            }
            else
                ucAnggota.Instance.BringToFront();
        }

        private void nbiPengaturan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucArea.Controls.Clear();
            if (!ucArea.Controls.Contains(ucSetting.Instance))
            {
                ucArea.Controls.Add(ucSetting.Instance);
                ucSetting.Instance.Dock = DockStyle.Fill;
                ucSetting.Instance.BringToFront();
            }
            else
                ucSetting.Instance.BringToFront();
        }

        private void nbiSimpanan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!ucArea.Controls.Contains(ucSimpanan.Instance))
            {
                ucArea.Controls.Add(ucSimpanan.Instance);
                ucSimpanan.Instance.Dock = DockStyle.Fill;
                ucSimpanan.Instance.BringToFront();
            }
            else
                ucSimpanan.Instance.BringToFront();
        }

        private void nbiReportSimpanan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!ucArea.Controls.Contains(ucRptSimpanan.Instance))
            {
                ucArea.Controls.Add(ucRptSimpanan.Instance);
                ucRptSimpanan.Instance.Dock = DockStyle.Fill;
                ucRptSimpanan.Instance.BringToFront();
            }
            else
                ucRptSimpanan.Instance.BringToFront();
        }

        private void nbiPengambilan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!ucArea.Controls.Contains(ucPengambilan.Instance))
            {
                ucArea.Controls.Add(ucPengambilan.Instance);
                ucPengambilan.Instance.Dock = DockStyle.Fill;
                ucPengambilan.Instance.BringToFront();
            }
            else
                ucPengambilan.Instance.BringToFront();
        }
    }
}
