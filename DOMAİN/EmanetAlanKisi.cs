using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite_Arsiv_Uygulamasi.DOMAİN
{
    internal class EmanetAlanKisi
    {
        int kisi_id;
        string name;
        string surname;
        string contactNumber;


        public EmanetAlanKisi(string gEmanetAlanAd,string gEmanetAlanSoyad, string gContactNumber)
        { 
            this.name = gEmanetAlanAd;
            this.surname = gEmanetAlanSoyad;
            this.contactNumber = gContactNumber;
        }

        public int EmanetAlanId { get => kisi_id; set => kisi_id = value; }
        public string EmanetAlanAd { get => name; set => name = value; }
        public string EmanetAlanSoyad { get => surname; set => surname = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
    }
}
