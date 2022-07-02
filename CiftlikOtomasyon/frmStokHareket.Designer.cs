
namespace CiftlikOtomasyon
{
    partial class frmStokHareket
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbStok = new System.Windows.Forms.ComboBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.dtStokGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StokHareketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokTurAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(700, 279);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbStok
            // 
            this.cbStok.FormattingEnabled = true;
            this.cbStok.Location = new System.Drawing.Point(700, 124);
            this.cbStok.Name = "cbStok";
            this.cbStok.Size = new System.Drawing.Size(200, 21);
            this.cbStok.TabIndex = 16;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(597, 127);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(29, 13);
            this.lblStok.TabIndex = 17;
            this.lblStok.Text = "Stok";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(600, 167);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 18;
            this.lblMiktar.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(700, 164);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(200, 20);
            this.txtMiktar.TabIndex = 19;
            // 
            // dtStokGirisTarihi
            // 
            this.dtStokGirisTarihi.Location = new System.Drawing.Point(700, 204);
            this.dtStokGirisTarihi.Name = "dtStokGirisTarihi";
            this.dtStokGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtStokGirisTarihi.TabIndex = 20;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(600, 210);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 21;
            this.lblTarih.Text = "Tarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokHareketID,
            this.StokId,
            this.StokTurAd,
            this.Miktar,
            this.IslemTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(35, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 317);
            this.dataGridView1.TabIndex = 22;
            // 
            // StokHareketID
            // 
            this.StokHareketID.DataPropertyName = "StokHareketID";
            this.StokHareketID.HeaderText = "StokHareketID";
            this.StokHareketID.Name = "StokHareketID";
            // 
            // StokId
            // 
            this.StokId.DataPropertyName = "StokTur";
            this.StokId.HeaderText = "StokId";
            this.StokId.Name = "StokId";
            this.StokId.Visible = false;
            // 
            // StokTurAd
            // 
            this.StokTurAd.DataPropertyName = "StokTurAd";
            this.StokTurAd.HeaderText = "StokTurAd";
            this.StokTurAd.Name = "StokTurAd";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // IslemTarihi
            // 
            this.IslemTarihi.DataPropertyName = "IslemTarihi";
            this.IslemTarihi.HeaderText = "IslemTarihi";
            this.IslemTarihi.Name = "IslemTarihi";
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(700, 328);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 12;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // frmStokHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dtStokGirisTarihi);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.cbStok);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Name = "frmStokHareket";
            this.Text = "Stok Giriş";
            this.Load += new System.EventHandler(this.frmStokHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.DateTimePicker dtStokGirisTarihi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokHareketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTurAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi;
        private System.Windows.Forms.Button btnCikar;
    }
}