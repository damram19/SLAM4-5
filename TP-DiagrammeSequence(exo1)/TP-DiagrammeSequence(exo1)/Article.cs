using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DiagrammeSequence_exo1_
{
    public partial class Article
    {
        private string designation;
        private double prixHorsTaxe;
        private double taucTva;

        public Article(string designation, double prixHorsTaxe, double taucTva)
        {
            this.designation = designation;
            this.prixHorsTaxe = prixHorsTaxe;
            this.taucTva = taucTva;
        }

        public double GetPrixHorsTaxe { get => prixHorsTaxe; set => prixHorsTaxe = value; }
        public string GetDesignation { get => designation; set => designation = value; }
    }
}
