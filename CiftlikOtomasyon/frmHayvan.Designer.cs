
namespace CiftlikOtomasyon
{
    partial class frmHayvan
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKupeNo = new System.Windows.Forms.TextBox();
            this.cbCins = new System.Windows.Forms.ComboBox();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lblKupeNo = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblAgirlik = new System.Windows.Forms.Label();
            this.lblOlcumTarihi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGucelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HayvanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KupeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CinsAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agirlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(728, 201);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 26);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKupeNo
            // 
            this.txtKupeNo.Location = new System.Drawing.Point(728, 83);
            this.txtKupeNo.MaxLength = 10;
            this.txtKupeNo.Name = "txtKupeNo";
            this.txtKupeNo.Size = new System.Drawing.Size(160, 20);
            this.txtKupeNo.TabIndex = 3;
            // 
            // cbCins
            // 
            this.cbCins.FormattingEnabled = true;
            this.cbCins.Location = new System.Drawing.Point(728, 109);
            this.cbCins.Name = "cbCins";
            this.cbCins.Size = new System.Drawing.Size(160, 21);
            this.cbCins.TabIndex = 4;
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(728, 136);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(160, 20);
            this.txtAgirlik.TabIndex = 5;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(728, 162);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(160, 20);
            this.dtTarih.TabIndex = 6;
            // 
            // lblKupeNo
            // 
            this.lblKupeNo.AutoSize = true;
            this.lblKupeNo.Location = new System.Drawing.Point(628, 89);
            this.lblKupeNo.Name = "lblKupeNo";
            this.lblKupeNo.Size = new System.Drawing.Size(47, 13);
            this.lblKupeNo.TabIndex = 7;
            this.lblKupeNo.Text = "Küpe no";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(631, 116);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(27, 13);
            this.lblCins.TabIndex = 8;
            this.lblCins.Text = "Cins";
            // 
            // lblAgirlik
            // 
            this.lblAgirlik.AutoSize = true;
            this.lblAgirlik.Location = new System.Drawing.Point(631, 142);
            this.lblAgirlik.Name = "lblAgirlik";
            this.lblAgirlik.Size = new System.Drawing.Size(35, 13);
            this.lblAgirlik.TabIndex = 9;
            this.lblAgirlik.Text = "Ağırlık";
            // 
            // lblOlcumTarihi
            // 
            this.lblOlcumTarihi.AutoSize = true;
            this.lblOlcumTarihi.Location = new System.Drawing.Point(631, 169);
            this.lblOlcumTarihi.Name = "lblOlcumTarihi";
            this.lblOlcumTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblOlcumTarihi.TabIndex = 10;
            this.lblOlcumTarihi.Text = "Ölçüm Tarihi";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(818, 208);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(728, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGucelle
            // 
            this.btnGucelle.Location = new System.Drawing.Point(728, 263);
            this.btnGucelle.Name = "btnGucelle";
            this.btnGucelle.Size = new System.Drawing.Size(75, 23);
            this.btnGucelle.TabIndex = 13;
            this.btnGucelle.Text = "Güncelle";
            this.btnGucelle.UseVisualStyleBackColor = true;
            this.btnGucelle.Click += new System.EventHandler(this.btnGucelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HayvanID,
            this.KupeNo,
            this.CinsAd,
            this.Agirlik,
            this.OlcumTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(33, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 203);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // HayvanID
            // 
            this.HayvanID.DataPropertyName = "HayvanID";
            this.HayvanID.HeaderText = "HayvanID";
            this.HayvanID.Name = "HayvanID";
            // 
            // KupeNo
            // 
            this.KupeNo.DataPropertyName = "KupeNo";
            this.KupeNo.HeaderText = "KupeNo";
            this.KupeNo.Name = "KupeNo";
            // 
            // CinsAd
            // 
            this.CinsAd.DataPropertyName = "CinsAd";
            this.CinsAd.HeaderText = "CinsId";
            this.CinsAd.Name = "CinsAd";
            // 
            // Agirlik
            // 
            this.Agirlik.DataPropertyName = "Agirlik";
            this.Agirlik.HeaderText = "Agirlik";
            this.Agirlik.Name = "Agirlik";
            // 
            // OlcumTarihi
            // 
            this.OlcumTarihi.DataPropertyName = "OlcumTarihi";
            this.OlcumTarihi.HeaderText = "OlcumTarihi";
            this.OlcumTarihi.Name = "OlcumTarihi";
            // 
            // frmHayvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGucelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblOlcumTarihi);
            this.Controls.Add(this.lblAgirlik);
            this.Controls.Add(this.lblCins);
            this.Controls.Add(this.lblKupeNo);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.cbCins);
            this.Controls.Add(this.txtKupeNo);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmHayvan";
            this.Text = "Hayvan giriş";
            this.Load += new System.EventHandler(this.frmHayvan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKupeNo;
        private System.Windows.Forms.ComboBox cbCins;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label lblKupeNo;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblAgirlik;
        private System.Windows.Forms.Label lblOlcumTarihi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGucelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HayvanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinsAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agirlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcumTarihi;
    }
}