using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class Database
    {
        ArrayList lesDocuments;

        public Database(ArrayList lesDocuments)
        {
            this.lesDocuments = new ArrayList();
        }

        public void Add(Document unDocument)
        {
            lesDocuments.Add(unDocument);
        }

        public void Editer()
        {
            for(int i = 0; i<lesDocuments.Count; i++)
            {
                Document document = (Document)lesDocuments[i];
                document.Afficher();
            }
        }
    }
}
