using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10, 5);
            //Console.WriteLine("Perimetre=" + r1.Perimetre());
            //Console.WriteLine("Surface=" + r1.Surface());
            Console.WriteLine(r1);

            Console.ReadKey();
        }
    }
}
