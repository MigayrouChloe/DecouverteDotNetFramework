using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossNumber2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomJoueur = "";
            int choix = 0;
            string sexe = "";


        System.Console.WriteLine("Bonjour, nous allons créer votre avatar. Veuillez entrer votre prénom : ");
            nomJoueur = System.Console.ReadLine();

            while (sexe != "M" && sexe != "F")
            {
                System.Console.WriteLine("Veuillez saisir votre sexe (M/F)");
                sexe = System.Console.ReadLine();
                //    System.Console.Clear();
            }


            Joueur monPremierJoueur = new Joueur(nomJoueur );

            Question premiereQuestion = new Question(1, "Ca va master " + monPremierJoueur.Nom + ". Vous semblez inquiet?! ", new string[] { "Non, un jedi n’a pas le droit d’être inquiet. Je vais bien, point c’est tout.",
                                                                                                                                            "Un peu oui, c’est mon premier jour en tant que Jedi. Merci." });


            System.Console.WriteLine("Bravo, vous avez créer votre joueur " + monPremierJoueur.Nom + " à " + monPremierJoueur.DateCreation + ". Nous allons commencer le jeu. \n");


            System.Console.WriteLine("Vous commencez votre aventure dans l'espace, à bord d'un vaisseau. Votre vaisseau est destiné à arriver sur la planète Geonosis pour commencer les combats." +
                " Un Storm troopers à coté de vous, vous voit et vous demande: \n" + premiereQuestion.IntituleQuestion);

            while (!Enumerable.Range(1, premiereQuestion.Reponse.Length + 1).Contains(choix))
            {
                System.Console.WriteLine("Que répondez-vous?");
                for (int i = 0; i < premiereQuestion.Reponse.Length; i++)
                {
                    System.Console.WriteLine(i + 1 + ". " + premiereQuestion.Reponse[i] + "\n");
                }

                if (!int.TryParse(System.Console.ReadLine(), out choix))
                    choix = 0;
            }

            System.Console.WriteLine("Vous avez saisie la réponse" + premiereQuestion.Reponse[choix - 1]);

        }
    }
}
