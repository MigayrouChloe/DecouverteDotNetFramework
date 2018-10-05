using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Version 1
            //Animal monPremierAnimal = new Animal();
            //monPremierAnimal.AUneBouche = true;
            //monPremierAnimal.NbMembres = 0;

            //Animal monSecondAnimal = new Animal();
            //monSecondAnimal.AUneBouche = false;
            //monSecondAnimal.NbMembres = 3;

            ////   Console.WriteLine("Le premier animal a une bouche ? " +
            ////                    monPremierAnimal.AUneBouche + ", il a aussi " + monPremierAnimal.NbMembres + " membre(s)");

            //Console.WriteLine("Le premier animal a-t-il une bouche? " +
            //                 (monPremierAnimal.AUneBouche ? "Oui" : "Non") + ". Il a " + 
            //                 monPremierAnimal.NbMembres + " membre" + (monPremierAnimal.NbMembres > 1 ? "s": "") + ".");

            //Console.WriteLine("Le second animal a-t-il une bouche? " +
            //     (monSecondAnimal.AUneBouche ? "Oui" : "Non") + ". Il a " +
            //     monSecondAnimal.NbMembres + " membre" + (monSecondAnimal.NbMembres > 1 ? "s" : "") + ".");

            //Console.ReadLine();
            #endregion

            #region Version 2.1
            //Animal monPremierAnimal = new Animal();
            //monPremierAnimal.AUneBouche = true;
            //monPremierAnimal.NbMembres = 4;


            //Console.WriteLine("Le premier animal a-t-il une bouche? " +
            //(monPremierAnimal.AUneBouche ? "Oui" : "Non") + ". Il a " +
            //monPremierAnimal.NbMembres + " membre" + (monPremierAnimal.NbMembres > 1 ? "s" : "") + ".");


            //// Alloue un nouvel espace memoire. Cependant l'ancien est déja libéré car C# un langage managé, donc pas besoin de lui dire de vider
            //// la memoire 
            //monPremierAnimal = new Animal();
            //monPremierAnimal.AUneBouche = false;
            //monPremierAnimal.NbMembres = 3;

            ////   Console.WriteLine("Le premier animal a une bouche ? " +
            ////                    monPremierAnimal.AUneBouche + ", il a aussi " + monPremierAnimal.NbMembres + " membre(s)");

            //Console.WriteLine("Le premier animal a-t-il une bouche? " +
            //                 (monPremierAnimal.AUneBouche ? "Oui" : "Non") + ". Il a " +
            //                 monPremierAnimal.NbMembres + " membre" + (monPremierAnimal.NbMembres > 1 ? "s" : "") + ".");

            //Console.ReadLine();
            #endregion

            #region Version 2.2

            //Animal animalCree1 = InitialiserAnimal(true, 4, "Simba", TypeAnimal.Lion);
            //Animal animalCree2 = InitialiserAnimal(true, 4, "Dumbo", TypeAnimal.Elephant);
            //Animal animalCree3 = InitialiserAnimal(true, 2, "Archimède", TypeAnimal.Hibou);

            //Affichage(animalCree1);
            //Affichage(animalCree2);
            //Affichage(animalCree3);
            #endregion

            #region Version 3.3
            //Animal monPremierAnimal = new Animal();
            //Elephant monPremierElephant = new Elephant(10.6M);
            //Humain monPremierHumain = new Humain();
            //Hibou monPremierHibou = new Hibou();
            //monPremierAnimal.Dormir();
            //monPremierHumain.Dormir();
            //monPremierElephant.Dormir();
            //monPremierHibou.Dormir();
            #endregion

            #region Essais
            List<Animal> listeAnimaux = new List<Animal>();

            listeAnimaux.Add(new Humain());
            listeAnimaux.Add(new Elephant(2.06M));

            // On doit caster pour acceder aux info de l'enfant.
            Console.WriteLine(((Elephant)listeAnimaux[1]).LongueurDeLaTrompe);



            Console.WriteLine(listeAnimaux.Distinct());


            #endregion

        }

        //static Animal InitialiserAnimal(bool aUneBouche, int nbMembres, string nom, TypeAnimal estDeType)
        //{
        //    Animal monAnimal = new Animal();
        //    monAnimal.NbMembres = nbMembres;
        //    monAnimal.AUneBouche = aUneBouche;
        //    monAnimal.Nom = nom;
        //    monAnimal.EstDeType = estDeType;

        //    return (monAnimal);
        //}
        //static void Affichage(Animal instanceAnimal)
        //{
        //    Console.WriteLine(instanceAnimal.Nom + " a-t-il une bouche? " +
        //                     (instanceAnimal.AUneBouche ? "Oui" : "Non") + ". Il a " +
        //                      instanceAnimal.NbMembres + " membre" + (instanceAnimal.NbMembres > 1 ? "s" : ""));
        //}
    }
}
