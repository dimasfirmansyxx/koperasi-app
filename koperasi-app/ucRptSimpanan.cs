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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Data;
using DevExpress.XtraReports.Parameters;

namespace koperasi_app
{
    public partial class ucRptSimpanan : DevExpress.XtraEditors.XtraUserControl
    {
        public static functions master = new functions();
        public static MySqlConnection conn = master.conn;
        public static MySqlCommand cmd = new MySqlCommand();

        private static ucRptSimpanan _instance;

        public static ucRptSimpanan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRptSimpanan();
                return _instance;
            }
        }

        private void getData()
        {
            string dari, sampai;
            DateTime dtDari, dtSampai;
            dari = dateDari.Text;
            sampai = dateSampai.Text;

            dtDari = DateTime.Parse(dari);
            dtSampai = DateTime.Parse(sampai);

            dari = dtDari.ToString("dd/MM/yyyy");
            sampai = dtSampai.ToString("dd/MM/yyyy");

            DataSet data = new DataSet();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblsimpanan WHERE tanggal BETWEEN '"+ dari +"' AND '"+ sampai +"'", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data, "tblsimpanan");

                dgv.DataSource = data.Tables["tblsimpanan"];
            }
            finally { conn.Close(); }
        }

        public ucRptSimpanan()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if ( dateDari.Text == "" || dateSampai.Text == "" || dateDari.Text == " " || dateSampai.Text == " ")
            {
                XtraMessageBox.Show("Pilih tanggal terlebih dahulu!");
                btnCetak.Enabled = false;
            }
            else
            {
                getData();
                btnCetak.Enabled = true;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            //var rpt = new rptSimpanan();

            //DataTable dt = new DataTable();

            //dt.Columns.Add("id", typeof(int));
            //dt.Columns.Add("tanggal", typeof(string));
            //dt.Columns.Add("kode_anggota", typeof(string));
            //dt.Columns.Add("nama_anggota", typeof(string));
            //dt.Columns.Add("jenis_simpanan", typeof(string));
            //dt.Columns.Add("jumlah", typeof(int));

            //for (int i = 1; i < 5; i++)
            //{
            //    DataRow dtrow = dt.NewRow();
            //    string tgl, kode, nama, jenis;
            //    int id, jml;
            //    id = Convert.ToInt32(gridViewData.GetFocusedRowCellValue("id"));
            //    tgl = gridViewData.GetFocusedRowCellValue("kode_anggota").ToString();
            //    kode = gridViewData.GetFocusedRowCellValue("tanggal").ToString();
            //    nama = gridViewData.GetFocusedRowCellValue("nama_anggota").ToString();
            //    jenis = gridViewData.GetFocusedRowCellValue("jenis_simpanan").ToString();
            //    jml = Convert.ToInt32(gridViewData.GetFocusedRowCellValue("jumlah"));

            //    dtrow[0] = id;
            //    dtrow[1] = tgl;
            //    dtrow[2] = kode;
            //    dtrow[3] = nama;
            //    dtrow[4] = jenis;
            //    dtrow[5] = jml;

            //    dt.Rows.Add(dtrow);
            //}

            //DataSet ds = new DataSet("tblrpt");
            //ds.Tables.Add(dt);
            ////rpt.DataSource = ds;
            ////ds.WriteXmlSchema("Reports/rptSimpanan.xml");
            //rpt.RequestParameters = false;
            //rpt.ShowPreview();
            
        }
    }
}
