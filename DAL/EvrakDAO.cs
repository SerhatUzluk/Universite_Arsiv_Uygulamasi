using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.DAL
{
    internal class EvrakDAO
    {
        public void evrakOlustur(Evrak gEvrak)
        {
            (new MySqlCommand("insert into Evrak (documentType,documentDescription,creationTime,depoId,location) values ('" + gEvrak.DocumentType + "','" + gEvrak.DocumentDescription + "','" + gEvrak.CreationTime + "'," + gEvrak.DepoId + ",'" + gEvrak.Location + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();

        }
        internal MySqlDataReader getReader()
        {
            MySqlDataReader reader = (new MySqlCommand("select * from Evrak", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            return reader; 
        } 
    }
}

