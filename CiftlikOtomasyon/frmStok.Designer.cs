
namespace CiftlikOtomasyon
{
    partial class frmStok
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
            this.StokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokTurId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokGirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.dtStokGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblStokTür = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblStokGirisTarihi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokID,
            this.StokTurId,
            this.Miktar,
            this.StokGirisTarihi,
            this.IslemTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 325);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // StokID
            // 
            this.StokID.DataPropertyName = "StokID";
            this.StokID.HeaderText = "StokID";
            this.StokID.Name = "StokID";
            // 
            // StokTurId
            // 
            this.StokTurId.DataPropertyName = "StokTurAd";
            this.StokTurId.HeaderText = "StokTurId";
            this.StokTurId.Name = "StokTurId";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // StokGirisTarihi
            // 
            this.StokGirisTarihi.DataPropertyName = "StokGirisTarihi";
            this.StokGirisTarihi.HeaderText = "StokGirisTarihi";
            this.StokGirisTarihi.Name = "StokGirisTarihi";
            // 
            // IslemTarihi
            // 
            this.IslemTarihi.DataPropertyName = "IslemTarihi";
            this.IslemTarihi.HeaderText = "IslemTarihi";
            this.IslemTarihi.Name = "IslemTarihi";
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(686, 119);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(121, 21);
            this.cbTur.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(686, 146);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 3;
            // 
            // dtStokGirisTarihi
            // 
            this.dtStokGirisTarihi.Location = new System.Drawing.Point(686, 172);
            this.dtStokGirisTarihi.Name = "dtStokGirisTarihi";
            this.dtStokGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtStokGirisTarihi.TabIndex = 4;
            // 
            // lblStokTür
            // 
            this.lblStokTür.AutoSize = true;
            this.lblStokTür.Location = new System.Drawing.Point(587, 119);
            this.lblStokTür.Name = "lblStokTür";
            this.lblStokTür.Size = new System.Drawing.Size(48, 13);
            this.lblStokTür.TabIndex = 5;
            this.lblStokTür.Text = "Stok Tür";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(590, 146);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 6;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblStokGirisTarihi
            // 
            this.lblStokGirisTarihi.AutoSize = true;
            this.lblStokGirisTarihi.Location = new System.Drawing.Point(593, 172);
            this.lblStokGirisTarihi.Name = "lblStokGirisTarihi";
            this.lblStokGirisTarihi.Size = new System.Drawing.Size(81, 13);
            this.lblStokGirisTarihi.TabIndex = 7;
            this.lblStokGirisTarihi.Text = "Stok Giriş Tarihi";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(791, 222);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "label4";
            this.lblID.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(632, 212);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(632, 269);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(632, 240);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 568);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblStokGirisTarihi);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblStokTür);
            this.Controls.Add(this.dtStokGirisTarihi);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStok";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.DateTimePicker dtStokGirisTarihi;
        private System.Windows.Forms.Label lblStokTür;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblStokGirisTarihi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTurId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokGirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}