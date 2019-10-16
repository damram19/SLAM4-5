using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jukebox
{
    public abstract class Document
    {
        string titre;
        int durée;
        bool enStock;
        string commentaire;

        public Document(string titre, int durée, bool enStock, string commentaire)
        {
            this.titre = titre;
            this.durée = durée;
            this.enStock = enStock;
            this.commentaire = commentaire;
        }

        public bool EnStock { get => enStock; set => enStock = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }

        public abstract void Afficher();
    }
}
