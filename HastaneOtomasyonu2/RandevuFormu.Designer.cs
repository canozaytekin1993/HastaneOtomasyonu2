namespace HastaneOtomasyonu2
{
    partial class RandevuFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lstKisi = new System.Windows.Forms.ListBox();
            this.grbHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBranslar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.grbSaatler = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.btn915 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.grbBolumSecimi = new System.Windows.Forms.GroupBox();
            this.grbHastaBilgileri.SuspendLayout();
            this.grbSaatler.SuspendLayout();
            this.grbBolumSecimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(112, 35);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(215, 28);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstKisi.FormattingEnabled = true;
            this.lstKisi.ItemHeight = 21;
            this.lstKisi.Location = new System.Drawing.Point(23, 78);
            this.lstKisi.Margin = new System.Windows.Forms.Padding(4);
            this.lstKisi.Name = "lstKisi";
            this.lstKisi.Size = new System.Drawing.Size(304, 592);
            this.lstKisi.TabIndex = 2;
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // grbHastaBilgileri
            // 
            this.grbHastaBilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbHastaBilgileri.Controls.Add(this.lstKisi);
            this.grbHastaBilgileri.Controls.Add(this.label1);
            this.grbHastaBilgileri.Controls.Add(this.txtArama);
            this.grbHastaBilgileri.Location = new System.Drawing.Point(13, 16);
            this.grbHastaBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.grbHastaBilgileri.Name = "grbHastaBilgileri";
            this.grbHastaBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.grbHastaBilgileri.Size = new System.Drawing.Size(342, 680);
            this.grbHastaBilgileri.TabIndex = 10;
            this.grbHastaBilgileri.TabStop = false;
            this.grbHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doktor Seçiniz";
            // 
            // cmbBranslar
            // 
            this.cmbBranslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranslar.FormattingEnabled = true;
            this.cmbBranslar.Location = new System.Drawing.Point(153, 30);
            this.cmbBranslar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBranslar.Name = "cmbBranslar";
            this.cmbBranslar.Size = new System.Drawing.Size(174, 29);
            this.cmbBranslar.TabIndex = 6;
            this.cmbBranslar.SelectedIndexChanged += new System.EventHandler(this.cmbBranslar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Branş Seçiniz";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(153, 68);
            this.cmbDoktorlar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(174, 29);
            this.cmbDoktorlar.TabIndex = 8;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.Location = new System.Drawing.Point(66, 47);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 55);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9:00";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button27_Click);
            // 
            // grbSaatler
            // 
            this.grbSaatler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSaatler.Controls.Add(this.label4);
            this.grbSaatler.Controls.Add(this.btn9);
            this.grbSaatler.Controls.Add(this.button11);
            this.grbSaatler.Controls.Add(this.button27);
            this.grbSaatler.Controls.Add(this.button18);
            this.grbSaatler.Controls.Add(this.button12);
            this.grbSaatler.Controls.Add(this.button28);
            this.grbSaatler.Controls.Add(this.button17);
            this.grbSaatler.Controls.Add(this.button13);
            this.grbSaatler.Controls.Add(this.button29);
            this.grbSaatler.Controls.Add(this.button16);
            this.grbSaatler.Controls.Add(this.button14);
            this.grbSaatler.Controls.Add(this.button30);
            this.grbSaatler.Controls.Add(this.button15);
            this.grbSaatler.Controls.Add(this.button7);
            this.grbSaatler.Controls.Add(this.button23);
            this.grbSaatler.Controls.Add(this.button22);
            this.grbSaatler.Controls.Add(this.button8);
            this.grbSaatler.Controls.Add(this.button24);
            this.grbSaatler.Controls.Add(this.button21);
            this.grbSaatler.Controls.Add(this.btn915);
            this.grbSaatler.Controls.Add(this.button9);
            this.grbSaatler.Controls.Add(this.button25);
            this.grbSaatler.Controls.Add(this.button20);
            this.grbSaatler.Controls.Add(this.button5);
            this.grbSaatler.Controls.Add(this.button10);
            this.grbSaatler.Controls.Add(this.button26);
            this.grbSaatler.Controls.Add(this.button19);
            this.grbSaatler.Controls.Add(this.button6);
            this.grbSaatler.Location = new System.Drawing.Point(377, 146);
            this.grbSaatler.Margin = new System.Windows.Forms.Padding(4);
            this.grbSaatler.Name = "grbSaatler";
            this.grbSaatler.Padding = new System.Windows.Forms.Padding(4);
            this.grbSaatler.Size = new System.Drawing.Size(523, 550);
            this.grbSaatler.TabIndex = 12;
            this.grbSaatler.TabStop = false;
            this.grbSaatler.Text = "Saatler";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "12:00 - 13:00 arası randevu alınamaz";
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.Location = new System.Drawing.Point(399, 173);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 55);
            this.button11.TabIndex = 20;
            this.button11.Text = "11:45";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button27_Click);
            // 
            // button27
            // 
            this.button27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button27.Location = new System.Drawing.Point(399, 473);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(72, 55);
            this.button27.TabIndex = 36;
            this.button27.Text = "16:45";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.Location = new System.Drawing.Point(66, 284);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 55);
            this.button18.TabIndex = 21;
            this.button18.Text = "13:00";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button27_Click);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.Location = new System.Drawing.Point(288, 173);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 55);
            this.button12.TabIndex = 19;
            this.button12.Text = "11:30";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button28.Location = new System.Drawing.Point(288, 473);
            this.button28.Margin = new System.Windows.Forms.Padding(4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(72, 55);
            this.button28.TabIndex = 35;
            this.button28.Text = "16:30";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button27_Click);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button17.Location = new System.Drawing.Point(177, 284);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(72, 55);
            this.button17.TabIndex = 22;
            this.button17.Text = "13:15";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button27_Click);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.Location = new System.Drawing.Point(177, 173);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(72, 55);
            this.button13.TabIndex = 18;
            this.button13.Text = "11:15";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button27_Click);
            // 
            // button29
            // 
            this.button29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button29.Location = new System.Drawing.Point(177, 473);
            this.button29.Margin = new System.Windows.Forms.Padding(4);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(72, 55);
            this.button29.TabIndex = 34;
            this.button29.Text = "16:15";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button27_Click);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.Location = new System.Drawing.Point(288, 284);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 55);
            this.button16.TabIndex = 23;
            this.button16.Text = "13:30";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button27_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.Location = new System.Drawing.Point(66, 173);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 55);
            this.button14.TabIndex = 17;
            this.button14.Text = "11:00";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button27_Click);
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button30.Location = new System.Drawing.Point(66, 473);
            this.button30.Margin = new System.Windows.Forms.Padding(4);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(72, 55);
            this.button30.TabIndex = 33;
            this.button30.Text = "16:00";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button27_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.Location = new System.Drawing.Point(399, 284);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 55);
            this.button15.TabIndex = 24;
            this.button15.Text = "13:45";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button27_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(399, 110);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 55);
            this.button7.TabIndex = 16;
            this.button7.Text = "10:45";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button27_Click);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button23.Location = new System.Drawing.Point(399, 410);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(72, 55);
            this.button23.TabIndex = 32;
            this.button23.Text = "15:45";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button27_Click);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button22.Location = new System.Drawing.Point(66, 347);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 55);
            this.button22.TabIndex = 25;
            this.button22.Text = "14:00";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button27_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.Location = new System.Drawing.Point(288, 110);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 55);
            this.button8.TabIndex = 15;
            this.button8.Text = "10:30";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button27_Click);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button24.Location = new System.Drawing.Point(288, 410);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(72, 55);
            this.button24.TabIndex = 31;
            this.button24.Text = "15:30";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button27_Click);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button21.Location = new System.Drawing.Point(177, 347);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 55);
            this.button21.TabIndex = 26;
            this.button21.Text = "14:15";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button27_Click);
            // 
            // btn915
            // 
            this.btn915.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn915.Location = new System.Drawing.Point(177, 47);
            this.btn915.Margin = new System.Windows.Forms.Padding(4);
            this.btn915.Name = "btn915";
            this.btn915.Size = new System.Drawing.Size(72, 55);
            this.btn915.TabIndex = 10;
            this.btn915.Text = "9:15";
            this.btn915.UseVisualStyleBackColor = true;
            this.btn915.Click += new System.EventHandler(this.button27_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Location = new System.Drawing.Point(177, 110);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 55);
            this.button9.TabIndex = 14;
            this.button9.Text = "10:15";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button27_Click);
            // 
            // button25
            // 
            this.button25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button25.Location = new System.Drawing.Point(177, 410);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(72, 55);
            this.button25.TabIndex = 30;
            this.button25.Text = "15:15";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button27_Click);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.Location = new System.Drawing.Point(288, 347);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 55);
            this.button20.TabIndex = 27;
            this.button20.Text = "14:30";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button27_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(288, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 55);
            this.button5.TabIndex = 11;
            this.button5.Text = "9:30";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button27_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.Location = new System.Drawing.Point(66, 110);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 55);
            this.button10.TabIndex = 13;
            this.button10.Text = "10:00";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button26.Location = new System.Drawing.Point(66, 410);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(72, 55);
            this.button26.TabIndex = 29;
            this.button26.Text = "15:00";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button27_Click);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.Location = new System.Drawing.Point(399, 347);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(72, 55);
            this.button19.TabIndex = 28;
            this.button19.Text = "14:45";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button27_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(399, 47);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 55);
            this.button6.TabIndex = 12;
            this.button6.Text = "9:45";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button27_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandevuAl.Location = new System.Drawing.Point(727, 25);
            this.btnRandevuAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(173, 46);
            this.btnRandevuAl.TabIndex = 5;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // grbBolumSecimi
            // 
            this.grbBolumSecimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBolumSecimi.Controls.Add(this.cmbDoktorlar);
            this.grbBolumSecimi.Controls.Add(this.label2);
            this.grbBolumSecimi.Controls.Add(this.cmbBranslar);
            this.grbBolumSecimi.Controls.Add(this.label3);
            this.grbBolumSecimi.Location = new System.Drawing.Point(377, 16);
            this.grbBolumSecimi.Margin = new System.Windows.Forms.Padding(4);
            this.grbBolumSecimi.Name = "grbBolumSecimi";
            this.grbBolumSecimi.Padding = new System.Windows.Forms.Padding(4);
            this.grbBolumSecimi.Size = new System.Drawing.Size(342, 122);
            this.grbBolumSecimi.TabIndex = 11;
            this.grbBolumSecimi.TabStop = false;
            this.grbBolumSecimi.Text = "Bölüm Seçimi";
            // 
            // RandevuFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(921, 702);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.grbSaatler);
            this.Controls.Add(this.grbBolumSecimi);
            this.Controls.Add(this.grbHastaBilgileri);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RandevuFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu İşlemleri";
            this.Load += new System.EventHandler(this.RandevuFormu_Load);
            this.grbHastaBilgileri.ResumeLayout(false);
            this.grbHastaBilgileri.PerformLayout();
            this.grbSaatler.ResumeLayout(false);
            this.grbBolumSecimi.ResumeLayout(false);
            this.grbBolumSecimi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ListBox lstKisi;
        private System.Windows.Forms.GroupBox grbHastaBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBranslar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.GroupBox grbSaatler;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn915;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbBolumSecimi;
    }
}