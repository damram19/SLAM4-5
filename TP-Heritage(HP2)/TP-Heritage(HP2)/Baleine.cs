using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Heritage_HP2_
{
    class Baleine:Cétacé
    {
        public Baleine(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int DuréeApnée, int ProfondeurPlongée):base(DuréeApnée, ProfondeurPlongée, nom, lieuHabitation, monCrie, jeSuisDomestique)
        {

        }

        public void Afficher()
        {

        }
    }
}
