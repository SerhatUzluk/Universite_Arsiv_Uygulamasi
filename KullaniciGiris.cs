using MySql.Data.MySqlClient;
using System.Drawing;
using Universite_Arsiv_Uygulamasi.DAL;

namespace Universite_Arsiv_Uygulamasi
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            string user = kullaniciAdiTextBox.Text;
            string pass = sifreTextBox.Text;

            bool isUserValid = new KullaniciDAO().kullaniciKontrol(user, pass);
            bool isUserAdmin = new KullaniciDAO().adminKontrol(user, pass);


            if (kullaniciAdiTextBox.Text == "" || sifreTextBox.Text == "")
            {
                MessageBox.Show("Lütfen belirtilen alanları boş bırakmayınız.");
            }
            else
            {
                if (isUserAdmin == true)
                {
                    MessageBox.Show("Yönetici Girişi Başarılı Hoşgeldiniz.");
                    YoneticiAnaSayfa yoneticiAnasayfa = new YoneticiAnaSayfa();
                    this.Hide();
                    yoneticiAnasayfa.ShowDialog();
                    this.Show();
                    kullaniciAdiTextBox.Clear();
                    sifreTextBox.Clear();
                    
                }
                else
                {
                    if (isUserValid == true)
                    {
                        MessageBox.Show("Kullanıcı Girişi Başarılı Hoşgeldiniz.");
                        AnaSayfa anaSayfa = new AnaSayfa();
                        this.Hide();
                        anaSayfa.ShowDialog();
                        this.Show();
                        kullaniciAdiTextBox.Clear();
                        sifreTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                    }
                }
            }

        }
    }
}
