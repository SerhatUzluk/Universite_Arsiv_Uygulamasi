using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DAL;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.SERVİCE
{
    internal class DepolamaAlaniService
    {
        internal void depolamaAlaniKaydet(int gDepoId, string gTag, string gLocation, int gStorageCapacity)
        {
            (new DepolamaAlaniDAO()).depolamaAlaniOlustur(new DepolamaAlani(gDepoId, gTag, gLocation, gStorageCapacity));
        }
    }
}
