using HastaneOtomasyonu2.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu2
{
    public partial class DoktorDuzenlemeFormu : DuzenleBaseForm
    {
        public DoktorDuzenlemeFormu()
        {
            InitializeComponent();
        }
        public List<Doktor> Doktorlar { get; set; }
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        Doktor seciliDoktor;

        private void DoktorDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBranslar.Items.AddRange(Enum.GetNames(typeof(DoktorBransı)));
            ListeyiDoldur();
        }

        #region Kaydet, Sil ve Güncelle İşlemleri

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                lstKisi.Items.Clear();
                Doktor yeniDoktorlar = new Doktor()
                {
                    Ad = txtAd.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Soyad = txtSoyad.Text,
                    DoktorBransı = (DoktorBransı)Enum.Parse(typeof(DoktorBransı), cmbBranslar.SelectedItem.ToString()),
                    Maas = numMaas.Value
                };

                //Atanmamış hemşireler listesindeki seçili her hemşireyi foreach ile dön. 
                //Doktorun hemşiresi listesine ekle ve hemşirenin atanmışMI özelliğini true yap.

                foreach (Hemsire item in lstAtanabilir.SelectedItems)
                {
                    yeniDoktorlar.hemsiresi.Add(item);
                    item.atanmısMı = true;
                }


                Doktorlar.Add(yeniDoktorlar);
                ListeyiDoldur();
                FormuTemizle();
                lstAtanabilir.Items.Clear();
                lstAtanmıs.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // todo: ListeyiDoldur();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliDoktor == null)
            {
                MessageBox.Show("Neyi güncelleyeyim?");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliDoktor.Ad} adlı kişiyi güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    lstKisi.Items.Clear();
                    seciliDoktor = Doktorlar.Where(item => item.TCKN == seciliDoktor.TCKN).FirstOrDefault();
                    seciliDoktor.Ad = txtAd.Text;
                    seciliDoktor.Soyad = txtSoyad.Text;
                    seciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
                    seciliDoktor.Maas = numMaas.Value;
                    seciliDoktor.Cinsiyet =
                        (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());

                    // Hoca burada branşlar güncellenmesin istiyor.
                    
                    //seciliDoktor.DoktorBransı =
                    //    (DoktorBransı)Enum.Parse(typeof(DoktorBransı), cmbBranslar.SelectedItem.ToString());


                    //Güncelleme yapıldığında boştaki seçili Hemşireleri o doktora atamasını yapar.
                    foreach (Hemsire item in lstAtanabilir.SelectedItems)
                    {
                        seciliDoktor.hemsiresi.Add(item);
                        item.atanmısMı = true;
                    }

                   //O doktora atanmış hemşirelerin seçilerek silinmesini sağlar.
                    foreach (Hemsire item in lstAtanmıs.SelectedItems)
                    {
                        seciliDoktor.hemsiresi.Remove(item);
                        item.atanmısMı = false;
                    }

                    FormuTemizle();
                    ListeyiDoldur();
                    lstAtanabilir.Items.Clear();
                    lstAtanmıs.Items.Clear();
                    seciliDoktor = null;
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
            seciliDoktor = lstKisi.SelectedItem as Doktor;

            DialogResult cevap = MessageBox.Show($"{seciliDoktor.Ad} adlı kişiyi silmek istiyor musunuz?", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                foreach (Hemsire item in lstAtanmıs.SelectedItems)
                {
                    //seciliDoktor.hemsiresi.Remove(item);
                    item.atanmısMı = false;
                }
                Doktorlar.Remove(seciliDoktor);
                lstKisi.Items.Clear();
                FormuTemizle();
                lstAtanabilir.Items.Clear();
                lstAtanmıs.Items.Clear();
                ListeyiDoldur();
                seciliDoktor = null;
                MessageBox.Show("Doktor silindi");
            }
        }

        #endregion

        #region Arama ve Seçme İşlemleri
        
        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1) return;
            seciliDoktor = lstKisi.SelectedItem as Doktor;
            txtAd.Text = seciliDoktor.Ad;
            txtSoyad.Text = seciliDoktor.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliDoktor.Cinsiyet;
            dtpDogumTarihi.Value = seciliDoktor.DogumTarihi;
            cmbBranslar.SelectedIndex = (int)seciliDoktor.DoktorBransı;
            numMaas.Value = seciliDoktor.Maas;
            lstAtanmıs.Items.Clear();
            foreach (Hemsire item in seciliDoktor.hemsiresi)
            {
                if (item.atanmısMı == true)
                {
                    lstAtanmıs.Items.Add(item);
                }
                
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Doktor> aramasonucu = Doktor.Ara(Doktorlar, txtArama.Text);
            ListeyiDoldur(aramasonucu);
        }
        #endregion

        #region Hemşirelere Doktor Atama ve Silme
        
        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAtanabilir.Items.Clear();
            lstAtanmıs.Items.Clear();
            lstAtanabilir.Items.AddRange((HemsireGetir.hemsireSecimi((Hemsireler.Where(x => x.atanmısMı == false).ToList()), Convert.ToString(cmbBranslar.SelectedItem))).ToArray());

            //lstAtanmıs.Items.AddRange((HemsireGetir.hemsireSecimi((Hemsireler.Where(x => x.atanmısMı == true).ToList()), Convert.ToString(cmbBranslar.SelectedItem))).ToArray());
        }
        #endregion

        #region Listeyi Doldur ve Formu Temizle Metodları
        void ListeyiDoldur()
        {
            foreach (Doktor item in Doktorlar)
            {
                lstKisi.Items.Add(item);
            }
        }

        void ListeyiDoldur(List<Doktor> aramasonucu)
        {
            lstKisi.Items.Clear();
            foreach (Doktor item in aramasonucu)
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

        #region AdSoyad Küçük Yazma
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
