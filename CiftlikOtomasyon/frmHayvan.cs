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
    public partial class frmHayvan : Form
    {

        public frmHayvan()
        {
            InitializeComponent();
        }
        void Temizle() {
            txtAgirlik.Text = "";
            txtKupeNo.Text = "";
            cbCins.SelectedValue = 0;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();

            Hayvan h = new Hayvan();
            String KupeNo = Convert.ToString(txtKupeNo.Text);

            h.KupeNo = KupeNo;
            h.CinsId = Convert.ToInt32(cbCins.SelectedValue);            
            decimal d= Convert.ToDecimal(txtAgirlik.Text);
            h.Agirlik = d;
            h.OlcumTarihi = dtTarih.Value;
            vt.Hayvan.Add(h);
            vt.SaveChanges();

            Hayvan hID = vt.Hayvan.FirstOrDefault(p=>p.KupeNo== KupeNo);
            SutTakip st = new SutTakip();
            st.HayvanId = hID.HayvanID;
            st.IslemTarihi= DateTime.Now;
            st.Miktar = 0;
            vt.SutTakip.Add(st);
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void btnGucelle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();

            int id = Convert.ToInt32(lblID.Text);
            Hayvan h = vt.Hayvan.FirstOrDefault(p=>p.HayvanID==id);
            h.KupeNo = Convert.ToString(txtKupeNo.Text);
            h.CinsId = Convert.ToInt32(cbCins.SelectedValue);
            decimal d = Convert.ToDecimal(txtAgirlik.Text);
            h.Agirlik = d;
            h.OlcumTarihi = dtTarih.Value;
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vHayvan.ToList();
            Temizle();
        }     

        private void frmHayvan_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
            // cbKullaniciRol doldurma
            cbCins.DisplayMember = "CinsAD";
            cbCins.ValueMember = "CinsID";
            CiftlikEntities vt = new CiftlikEntities();
            cbCins.DataSource = vt.Cins.ToList();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblID.Text = secilen.Cells[0].Value.ToString();
            txtKupeNo.Text = secilen.Cells[1].Value.ToString();
            cbCins.Text = secilen.Cells[2].Value.ToString();
            txtAgirlik.Text = secilen.Cells[3].Value.ToString();
            dtTarih.Text = secilen.Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int id = Convert.ToInt32(lblID.Text);
            Hayvan h = vt.Hayvan.FirstOrDefault(p => p.HayvanID == id);
            vt.Hayvan.Remove(h);
            vt.SaveChanges();
            TumKullanicilariListele();

        }
    }
}
