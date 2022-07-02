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
    public partial class frmStokHareket : Form
    {
        public frmStokHareket()
        {
            InitializeComponent();
        }

        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vStokHareket.ToList();
            Temizle();
        }
        void Temizle(){
            cbStok.SelectedValue = 0;
            txtMiktar.Text = "";

        }
        private void frmStokHareket_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();

            CiftlikEntities vt = new CiftlikEntities();

            TumKullanicilariListele();
            cbStok.DisplayMember = "StokTurAd";
            cbStok.ValueMember = "StokTurID";
            cbStok.DataSource = vt.StokTur.ToList();
            cbStok.SelectedValue = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            StokHareket s = new StokHareket();
            s.StokId = Convert.ToInt32(cbStok.SelectedValue);
            decimal d = Convert.ToDecimal(txtMiktar.Text);
            s.Miktar = d;
            s.IslemTarihi = dtStokGirisTarihi.Value;
            vt.StokHareket.Add(s);
            vt.SaveChanges();

            int stokTr = Convert.ToInt32(cbStok.SelectedValue);
            Stok ss = vt.Stok.FirstOrDefault(p => p.StokTurId == stokTr);
            decimal ssDeger = ss.Miktar + d;
            ss.Miktar = ssDeger;
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            StokHareket s = new StokHareket();
            s.StokId = Convert.ToInt32(cbStok.SelectedValue);
            decimal d = Convert.ToDecimal(txtMiktar.Text)-(2*Convert.ToDecimal(txtMiktar.Text)) ;
            s.Miktar =  d;
            s.IslemTarihi = dtStokGirisTarihi.Value;
            vt.StokHareket.Add(s);
            vt.SaveChanges();

            int stokTr = Convert.ToInt32(cbStok.SelectedValue);
            Stok ss = vt.Stok.FirstOrDefault(p => p.StokTurId == stokTr);
            decimal ssDeger = ss.Miktar + d;
            ss.Miktar = ssDeger;
            vt.SaveChanges();
            TumKullanicilariListele();
        }
    }
}
