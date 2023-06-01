using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite_Arsiv_Uygulamasi.DOMAİN
{
    internal class DepolamaAlani
    {
        int depoId;
        string tag;
        string location;
        int storageCapacity;

        public DepolamaAlani(int gDepoId, string gTag, string gLocation, int gStorageCapacity)
        {
            this.depoId = gDepoId;
            this.tag = gTag;
            this.location = gLocation;
            this.storageCapacity = gStorageCapacity;
        }

        public int DepoId { get => depoId; set => depoId = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Location { get => location; set => location = value; }
        public int StorageCapacity { get => storageCapacity; set => storageCapacity = value; }

        public static implicit operator DepolamaAlani(int v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator DepolamaAlani(string v)
        {
            throw new NotImplementedException();
        }
    }
}
