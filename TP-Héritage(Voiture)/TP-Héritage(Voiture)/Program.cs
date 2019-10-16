using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage_Voiture_
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] Tab = new Vehicule[4];
            Tab[0] = new Voiture(true, false, "333 ABC 06", 2000, "Peugeot", "306");
            Tab[1] = new Voiture(false, true, "321 BBD 06", 2001, "Renault", "Clio");
            Tab[2] = new Camion(true, 4, "1234 TZ 06", 1993, "DAF", "T43");
            Tab[3] = new Camion(false, 3, "765 ACE 06", 1999, "Mercedes", "C.L");

            for(int i=0; i<Tab.Length; i++)
            {
                if(Tab[i] is Voiture)
                {
                    ((Voiture)Tab[i]).Afficher();
                    Console.WriteLine("\n");
                }
                else
                {
                    ((Camion)Tab[i]).Afficher();
                    Console.WriteLine("\n");
                }
            }

            Console.ReadLine();
        }
    }
}
