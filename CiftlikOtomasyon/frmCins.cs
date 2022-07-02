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
    public partial class frmCins : Form
    {

        public frmCins()
        {
            InitializeComponent();
        }

        private void frmCins_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
        }
        void Temizle() {
            txtCinsTur.Text = "";
        } 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();

            Cins c = new Cins();
            c.CinsAd = Convert.ToString(txtCinsTur.Text);
            vt.Cins.Add(c);
            vt.SaveChanges();
            TumKullanicilariListele();
            Temizle();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();

            int id = Convert.ToInt32(lblID.Text);
            Cins c = vt.Cins.FirstOrDefault(p => p.CinsID == id);
            vt.Cins.Remove(c);
            vt.SaveChanges();
            Temizle();
            TumKullanicilariListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();

            int id = Convert.ToInt32(lblID.Text);
            Cins c = vt.Cins.FirstOrDefault(p => p.CinsID == id);
            c.CinsAd = txtCinsTur.Text;
            vt.SaveChanges();
            TumKullanicilariListele();
            Temizle();
        }


        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.Cins.ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblID.Text = secilen.Cells[0].Value.ToString();
            txtCinsTur.Text = secilen.Cells[1].Value.ToString();
        }
    }
}
