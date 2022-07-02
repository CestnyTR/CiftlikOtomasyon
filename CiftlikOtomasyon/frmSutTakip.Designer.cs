
namespace CiftlikOtomasyon
{
    partial class frmSutTakip
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
            this.SutHareketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KupeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKüpeNo = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.cbKupeNo = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SutHareketID,
            this.KupeNo,
            this.Miktar,
            this.IslemTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(72, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SutHareketID
            // 
            this.SutHareketID.DataPropertyName = "SutHareketID";
            this.SutHareketID.HeaderText = "SutHareketID";
            this.SutHareketID.Name = "SutHareketID";
            // 
            // KupeNo
            // 
            this.KupeNo.DataPropertyName = "KupeNo";
            this.KupeNo.HeaderText = "KupeNo";
            this.KupeNo.Name = "KupeNo";
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
            // lblKüpeNo
            // 
            this.lblKüpeNo.AutoSize = true;
            this.lblKüpeNo.Location = new System.Drawing.Point(616, 88);
            this.lblKüpeNo.Name = "lblKüpeNo";
            this.lblKüpeNo.Size = new System.Drawing.Size(77, 13);
            this.lblKüpeNo.TabIndex = 1;
            this.lblKüpeNo.Text = "Küpe numarası";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(616, 121);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(23, 13);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "litre";
            // 
            // cbKupeNo
            // 
            this.cbKupeNo.FormattingEnabled = true;
            this.cbKupeNo.Location = new System.Drawing.Point(775, 88);
            this.cbKupeNo.Name = "cbKupeNo";
            this.cbKupeNo.Size = new System.Drawing.Size(121, 21);
            this.cbKupeNo.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(775, 121);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 20);
            this.txtMiktar.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(775, 219);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(856, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // frmSutTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 659);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cbKupeNo);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblKüpeNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSutTakip";
            this.Text = "Süt Stok";
            this.Load += new System.EventHandler(this.frmSutTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKüpeNo;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.ComboBox cbKupeNo;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SutHareketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi;
        private System.Windows.Forms.Label lblID;
    }
}