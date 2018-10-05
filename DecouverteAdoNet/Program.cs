using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DecouverteAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {

            // Connexion a la BD ? 
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Server = AJC342\SQLEXPRESS ; Database = JeuDroides; Trusted_Connection = True ; ";


                connection.Open();


                #region Affichage d'une question et ses reponses
                /*
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Question.Texte AS Question_Texte, Question.Id AS Question_Id, Reponse.Id as Reponse_Id, Reponse.Texte AS Reponse_Texte " +
                                       "FROM Question JOIN Reponse ON Question.Id = Reponse.QuestionId " +
                                       "ORDER BY Question.Id;";

                // command.ExecuteNonQuery execute select, insert, update
                SqlDataReader reader = command.ExecuteReader(); // envoi un lecteur


                int test = 0;

                while (reader.Read())
                {
                    int aTester = int.Parse(reader["Question_Id"].ToString());
                    if (test != aTester)
                    {
                        test = aTester;
                        Console.WriteLine(reader["Question_Texte"].ToString());
                    }

                    Console.WriteLine("".PadLeft(10) + reader["Reponse_Texte"].ToString());
                    // Console.WriteLine("Identifiant de la reponse :"  + reader["Reponse_Texte"]);
                    // int valeur = int.Parse(reader["Question_Id"].ToString());


                }
                reader.close();
                */
                #endregion

                #region Choix Paragraphe
                /* 
                SqlCommand commandAmeneParagraphes = connection.CreateCommand();
                commandAmeneParagraphes.CommandText = "SELECT Id, numero AS Paragraphe_numero " +
                                                       "FROM Paragraphe " + 
                                                       "ORDER BY numero;" ;
                SqlDataReader readerParagraphes = commandAmeneParagraphes.ExecuteReader();

                Console.WriteLine("Veuillez choisir une paragraphe :");
                while (readerParagraphes.Read())
                {
                    Console.WriteLine(readerParagraphes["Paragraphe_numero"]);
                }
                int.TryParse(Console.ReadLine(), out int numeroParagrapheChoisi);

                string requeteUnParagraph = "SELECT Id FROM Paragraphe WHERE numero = " + numeroParagrapheChoisi;



                readerParagraphes.Close();


                SqlCommand commandUnParagraphe = connection.CreateCommand();
                commandUnParagraphe.CommandText = requeteUnParagraph;
                decimal resultat = (decimal) commandUnParagraphe.ExecuteScalar();  // 1 ligne 1 colonne 


                Console.WriteLine(resultat);



                Console.WriteLine("Vous avez choisi" + numeroParagrapheChoisi);


              */
                #endregion

                #region Affichage final 


                SqlCommand commandAmeneParagraphes = connection.CreateCommand();
                commandAmeneParagraphes.CommandText = "SELECT Id, numero AS Paragraphe_numero " +
                                                       "FROM Paragraphe " +
                                                       "ORDER BY numero;";

                int numeroParagrapheChoisi = -1;
                using (SqlDataReader readerParagraphes = commandAmeneParagraphes.ExecuteReader())
                {

                    Console.WriteLine("Veuillez choisir une paragraphe :");
                    while (readerParagraphes.Read())
                    {
                        Console.WriteLine(readerParagraphes["Paragraphe_numero"]);
                    }
                    int.TryParse(Console.ReadLine(), out numeroParagrapheChoisi);
                    //    readerParagraphes.Close();
                }

                string requeteUnParagraph = "SELECT     Paragraphe.Id AS Paragraphe_Id ,Paragraphe.Contenu As Paragraphe_Contenu, " +
                    "                                   Question.Texte as Question_Texte, " +
                    "                                   Question.Id AS Question_Id, Reponse.Texte AS Reponse_Texte " +
                                            "FROM Paragraphe " +
                                            " Join Question ON(Paragraphe.Id = Question.ParagrapheId) " +
                                            " Join Reponse ON(Question.Id = Reponse.QuestionId) " +
                                            "WHERE Paragraphe.Numero = " + numeroParagrapheChoisi +
                                            " ORDER BY Paragraphe.Numero; ";


                using (SqlCommand commandUnParagraphe = connection.CreateCommand())
                {

                    commandUnParagraphe.CommandText = requeteUnParagraph;


                    using (SqlDataReader readerMesParagraphes = commandUnParagraphe.ExecuteReader())
                    {


                        int test = 0;

                        while (readerMesParagraphes.Read())
                        {

                            int aTester = int.Parse(readerMesParagraphes["Question_Id"].ToString());
                            if (test != aTester)
                            {
                                test = aTester;
                                Console.WriteLine(readerMesParagraphes["Paragraphe_Contenu"].ToString());
                                Console.WriteLine(readerMesParagraphes["Question_Texte"].ToString());
                            }

                            Console.WriteLine("".PadLeft(10) + readerMesParagraphes["Reponse_Texte"].ToString());
                        }



                        // readerMesParagraphes.Close();
                    }
                }

                #endregion


                Console.ReadLine();
                // connection.Close(); // si il n'y a pas de Using a début 
            }
        }
    }
}
