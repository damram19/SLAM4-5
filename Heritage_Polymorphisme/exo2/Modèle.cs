using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Modèle
    {
        string nom;
        double prix;
        List<Option> optionsModèle;
        public Modèle(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionsModèle = new List<Option>();
        }

        public double GetPrix { get => prix; }

        public void AddOption(Option option)
        {
            optionsModèle.Add(option);
        }

        public Option this[int index]
        {
            get
            {
                return this.optionsModèle[index];
            }
        }

        public bool PossèdeOption(string libellé)
        {
            for(int i=0; i < optionsModèle.Count; i++)
            {
                if (optionsModèle[i].GetLibellé == libellé)
                {
                    return true;
                }
            }
            return false;
        }

        public int Count
        {
            get
            {
                return optionsModèle.Count;
            }
        }

        public new string ToString()
        {
            string modèle = "";
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                modèle += optionsModèle[i].ToString() + "\n";
            }
            return String.Format("Modele: {0} GetPrix: {1} \n{2}", this.nom, this.prix, modèle);
        }
    }
}
