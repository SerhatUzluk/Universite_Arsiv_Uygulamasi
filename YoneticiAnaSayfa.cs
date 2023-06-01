using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universite_Arsiv_Uygulamasi
{
    public partial class YoneticiAnaSayfa : Form
    {
        public YoneticiAnaSayfa()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
        private void evrakOlusturLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvrakKayit evrakKayit = new EvrakKayit();
            evrakKayit.Show();
        }


        private void emanetKayitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmanetKayit emanetKayit = new EmanetKayit();
            emanetKayit.Show();
        }

        private void kullaniciOlusturLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.Show();
        }

        private void emanetListesiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmanetListesi emanetListesi = new EmanetListesi();
            emanetListesi.Show();
        }

        private void evrakListesiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvrakListesi evrakListesi = new EvrakListesi();
            evrakListesi.Show();
        }
        private void YoneticiAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvrakKayit evrakKayit = new EvrakKayit();
            evrakKayit.Show();
        }

        private void evrakListesiLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvrakListesi evrakListesi = new EvrakListesi();
            evrakListesi.Show();
        }

        private void emanetKayitLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmanetKayit emanetKayit = new EmanetKayit();
            emanetKayit.Show();
        }

        private void emanetListesiLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmanetListesi emanetListesi = new EmanetListesi();
            emanetListesi.Show();
        }

        private void kullaniciOlusturLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciOlustur kullaniciOlustur = new KullaniciOlustur();
            kullaniciOlustur.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
