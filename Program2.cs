using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump_Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapar ett slumpat tal mellan 1 och 100 */
            Random rnd = new Random();
            int tal = rnd.Next(1, 101);

            Console.Write("Gissa ett tal mellan 1-100: ");
            int gissning = int.Parse(Console.ReadLine());

            if (gissning < tal)
                Console.WriteLine("Gissa högre!");
            else if (gissning > tal)
                Console.WriteLine("Gissa lägre!");

            int antal = 1;

            while (gissning != tal)
            {
                Console.Write("Gissa ett nytt tal mellan 1-100: ");
                gissning = int.Parse(Console.ReadLine());

                if (gissning < tal)
                    Console.WriteLine("Gissa högre!");
                else if (gissning > tal)
                    Console.WriteLine("Gissa lägre!");

                antal++;
            }

            Console.WriteLine("Du gissade rätt, svaret var: " + tal + " och det tog dig: " + antal + " gissningar");

        }
    }
}
