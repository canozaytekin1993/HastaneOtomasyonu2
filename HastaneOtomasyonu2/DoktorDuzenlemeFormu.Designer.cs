namespace HastaneOtomasyonu2
{
    partial class DoktorDuzenlemeFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorDuzenlemeFormu));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBranslar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAtanabilir = new System.Windows.Forms.ListBox();
            this.lstAtanmıs = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::HastaneOtomasyonu2.Properties.Resources.Ekle;
            this.btnKaydet.Location = new System.Drawing.Point(39, 437);
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
            this.cmbCinsiyet.Location = new System.Drawing.Point(221, 166);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCinsiyet.Size = new System.Drawing.Size(704, 32);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(221, 122);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDogumTarihi.Size = new System.Drawing.Size(704, 32);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(97, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(115, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoyad.Location = new System.Drawing.Point(221, 78);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyad.Size = new System.Drawing.Size(704, 32);
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAd.Location = new System.Drawing.Point(221, 34);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAd.Size = new System.Drawing.Size(704, 32);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtArama
            // 
            this.txtArama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArama.Location = new System.Drawing.Point(218, 551);
            this.txtArama.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtArama.Size = new System.Drawing.Size(707, 32);
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKisi.Location = new System.Drawing.Point(37, 596);
            this.lstKisi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.lstKisi.Size = new System.Drawing.Size(888, 244);
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.Image = global::HastaneOtomasyonu2.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(374, 437);
            this.btnSil.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSil.Size = new System.Drawing.Size(219, 98);
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.Image = global::HastaneOtomasyonu2.Properties.Resources.Güncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(706, 437);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(219, 98);
            this.btnGuncelle.TabIndex = 72;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Maas";
            // 
            // cmbBranslar
            // 
            this.cmbBranslar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBranslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranslar.FormattingEnabled = true;
            this.cmbBranslar.Location = new System.Drawing.Point(221, 254);
            this.cmbBranslar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbBranslar.Name = "cmbBranslar";
            this.cmbBranslar.Size = new System.Drawing.Size(704, 32);
            this.cmbBranslar.TabIndex = 75;
            this.cmbBranslar.SelectedIndexChanged += new System.EventHandler(this.cmbBranslar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 76;
            this.label6.Text = "Branşlar";
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
            this.numMaas.Location = new System.Drawing.Point(221, 212);
            this.numMaas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(704, 32);
            this.numMaas.TabIndex = 77;
            this.numMaas.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 24);
            this.label7.TabIndex = 84;
            this.label7.Text = "Boştaki Hemşireler";
            // 
            // lstAtanabilir
            // 
            this.lstAtanabilir.FormattingEnabled = true;
            this.lstAtanabilir.ItemHeight = 24;
            this.lstAtanabilir.Location = new System.Drawing.Point(218, 330);
            this.lstAtanabilir.Name = "lstAtanabilir";
            this.lstAtanabilir.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAtanabilir.Size = new System.Drawing.Size(359, 100);
            this.lstAtanabilir.TabIndex = 85;
            // 
            // lstAtanmıs
            // 
            this.lstAtanmıs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAtanmıs.FormattingEnabled = true;
            this.lstAtanmıs.ItemHeight = 24;
            this.lstAtanmıs.Location = new System.Drawing.Point(583, 330);
            this.lstAtanmıs.Name = "lstAtanmıs";
            this.lstAtanmıs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAtanmıs.Size = new System.Drawing.Size(342, 100);
            this.lstAtanmıs.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 24);
            this.label8.TabIndex = 87;
            this.label8.Text = "Doktora Bağlı Hemşireler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 554);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 88;
            this.label9.Text = "Doktor Arama";
            // 
            // DoktorDuzenlemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 958);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstAtanmıs);
            this.Controls.Add(this.lstAtanabilir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numMaas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBranslar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "DoktorDuzenlemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.DoktorDuzenlemeFormu_Load);
            this.Controls.SetChildIndex(this.btnGuncelle, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbBranslar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
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
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lstAtanabilir, 0);
            this.Controls.SetChildIndex(this.lstAtanmıs, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBranslar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstAtanabilir;
        private System.Windows.Forms.ListBox lstAtanmıs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}