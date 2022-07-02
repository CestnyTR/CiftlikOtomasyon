using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiftlikOtomasyon
{
    public partial class rprSutStok : Form
    {
        public rprSutStok()
        {
            InitializeComponent();
        }

        private void rprSutStok_Load(object sender, EventArgs e)
        {

            CiftlikEntities vt = new CiftlikEntities();
            List<vSutTakip> personelMaasListesi = vt.vSutTakip.ToList();

            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "CiftlikOtomasyon.rprSutStok.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", personelMaasListesi);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
