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
    public partial class frmKullaniciRolleri : Form
    {
        public frmKullaniciRolleri()
        {
            InitializeComponent();
        }
        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.Rol.ToList();
            Temizle();
        }

        private void fmrKullaniciRolleri_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblId.Text = secilen.Cells[0].Value.ToString();
            txtRolAd.Text = secilen.Cells[1].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Rol yeniRol = new Rol();
            yeniRol.RolAd = txtRolAd.Text;

            yeniRol.RolKod = txtRolAd.Text.Trim().Replace(" ", string.Empty);
            CiftlikEntities vt = new CiftlikEntities();
            vt.Rol.Add(yeniRol);
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int rolId = Convert.ToInt32(lblId.Text);
            Rol rol = vt.Rol.FirstOrDefault(p => p.RolID == rolId);
            vt.Rol.Remove(rol);
            vt.SaveChanges();
            TumKullanicilariListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int rolId = Convert.ToInt32(lblId.Text);
            Rol r1 = vt.Rol.FirstOrDefault(p => p.RolID == rolId);
            r1.RolAd = txtRolAd.Text;
            r1.RolKod = txtRolAd.Text.Trim().Replace(" ", string.Empty);
            vt.SaveChanges();
            TumKullanicilariListele();
        }
        private void Temizle() {
            txtRolAd.Clear();
            lblId.Text = "";
        }
    }
}
