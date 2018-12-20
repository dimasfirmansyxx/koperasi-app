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
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Web;

namespace koperasi_app
{
    public partial class frmServer : DevExpress.XtraEditors.XtraForm
    {
        public frmServer()
        {
            var appSettings = ConfigurationManager.AppSettings;
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.server;
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;
            cmbDatabase.Text = Properties.Settings.Default.database;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string str = @"server="+ txtServer.Text +";userid="+ txtUsername.Text +";password="+ txtPassword.Text +";sslmode=none";
            try
            {
                MySqlConnection conn = new MySqlConnection(str);
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("show databases", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string row = "";
                        for ( int i = 0; i < reader.FieldCount; i++ )
                            row += reader.GetValue(i).ToString();
                        cmbDatabase.Properties.Items.Add(row);
                    }
                }
                finally { conn.Close(); }
                XtraMessageBox.Show("Connection Success");
                btnConnect.Enabled = true;
            }
            catch (MySqlException ex)
            {
                XtraMessageBox.Show("Connection Failed. Error : " + ex);
                btnConnect.Enabled = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ( cmbDatabase.Text == "" )
            {
                XtraMessageBox.Show("Choose a Database!");
                return;
            }
            string server = txtServer.Text;
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            string db = cmbDatabase.Text;
            bool val;
            try
            {
                string str = @"server="+server+";userid="+user+";password="+pass+";database="+db+";sslmode=none";
                MySqlConnection conn = new MySqlConnection(str);
                val = true;
            }
            catch (MySqlException ex)
            {
                XtraMessageBox.Show("Failed to Connect. Error : " + ex);
                val = false;
            }

            if (val == true)
            {
                Properties.Settings.Default.server = txtServer.Text;
                Properties.Settings.Default.username = txtUsername.Text;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.database = cmbDatabase.Text;
                Properties.Settings.Default.Save();

                //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var set = config.AppSettings.Settings;
                //set["server"].Value = txtServer.Text;
                //set["username"].Value = txtUsername.Text;
                //set["password"].Value = txtPassword.Text;
                //set["database"].Value = cmbDatabase.Text;

                //config.Save(ConfigurationSaveMode.Modified);
                //ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

                XtraMessageBox.Show("Connection Succeeded");
            }
        }

        private void frmServer_Load(object sender, EventArgs e)
        {

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "dimas" && txtPass.Text == "mlpnkobji")
                panelLog.Visible = false;
            else
                XtraMessageBox.Show("Wrong Identity");
        }
    }
}