﻿
namespace CiftlikOtomasyon
{
    partial class frmStokTur
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
            this.StokTurID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokTurAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStokTurAd = new System.Windows.Forms.TextBox();
            this.lblStokTurAd = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokTurID,
            this.StokTurAd});
            this.dataGridView1.Location = new System.Drawing.Point(36, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // StokTurID
            // 
            this.StokTurID.DataPropertyName = "StokTurID";
            this.StokTurID.HeaderText = "Stok Tur No";
            this.StokTurID.Name = "StokTurID";
            // 
            // StokTurAd
            // 
            this.StokTurAd.DataPropertyName = "StokTurAd";
            this.StokTurAd.HeaderText = "StokTurAd";
            this.StokTurAd.Name = "StokTurAd";
            // 
            // txtStokTurAd
            // 
            this.txtStokTurAd.Location = new System.Drawing.Point(504, 73);
            this.txtStokTurAd.Name = "txtStokTurAd";
            this.txtStokTurAd.Size = new System.Drawing.Size(100, 20);
            this.txtStokTurAd.TabIndex = 1;
            // 
            // lblStokTurAd
            // 
            this.lblStokTurAd.AutoSize = true;
            this.lblStokTurAd.Location = new System.Drawing.Point(394, 73);
            this.lblStokTurAd.Name = "lblStokTurAd";
            this.lblStokTurAd.Size = new System.Drawing.Size(64, 13);
            this.lblStokTurAd.TabIndex = 2;
            this.lblStokTurAd.Text = "Stok Tür Ad";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(504, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(504, 147);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(504, 178);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(615, 111);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // frmStokTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblStokTurAd);
            this.Controls.Add(this.txtStokTurAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStokTur";
            this.Text = "Stok Tür";
            this.Load += new System.EventHandler(this.frmStokTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTurID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTurAd;
        private System.Windows.Forms.TextBox txtStokTurAd;
        private System.Windows.Forms.Label lblStokTurAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblID;
    }
}