using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class Video:Document
    {
        string metteurEnScène;

        public Video(string titre, int durée, bool enStock, string commentaire, string metteurEnScène) : base(titre, durée, enStock, commentaire)
        {
            this.metteurEnScène = metteurEnScène;
        }

        public override void Afficher()
        {
            Console.WriteLine("metteur en scène: " + this.metteurEnScène);
        }
    }
}
