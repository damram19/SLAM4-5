using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage
{
    class Félin:Mammifère
    {
        protected int nombrePattes;

        public Félin(string nom, string LieuHabitation,string monCrie,bool jeSuisDomestique,int nombrePattes):base(nom, LieuHabitation, monCrie, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }
    }
}
