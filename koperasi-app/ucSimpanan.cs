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
    public partial class ucSimpanan : DevExpress.XtraEditors.XtraUserControl
    {
        public static functions master = new functions();
        public static MySqlConnection conn = master.conn;
        public static MySqlCommand cmd = new MySqlCommand();
        private string action, kodeFocused, jumlahFocused;

        private static ucSimpanan _instance;

        public static ucSimpanan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSimpanan();
                return _instance;
            }
        }

        private void getData()
        {
            DataSet data = new DataSet();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblsimpanan ORDER BY id DESC", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data, "tblsimpanan");

                dgv.DataSource = data.Tables["tblsimpanan"];
            }
            finally { conn.Close(); }
        }

        public ucSimpanan()
        {
            InitializeComponent();
            getData();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gbx.Enabled = true;
            txtKodeTransaksi.Text = master.getDepositTransactionNumber();
            txtKodeAnggota.Enabled = true;
            cmbJenis.Enabled = true;
            action = "tambah";
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] jumlah = master.getRules();
            if ( cmbJenis.SelectedIndex == 0 )
            {
                txtJumlah.Text = jumlah[0];
                txtJumlah.Enabled = false;
            }
            else if ( cmbJenis.SelectedIndex == 1 )
            {
                txtJumlah.Text = jumlah[1];
                txtJumlah.Enabled = false;
            }
            else if ( cmbJenis.SelectedIndex == 2 )
            {
                txtJumlah.Text = jumlah[2];
                txtJumlah.Enabled = true;
            }
        }

        private void txtKodeAnggota_EditValueChanged(object sender, EventArgs e)
        {
            string nama = master.getMemberInfo(txtKodeAnggota.Text)[0];
            if ( nama != "0" )
            {
                txtNamaAnggota.Text = nama;
            }
            else
            {
                txtNamaAnggota.Text = "";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gbx.Enabled = false;
            txtKodeTransaksi.Text = "";
            txtKodeTransaksi.Enabled = false;
            txtTanggal.Text = "";
            txtKodeAnggota.Text = "";
            txtKodeAnggota.Enabled = false;
            txtNamaAnggota.Text = "";
            txtNamaAnggota.Enabled = false;
            cmbJenis.SelectedIndex = -1;
            cmbJenis.Enabled = false;
            txtJumlah.Text = "";
            txtJumlah.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtTanggal.Text == "" || txtNamaAnggota.Text == "" || cmbJenis.Text == "" || txtJumlah.Text == "")
                {
                XtraMessageBox.Show("Isikan Seluruh Data!");
                return;
            }
                else if (txtJumlah.Text.All(char.IsNumber) == false)
            {
                XtraMessageBox.Show("Isikan jumlah dengan angka!");
                return;
            }

            string kode, tanggal, kode_anggota, nama, jenis, jumlah, data, bln, thn, bulan;
            int newSaldo;
            DateTime tgl;
            kode = txtKodeTransaksi.Text;
            tgl = DateTime.Parse(txtTanggal.Text);
            tanggal = tgl.ToString("dd/MM/yyyy");
            kode_anggota = txtKodeAnggota.Text.ToUpper();
            nama = txtNamaAnggota.Text;
            jenis = cmbJenis.Text;
            jumlah = txtJumlah.Text;

            bln = tanggal.Substring(3, 2);
            bln = master.monthID(bln);
            thn = tanggal.Substring(6, 4);
            bulan = bln + " " + thn;

            if ( action == "tambah" )
            {
                if ( jenis == "Pokok" )
                {
                    if ( master.validateComplex("SELECT * FROM tblsimpanan WHERE kode_anggota = '" + kode_anggota + "' AND jenis_simpanan = 'Pokok'") )
                    {
                        XtraMessageBox.Show("Anggota ini sudah membayar Simpanan Pokok");
                        return;
                    }
                }
                else if ( jenis == "Wajib" )
                {
                    if (master.validateComplex("SELECT * FROM tblsimpanan WHERE kode_anggota = '" + kode_anggota + "' AND jenis_simpanan = 'Wajib' AND bulan = '" + bulan + "'"))
                    {
                        XtraMessageBox.Show("Anggota ini sudah membayar Simpanan Wajib bulan ini");
                        return;
                    }
                }

                data = " '"+ kode +"', '"+ tanggal +"', '"+ kode_anggota +"', '"+ nama +"', '"+ jenis +"', '"+ jumlah +"', '"+ bulan +"' ";
                master.insertData("tblsimpanan", data);

                string getSaldo = master.getMemberInfo(kode_anggota)[4];
                newSaldo = Convert.ToInt32(getSaldo) + Convert.ToInt32(jumlah);

                master.updateData("tblanggota", "saldo = '" + newSaldo.ToString() + "'", "kode", kode_anggota);
            }
            else if (action == "edit")
            {
                string getSaldo = master.getMemberInfo(kode_anggota)[4];
                newSaldo = Convert.ToInt32(getSaldo) - Convert.ToInt32(jumlahFocused);
                newSaldo = newSaldo + Convert.ToInt32(jumlah);

                if ( jenis == "Pokok" )
                {
                    if ( master.validateComplex("SELECT * FROM tblsimpanan WHERE kode_anggota = '"+ kode_anggota +"' AND jenis_simpanan = 'Pokok'") )
                    {
                        XtraMessageBox.Show("Anggota ini sudah membayar Simpanan Pokok");
                        return;
                    }
                }
                else if ( jenis == "Wajib" )
                {
                    if (master.validateComplex("SELECT * FROM tblsimpanan WHERE kode_anggota = '" + kode_anggota + "' AND jenis_simpanan = 'Wajib' AND bulan = '" + bulan + "'"))
                    {
                        XtraMessageBox.Show("Anggota ini sudah membayar Simpanan Wajib bulan ini");
                        return;
                    }
                }

                data = " tanggal = '"+ tanggal +"', jenis_simpanan = '" + jenis + "', jumlah = '"+ jumlah +"', bulan = '"+ bulan +"' ";

                master.updateData("tblanggota", "saldo = '" + newSaldo.ToString() + "'", "kode", kode_anggota);
                master.updateData("tblsimpanan", data, "id", kode);
                btnCancel.PerformClick();
            }
            getData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            kodeFocused = gridViewData.GetFocusedRowCellValue("id").ToString();
            if (XtraMessageBox.Show("Jika dihapus, saldo anggota juga akan berkurang. Yakin ingin dihapus ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string jumlah = master.getData("tblsimpanan", "id", kodeFocused, "jumlah");
                string saldo = master.getData("tblanggota", "kode", gridViewData.GetFocusedRowCellValue("kode_anggota").ToString(), "saldo");
                int newSaldo = Convert.ToInt32(saldo) - Convert.ToInt32(jumlah);
                master.updateData("tblanggota", "saldo = '" + newSaldo.ToString() + "'", "kode", gridViewData.GetFocusedRowCellValue("kode_anggota").ToString());
                master.deleteData("tblsimpanan", "id", kodeFocused);
                getData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string kode, tanggal, kode_anggota, nama, jenis, jumlah;
            string tgl, bln, thn;
            kode = gridViewData.GetFocusedRowCellValue("id").ToString();
            tanggal = gridViewData.GetFocusedRowCellValue("tanggal").ToString();
            kode_anggota = gridViewData.GetFocusedRowCellValue("kode_anggota").ToString();
            nama = gridViewData.GetFocusedRowCellValue("nama_anggota").ToString();
            jenis = gridViewData.GetFocusedRowCellValue("jenis_simpanan").ToString();
            jumlah = gridViewData.GetFocusedRowCellValue("jumlah").ToString();
            jumlahFocused = gridViewData.GetFocusedRowCellValue("jumlah").ToString();

            tgl = tanggal.Substring(0, 2);
            bln = tanggal.Substring(3, 2);
            thn = tanggal.Substring(6, 4);

            tanggal = bln + "/" + tgl + "/" + thn;

            txtKodeTransaksi.Text = kode;
            txtTanggal.Text = tanggal;
            txtKodeAnggota.Text = kode_anggota;
            txtNamaAnggota.Text = nama;
            cmbJenis.Text = jenis;
            txtJumlah.Text = jumlah;

            gbx.Enabled = true;
            txtKodeAnggota.Enabled = false;
            cmbJenis.Enabled = true;
            action = "edit";
        }
    }
}
