using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Option directionAssistée = new Option("Direction Assistée", 250);
            Option airBag = new Option("Air Bag", 320);
            Option cdAudio = new Option("CD Audio", 230);
            Option airConditionné = new Option("Air Conditionné", 395);

            Modèle modèle = new Modèle("Clio", 12000);

            modèle.AddOption(directionAssistée);
            modèle.AddOption(airBag);

            Vehicule vehicule = new Voiture("474 QQ 95", modèle);

            vehicule.AddOption(cdAudio);
            vehicule.AddOption(airConditionné);

            Console.WriteLine(vehicule.ToString());
            Console.ReadLine();
        }
    }
}
