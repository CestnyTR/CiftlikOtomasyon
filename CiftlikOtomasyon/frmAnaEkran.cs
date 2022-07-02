using System;
using System.Windows.Forms;

namespace CiftlikOtomasyon
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        public frmAnaEkran(Kullanici pKullanici)
        {
            InitializeComponent();

            menuYonetici.Visible = false;
            menuStokSorumlusu.Visible = false;
            menuSutSagimSorumlusu.Visible = false;

            switch (pKullanici.Rol.RolKod)
            {
                case "Yonetici":
                    menuYonetici.Visible = true;
                    break;
                case "StokSorumlusu":
                    menuStokSorumlusu.Visible = true;
                    break;
                case "SutSagimSorumlusu":
                    menuSutSagimSorumlusu.Visible = true;
                    break;
            }

        }

        private void frmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tümKullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanicilar kullanicilar = new frmKullanicilar();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void kullanıcıRolleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciRolleri kullanicilar = new frmKullaniciRolleri();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStok kullanicilar = new frmStok();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void hayvanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHayvan kullanicilar = new frmHayvan();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void cinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCins kullanicilar = new frmCins();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void stokTürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokTur kullanicilar = new frmStokTur();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmStok kullanicilar = new frmStok();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmSutUretimEkranı kullanicilar = new frmSutUretimEkranı();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void stokHareketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokHareket kullanicilar = new frmStokHareket();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void sütÜretimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSutUretimEkranı kullanicilar = new frmSutUretimEkranı();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void sütStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSutTakip kullanicilar = new frmSutTakip();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void sütGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rprSutStok kullanicilar = new rprSutStok();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void yemGrafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rprStok kullanicilar = new rprStok();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }
    }
}
