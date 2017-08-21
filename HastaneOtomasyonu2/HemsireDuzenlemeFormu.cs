using HastaneOtomasyonu2.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu2
{
    public partial class HemsireDuzenlemeFormu : DuzenleBaseForm
    {
        public HemsireDuzenlemeFormu()
        {
            InitializeComponent();
        }
        public List<Hemsire> Hemsireler { get; set; }

        private void HemsireDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBranslar.Items.AddRange(Enum.GetNames(typeof(HemsireBransı)));
            ListeyiDoldur();
        }

        #region Listeyi Doldur ve Formu Temizle Metodları
        void ListeyiDoldur()
        {
            foreach (Hemsire item in Hemsireler)
            {
                lstKisi.Items.Add(item);
            }
        }
        void ListeyiDoldur(List<Hemsire> aramasonucu)
        {
            lstKisi.Items.Clear();
            foreach (Hemsire item in aramasonucu)
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
        } 
        #endregion

        #region Kaydet, Güncelle ve Sil İşlemleri

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                lstKisi.Items.Clear();
                Hemsire yeniHemsire = new Hemsire()
                {
                    Ad = txtAd.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Soyad = txtSoyad.Text,
                    HemsireBransı = (HemsireBransı)Enum.Parse(typeof(HemsireBransı), cmbBranslar.SelectedItem.ToString()),
                    Maas = numMaas.Value
                };
                Hemsireler.Add(yeniHemsire);
                ListeyiDoldur();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ListeyiDoldur();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem == null)
            {
                MessageBox.Show("Neyi sileyim?");
                return;
            }
            seciliHemsire = lstKisi.SelectedItem as Hemsire;

            DialogResult cevap = MessageBox.Show($"{seciliHemsire.Ad} adlı kişiyi silmek istiyor musunuz?", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Hemsireler.Remove(seciliHemsire);
                seciliHemsire.atanmısMı = false;
                lstKisi.Items.Clear();
                ListeyiDoldur();
                FormuTemizle();
                seciliHemsire = null;
                MessageBox.Show("Kişi silindi");
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (seciliHemsire == null)
            {
                MessageBox.Show("Neyi güncelleyeyim?");

                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliHemsire.Ad} adlı kişiyi güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    lstKisi.Items.Clear();
                    seciliHemsire = Hemsireler.Where(item => item.TCKN == seciliHemsire.TCKN).FirstOrDefault();
                    seciliHemsire.Ad = txtAd.Text;
                    seciliHemsire.Soyad = txtSoyad.Text;
                    seciliHemsire.DogumTarihi = dtpDogumTarihi.Value;
                    seciliHemsire.Maas = numMaas.Value;

                    if (seciliHemsire.HemsireBransı.ToString() != cmbBranslar.SelectedItem.ToString())
                    {
                        seciliHemsire.atanmısMı = false;
                    }

                    seciliHemsire.HemsireBransı =
                        (HemsireBransı) Enum.Parse(typeof(DoktorBransı), cmbBranslar.SelectedItem.ToString());
                    seciliHemsire.Cinsiyet =
                        (Cinsiyetler) Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    

                    ListeyiDoldur();
                    FormuTemizle();
                    seciliHemsire = null;
                    MessageBox.Show("Güncelleme Başarılı");  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Arama ve Seçme İşlemleri
        Hemsire seciliHemsire;
        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1) return;
            seciliHemsire = lstKisi.SelectedItem as Hemsire;
            txtAd.Text = seciliHemsire.Ad;
            txtSoyad.Text = seciliHemsire.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliHemsire.Cinsiyet;
            dtpDogumTarihi.Value = seciliHemsire.DogumTarihi;
            cmbBranslar.SelectedIndex = (int)seciliHemsire.HemsireBransı;
            numMaas.Value = seciliHemsire.Maas;
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hemsire> aramasonucu = Hemsire.Ara(Hemsireler, txtArama.Text);
            ListeyiDoldur(aramasonucu);
        }

        #endregion

        #region AdSoyad Küçük harf
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.CharacterCasing = CharacterCasing.Lower;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            txtSoyad.CharacterCasing = CharacterCasing.Lower;
        } 
        #endregion
    }
}
