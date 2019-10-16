using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeSequence
{
    class Waiter:Personne
    {
        private Client monClient;
        private Cook monCuisinier;
        private Cashier leCaissier;

        public Waiter(string nom, Cook leCuisinier, Cashier leCaissier) : base(nom)
        {
            this.monCuisinier = leCuisinier;
            this.leCaissier = leCaissier;
        }

        public void OrderFood(Client leClient)
        {
            this.monClient = leClient;
            this.monCuisinier.OrderFood(this);
        }

        public void PickUp()
        {
            Console.WriteLine("Commande Envoyer !!");
            this.monClient.ServeFood(leCaissier);
        }
    }
}
