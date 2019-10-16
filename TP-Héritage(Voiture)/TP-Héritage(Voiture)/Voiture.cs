using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage_Voiture_
{
    class Voiture:Vehicule
    {
        protected bool decapotable;
        protected bool climatisation;

        public Voiture(bool decapotable, bool climatisation, string immatriculation, int anneeConstruction, string marque, string modele):base(immatriculation,anneeConstruction,marque,modele)
        {
            this.decapotable = decapotable;
            this.climatisation = climatisation;
        }

        public void Afficher()
        {
            if(this.decapotable==true && this.climatisation==true)
            {
                Console.WriteLine("Voiture décapotable Avec climatisation");
            }
            else
            {
                if(this.decapotable == true && this.climatisation == false)
                {
                    Console.WriteLine("Voiture décapotable Sans climatisation");
                }
                else
                {
                    if(this.decapotable == false && this.climatisation == true)
                    {
                        Console.WriteLine("Voiture Non décapotable Avec climatisation");
                    }
                    else
                    {
                        Console.WriteLine("Voiture Non décapotable Sans climatisation");
                    }
                }
            }
            Console.WriteLine("Immatriculation: {0}",this.immatriculation);
            Console.WriteLine("Année de construction: {0}", this.anneeConstruction);
            Console.WriteLine("Marque: {0}", this.marque);
            Console.WriteLine("Modèle: {0}", this.modele);
        }
    }
}
