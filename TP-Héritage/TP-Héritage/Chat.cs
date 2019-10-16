using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage
{
    class Chat:Félin
    {
        public Chat(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes):base(nom, lieuHabitation, monCrie, jeSuisDomestique, nombrePattes)
        {

        }

        public void Afficher()
        {

        }
    }
}
