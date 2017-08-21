using HastaneOtomasyonu2.Lib;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HastaneOtomasyonu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context context = new Context();

        #region Form LOAD VE Closed veri çekmesi olayları
        private void Form1_Load(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir Kisi XML dosyasını seçiniz";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = @"C:\Users\CAN\Desktop";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Context));
            TextReader reader = new StreamReader(@"C:\Users\CAN\Desktop\veriler.xml");
            context = (Context)xmlSerializer.Deserialize(reader) as Context;
            reader.Close();
            reader.Dispose();
            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            dosyaKaydet.Filter = "XML Format | *.xml";
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = @"C:\Users\CAN\Desktop";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Context));
            TextWriter writer = new StreamWriter(@"C:\Users\CAN\Desktop\veriler.xml");
            xmlSerializer.Serialize(writer, context);
            writer.Close();
            writer.Dispose();
        }

        #endregion

        #region Dosya İşlemleri

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Filter = "XML Format | *.xml";
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Context));
                TextWriter writer = new StreamWriter(dosyaKaydet.FileName);
                xmlSerializer.Serialize(writer, context);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("Veriler Dışarıya aktarıldı");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir Kisi XML dosyasını seçiniz";
            dosyaAc.Filter = "XML Format | *.xml";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Context));
                TextReader reader = new StreamReader(dosyaKaydet.FileName);
                context = (Context) xmlSerializer.Deserialize(reader) as Context;
                reader.Close();
                reader.Dispose();
                MessageBox.Show($"Kayıtlar eklendi.");
            }
        }
        
        #endregion

        PersonelDuzenleForm personelDuzenleForm;
        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personelDuzenleForm == null || personelDuzenleForm.IsDisposed)
            {
                personelDuzenleForm = new PersonelDuzenleForm();
                personelDuzenleForm.MdiParent = this;
                personelDuzenleForm.Personeller = context.Personeller;
                personelDuzenleForm.Show();
            }
        }

        DoktorDuzenlemeFormu doktorDuzenlemeFormu;
        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doktorDuzenlemeFormu == null || doktorDuzenlemeFormu.IsDisposed)
            {
                doktorDuzenlemeFormu = new DoktorDuzenlemeFormu();
                doktorDuzenlemeFormu.MdiParent = this;
                doktorDuzenlemeFormu.Doktorlar = context.Doktorlar;
                doktorDuzenlemeFormu.Hemsireler = context.Hemsireler;
                doktorDuzenlemeFormu.Show();
            }
        }

        HemsireDuzenlemeFormu hemsireDuzenlemeFormu;
        private void hemşireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hemsireDuzenlemeFormu == null || hemsireDuzenlemeFormu.IsDisposed)
            {
                hemsireDuzenlemeFormu = new HemsireDuzenlemeFormu();
                hemsireDuzenlemeFormu.MdiParent = this;
                hemsireDuzenlemeFormu.Hemsireler = context.Hemsireler;
                hemsireDuzenlemeFormu.Show();
            }
        }
        HastaDuzenlemeFormu hastaDuzenlemeFormu;
        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hastaDuzenlemeFormu == null || hastaDuzenlemeFormu.IsDisposed)
            {
                hastaDuzenlemeFormu = new HastaDuzenlemeFormu();
                hastaDuzenlemeFormu.MdiParent = this;
                hastaDuzenlemeFormu.Hastalar = context.Hastalar;
                hastaDuzenlemeFormu.Show();
            }
        }

        RandevuFormu randevuFormu;
        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randevuFormu == null || randevuFormu.IsDisposed)
            {
                randevuFormu = new RandevuFormu();
                randevuFormu.MdiParent = this;
                randevuFormu.Hastalar = context.Hastalar;
                randevuFormu.Doktorlar = context.Doktorlar;
                randevuFormu.Randevular = context.Randevular;
                randevuFormu.Show();
            }
        }

    }
}
