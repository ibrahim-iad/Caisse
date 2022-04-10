using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /**
 * Consigne de l'exercice "CAISSE" :
 * On doit saisir le prix et la quantité d'un produit acheté puis affiché le montant
 * La saisie de saisie est une bouche infinie qui s'arrete dès qu'on saisit un PRIX=0
 * Ensuite le TOTAL à payer est affiché par le programme
 * Une remise de 10% est accordé si le TOTAL des achats dépasse 5000.
 **/

namespace Caisse
{
    class Program
    {
        static void Main(string[] args)
        {
            int prix, quantite, montant, total = 0;
            double remise = 0;

            while (true)
            {
                Console.Write("Donner le prix:");
                prix = Convert.ToInt32(Console.ReadLine());
                if (prix == 0)
                    break;

                Console.Write("Quantite:");
                quantite = Convert.ToInt32(Console.ReadLine());
                montant = prix * quantite;
                total = total + montant;
                Console.WriteLine("Montant = " + montant);
            }

            remise = (total > 5000) ? total * 0.1 : 0;
            Console.WriteLine("REMISE = " + remise);
            Console.WriteLine("TOTAL = " + (total-remise));

            Console.ReadKey();
        }
    }
}
