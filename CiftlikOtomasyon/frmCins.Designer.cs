
namespace CiftlikOtomasyon
{
    partial class frmCins
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
            this.CinsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CinsAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCinsTur = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblCinsTur = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CinsID,
            this.CinsAd});
            this.dataGridView1.Location = new System.Drawing.Point(45, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CinsID
            // 
            this.CinsID.DataPropertyName = "CinsID";
            this.CinsID.HeaderText = "CinsID";
            this.CinsID.Name = "CinsID";
            // 
            // CinsAd
            // 
            this.CinsAd.DataPropertyName = "CinsAd";
            this.CinsAd.HeaderText = "CinsAd";
            this.CinsAd.Name = "CinsAd";
            // 
            // txtCinsTur
            // 
            this.txtCinsTur.Location = new System.Drawing.Point(475, 115);
            this.txtCinsTur.Name = "txtCinsTur";
            this.txtCinsTur.Size = new System.Drawing.Size(100, 20);
            this.txtCinsTur.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(475, 166);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(475, 195);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblCinsTur
            // 
            this.lblCinsTur.AutoSize = true;
            this.lblCinsTur.Location = new System.Drawing.Point(409, 118);
            this.lblCinsTur.Name = "lblCinsTur";
            this.lblCinsTur.Size = new System.Drawing.Size(46, 13);
            this.lblCinsTur.TabIndex = 4;
            this.lblCinsTur.Text = "Cins Tür";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(475, 224);
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
            this.lblID.Location = new System.Drawing.Point(573, 176);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // frmCins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblCinsTur);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtCinsTur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCins";
            this.Text = "Hayvan cins";
            this.Load += new System.EventHandler(this.frmCins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinsAd;
        private System.Windows.Forms.TextBox txtCinsTur;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblCinsTur;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblID;
    }
}