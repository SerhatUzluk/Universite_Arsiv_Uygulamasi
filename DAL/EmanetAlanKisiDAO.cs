using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.DAL
{
    internal class EmanetAlanKisiDAO
    {
        public void emanetAlanKisiOlustur(EmanetAlanKisi gEmanetAlan)
        {
            (new MySqlCommand("insert into EmanetAlanKisi (name,surname,contactNumber) values ('" + gEmanetAlan.EmanetAlanAd + "','" + gEmanetAlan.EmanetAlanSoyad + "','" + gEmanetAlan.ContactNumber + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();

        }
    }
}
