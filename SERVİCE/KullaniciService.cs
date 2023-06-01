using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DAL;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.SERVİCE
{
    internal class KullaniciService
    {
        internal void kullaniciOlustur(string gUserName, string gPassword,string gUserType)
        {
            (new KullaniciDAO()).kullaniciOlustur(new Kullanici(gUserName, gPassword, gUserType));
           //(new UrunDAO()).urunKaydet(new Urun(gUrunad, Convert.ToDouble(gUrunFiyat), Convert.ToInt32(gUrunAdet)));
        }
    }
}
