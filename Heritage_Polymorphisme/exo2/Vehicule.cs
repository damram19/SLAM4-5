using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    abstract class Vehicule
    {
        List<Option> optionsBase;
        string immatriculation;

        public Vehicule(string immatriculation)
        {
            this.immatriculation = immatriculation;
            optionsBase = new List<Option>();
        }

        public void AddOption(Option option)
        {
            optionsBase.Add(option);
        }

        public bool possèdeOption(string libellé)
        {
            for (int i = 0; i < optionsBase.Count; i++)
            {
                if (optionsBase[i].GetLibellé == libellé)
                {
                    return true;
                }
            }
            return false;
        }

        public Option this[int index]
        {
            get
            {
                return this.optionsBase[index];
            }
        }

        public int Count
        {
            get
            {
                return this.optionsBase.Count;
            }
        }

        public override string ToString()
        {
            string vehicule = "";
            for (int i = 0; i < optionsBase.Count; i++)
            {                
                vehicule += optionsBase[i].ToString() +"\n";
            }
            return String.Format("Vehicule: {0} \n{1}", this.immatriculation, vehicule);
        }

    }
}
