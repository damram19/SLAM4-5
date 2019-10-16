using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_Athlon
{
    class Participant
    {
        int id;
        string nom;
        DateTime dateInscription;
        List<Resultat> lesResultats;

        public Participant(string nom, DateTime dateInscription)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public DateTime GetDateInscription()
        {
            return this.dateInscription;
        }

        private bool resultatPresent(Epreuve uneEpreuve)
        {
            for(int i = 0; i<lesResultats.Count; i++)
            {
                if (lesResultats[i].GetEpreuve().GetNom() == uneEpreuve.GetNom())
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Epreuve uneEpreuve, int tempsRealise)
        {
            if (resultatPresent(uneEpreuve) == false)
            {
                Resultat nouveauParticipant = new Resultat(this, uneEpreuve, tempsRealise);
                lesResultats.Add(nouveauParticipant);
            }
        }

        public int GetTempsTotal()
        {
            int totale = 0;
            for(int i = 0; i<lesResultats.Count; i++)
            {
                totale = totale + lesResultats[i].GetTempsRealise();
            }
            return totale;
        }

        public bool HorsDélai()
        {
            List<Resultat> natation = new List<Resultat>();
            List<Resultat> velo = new List<Resultat>();
            for(int i=0; i<lesResultats.Count; i++)
            {
                if (lesResultats[i].GetEpreuve().GetNom() == "natation")
                {
                    natation.Add(lesResultats[i]);
                }
                else
                {
                    if(lesResultats[i].GetEpreuve().GetNom() == "vélo")
                    {
                        velo.Add(lesResultats[i]);
                    }
                }
            }
            int totNat = 0;
            int totVel = 0;
            for(int i = 0; i<natation.Count; i++)
            {
                totNat = totNat + natation[i].GetTempsRealise();
            }
            for (int i = 0; i < velo.Count; i++)
            {
                totVel = totVel + velo[i].GetTempsRealise();
            }

            bool nat;
            bool vel;

            if (natation[0].GetEpreuve().GetTempsEliminatoire() < totNat)
            {
                nat = true;
            }
            else
            {
                nat = false;
            }
            if (velo[0].GetEpreuve().GetTempsEliminatoire() < totVel)
            {
                vel = true;
            }
            else
            {
                vel = false;
            }

            if(vel == true || nat == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
