using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite_Arsiv_Uygulamasi.DOMAİN
{
    internal class Emanet
    {
        int kullaniciId;
        int emanetId;
        string eCreationTime;
        string eClosedTime;
        string eDescription;
        int evrakId;
        string emanetAlanName;
        string emanetAlanSurname;
        string contactNumber;
        public bool emanetAlindi = false;

        public Emanet(int gKullaniciId,int gEmanetId, string gECreationTime, string gEClosedTime, string gEDescription, int gEvrakId,string gEmanetAlanName,string gEmanetAlanSurname, string gContactNumber, bool gEmanetAlindi)
        {
            this.kullaniciId = gKullaniciId;
            this.emanetId = gEmanetId;
            this.eCreationTime = gECreationTime;
            this.eClosedTime = gEClosedTime;
            this.eDescription = gEDescription;
            this.evrakId = gEvrakId;
            this.emanetAlanName = gEmanetAlanName;
            this.emanetAlanSurname = gEmanetAlanSurname;
            this.contactNumber = gContactNumber;
            this.emanetAlindi = false;
               
        }

        public int EmanetId { get => emanetId; set => emanetId = value; }
        public string ECreationTime { get => eCreationTime; set => eCreationTime = value; }
        public string EClosedTime { get => eClosedTime; set => eClosedTime = value; }
        public string EDescription { get => eDescription; set => eDescription = value; }
        public int EvrakId { get => evrakId; set => evrakId = value; }
        public int KullaniciId { get => kullaniciId; set => kullaniciId = value; }
        public string EmanetAlanName { get => emanetAlanName; set => emanetAlanName = value; }
        public string EmanetAlanSurname { get => emanetAlanSurname; set => emanetAlanSurname = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public bool EmanetAlindi { get => emanetAlindi; set => emanetAlindi = value; }

        public override string ToString()
        {
            return this.emanetId + "-" + this.kullaniciId + "-" + this.evrakId + "-" + this.eDescription + "-" +
                this.eCreationTime + "-" + this.eClosedTime;
        }
    }
    
}
