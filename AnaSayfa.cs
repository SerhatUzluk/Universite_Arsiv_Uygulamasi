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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }


        private void AnaSayfa_Load(object sender, EventArgs e)
        {

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

        private void evrakOlusturLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvrakKayit evrakKayit = new EvrakKayit();
            evrakKayit.Show();
        }

        private void evrakListesiLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EvrakListesi evrakListesi = new EvrakListesi();
            evrakListesi.Show();
        }
    }
}
