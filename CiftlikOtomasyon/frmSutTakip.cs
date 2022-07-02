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
    public partial class frmSutTakip : Form
    {
        public frmSutTakip()
        {
            InitializeComponent();
        }
        void Temizle() {
            txtMiktar.Text = "";
            cbKupeNo.SelectedValue = 0;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int id = Convert.ToInt32(lblID.Text);
            SutTakip su = vt.SutTakip.SingleOrDefault(p=>p.SutHareketId==id);
            su.HayvanId = Convert.ToInt32(cbKupeNo.SelectedValue);
            DateTime now = DateTime.Now;
            su.IslemTarihi = now;
            decimal d = Convert.ToDecimal(txtMiktar.Text);
            su.Miktar = d;
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void frmSutTakip_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
            //hayvan doldurma
            cbKupeNo.DisplayMember = "KupeNo";
            cbKupeNo.ValueMember = "HayvanID";
      
            CiftlikEntities vt = new CiftlikEntities();
            cbKupeNo.DataSource = vt.Hayvan.ToList();
            cbKupeNo.SelectedValue = 0;
        }

        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vSutTakip.ToList();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
           
            cbKupeNo.Text = secilen.Cells[1].Value.ToString();
            txtMiktar.Text = secilen.Cells[2].Value.ToString();
          
        }
    }
}
