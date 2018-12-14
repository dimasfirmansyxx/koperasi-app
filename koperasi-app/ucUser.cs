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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace koperasi_app
{
    public partial class ucUser : DevExpress.XtraEditors.XtraUserControl
    {
        public static functions master = new functions();
        public static MySqlConnection conn = master.conn;
        public static MySqlCommand cmd = new MySqlCommand();
        public string action;
        public string idFocused;
        public string unameFocused;
        public string passFocused;

        private static ucUser _instance;
        public static ucUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUser();
                return _instance;
            }
        }

        public void getUser()
        {
            DataSet data = new DataSet();

            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tbluser", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data, "tbluser");

                dgv.DataSource = data.Tables["tbluser"];

            }
            catch { }
            finally
            {
                conn.Close();
            }
        }
        

        public ucUser()
        {
            InitializeComponent();
            getUser();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            gbxForm.Enabled = true;
            txtNama.Enabled = true;
            txtUname.Enabled = true;
            txtPass.Enabled = true;
            txtKode.Text = master.getIdForNewUser();
            action = "tambah";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gbxForm.Enabled = false;
            txtNama.Enabled = false;
            txtUname.Enabled = false;
            txtPass.Enabled = false;

            txtNama.Text = "";
            txtUname.Text = "";
            txtPass.Text = "";
            txtKode.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ( action == "tambah" )
            {
                if ( txtNama.Text == "" || txtUname.Text == "" || txtPass.Text == "" )
                {
                    XtraMessageBox.Show("Isikan Seluruh data!");
                }
                else
                {
                    if ( master.validate("tbluser","username",txtUname.Text) == true )
                    {
                        XtraMessageBox.Show("Username sudah terdaftar!");
                    }
                    else
                    {
                        string values;
                        values = " "+ txtKode.Text +", '"+ txtNama.Text +"', '"+ txtUname.Text +"', '"+ txtPass.Text +"' ";
                        if ( master.insertData("tbluser",values) == true )
                        {
                            int newCode;
                            newCode = Convert.ToInt32(txtKode.Text) + 1;
                            txtKode.Text = newCode.ToString();
                            txtNama.Text = "";
                            txtUname.Text = "";
                            txtPass.Text = "";
                        }
                        else
                        {
                            XtraMessageBox.Show("Gagal");
                        }
                    }
                }
            }
            else if ( action == "edit" )
            {
                if (txtNama.Text == "" || txtUname.Text == "")
                {
                    XtraMessageBox.Show("Field nama dan username harus diisi!");
                }
                else
                {
                    bool val;
                    string password;
                    if (txtUname.Text != unameFocused)
                    {
                        if (master.validate("tbluser", "username", txtUname.Text) == true)
                        {
                            XtraMessageBox.Show("Username yang dipilih sudah terdaftar!");
                            val = false;
                            return;
                        }
                        else
                        {
                            val = true;
                        }
                    }
                    else
                    {
                        val = true;
                    }

                    if (txtPass.Text == "")
                    {
                        password = passFocused;
                    }
                    else
                    {
                        password = txtPass.Text;
                    }

                    string data;
                    data = "nama = '" + txtNama.Text + "', username = '" + txtUname.Text + "', password = '" + password + "' ";
                    bool confirm = master.updateData("tbluser", data, "id", txtKode.Text);
                    if ( confirm == true )
                    {
                        XtraMessageBox.Show("Berhasil merubah data");
                    }
                    else
                    {
                        XtraMessageBox.Show("Gagal!");
                    }
                    btnCancel.PerformClick();
                }
            }

            getUser();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            idFocused = gridViewData.GetFocusedRowCellValue("id").ToString();
            if ( XtraMessageBox.Show("Yakin ingin dihapus ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                master.deleteData("tbluser", "id", idFocused);
                getUser();
            }
        }

        private void dgv_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            idFocused = gridViewData.GetFocusedRowCellValue("id").ToString();
            gbxForm.Enabled = true;
            txtNama.Enabled = true;
            txtUname.Enabled = true;
            txtPass.Enabled = true;

            string[] userInfo = master.getUserInfo(idFocused);
            txtKode.Text = idFocused;
            
            txtNama.Text = userInfo[0].ToString();
            txtUname.Text = userInfo[1].ToString();
            unameFocused = userInfo[1].ToString();
            passFocused = userInfo[2].ToString();

            action = "edit";
        }
    }
}
