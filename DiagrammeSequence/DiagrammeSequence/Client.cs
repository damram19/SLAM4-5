using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeSequence
{
    class Client:Personne
    {
        public Client(string nom) : base(nom)
        {

        }

        public void SaisirWine()
        {
            Console.WriteLine("Le vin a été servi");
        }

        public void ServeFood(Cashier leCaissier)
        {
            Console.WriteLine("Le client a bien été servi de son repas commander");
            leCaissier.Pay();
        }

        public void SeatAtTable(Waiter unServeur)
        {
            Console.WriteLine("Le client a bien été installé");
            unServeur.OrderFood(this);
        }
    }
}
