using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Heritage_HP2_
{
    class Cétacé:Mammifère
    {
        private int DuréeApnée;
        private int ProfondeurPlongée;

        public Cétacé(int duréeApnée, int profondeurPlongée, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique):base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            DuréeApnée = duréeApnée;
            ProfondeurPlongée = profondeurPlongée;
        }

        public void Afficher()
        {

        }
    }
}
