using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Animal
    {
        public string Nom = "";
        public int NbMembres = 0 ;
        public bool AUneBouche = true;

        //public Animal(string nom, int nbMembres, bool aUneBouche, TypeAnimal estDeType)
        //{
        //    Nom = nom;
        //    NbMembres = nbMembres;
        //    AUneBouche = aUneBouche;
        //    EstDeType = estDeType;
        //}

        public void Manger(string maNourriture)
        {
            Console.WriteLine("Je mange : " + maNourriture);
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Je ne dors jamais, je suis une sur-animal ! ");
        }
    }
}
