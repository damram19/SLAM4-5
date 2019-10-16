using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Heritage_HP2_
{
    class Félin:Mammifère
    {
        private int nombrePattes;

        public Félin(int nombrePattes, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique):base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }

        public void Afficher()
        {

        }
    }
}
