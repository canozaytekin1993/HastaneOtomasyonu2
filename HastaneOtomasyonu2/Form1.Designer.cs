namespace HastaneOtomasyonu2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.dosyaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(997, 78);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Personel;
            this.personelToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.personelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(136, 72);
            this.personelToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Doktor;
            this.doktorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.doktorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(127, 72);
            this.doktorToolStripMenuItem.Text = "Doktor İşlemleri";
            this.doktorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.doktorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Hemşire;
            this.hemşireToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hemşireToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(136, 72);
            this.hemşireToolStripMenuItem.Text = "Hemşire İşlemleri";
            this.hemşireToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hemşireToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hemşireToolStripMenuItem.Click += new System.EventHandler(this.hemşireToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Hasta;
            this.hastaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hastaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(119, 72);
            this.hastaToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hastaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Randevu;
            this.randevuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randevuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(138, 72);
            this.randevuToolStripMenuItem.Text = "Randevu İşlemleri";
            this.randevuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.randevuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem,
            this.dışarıAktarToolStripMenuItem});
            this.dosyaİşlemleriToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Dosya_İslemleri;
            this.dosyaİşlemleriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dosyaİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            this.dosyaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(122, 72);
            this.dosyaİşlemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            this.dosyaİşlemleriToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dosyaİşlemleriToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.İçeri_Aktar;
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            this.içeriAktarToolStripMenuItem.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem_Click);
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.Image = global::HastaneOtomasyonu2.Properties.Resources.Dışarı_Aktar;
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            this.dışarıAktarToolStripMenuItem.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 705);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
    }
}

