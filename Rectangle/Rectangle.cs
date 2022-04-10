using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Consigne de l'exercice "RECTANGLE" :
 * La classe Rectangle possède :
 * 1 constructeur
 * 2 setteurs: setLongueur, setLArgeur
 * 2 fonctions: Surface, Perimetre
 * 1 redéfinition: ToString()
 * */
namespace Rectangle
{
    class Rectangle
    {
        private int longueur;
        private int largeur;
        public Rectangle(int lon, int lar)
        {
            this.longueur = lon;
            this.largeur = lar;
        }
        public void setLongueur(int lon)
        {
            this.longueur = lon;
        }
        public void setLargeur(int lar)
        {
            this.largeur = lar;
        }
        public int Perimetre()
        {
            return 2 * (this.longueur + this.largeur);
        }
        public int Surface()
        {
            return this.longueur * this.largeur;
        }
        public void Afficher()
        {
            Console.WriteLine("Longueur=" + this.longueur);
            ///
        }
        public override string ToString()
        {
            string message = "Longueur=" + this.longueur + "\nLargeur=" +
                this.largeur + "\nPerimetre=" + this.Perimetre() +
                "\nSurface=" + this.Surface();
            return message;
        }



    }
}
