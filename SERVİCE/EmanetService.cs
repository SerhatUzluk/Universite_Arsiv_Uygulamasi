using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DAL;
using Universite_Arsiv_Uygulamasi.DOMAİN;

namespace Universite_Arsiv_Uygulamasi.SERVİCE
{
    internal class EmanetService
    {
        internal System.Collections.ArrayList emanetleriOku()
        {
            return (new EmanetDAO()).emanetleriListele();
        }

        internal void emanetKaydiOlustur(int gKullaniciId,int gEmanetId, string gECreationTime, string gEClosedTime, string gEDescription, int gEvrakId, string gEmanetAlanName, string gEmanetAlanSurname, string gContactNumber, bool gEmanetAlindi)
        {
            (new EmanetDAO()).emanetKaydiOlustur(new Emanet(gKullaniciId, gEmanetId, gECreationTime, gEClosedTime, gEDescription, gEvrakId, gEmanetAlanName, gEmanetAlanSurname, gContactNumber, gEmanetAlindi = false));

        }
    }
}
