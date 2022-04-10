using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panier
{
    class Panier
    {
        private List<Produit> produits;

        public Panier()
        {
            this.produits = new List<Produit>();
        }

        public void AjouterProduit(Produit p)
        {
            this.produits.Add(p);
        }

        public void EnleverProduit(int indice)
        {
            this.produits.RemoveAt(indice);
        }

        public int Total()
        {
            int total = 0;
            foreach(Produit p in this.produits)
            {
                total += p.Montant();
            }

            return total;
        }

        public void Imprimer()
        {
            Console.WriteLine("Designation\tPrix\tQte\tMontant");
            foreach (Produit p in this.produits)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", p.getDesignation(),
                    p.getPrix(), p.getQuantite(), p.Montant());
            }
        }
    }
}
