using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using HastaneOtomasyonu2.Lib;

namespace HastaneOtomasyonu2
{
    public partial class HastaDuzenlemeFormu : DuzenleBaseForm
    {
        public HastaDuzenlemeFormu()
        {
            InitializeComponent();
        }
        public List<Hasta> Hastalar { get; set; }
        private void HastaDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            ListeyiDoldur();
        }

        #region Kaydet, Güncelle ve Sil İşlemleri
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                lstKisi.Items.Clear();
                Hasta yeniHasta = new Hasta()
                {
                    Ad = txtAd.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Soyad = txtSoyad.Text,
                    
                };
                Hastalar.Add(yeniHasta);
                ListeyiDoldur();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ListeyiDoldur();
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (seciliHasta == null)
            {
                MessageBox.Show("Neyi güncelleyeyim?");

                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliHasta.Ad} adlı kişiyi güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    lstKisi.Items.Clear();
                    seciliHasta = Hastalar.Where(item => item.TCKN == seciliHasta.TCKN).FirstOrDefault();
                    seciliHasta.Ad = txtAd.Text;
                    seciliHasta.Soyad = txtSoyad.Text;
                    seciliHasta.DogumTarihi = dtpDogumTarihi.Value;
                    ListeyiDoldur();
                    FormuTemizle();
                    seciliHasta = null;
                    MessageBox.Show("Güncelleme Başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem == null)
            {
                MessageBox.Show("Neyi sileyim?");
                return;
            }
            seciliHasta = lstKisi.SelectedItem as Hasta;

            DialogResult cevap = MessageBox.Show($"{seciliHasta.Ad} adlı kişiyi silmek istiyor musunuz?", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Hastalar.Remove(seciliHasta);
                lstKisi.Items.Clear();
                ListeyiDoldur();
                FormuTemizle();
                seciliHasta = null;
                MessageBox.Show("Kişi silindi");
            }
        }
        #endregion

        #region Arama ve Seçme İşlemleri
        Hasta seciliHasta;
        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1) return;
            seciliHasta = lstKisi.SelectedItem as Hasta;
            txtAd.Text = seciliHasta.Ad;
            txtSoyad.Text = seciliHasta.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliHasta.Cinsiyet;
            dtpDogumTarihi.Value = seciliHasta.DogumTarihi;
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hasta> aramasonucu = Hasta.Ara(Hastalar, txtArama.Text);
            ListeyiDoldur(aramasonucu);
        }
        #endregion

        #region ListeyiDoldur ve Formu Temizle Metodları
        void ListeyiDoldur()
        {
            foreach (Hasta item in Hastalar)
            {
                lstKisi.Items.Add(item);
            }
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
        }
        #endregion

        #region AdSoyad küçük harfe çevirme
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
