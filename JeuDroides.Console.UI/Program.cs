using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDroides.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Version 1  
            /*
              string maChaine = "";
              string nom = "";
              nom = "";
              string sexe = "";
              string determinant = "";

              //   while((sexe != "M") || (sexe != "F"))  // Ne fonctionne pas car si on saisit M on aura le doublet (0 OU 1) = 1 donc on rentrera dans le while 
              while ((sexe != "M") && (sexe != "F"))  // Si on saisit M on aura le doublet (1 ET 0) = 0 donc on sortira de la boucle 
              {
                  System.Console.WriteLine("Quel est votre sexe (M/F)?");
                  sexe = System.Console.ReadLine();
              }


              System.Console.ForegroundColor = ConsoleColor.Cyan;
              if (sexe == "F")
              {
                  System.Console.WriteLine("Vous êtes une femme");
                  System.Console.ReadLine();
              } else if (sexe == "M")
              {
                  System.Console.WriteLine("Vous êtes un homme");
                  System.Console.ReadLine();
              }else
              {
                  System.Console.ForegroundColor = ConsoleColor.Green;
                  System.Console.WriteLine("Vous êtes un alien");
                  System.Console.ReadLine();
              }
              System.Console.ResetColor();

              maChaine = "Il était une fois dans une galaxie lointaine... Très lointaine..., un(e) jeune JEDI " + nom + " arriva pour commencer la guerre des clones";

              System.Console.WriteLine(maChaine);
              System.Console.ReadLine();
             */
            #endregion

            #region Version 2

            //string maChaine = "";
            //string nom = "";
            //string sexe = "";
            //string determinant = "";

            //int choixEspece = -1;


            //while (sexe != "M" && sexe != "F")
            //{
            //    System.Console.WriteLine("Veuillez saisir votre sexe (M/F)");
            //    sexe = System.Console.ReadLine();
            //    //    System.Console.Clear();
            //}

            //determinant = (sexe == "F" ? "une" : "un");


            //System.Console.WriteLine("Veuillez entrer votre prénom");
            //nom = System.Console.ReadLine();

            ////string[] espece = new string[3] { "Wookie", "Humain", "Droide" };
            //string[] espece = Enum.GetNames(typeof(TypeEspece));

            //while (!Enumerable.Range(0, espece.Length).Contains(choixEspece))
            //{
            //    System.Console.WriteLine("Voici les espèces disponibles, veuillez saisir le numero correspondant : \n ");

            //    for (int i = 0; i < espece.Length; i++)
            //    {
            //        System.Console.WriteLine(i + ". " + espece[i] + "\n");
            //    }
            //    // out passer param dans fonction et recuperation apres 

            //    if (!int.TryParse(System.Console.ReadLine(), out choixEspece))
            //        choixEspece = -1;
            //}


            //if (sexe == "F")
            //{
            //    espece[Array.IndexOf(espece, "Humain")] = "humaine";
            //}


            //maChaine = "Il était une fois dans une galaxie lointaine... Très lointaine..., " + determinant + " jeune " + espece[choixEspece] + "\n" + nom + " arriva pour commencer la guerre des clones";

            //System.Console.WriteLine(maChaine);
            //System.Console.ReadLine();


            #endregion

            #region Version 2.1

            //string maChaine = "";
            //string nom = "";
            //string sexe = "";
            //string determinant = "";
            //int choixEspece = -1;


            //while (sexe != "M" && sexe != "F")
            //{
            //    System.Console.WriteLine("Veuillez saisir votre sexe (M/F)");
            //    sexe = System.Console.ReadLine();
            //    //    System.Console.Clear();
            //}

            //determinant = (sexe == "F" ? "une" : "un");


            //System.Console.WriteLine("Veuillez entrer votre prénom");
            //nom = System.Console.ReadLine();
            //System.Console.Clear();


            //while (choixEspece < 0)
            //{
            //    System.Console.WriteLine("Voici les espèces disponibles, veuillez saisir le numero correspondant : \n ");


            //    foreach (string s in Enum.GetNames(typeof(TypeEspece)))
            //    {
            //        System.Console.WriteLine((int)Enum.Parse(typeof(TypeEspece), s) + " : " + s);
            //    }
            //    // out passer param dans fonction et recuperation apres 

            //    if (!int.TryParse(System.Console.ReadLine(), out choixEspece))
            //        choixEspece = -1;
            //}

            //// Pas fini il faut adapter la phrase en fonction du choixEspece récupéré
            //maChaine = "Il était une fois dans une galaxie lointaine... Très lointaine..., " + determinant + " jeune " + TypeEspece + "\n" + nom + " arriva pour commencer la guerre des clones";

            //System.Console.WriteLine(maChaine);
            //System.Console.ReadLine();



            //#endregion

            #region Version 3
            /*
            string maChaine = "";
            string nom = "";
            string sexe = "";


            System.Console.WriteLine("Veuillez saisir H si vous êtes un homme ou F si vous êtes une femme");
            sexe = System.Console.ReadLine();
            System.Console.Clear();

            System.Console.WriteLine("Veuillez entrer votre prénom");
            nom = System.Console.ReadLine();
            System.Console.Clear();

            maChaine = "Il était une fois dans une galaxie lointaine... Très lointaine..., un" + (sexe == "F"? "e" :"") + " jeune JEDI " + nom + " arriva pour commencer la guerre des clones";


            System.Console.WriteLine(maChaine);
            System.Console.ReadLine();*/
            #endregion

            #region Version 4
            /*
            string maChaine = "";
            string nom = "";

            System.Console.WriteLine("Veuillez entrer votre prénom");
            nom = System.Console.ReadLine();
            System.Console.Clear();

            string[] nomHomme = new string[] { "Olivier", "Marc Antoine", "Christian", "Jan", "Oualim", "Hermann" , "Evan"};
            string[] nomFemme = new string[] { "Magalie", "Mariem", "Chloé" };

            maChaine = "Il était une fois dans une galaxie lointaine... Très lointaine..., un" + (nomHomme.Contains(nom)? "" : "e") + " jeune JEDI " + nom + " arriva pour commencer la guerre des clones";

            System.Console.WriteLine(maChaine);
            System.Console.ReadLine(); */
            #endregion

        }




    }
}