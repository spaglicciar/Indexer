using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary cd = InizializzaCD();

            Console.WriteLine(cd.ToString());

            Console.WriteLine("Il valore dell'oggetto con chiave {0} è {1}", "4", cd.GetValore("4"));

            ChiaveValore cv = cd["4"];
            Console.WriteLine(cv.ToString());

            cd["6"] = new ChiaveValore() { Chiave = "6", Valore = "Nuovo valore della chiave 6" };

            Console.WriteLine(cd[6].ToString());

            ChiaveValore cv1 = new ChiaveValore() { Chiave = "A", Valore = "Valore di A" };
            ChiaveValore cv2 = new ChiaveValore() { Chiave = "A", Valore = "Valore di A" };

            Console.WriteLine("I due oggetti sono uguali? {0}", cv1.Equals(cv2));

            Console.ReadLine();
        }

        static CustomDictionary InizializzaCD()
        {
            CustomDictionary result = new CustomDictionary();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new ChiaveValore() { Chiave = i.ToString(), Valore = string.Format("Valore di {0}", i) };
            }

            return result;
        }


    }
}
