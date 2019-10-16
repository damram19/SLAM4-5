using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeSequence
{
    class Cashier:Personne
    {
        public Cashier(string nom) : base(nom)
        {

        }

        public void Pay()
        {
            Console.WriteLine("Le client a bien payé !");
        }
    }
}
