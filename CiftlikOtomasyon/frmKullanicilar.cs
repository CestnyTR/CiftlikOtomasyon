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
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }


        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vKullanici.ToList();
        }
        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();

            //cbKullaniciRol doldurma
            cbKullaniciRol.DisplayMember = "RolAd";
            cbKullaniciRol.ValueMember = "RolID";
            CiftlikEntities vt = new CiftlikEntities();
            cbKullaniciRol.DataSource = vt.Rol.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.KullaniciAd = txtKullaniciAd.Text;
            yeniKullanici.KullanciRolId = Convert.ToInt32(cbKullaniciRol.SelectedValue);
            yeniKullanici.Sifre = yeniKullanici.KullaniciAd.Substring(0, 10);
            yeniKullanici.Aktif = chkAktif.Checked;
            CiftlikEntities vt = new CiftlikEntities();
            vt.Kullanici.Add(yeniKullanici);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                AlanlariTemizle();
                TumKullanicilariListele();
                MessageBox.Show("Kayıt başarılı!!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız!!");
            }
        }


        void AlanlariTemizle()
        {
            txtKullaniciAd.Clear();
            cbKullaniciRol.SelectedIndex = 0;
            chkAktif.Checked = true;
            lblId.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secilen = dataGridView1.Rows[e.RowIndex];
            lblId.Text = secilen.Cells["KullaniciID"].Value.ToString();
            txtKullaniciAd.Text = secilen.Cells[2].Value.ToString();
            cbKullaniciRol.Text = secilen.Cells[1].Value.ToString();
            String aktif = secilen.Cells[3].Value.ToString();
            if (secilen.Cells[3].Value.ToString() == "True")
            {
                chkAktif.Checked = true;
            }
            else
            {
                chkAktif.Checked = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int kisiId = Convert.ToInt32(lblId.Text);
            Kullanici k1 = vt.Kullanici.FirstOrDefault(p => p.KullaniciID == kisiId);
            k1.KullaniciAd = txtKullaniciAd.Text;
            k1.KullanciRolId = Convert.ToInt32(cbKullaniciRol.SelectedValue);
            k1.Aktif = chkAktif.Checked ? true : false;
            vt.SaveChanges();
            TumKullanicilariListele();
            AlanlariTemizle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int kisiId = Convert.ToInt32(lblId.Text);
            Kullanici k1 = vt.Kullanici.FirstOrDefault(p => p.KullaniciID == kisiId);
            vt.Kullanici.Remove(k1);

            vt.SaveChanges();
            TumKullanicilariListele();
            AlanlariTemizle();
        }
    }
}
