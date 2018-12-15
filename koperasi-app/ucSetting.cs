using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace koperasi_app
{
    public partial class ucSetting : DevExpress.XtraEditors.XtraUserControl
    {
        public static functions master = new functions();
        private static ucSetting _instance;

        public static ucSetting Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSetting();
                return _instance;
            }
        }

        private string[] getData = master.getRules();

        public ucSetting()
        {
            InitializeComponent();

            txtSimpananPokok.Text = getData[0];
            txtSimpananWajib.Text = getData[1];
            txtSimpananSukarela.Text = getData[2];
            txtDenda.Text = getData[3];
            txtMaxPinjaman.Text = getData[4];
            txtMinimalSaldo.Text = getData[5];
            txtMaxPengurus.Text = getData[6];
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if ( txtSimpananPokok.Text == "" || txtSimpananWajib.Text == "" || txtSimpananSukarela.Text == "" || txtDenda.Text == "" || txtMaxPinjaman.Text == "" || txtMinimalSaldo.Text == "" || txtMaxPengurus.Text == "" )
            {
                XtraMessageBox.Show("Isikan seluruh data!");
            }
            else
            {
                string pokok, wajib, sukarela, denda, maxpinjam, minsaldo, maxpengurus, data;
                pokok = txtSimpananPokok.Text;
                wajib = txtSimpananWajib.Text;
                sukarela = txtSimpananSukarela.Text;
                denda = txtDenda.Text;
                maxpinjam = txtMaxPinjaman.Text;
                minsaldo = txtMinimalSaldo.Text;
                maxpengurus = txtMaxPengurus.Text;

                data = " simpanan_pokok = '"+ pokok +"', simpanan_wajib = '"+ wajib +"', simpanan_sukarela = '"+ sukarela +"', denda = '"+ denda +"', maksimal_peminjaman = '"+ maxpinjam +"', minimal_saldo = '"+ minsaldo +"', maks_root = '"+ maxpengurus +"' ";
                if (master.updateData("tblaturan", data, "id", "0") == true)
                    XtraMessageBox.Show("Berhasil");
            }
        }
    }
}
