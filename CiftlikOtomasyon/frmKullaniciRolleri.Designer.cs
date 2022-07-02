
namespace CiftlikOtomasyon
{
    partial class frmKullaniciRolleri
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
            this.rolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblRolAd = new System.Windows.Forms.Label();
            this.txtRolAd = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolId,
            this.RolAd,
            this.rolKod});
            this.dataGridView1.Location = new System.Drawing.Point(76, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // rolId
            // 
            this.rolId.DataPropertyName = "rolId";
            this.rolId.HeaderText = "Rol Numara";
            this.rolId.Name = "rolId";
            // 
            // RolAd
            // 
            this.RolAd.DataPropertyName = "RolAd";
            this.RolAd.HeaderText = "Rol Ad";
            this.RolAd.Name = "RolAd";
            // 
            // rolKod
            // 
            this.rolKod.DataPropertyName = "rolKod";
            this.rolKod.HeaderText = "Rol Kod";
            this.rolKod.Name = "rolKod";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(605, 183);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblRolAd
            // 
            this.lblRolAd.AutoSize = true;
            this.lblRolAd.Location = new System.Drawing.Point(542, 93);
            this.lblRolAd.Name = "lblRolAd";
            this.lblRolAd.Size = new System.Drawing.Size(38, 13);
            this.lblRolAd.TabIndex = 2;
            this.lblRolAd.Text = "Rol ad";
            // 
            // txtRolAd
            // 
            this.txtRolAd.Location = new System.Drawing.Point(586, 90);
            this.txtRolAd.Name = "txtRolAd";
            this.txtRolAd.Size = new System.Drawing.Size(176, 20);
            this.txtRolAd.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(605, 213);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(605, 243);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(714, 222);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // frmKullaniciRolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtRolAd);
            this.Controls.Add(this.lblRolAd);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullaniciRolleri";
            this.Text = "Kullanıcı rolleri";
            this.Load += new System.EventHandler(this.fmrKullaniciRolleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolKod;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblRolAd;
        private System.Windows.Forms.TextBox txtRolAd;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblId;
    }
}