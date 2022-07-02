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
    public partial class rprStok : Form
    {
        public rprStok()
        {
            InitializeComponent();
        }

        private void rprStok_Load(object sender, EventArgs e)
        {

            CiftlikEntities vt = new CiftlikEntities();
            List<vStok> personelMaasListesi = vt.vStok.ToList();

            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "CiftlikOtomasyon.rprStok.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", personelMaasListesi);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
