using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Consigne de l'exercice "TABLEAU" :
 * Créer un tableau de N éléments dont la taille du tableau est définie par la saisie
 * Remplissez le tableau grâce à une saisie au clavier
 * Affichez la somme de tous les nombres saisis grâce à une boucle FOREACH
 * */
namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int somme=0;
            int[] tableau;

            Console.Write("Nombre éléments: ");
            x = Convert.ToInt32(Console.ReadLine());
            tableau = new int[x];

            for(int i=0;i<tableau.Length;i++)
            {
                Console.Write("Nombre: ");
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int n in tableau)
            {
                somme += n;
            }
            Console.WriteLine("Somme: " + somme);

            Console.ReadKey();
        }
    }
}
