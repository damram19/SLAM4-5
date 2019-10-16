using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class CD:Document
    {
        string artiste;
        int nombreDePistes;

        public CD(string titre, int durée, bool enStock, string commentaire, string artiste, int nombreDePistes):base(titre, durée, enStock, commentaire)
        {
            this.artiste = artiste;
            this.nombreDePistes = nombreDePistes;
        }

        public override void Afficher()
        {
            Console.WriteLine("artiste: {0} \nnombre de pistes: {1}", this.artiste, this.nombreDePistes);
        }
    }
}
