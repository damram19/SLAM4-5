using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_Athlon
{
    class Tri
    {
        string nature;
        Epreuve natation;
        Epreuve velo;
        Epreuve course;
        List<Participant> lesParticipants;

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            natation = new Epreuve("natation", distanceNatation);
            velo = new Epreuve("vélo", distanceVelo);
            course = new Epreuve("course", distanceCourse);
            List<Participant> lesParticipants = new List<Participant>();
        }

        public string GetNature()
        {
            return this.nature;
        }

        public void AddParticipant(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);
        }

        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "vélo":
                    return this.velo;
                default:
                    return this.course;
            }
        }

        public Participant GetParticipantById(int id) {
            Participant Rechercher = null;
            for(int i = 0; i<lesParticipants.Count; i++)
            {
                if (this.lesParticipants[i].GetId() == id)
                {
                    Rechercher = lesParticipants[i];
                }
            }
            return Rechercher;
        }

        public int GetDistanceTotale() {
            int totale;
            totale = natation.GetDistance() + velo.GetDistance() + course.GetDistance();
            return totale;
        }

        public List<Participant> GetLesTemps() {
            List<Participant> p = new List<Participant>();
            for(int i = 0; i<lesParticipants.Count; i++)
            {
                if (lesParticipants[i].HorsDélai() == false)
                {
                    p.Add(lesParticipants[i]);
                }
            }
            return p;
        }
    }
}
