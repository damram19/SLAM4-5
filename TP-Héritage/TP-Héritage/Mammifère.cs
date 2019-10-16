using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Héritage
{
    class Mammifère
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCrie;
        protected bool jesuisDomestique;

        public Mammifère(string nom, string lieuHabitation, string monCrie, bool jesuisDomestique)
        {
            this.nom = nom;
            LieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jesuisDomestique = jesuisDomestique;
        }

        public bool JeSuisDangereux { get => jesuisDomestique; set => jesuisDomestique = value; }

    }
}
