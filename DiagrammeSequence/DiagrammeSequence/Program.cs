using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Fred");
            Cook cuisinier = new Cook("Hank");
            Cashier caissier = new Cashier("Renee");
            Waiter serveur = new Waiter("Bod",cuisinier, caissier);
            client.SeatAtTable(serveur);
            client.SaisirWine();
            Console.ReadLine();
        }
    }
}
