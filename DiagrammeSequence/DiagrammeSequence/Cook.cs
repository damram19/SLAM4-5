using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeSequence
{
    class Cook:Personne
    {
        public Cook(string nom) : base(nom)
        {

        }

        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Commande du client bien passé");
            unServeur.PickUp(); 
        }
    }
}
