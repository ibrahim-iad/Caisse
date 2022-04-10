using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panier
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p1 = new Produit("Lait", 150, 2);
            Produit p2 = new Produit("Riz", 200, 3);
            Produit p3 = new Produit("Fanta", 50, 1);
            Panier panier = new Panier();
            panier.AjouterProduit(p1);
            panier.AjouterProduit(p2);
            panier.AjouterProduit(p3);
            panier.Imprimer(); 
            Console.WriteLine("Total:" + panier.Total());
            
            Console.ReadKey();
        }
    }
}
