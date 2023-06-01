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
using Universite_Arsiv_Uygulamasi.SERVİCE;

namespace Universite_Arsiv_Uygulamasi
{
    public partial class EvrakKayit : Form
    {
        public EvrakKayit()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void evrakKayitButon_Click_1(object sender, EventArgs e)
        {
            if (evrakTanim.Text != "" && evrakTuru.Text != "" && depoIdText.Text != "" && arsivKonumText.Text != "")
            {
                (new EvrakService()).evrakKaydet(evrakTuru.Text, evrakTanim.Text, tarihBilgiEK.Value.ToString(), Convert.ToInt32(depoIdText.Text), arsivKonumText.Text);
                evrakTuru.Clear();
                evrakTanim.Clear();
                tarihBilgiEK.Refresh();
                depoIdText.Clear();
                arsivKonumText.Clear();
                MessageBox.Show("Evrak Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Lütfen belirtilen alanları doldurunuz");
            }
        }
    }
}
