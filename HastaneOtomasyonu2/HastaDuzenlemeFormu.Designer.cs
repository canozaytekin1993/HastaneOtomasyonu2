namespace HastaneOtomasyonu2
{
    partial class HastaDuzenlemeFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaDuzenlemeFormu));
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::HastaneOtomasyonu2.Properties.Resources.Ekle;
            this.btnKaydet.Location = new System.Drawing.Point(50, 298);
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
            this.cmbCinsiyet.Location = new System.Drawing.Point(198, 182);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCinsiyet.Size = new System.Drawing.Size(738, 32);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(198, 136);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDogumTarihi.Size = new System.Drawing.Size(738, 32);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(76, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(88, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(120, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoyad.Location = new System.Drawing.Point(198, 92);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyad.Size = new System.Drawing.Size(738, 32);
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAd.Location = new System.Drawing.Point(198, 46);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAd.Size = new System.Drawing.Size(738, 32);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtArama
            // 
            this.txtArama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArama.Location = new System.Drawing.Point(198, 420);
            this.txtArama.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtArama.Size = new System.Drawing.Size(739, 32);
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKisi.Location = new System.Drawing.Point(49, 465);
            this.lstKisi.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lstKisi.Size = new System.Drawing.Size(888, 364);
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.Image = global::HastaneOtomasyonu2.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(385, 298);
            this.btnSil.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSil.Size = new System.Drawing.Size(219, 98);
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGüncelle.Image = global::HastaneOtomasyonu2.Properties.Resources.Güncelle;
            this.btnGüncelle.Location = new System.Drawing.Point(720, 298);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(219, 98);
            this.btnGüncelle.TabIndex = 72;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 423);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "Hasta Arama";
            // 
            // HastaDuzenlemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 849);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGüncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "HastaDuzenlemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.HastaDuzenlemeFormu_Load);
            this.Controls.SetChildIndex(this.btnGüncelle, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label7;
    }
}