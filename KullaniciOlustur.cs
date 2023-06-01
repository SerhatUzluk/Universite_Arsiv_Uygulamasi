using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universite_Arsiv_Uygulamasi.DAL;
using Universite_Arsiv_Uygulamasi.DOMAİN;
using Universite_Arsiv_Uygulamasi.SERVİCE;
using static System.Net.Mime.MediaTypeNames;

namespace Universite_Arsiv_Uygulamasi
{
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void kullaniciOlusturBtn_Click(object sender, EventArgs e)
        {
            KullaniciService kullaniciService = new KullaniciService();
            kullaniciService.kullaniciOlustur(gUserName: kullaniciAdiTextBox.Text, gPassword: sifreTextBox.Text, gUserType: kullaniciTurTextBox.Text);

        }

        private void KullaniciOlustur_Load(object sender, EventArgs e)
        {

        }

        private void kullaniciOlusturBtn_Click_1(object sender, EventArgs e)
        {
            /* KullaniciService kullaniciService = new KullaniciService();
             kullaniciService.kullaniciOlustur(gUserName: kullaniciAdiTextBox.Text, gPassword: sifreTextBox.Text, gUserType: kullaniciTurTextBox.Text);*/
            (new KullaniciService()).kullaniciOlustur(kullaniciAdiTextBox.Text, sifreTextBox.Text, kullaniciTurTextBox.Text);
            MessageBox.Show("Kullanıcı Oluşturuldu.");
        }

        private void KullaniciOlustur_Load_1(object sender, EventArgs e)
        {

        }

        private void kullaniciOlusturText_Click(object sender, EventArgs e)
        {

        }
    }
}
