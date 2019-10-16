using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DiagrammeSequence_exo1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue unCatalogue = new Catalogue();
            Article unProcesseur = new Article("Processeur", 150, 19.6);
            Article uneBaretteMemoire = new Article("Mémoire", 30, 19.6);
            Article uneCarteMere = new Article("carte mère", 80, 19.6);

            unCatalogue.AjouterArticle(unProcesseur);
            unCatalogue.AjouterArticle(uneBaretteMemoire);
            unCatalogue.AjouterArticle(uneCarteMere);

            unCatalogue.AugmenterPetitPrix(10);

            unCatalogue.AfficherCatalogue();

            Console.ReadLine();

        }
    }
}
