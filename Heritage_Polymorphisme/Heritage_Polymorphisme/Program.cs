using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne s1;
            Personne p1 = new Etudiant();
            Personne p2 = new EtudiantDiplômé();
            Etudiant e1 = new EtudiantDiplômé();
            Personne t2 = new Professeur();

            s1 = p1;
            p1 = e1;
            e1 = (Etudiant)s1;
        }
    }
}
