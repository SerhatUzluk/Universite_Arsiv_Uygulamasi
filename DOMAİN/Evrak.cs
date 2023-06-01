using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite_Arsiv_Uygulamasi.DOMAİN
{
    internal class Evrak
    {
        int evrakId;
        string documentType;
        string documentDescription;
        string creationTime;
        int depoId;
        string location;

        public Evrak(int gEvrakId,string gDocumentType,string gDocumentDescription, string gCreationTime, int gDepoId, string gLocation)
        {
            this.evrakId = gEvrakId;
            this.documentType = gDocumentType;
            this.documentDescription = gDocumentDescription;
            this.creationTime = gCreationTime;
            this.depoId = gDepoId;
            this.location = gLocation;
        }

        public Evrak(string gDocumentType, string gDocumentDescription, string gCreationTime, int gDepoId, string gLocation)
        {
            this.documentType = gDocumentType;
            this.documentDescription = gDocumentDescription;
            this.creationTime = gCreationTime;
            this.depoId = gDepoId;
            this.location = gLocation;
        }

        public int EvrakId { get => evrakId; set => evrakId = value; }
        public string DocumentType { get => documentType; set => documentType = value; }
        public string DocumentDescription { get => documentDescription; set => documentDescription = value; }
        public string CreationTime { get => creationTime; set => creationTime = value; }
        public int DepoId { get => depoId; set => depoId = value; }
        public string Location { get => location; set => location = value; }
    }
}
