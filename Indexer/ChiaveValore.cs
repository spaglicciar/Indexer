using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class ChiaveValore
    {
        public string Chiave { get; set; }
        public string Valore { get; set; }

        public override string ToString()
        {
            return string.Format("Chiave: {0}, Valore: {1}", Chiave, Valore);
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            ChiaveValore temp = obj as ChiaveValore; //no errore ma se non riesce, -> temp = null

            if (temp != null)
            {
                result = temp.Chiave == this.Chiave && temp.Valore == this.Valore;
            }
            
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
