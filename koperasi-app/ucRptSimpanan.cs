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
        public string total;

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

            total = master.getTotal("SELECT SUM(jumlah) AS total FROM tblsimpanan WHERE tanggal BETWEEN '" + dari + "' AND '" + sampai + "'");
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
            rptSimpanan rpt = new rptSimpanan();

            DataTable dt = new DataTable();

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("tanggal", typeof(string));
            dt.Columns.Add("kode_anggota", typeof(string));
            dt.Columns.Add("nama_anggota", typeof(string));
            dt.Columns.Add("jenis_simpanan", typeof(string));
            dt.Columns.Add("jumlah", typeof(int));
            dt.Columns.Add("totalJumlah", typeof(int));

            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                string tgl, kode, nama, jenis;
                int id, jml;
                id = Convert.ToInt32(gridViewData.GetRowCellValue(i, "id"));
                tgl = gridViewData.GetRowCellValue(i, "tanggal").ToString();
                kode = gridViewData.GetRowCellValue(i, "kode_anggota").ToString();
                nama = gridViewData.GetRowCellValue(i, "nama_anggota").ToString();
                jenis = gridViewData.GetRowCellValue(i, "jenis_simpanan").ToString();
                jml = Convert.ToInt32(gridViewData.GetRowCellValue(i, "jumlah"));

                dt.Rows.Add(id, tgl, kode, nama, jenis, jml, total.ToString());

                rpt.Bands[BandKind.Detail].Controls[0].DataBindings.Add(new XRBinding("Text", dt, "jumlah"));
                rpt.Bands[BandKind.Detail].Controls[1].DataBindings.Add(new XRBinding("Text", dt, "jenis_simpanan"));
                rpt.Bands[BandKind.Detail].Controls[2].DataBindings.Add(new XRBinding("Text", dt, "nama_anggota"));
                rpt.Bands[BandKind.Detail].Controls[3].DataBindings.Add(new XRBinding("Text", dt, "kode_anggota"));
                rpt.Bands[BandKind.Detail].Controls[4].DataBindings.Add(new XRBinding("Text", dt, "tanggal"));
                rpt.Bands[BandKind.Detail].Controls[5].DataBindings.Add(new XRBinding("Text", dt, "id"));
            }

            rpt.Parameters["totalJumlah"].Value = total;

            rpt.DataSource = dt;
            rpt.RequestParameters = false;
            rpt.ShowPreview();
        }
    }
}
