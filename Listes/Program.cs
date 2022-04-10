using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /**
 * Consigne de l'exercice "LISTE" :
 * Créer une liste typée de type "string"
 * Ajouter y quelques chaines de caractères
 * Tester les méthodes de la LISTE : Add, AddRange, RemoveAt, Insert
 **/
namespace Listes
{
class Program
{
    static void Main(string[] args)
    {
        List<string> quartiers = new List<string>();
        quartiers.Add("quartier 1");
        quartiers.Add("quartier 2");
        
        string[] zone_balbala = new string[] { "hayable", "cheik moussa", "cheik osman" };
        quartiers.AddRange(zone_balbala);

        quartiers.Insert(1, "quartier 5");
        quartiers.RemoveAt(3);
        quartiers.Add("100");

        foreach(string s in quartiers)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();
    }
}
}
