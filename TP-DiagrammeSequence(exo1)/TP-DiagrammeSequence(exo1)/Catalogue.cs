using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DiagrammeSequence_exo1_
{
    public class Catalogue
    {
        private List<Article> leCatalogue;

        public Catalogue()
        {
            leCatalogue = new List<Article>();
        }

        public void AjouterArticle(Article unArticle)
        {
            leCatalogue.Add(unArticle);
        }

        public void AugmenterPetitPrix(double pourcentage)
        {
            pourcentage = pourcentage / 100;
            for(int i = 0; i<leCatalogue.Count; i++)
            {
                if (leCatalogue[i].GetPrixHorsTaxe > 2)
                {
                    double prixBase = leCatalogue[i].GetPrixHorsTaxe;
                    double prixNouv = prixBase * pourcentage;
                    prixNouv = prixNouv + prixBase;
                    leCatalogue[i].GetPrixHorsTaxe = prixNouv;
                }
            }
        }

        public void AfficherCatalogue()
        {
            for(int i = 0; i<leCatalogue.Count; i++)
            {
                Console.WriteLine("Désignation: {0} Prix HT: {1}", leCatalogue[i].GetDesignation, leCatalogue[i].GetPrixHorsTaxe);
            }
        }
    }
}
