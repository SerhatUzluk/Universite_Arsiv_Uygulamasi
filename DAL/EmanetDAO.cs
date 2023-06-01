using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.DAL
{
    internal class EmanetDAO
    {
        public void emanetKaydiOlustur(Emanet gEmanet)
        {
            (new MySqlCommand("insert into Emanet (userId,emanetId,eCreationTime,eClosedTime,eDescription,evrakId,emanetAlanName,emanetAlanSurname,contactNumber,emanetAlindi) values (" + gEmanet.KullaniciId + "," + gEmanet.EmanetId + ",'" + gEmanet.ECreationTime + "','" + gEmanet.EClosedTime + "','" + gEmanet.EDescription + "'," + gEmanet.EvrakId + ",'" + gEmanet.EmanetAlanName + "','" + gEmanet.EmanetAlanSurname + "','" + gEmanet.ContactNumber + "' , " + gEmanet.emanetAlindi + ")", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }//            (new MySqlCommand("insert into Evrak (documentType,documentDescription,creationTime,depoId,location) values ('" + gEvrak.DocumentType + "','" + gEvrak.DocumentDescription + "','" + gEvrak.CreationTime + "'," + gEvrak.DepoId + ",'" + gEvrak.Location + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();

        public void emanetTeslimAlındı(int gEvrakId)
        {
            (new MySqlCommand("UPDATE Emanet SET emanetAlindi='1' where emanetAlindi='0' AND evrakId="+gEvrakId+"", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
        internal System.Collections.ArrayList emanetleriListele()
        {
            ArrayList emanetVerilenEvraklar = new ArrayList();
            MySqlDataReader emanet = (new MySqlCommand("select * from Emanet", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (emanet.Read())
            {
                emanetVerilenEvraklar.Add(new Emanet(Convert.ToInt32(emanet[0]), Convert.ToInt32(emanet[1]), emanet[2].ToString(), emanet[3].ToString(), emanet[4].ToString(), Convert.ToInt32(emanet[5]), emanet[6].ToString(), emanet[7].ToString(), emanet[8].ToString(), Convert.ToBoolean(emanet[9])));
            }
            return emanetVerilenEvraklar;

        }
        internal MySqlDataReader getReaderEmanet()
        {
            MySqlDataReader emanet = (new MySqlCommand("select * from Emanet", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            return emanet;
        }

    }
}
