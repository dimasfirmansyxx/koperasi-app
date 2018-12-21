using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Management;

namespace koperasi_app
{
    public partial class frmLicense : DevExpress.XtraEditors.XtraForm
    {
        private static string str = @"server=207.148.68.144;port=3306;userid=dimasfir_data;password=010401@dimas;database=dimasfir_data;sslmode=none";
        private static MySqlConnection conn = new MySqlConnection(str);

        public frmLicense()
        {
            InitializeComponent();
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {

        }

        private string getHWID()
        {
            ManagementObject mo = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            mo.Get();
            return mo["VolumeSerialNumber"].ToString();
        }

        private string getRegisteredID()
        {
            int id;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_registered ORDER BY id DESC",conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    id = Convert.ToInt32(reader["id"]) + 1;
                else
                    id = 1;

                return id.ToString();
            }
            finally { conn.Close(); }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            bool val;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_license WHERE license = '" + txtLicense.Text + "'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    string key = reader["serial"].ToString();
                    string status = reader["status"].ToString();
                    if (key == txtKey.Text)
                    {
                        if (status == "Ready")
                        {
                            XtraMessageBox.Show("Registered Successfully");
                            Properties.Settings.Default.status = "registered";
                            Properties.Settings.Default.license = txtLicense.Text;
                            Properties.Settings.Default.Save();
                            val = true;
                        }
                        else
                        {
                            XtraMessageBox.Show("License was Registered");
                            val = false;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Incorrect Key!");
                        val = false;
                    } 
                }
                else
                {
                    XtraMessageBox.Show("License Number does not exist");
                    val = false;
                }
            }
            catch (MySqlException ex)
            {
                XtraMessageBox.Show("Failed. Mysql Error. " + ex);
            }
            finally { conn.Close(); }

            string hwid = getHWID();
            string license = txtLicense.Text;
            string id = getRegisteredID();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_registered VALUES (" + id + ", '" + hwid + "', '" + license + "')",conn);
                cmd.ExecuteNonQuery();
            }
            finally { conn.Close(); }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_license SET status = 'Activated' WHERE license = '" + license + "'", conn);
                cmd.ExecuteNonQuery();
            }
            finally { conn.Close(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.status != "registered")
            {
                lblStatusReg.Text = "Status : Trial";
                lblStatusReg.ForeColor = Color.Red;
            }
            else
            {
                lblStatusReg.Text = "Status : Activated";
                lblStatusReg.ForeColor = Color.Green;
                btnRegist.Enabled = false;
            }
        }

        private void frmLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                if ( XtraMessageBox.Show("Are you sure to delete the License ?","Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes )
                {
                    Properties.Settings.Default.status = "trial";
                    Properties.Settings.Default.license = "";
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}