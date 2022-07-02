
namespace CiftlikOtomasyon
{
    partial class frmSutUretimEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SutUretimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KupeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZamanAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.cbHayvan = new System.Windows.Forms.ComboBox();
            this.dtIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbZaman = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblHayvan = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SutUretimID,
            this.KupeNo,
            this.Tarih,
            this.ZamanAD,
            this.Miktar});
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SutUretimID
            // 
            this.SutUretimID.DataPropertyName = "SutUretimID";
            this.SutUretimID.HeaderText = "SutUretimID";
            this.SutUretimID.Name = "SutUretimID";
            // 
            // KupeNo
            // 
            this.KupeNo.DataPropertyName = "KupeNo";
            this.KupeNo.HeaderText = "HayvanId";
            this.KupeNo.Name = "KupeNo";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // ZamanAD
            // 
            this.ZamanAD.DataPropertyName = "ZamanAd";
            this.ZamanAD.HeaderText = "ZamanId";
            this.ZamanAD.Name = "ZamanAD";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(849, 309);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Visible = false;
            // 
            // cbHayvan
            // 
            this.cbHayvan.FormattingEnabled = true;
            this.cbHayvan.Location = new System.Drawing.Point(683, 70);
            this.cbHayvan.Name = "cbHayvan";
            this.cbHayvan.Size = new System.Drawing.Size(200, 21);
            this.cbHayvan.TabIndex = 2;
            // 
            // dtIslemTarihi
            // 
            this.dtIslemTarihi.Location = new System.Drawing.Point(683, 114);
            this.dtIslemTarihi.Name = "dtIslemTarihi";
            this.dtIslemTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtIslemTarihi.TabIndex = 3;
            // 
            // cbZaman
            // 
            this.cbZaman.FormattingEnabled = true;
            this.cbZaman.Location = new System.Drawing.Point(683, 150);
            this.cbZaman.Name = "cbZaman";
            this.cbZaman.Size = new System.Drawing.Size(200, 21);
            this.cbZaman.TabIndex = 4;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(683, 190);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(200, 20);
            this.txtMiktar.TabIndex = 5;
            // 
            // lblHayvan
            // 
            this.lblHayvan.AutoSize = true;
            this.lblHayvan.Location = new System.Drawing.Point(634, 77);
            this.lblHayvan.Name = "lblHayvan";
            this.lblHayvan.Size = new System.Drawing.Size(44, 13);
            this.lblHayvan.TabIndex = 6;
            this.lblHayvan.Text = "Hayvan";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(637, 120);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "Tarih";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(637, 157);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(40, 13);
            this.lblZaman.TabIndex = 8;
            this.lblZaman.Text = "Zaman";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(640, 196);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 9;
            this.lblMiktar.Text = "Miktar";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(683, 272);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Litre gir";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(683, 309);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 10;
            this.btnCikar.Text = "litre eksilt";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // frmSutUretimEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 576);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblHayvan);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cbZaman);
            this.Controls.Add(this.dtIslemTarihi);
            this.Controls.Add(this.cbHayvan);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSutUretimEkranı";
            this.Text = "Süt Üretim Paneli";
            this.Load += new System.EventHandler(this.fmrSutUretimEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbHayvan;
        private System.Windows.Forms.DateTimePicker dtIslemTarihi;
        private System.Windows.Forms.ComboBox cbZaman;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblHayvan;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SutUretimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZamanAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.Button btnCikar;
    }
}