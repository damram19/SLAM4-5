using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage
{
    class Cétacé:Mammifère
    {
        protected int DuréeApnée;
        protected int ProfondeurPlongée;

        public Cétacé(int duréeApnée, int profondeurPlongée, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique):base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            DuréeApnée = duréeApnée;
            ProfondeurPlongée = profondeurPlongée;
        }
    }
}
