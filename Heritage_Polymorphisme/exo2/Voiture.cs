using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Voiture:Vehicule
    {
        Modèle possède;

        public Voiture(string immatriculation, Modèle possède):base(immatriculation)
        {
            this.possède = possède;
        }

        public double CalculerPrix()
        {
            double totale = possède.GetPrix;

            for(int i = 0; i<possède.Count; i++)
            {
                totale = totale + possède[i].GetPrix;
            }
            for(int i = 0; i<base.Count; i++)
            {
                totale = totale + base[i].GetPrix;
            }

            return totale;
        }

        public override string ToString()
        { 
            return String.Format("{0}{1}Prix Total: {2}", possède.ToString(), base.ToString(), this.CalculerPrix());
        }
    }
}
