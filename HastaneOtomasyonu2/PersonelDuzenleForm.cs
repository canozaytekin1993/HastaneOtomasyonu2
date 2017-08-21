using HastaneOtomasyonu2.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu2
{
    public partial class PersonelDuzenleForm : DuzenleBaseForm
    {
        public PersonelDuzenleForm()
        {
            InitializeComponent();
        }
        public List<Personel> Personeller { get; set; }

        private void PersonelDuzenleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbGorev.Items.AddRange(Enum.GetNames(typeof(Gorevler)));
            ListeyiDoldur();
        }

        #region Kaydet,Güncelle ve Silme İşlemleri
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                lstKisi.Items.Clear();
                Personel yeniPersonel = new Personel()
                {
                    Ad = txtAd.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Soyad = txtSoyad.Text,
                    Maas = numMaas.Value,
                    Gorev = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGorev.SelectedItem.ToString()),
                };
                Personeller.Add(yeniPersonel);
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
            seciliPersonel = lstKisi.SelectedItem as Personel;

            DialogResult cevap = MessageBox.Show($"{seciliPersonel.Ad} adlı kişiyi silmek istiyor musunuz?", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Personeller.Remove(seciliPersonel);
                lstKisi.Items.Clear();
                ListeyiDoldur();
                FormuTemizle();
                seciliPersonel = null;
                MessageBox.Show("Kişi silindi");
            }
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (seciliPersonel == null)
            {
                MessageBox.Show("Neyi güncelleyeyim?");

                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliPersonel.Ad} adlı kişiyi güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    lstKisi.Items.Clear();
                    seciliPersonel = Personeller.Where(item => item.TCKN == seciliPersonel.TCKN).FirstOrDefault();
                    seciliPersonel.Ad = txtAd.Text;
                    seciliPersonel.Soyad = txtSoyad.Text;
                    seciliPersonel.DogumTarihi = dtpDogumTarihi.Value;
                    seciliPersonel.Maas = numMaas.Value;
                    seciliPersonel.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    seciliPersonel.Gorev = (Gorevler) Enum.Parse(typeof(Gorevler), cmbGorev.SelectedItem.ToString());
                    ListeyiDoldur();
                    FormuTemizle();
                    seciliPersonel = null;
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
        Personel seciliPersonel;
        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1) return;
            seciliPersonel = lstKisi.SelectedItem as Personel;
            txtAd.Text = seciliPersonel.Ad;
            txtSoyad.Text = seciliPersonel.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliPersonel.Cinsiyet;
            dtpDogumTarihi.Value = seciliPersonel.DogumTarihi;
            cmbGorev.SelectedIndex = (int)seciliPersonel.Gorev;
            numMaas.Value = seciliPersonel.Maas;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

            List<Personel> aramasonucu = Personel.Ara(Personeller, txtArama.Text);
            ListeyiDoldur(aramasonucu);
        }
        #endregion

        #region Liste Doldur ve Form Temizle Metodlar
        void ListeyiDoldur()
        {
            foreach (Personel item in Personeller)
            {
                lstKisi.Items.Add(item);
            }
        }
        void ListeyiDoldur(List<Personel> aramasonucu)
        {
            lstKisi.Items.Clear();
            foreach (Personel item in aramasonucu)
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

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.CharacterCasing = CharacterCasing.Lower;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            txtSoyad.CharacterCasing = CharacterCasing.Lower;
        }
    }
}
