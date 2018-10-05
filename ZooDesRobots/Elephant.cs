using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Elephant : Animal
    {
        public decimal LongueurDeLaTrompe = 200.5M;

        public Elephant(decimal longueurDeLaTrompe)
        {
            LongueurDeLaTrompe = longueurDeLaTrompe;
        }



        public override void Dormir()
        {
            Console.WriteLine("Je dors debout dans la savane en révant de bananes.");
        }


    }
}
