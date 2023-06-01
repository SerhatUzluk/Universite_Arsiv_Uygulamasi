using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DAL;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.SERVİCE
{
    internal class EvrakService
    {
        internal void evrakKaydet(string gDocumentType ,string gDocumentDescription,string gCreationTime,int gDepoId,string gLocation)
        {
            (new EvrakDAO()).evrakOlustur(new Evrak(gDocumentType,gDocumentDescription,gCreationTime,gDepoId,gLocation));
        }
    }
}
