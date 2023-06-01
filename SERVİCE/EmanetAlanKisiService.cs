using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DAL;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.SERVİCE
{
    internal class EmanetAlanKisiService
    {
        internal void emanetAlanKaydet(string gEmanetAlanAd, string gEmanetAlanSoyad, string gContactNumber)
        {
            (new EmanetAlanKisiDAO()).emanetAlanKisiOlustur(new EmanetAlanKisi(gEmanetAlanAd,gEmanetAlanSoyad,gContactNumber));
        }
    }
    
}
