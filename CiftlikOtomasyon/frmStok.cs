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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblID.Text = secilen.Cells[0].Value.ToString();
            cbTur.Text = secilen.Cells[1].Value.ToString();
            txtMiktar.Text = secilen.Cells[2].Value.ToString();
            dtStokGirisTarihi.Text = secilen.Cells[3].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            Stok s = new Stok();
            s.StokTurId= Convert.ToInt32(cbTur.SelectedValue);
            decimal d = Convert.ToDecimal(txtMiktar.Text);
            s.Miktar = d;
            s.IslemTarihi = dtStokGirisTarihi.Value;
            DateTime now = DateTime.Now;
            s.StokGirisTarihi = now;
            vt.Stok.Add(s);
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int id = Convert.ToInt32(lblID.Text);
            Stok su = vt.Stok.FirstOrDefault(p => p.StokID == id);
            vt.Stok.Remove(su);
            vt.SaveChanges();
            TumKullanicilariListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int id = Convert.ToInt32(lblID.Text);
            Stok s = vt.Stok.FirstOrDefault(p => p.StokID == id);
            s.StokTurId = Convert.ToInt32(cbTur.SelectedValue);
            decimal d = Convert.ToDecimal(txtMiktar.Text);
            s.Miktar = d;
            s.IslemTarihi = dtStokGirisTarihi.Value;
            DateTime now = DateTime.Now;
            s.StokGirisTarihi = now;
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
            cbTur.DisplayMember = "StokTurAd";
            cbTur.ValueMember = "StokTurID";
            CiftlikEntities vt = new CiftlikEntities();
            cbTur.DataSource = vt.StokTur.ToList();
        }
        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vStok.ToList();
            Temizle();
        }
        void Temizle() {
            cbTur.SelectedValue = 0;
            txtMiktar.Text = "";
        }

    }
}
