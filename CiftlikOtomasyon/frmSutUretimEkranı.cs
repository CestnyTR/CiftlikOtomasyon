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
    public partial class frmSutUretimEkranı : Form
    {
        public frmSutUretimEkranı()
        {
            InitializeComponent();
            TumKullanicilariListele();
        }

        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vSutUretim.ToList();
            Temizle();
        }
        void Temizle() {
            cbHayvan.SelectedValue = 0;
            txtMiktar.Text = "";
            cbZaman.SelectedValue = 0;
        }

        private void fmrSutUretimEkranı_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
            //hayvan doldurma
            cbHayvan.DisplayMember = "KupeNo";
            cbHayvan.ValueMember = "HayvanID";           
            //zaman doldurma
            cbZaman.DisplayMember = "ZamanAd";
            cbZaman.ValueMember = "ZamanID";
            CiftlikEntities vt = new CiftlikEntities();
            cbHayvan.DataSource = vt.Hayvan.ToList();
            cbZaman.DataSource = vt.Zaman.ToList();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblID.Text = secilen.Cells[0].Value.ToString();
            cbHayvan.Text  = secilen.Cells[1].Value.ToString();
            dtIslemTarihi.Text = secilen.Cells[2].Value.ToString();
            cbZaman.Text = secilen.Cells[3].Value.ToString();
            txtMiktar.Text = secilen.Cells[4].Value.ToString();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            SutUretim su = new SutUretim();
            su.HayvanId = Convert.ToInt32(cbHayvan.SelectedValue);
            su.Tarih = dtIslemTarihi.Value;
            su.ZamanId = Convert.ToInt32(cbZaman.SelectedValue);
            decimal d = Convert.ToDecimal(txtMiktar.Text);
            su.Miktar = d;
            vt.SutUretim.Add(su);
            vt.SaveChanges();


            int stokTr = Convert.ToInt32(cbHayvan.SelectedValue);
            SutTakip ss = vt.SutTakip.FirstOrDefault(p => p.HayvanId == su.HayvanId);
            decimal ssDeger = ss.Miktar + d;
            ss.Miktar = ssDeger;
            vt.SaveChanges();
            TumKullanicilariListele();

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            SutUretim su = new SutUretim();
            su.HayvanId = Convert.ToInt32(cbHayvan.SelectedValue);
            su.Tarih = dtIslemTarihi.Value;
            su.ZamanId = Convert.ToInt32(cbZaman.SelectedValue);
            decimal d = Convert.ToDecimal(txtMiktar.Text) - (2 * Convert.ToDecimal(txtMiktar.Text));
            su.Miktar = d;
            vt.SutUretim.Add(su);
            vt.SaveChanges();
            int stokTr = Convert.ToInt32(cbHayvan.SelectedValue);
            SutTakip ss = vt.SutTakip.FirstOrDefault(p => p.HayvanId == su.HayvanId);
            decimal ssDeger = ss.Miktar + d;
            ss.Miktar = ssDeger;
            vt.SaveChanges();
            TumKullanicilariListele();
        }
    }
}
