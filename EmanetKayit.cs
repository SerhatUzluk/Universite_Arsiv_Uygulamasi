using MySql.Data.MySqlClient;
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

namespace Universite_Arsiv_Uygulamasi
{
    public partial class EmanetKayit : Form
    {
        public EmanetKayit()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void emanetKayitButon_Click_1(object sender, EventArgs e)
        {
            if (emanetPersonelId.Text != "" && emanetNo.Text != "" && emanetEvrakId.Text != "" && emanetAlanAd.Text != "" && emanetAlanSoyad.Text != "" && emanetAlanTel.Text != "")
            {
                (new EmanetService()).emanetKaydiOlustur(Convert.ToInt32(emanetPersonelId.Text), Convert.ToInt32(emanetNo.Text), emanetCreation.Value.ToString(), emanetClosed.Value.ToString(), emanetTanim.Text.ToString(), Convert.ToInt32(emanetEvrakId.Text), emanetAlanAd.Text.ToString(), emanetAlanSoyad.Text.ToString(), emanetAlanTel.Text.ToString(), false);
                (new EmanetAlanKisiService()).emanetAlanKaydet(emanetAlanAd.Text.ToString(), emanetAlanSoyad.Text.ToString(), emanetAlanTel.Text.ToString());
                emanetPersonelId.Clear();
                emanetNo.Clear();
                emanetCreation.Refresh();
                emanetClosed.Refresh();
                emanetEvrakId.Clear();
                emanetAlanAd.Clear();
                emanetAlanSoyad.Clear();
                emanetAlanTel.Clear();
                MessageBox.Show("Emanet Kaydı Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Lütfen belirtilen alanları doldurunuz");
            }
        }

        private void EmanetKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
