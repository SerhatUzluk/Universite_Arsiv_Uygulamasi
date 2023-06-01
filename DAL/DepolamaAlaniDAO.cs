
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.DAL
{
    internal class DepolamaAlaniDAO
    {
        public void depolamaAlaniOlustur(DepolamaAlani gDepo)
        {
            (new MySqlCommand("insert into DepolamaAlani (depoId,tag,location,storageCapacity) values (" + gDepo.DepoId + "," + gDepo.Tag + "," + gDepo.Location + ",'" + gDepo.StorageCapacity + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
