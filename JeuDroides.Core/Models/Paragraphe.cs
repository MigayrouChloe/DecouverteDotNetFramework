using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace JeuDroides.Core.Models
{
    public class Paragraphe : Texte
    {

        #region Attributs 
        public int Numero { get; set; }
        public Question MaQuestion { get; set; }
        #endregion

        #region Methodes
        public void Initialise(int numeroDuParagraphe)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.chaineConnexion;
                connection.Open();
                using (SqlCommand commande = connection.CreateCommand())
                {
                    commande.CommandText = " SELECT Paragraphe.Contenu as contenuParagrahe, " +
                                                " Question.Texte as contenuQuestion, " +
                                                " Reponse.Texte as contenuReponse " +
                                            " FROM Paragraphe " +
                                            " JOIN Question on Paragraphe.Id = question.ParagrapheId " +
                                            " JOIN Reponse on Question.Id = Reponse.QuestionId " +
                                            " WHERE Paragraphe.Numero = " + numeroDuParagraphe + "; ";

                    using (SqlDataReader reader = commande.ExecuteReader())
                    {
                        this.MaQuestion = new Question();
                        this.MaQuestion.MesReponses = new List<Reponse>();
                        while (reader.Read())
                        {
                            this.Contenu = reader["contenuParagrahe"].ToString();

                            this.MaQuestion.Contenu = reader["contenuQuestion"].ToString();

                            Reponse reponse = new Reponse();
                            reponse.Contenu = reader["contenuReponse"].ToString();
                            this.MaQuestion.MesReponses.Add(reponse);
                        }

                    }

                }


            }
        }

        #endregion



    }
}