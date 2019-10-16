using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage_Voiture_
{
    public class Vehicule
    {
        protected string immatriculation;
        protected int anneeConstruction;
        protected string marque;
        protected string modele;

        public Vehicule(string immatriculation, int anneeConstruction, string marque, string modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
        }

        public void Afficher()
        {
            Console.WriteLine("{0} {1}", this.marque, this.modele);
            Console.WriteLine("Immatriculation: {0}", this.immatriculation);
            Console.WriteLine("Année de construction: {0}", anneeConstruction);
        }
    }
}
