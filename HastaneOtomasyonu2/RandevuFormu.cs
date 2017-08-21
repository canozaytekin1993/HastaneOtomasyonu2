using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu2.Lib;

namespace HastaneOtomasyonu2
{
    public partial class RandevuFormu : Form
    {
        public RandevuFormu()
        {
            InitializeComponent();    
        }
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();

        public Randevu randevu = new Randevu();

        #region ListeyiDoldur, Formu Temizle, DoktorlarDoldur ve Arama

        void renklendir()
        {
            foreach (var item in grbSaatler.Controls)
            {
                if (item is Button)
                {
                    if (randevu.Hasta.Saat == null || randevu.Doktor.Saat == null)
                        return;
                    if (randevu.Hasta.Saat.Contains((item as Button).Text) || randevu.Doktor.Saat.Contains((item as Button).Text))
                    {
                        (item as Button).BackColor = Color.Gray;
                        (item as Button).Enabled = false;
                    }
                    else
                    {
                        (item as Button).BackColor = Color.GreenYellow;
                        (item as Button).Enabled = true;
                    }
                }
            }
        }

        void ListeyiDoldur()
        {
            foreach (Hasta item in Hastalar)
            {
                lstKisi.Items.Add(item);
            }
        }

        //void DoktorlarDoldur()
        //{
        //    foreach (Doktor item in Doktorlar)
        //    {
        //        cmbDoktorlar.Items.Add(item);
        //    }
        //}

        void gizle()
        {
            grbSaatler.Visible = false;
            grbBolumSecimi.Visible = false;
            btnRandevuAl.Visible = false;
        }

        void ListeyiDoldur(List<Hasta> aramasonucu)
        {
            lstKisi.Items.Clear();
            foreach (Hasta item in aramasonucu)
            {
                lstKisi.Items.Add(item);
            }
        }

        void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                
            }
            foreach (var item in grbSaatler.Controls)
            {
                if (item is Button)
                {
                    (item as Button).BackColor = Color.GreenYellow;
                    (item as Button).Enabled = true;
                }
            }
        }

        #endregion

        #region Visible false ve true özelliği kullanıldığı alan

        private void RandevuFormu_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
            cmbBranslar.Items.AddRange(Enum.GetNames(typeof(DoktorBransı)));
            foreach (var item in grbSaatler.Controls)
            {
                if (item is Button)
                {
                    (item as Button).BackColor = Color.GreenYellow;
                    (item as Button).Enabled = false;
                }
            }
            grbBolumSecimi.Visible = false;
            cmbBranslar.Visible = false;
            cmbDoktorlar.Visible = false;
            grbSaatler.Visible = false;
            btnRandevuAl.Visible = false;
        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listedeki bir kişi seçildiğini kesinleştirmiş oluyoruz.
            if(lstKisi.SelectedIndex == -1) return;

            randevu.Hasta = lstKisi.SelectedItem as Hasta;
            grbBolumSecimi.Visible = true;
            label2.Visible = true;
            cmbBranslar.Visible = true;
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            label3.Visible = true;
            cmbDoktorlar.Visible = true;
            
            cmbDoktorlar.Items.AddRange((DoktorlarıGetir.DoktorSecimi(Doktorlar, Convert.ToString(cmbBranslar.SelectedItem)).ToArray()));
        }

        // ARAMA İŞLEMİ İÇİN KULLANILAN TEXT
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Hasta> aramasonucu = Hasta.Ara(Hastalar, txtArama.Text);
            ListeyiDoldur(aramasonucu);
        }

        private Doktor secilidoktor;
        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedIndex == -1) return;
            secilidoktor = cmbDoktorlar.SelectedItem as Doktor;

            grbSaatler.Visible = true;
            randevu.Doktor = cmbDoktorlar.SelectedItem as Doktor;
            renklendir();
        }
        #endregion

        private string saat;
        private void button27_Click(object sender, EventArgs e)
        {
            Button tiklama = sender as Button;
            saat = tiklama.Text;

            renklendir();
            tiklama.BackColor = Color.Red;
            btnRandevuAl.Visible = true;
        }

        private bool randevuAlindiMi = false;
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            randevu.Doktor.Saat += saat;
            randevu.Hasta.Saat += saat;

            randevuAlindiMi = true;
            cmbDoktorlar.SelectedIndex = -1;
            cmbBranslar.SelectedIndex = -1;
            lstKisi.SelectedIndex = -1;
            randevuAlindiMi = false;
            FormuTemizle();
            gizle();
            MessageBox.Show($"{randevu.Hasta.Ad} {randevu.Hasta.Soyad} isimli kişi {randevu.Hasta.Saat} saatine {randevu.Doktor.Ad} {randevu.Doktor.Soyad} adlı doktordan randevusu onaylanmıştır.");           
        }
    }
}
