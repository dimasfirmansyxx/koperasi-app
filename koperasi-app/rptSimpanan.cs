using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;

namespace koperasi_app
{
    public partial class rptSimpanan : DevExpress.XtraReports.UI.XtraReport
    {
        
        public rptSimpanan()
        {
            InitializeComponent();
            //this.Bands[BandKind.Detail].Controls[0].DataBindings.Add(new XRBinding("Text", this, "id"));
            //this.Bands[BandKind.Detail].Controls[1].DataBindings.Add(new XRBinding("Text", this, "kode_anggota"));
            //this.Bands[BandKind.Detail].Controls[2].DataBindings.Add(new XRBinding("Text", this, "tanggal"));
            //this.Bands[BandKind.Detail].Controls[3].DataBindings.Add(new XRBinding("Text", this, "nama_anggota"));
            //this.Bands[BandKind.Detail].Controls[4].DataBindings.Add(new XRBinding("Text", this, "jenis_simpanan"));
            //this.Bands[BandKind.Detail].Controls[5].DataBindings.Add(new XRBinding("Text", this, "jumlah"));
        }

    }
}
