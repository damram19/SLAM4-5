using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Option
    {
        string libellé;
        double prix;

        public Option(string libellé, double prix)
        {
            this.libellé = libellé;
            this.prix = prix;
        }

        public string GetLibellé { get => libellé; }
        public double GetPrix { get => prix; }

        public new string ToString()
        {
            return String.Format("{0} {1}", this.libellé, this.prix);
        }
    }
}
