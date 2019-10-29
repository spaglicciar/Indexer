using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class CustomDictionary
    {
        private ChiaveValore[] collection = new ChiaveValore[10];
        public int Length
        {
            get
            {
                return collection.Length;
            }
        }

        public ChiaveValore this[int index]
        {
            get
            {
                return (index < 0 || index >= collection.Length)
                    ? null
                    : collection[index];
            }
            set
            {
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }

        public ChiaveValore this[string chiave]
        {
            get 
            {
                return GetChiaveValore(chiave);
            }
            set
            {
                SetChiaveValore(chiave, value.Valore);
            }
        }

        private ChiaveValore GetChiaveValore(string chiave)
        {
            ChiaveValore result = null;

            foreach(var cv in collection)
            {
                if (cv.Chiave.Equals(chiave))
                {
                    result = cv;
                }
            }

            return result;
        }

        private void SetChiaveValore(string chiave, string valore)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Chiave == chiave)
                {
                    collection[i].Valore = valore;
                    break;
                }
            }
        }

        public string GetValore(string chiave)
        {
            string result = String.Empty;

            foreach(ChiaveValore cv in collection)
            {
                if (cv.Chiave == chiave)
                {
                    result = cv.Valore;
                    break;
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var cv in collection)
            {
                result += cv.ToString() + Environment.NewLine;
            }

            return result;
        }
    }
}
