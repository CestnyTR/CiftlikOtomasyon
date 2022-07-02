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
    public partial class frmStokTur : Form
    {
        public frmStokTur()
        {
            InitializeComponent();
        }
        void Temizle() {
            txtStokTurAd.Text = ""; 
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            StokTur st = new StokTur();
            st.StokTurAd = Convert.ToString(txtStokTurAd.Text);
            vt.StokTur.Add(st);          
            vt.SaveChanges();
            String a = Convert.ToString(txtStokTurAd.Text);
            StokTur stID = vt.StokTur.FirstOrDefault(p=> p.StokTurAd== a);
           Stok s = new Stok();
            s.StokTurId = stID.StokTurID;
            s.Miktar = Convert.ToDecimal(0);
            DateTime now = DateTime.Now;
            s.IslemTarihi = now;
            s.StokGirisTarihi = now;
            vt.Stok.Add(s);
            vt.SaveChanges();
            

            TumKullanicilariListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblID.Text = secilen.Cells[0].Value.ToString();
            txtStokTurAd.Text = secilen.Cells[1].Value.ToString();
        }

        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.StokTur.ToList();
            Temizle(); 
        }

        private void frmStokTur_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();

            int id = Convert.ToInt32(lblID.Text);
            StokTur st = vt.StokTur.FirstOrDefault(p => p.StokTurID == id);
            vt.StokTur.Remove(st);
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            CiftlikEntities vt = new CiftlikEntities();

            int id = Convert.ToInt32(lblID.Text);
            StokTur st = vt.StokTur.FirstOrDefault(p => p.StokTurID == id);
            st.StokTurAd = Convert.ToString(txtStokTurAd.Text);
            vt.SaveChanges();
            TumKullanicilariListele();
        }
    }
}
