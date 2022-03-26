using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caisse
{
    class Program
    {
        static void Main(string[] args)
        {
            int prix, quantite, montant, total = 0;

            while (true)
            {
                Console.Write("Donner le prix:");
                prix = Convert.ToInt32(Console.ReadLine());
                //////////
                if (prix == 0)
                    break;
                //////////
                Console.Write("Quantite:");
                quantite = Convert.ToInt32(Console.ReadLine());
                montant = prix * quantite;
                total = total + montant;
                Console.WriteLine("Montant = " + montant);
            }
            Console.WriteLine("TOTAL = " + total);
            Console.ReadKey();
        }
    }
}
