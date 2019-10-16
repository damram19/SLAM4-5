using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage_Voiture_
{
    class Camion:Vehicule
    {
        protected bool semiRemorque;
        protected int essieux;

        public Camion(bool semiRemorque, int essieux, string immatriculation, int anneeConstruction, string marque, string modele):base(immatriculation, anneeConstruction, marque, modele)
        {
            this.semiRemorque = semiRemorque;
            this.essieux = essieux;
        }

        public void Afficher()
        {
            if(this.semiRemorque == true)
            {
                Console.WriteLine("Semi remorque avec {0} essieux", this.essieux);
            }
            else
            {
                Console.WriteLine("Camion avec {0} essieux", this.essieux);
            }
            Console.WriteLine("Immatriculation: {0}", this.immatriculation);
            Console.WriteLine("Année de construction: {0}", this.anneeConstruction);
            Console.WriteLine("Marque: {0}", this.marque);
            Console.WriteLine("Modèle: {0}", this.modele);
        }
    }
}
