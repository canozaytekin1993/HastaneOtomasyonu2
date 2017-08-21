namespace HastaneOtomasyonu2
{
    partial class PersonelDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelDuzenleForm));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::HastaneOtomasyonu2.Properties.Resources.Ekle;
            this.btnKaydet.Location = new System.Drawing.Point(49, 374);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnKaydet.Size = new System.Drawing.Size(219, 98);
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCinsiyet.Location = new System.Drawing.Point(223, 192);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCinsiyet.Size = new System.Drawing.Size(714, 32);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(223, 139);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDogumTarihi.Size = new System.Drawing.Size(714, 32);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(99, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(117, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(152, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoyad.Location = new System.Drawing.Point(223, 86);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyad.Size = new System.Drawing.Size(714, 32);
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAd.Location = new System.Drawing.Point(223, 33);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAd.Size = new System.Drawing.Size(714, 32);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtArama
            // 
            this.txtArama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArama.Location = new System.Drawing.Point(223, 514);
            this.txtArama.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtArama.Size = new System.Drawing.Size(714, 32);
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKisi.Location = new System.Drawing.Point(49, 564);
            this.lstKisi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.lstKisi.Size = new System.Drawing.Size(888, 244);
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.Image = global::HastaneOtomasyonu2.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(384, 374);
            this.btnSil.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSil.Size = new System.Drawing.Size(219, 98);
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 75;
            this.label5.Text = "Maaş";
            // 
            // cmbGorev
            // 
            this.cmbGorev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(223, 245);
            this.cmbGorev.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(714, 32);
            this.cmbGorev.TabIndex = 77;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(119, 248);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 24);
            this.Label6.TabIndex = 78;
            this.Label6.Text = "Gorev";
            // 
            // numMaas
            // 
            this.numMaas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaas.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMaas.Location = new System.Drawing.Point(223, 298);
            this.numMaas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(717, 32);
            this.numMaas.TabIndex = 79;
            this.numMaas.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.Image = global::HastaneOtomasyonu2.Properties.Resources.Güncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(718, 374);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(219, 98);
            this.btnGuncelle.TabIndex = 80;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 517);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 24);
            this.label7.TabIndex = 81;
            this.label7.Text = "Personel Arama";
            // 
            // PersonelDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 958);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.numMaas);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cmbGorev);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "PersonelDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.PersonelDuzenleForm_Load);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbGorev, 0);
            this.Controls.SetChildIndex(this.Label6, 0);
            this.Controls.SetChildIndex(this.numMaas, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.lstKisi, 0);
            this.Controls.SetChildIndex(this.txtArama, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.btnGuncelle, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
    }
}