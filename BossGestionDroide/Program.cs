using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BossGestionDroide
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MVP OK 
            string etat = "";
            int nombreDeces = 2;
            int nombreNaissance = 5;
            string listeNaissance = "";
            string listeMort = "";



            while ((etat != "N") && (etat != "D"))
            {
                Console.WriteLine("Bonjour Empereur(e), que souhaitez vous consulter (N ou D) ? \n 1. Les naissances (N) \n 2. Les décès (D)");
                etat = Console.ReadLine();
            }

            System.Console.ForegroundColor = ConsoleColor.Green;
            if (etat == "N")
            {
                bool verifReponse = false;
                int reponse2 = -1;
                while (verifReponse == false || !Enumerable.Range(0,3).Contains(reponse2))
                {
                    System.Console.WriteLine("Vous avez choisi le menu naissances. Souhaitez vous voir \n 1. La liste exaustive des naissances. \n 2. Seulement le nombre total de naissance?  ");
                    verifReponse = int.TryParse(Console.ReadLine(), out reponse2);
                }
                if (reponse2 == 1)
                {
                    Console.WriteLine("La liste des naissances est la suivante : " + listeNaissance);
                }
                else
                {
                    Console.WriteLine("Le nombre des naissances est : " + nombreNaissance);
                }

            }

            else
            {
                bool verifReponse = false;
                int reponse3 = -1;

                while (verifReponse == false || !Enumerable.Range(0, 3).Contains(reponse3))
                {
                    System.Console.WriteLine("Vous avez choisi le menu des décès. Souhaitez vous voir \n 1. La liste exaustive des décès. \n 2. Seulement le nombre total de décès?  ");
                    verifReponse = int.TryParse(Console.ReadLine(), out reponse3);
                }

                if (reponse3 == 1)
                {
                    Console.WriteLine("La liste des décès est la suivante : " + listeMort);
                }
                else
                {
                    Console.WriteLine("Le nombre des décès est : " + nombreDeces);
                }
            }

            System.Console.ResetColor();

            System.Console.ReadLine();

            #endregion



        }
    }
}
