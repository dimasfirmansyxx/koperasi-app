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
using MySql.Data.MySqlClient;
using MySql.Web;

namespace koperasi_app
{
    public partial class ucAnggota : DevExpress.XtraEditors.XtraUserControl
    {
        public static functions master = new functions();
        public static MySqlConnection conn = master.conn;
        public static MySqlCommand cmd = new MySqlCommand();
        private string action = "";
        private string kodeFocused = "";
        private string KTPfocused = "";

        private static ucAnggota _instance;
        
        public static ucAnggota Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAnggota();
                return _instance;
            }
        }

        private void getAnggota()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblanggota", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds, "tblanggota");
                dgv.DataSource = ds.Tables["tblanggota"];
                
            }
            finally { conn.Close(); }
        }

        public ucAnggota()
        {
            InitializeComponent();
            getAnggota();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnCancel.PerformClick();
            gbxForm.Enabled = true;
            cmbTipe.Enabled = true;
            
            action = "tambah";
        }

        private void cmbTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val;
            if ( cmbTipe.Text == "" )
            {
                txtKode.Text = "";
                txtNama.Text = "";
                txtNama.Enabled = false;
                txtKTP.Text = "";
                txtKTP.Enabled = false;
                txtAlamat.Clear();
                txtAlamat.Enabled = false;
                txtTelepon.Text = "";
                txtTelepon.Enabled = false;
                return;
            }

            val = master.getIdMember(cmbTipe.Text);
            if (val == "pengurus penuh")
            {
                XtraMessageBox.Show("Tipe anggota untuk pengurus sudah penuh");
                return;
            }
            else if (val == "pendiri penuh")
            {
                XtraMessageBox.Show("Tipe anggota untuk pendiri sudah penuh");
                return;
            }

            txtKode.Text = val;
            txtNama.Enabled = true;
            txtKTP.Enabled = true;
            txtAlamat.Enabled = true;
            txtTelepon.Enabled = true;
            gbxForm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbxForm.Enabled = false;
            txtNama.Enabled = false;
            txtKTP.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelepon.Enabled = false;
            lblTipe.Visible = true;
            cmbTipe.Visible = true;

            cmbTipe.SelectedIndex = -1;
            txtNama.Text = "";
            txtKTP.Text = "";
            txtAlamat.Text = "";
            txtKode.Text = "";
            txtTelepon.Text = "";

            gbxForm.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (action == "tambah")
            {
                if (txtNama.Text == "" || txtKTP.Text == "" || txtAlamat.Text == "" || txtTelepon.Text == "")
                {
                    XtraMessageBox.Show("Isikan seluruh data!");
                }
                else if (!txtKTP.Text.All(char.IsNumber))
                {
                    XtraMessageBox.Show("Isikan Nomor KTP hanya dengan angka!");
                }
                else if (!txtTelepon.Text.All(char.IsNumber))
                {
                    XtraMessageBox.Show("Isikan Nomor Telepon hanya dengan angka!");
                }
                else if ( master.validate("tblanggota","ktp",txtKTP.Text) == true )
                {
                    XtraMessageBox.Show("Nomor KTP telah terdaftar!");
                }
                else
                {
                    string tipeanggota = "";
                    string id = master.getIdForNewMember();
                    if (cmbTipe.Text == "Anggota")
                        tipeanggota = "A";
                    else if (cmbTipe.Text == "Pengurus")
                        tipeanggota = "PG";
                    else if (cmbTipe.Text == "Pendiri")
                        tipeanggota = "P";
                    string value;
                    value = " " + id + ",'"+ txtKode.Text +"', '" + txtNama.Text + "','" + txtAlamat.Text + "','" + txtTelepon.Text + "','"+ txtKTP.Text + "',0,'" + tipeanggota + "'";
                    if ( master.insertData("tblanggota",value) == true )
                    {
                        txtKode.Text = master.getIdMember(cmbTipe.Text);
                        txtNama.Text = "";
                        txtKTP.Text = "";
                        txtAlamat.Text = "";
                        txtTelepon.Text = "";
                    }
                }
            }
            else if (action == "edit")
            {
                if (txtNama.Text == "" || txtKTP.Text == "" || txtAlamat.Text == "" || txtTelepon.Text == "")
                {
                    XtraMessageBox.Show("Isikan seluruh data!");
                }
                else if (!txtKTP.Text.All(char.IsNumber))
                {
                    XtraMessageBox.Show("Isikan Nomor KTP hanya dengan angka!");
                }
                else if (!txtTelepon.Text.All(char.IsNumber))
                {
                    XtraMessageBox.Show("Isikan Nomor Telepon hanya dengan angka!");
                }
                else
                {
                    string kode, nama, ktp, alamat, telepon;
                    kode = txtKode.Text;
                    nama = txtNama.Text;
                    ktp = txtKTP.Text;
                    alamat = txtAlamat.Text;
                    telepon = txtTelepon.Text;

                    if ( KTPfocused != ktp )
                    {
                        if ( master.validate("tblanggota","ktp",ktp) )
                        {
                            XtraMessageBox.Show("KTP yang dimasukkan sudah terdaftar!");
                            return;
                        }
                    }

                    string data;
                    data = " nama = '"+ nama +"', alamat = '"+ alamat +"', telepon = '"+ telepon +"', ktp = '"+ ktp +"' ";
                    if (master.updateData("tblanggota", data, "kode", kode))
                        btnCancel.PerformClick();
                }
            }

            getAnggota();
            
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            kodeFocused = gridViewData.GetFocusedRowCellValue("kode").ToString();
            if (XtraMessageBox.Show("Yakin ingin dihapus ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                master.deleteData("tblanggota", "kode", kodeFocused);
                getAnggota();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            kodeFocused = gridViewData.GetFocusedRowCellValue("kode").ToString();
            gbxForm.Enabled = true;
            txtNama.Enabled = true;
            txtKTP.Enabled = true;
            txtAlamat.Enabled = true;
            txtTelepon.Enabled = true;
            lblTipe.Visible = false;
            cmbTipe.Visible = false;

            string[] memberInfo = master.getMemberInfo(kodeFocused);

            txtKode.Text = kodeFocused;
            txtNama.Text = memberInfo[0];
            txtAlamat.Text = memberInfo[1];
            txtTelepon.Text = memberInfo[2];
            txtKTP.Text = memberInfo[3];
            KTPfocused = memberInfo[3];

            action = "edit";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getAnggota();
        }
    }
}
