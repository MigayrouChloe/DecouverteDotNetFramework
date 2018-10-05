using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Reflection;
using JeuDroides.Core.Models;

namespace DecouverteMvcNet.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {
            #region Premiere version : tout dans le controlleur  ---> Procedurale 
            //List<string> reponseListe = new List<string>();

            //using (SqlConnection connection = new SqlConnection())
            //{
            //    connection.ConnectionString = Properties.Settings.Default.chaineConnexion;
            //    connection.Open();

            //    using (SqlCommand selectionParagraphe = connection.CreateCommand())
            //    {
            //        selectionParagraphe.CommandText = " SELECT Paragraphe.Contenu as contenuParagrahe, " +
            //                                                                 " Question.Texte as contenuQuestion, " +
            //                                                                 " Reponse.Texte as contenuReponse " +
            //                                                         " FROM Paragraphe " +
            //                                                         " JOIN Question on Paragraphe.Id = question.ParagrapheId " +
            //                                                         " JOIN Reponse on Question.Id = Reponse.QuestionId " +
            //                                                         " WHERE Paragraphe.Id = 2; ";

            //        using (SqlDataReader reader = selectionParagraphe.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                ViewBag.ContenuParagraphe = reader["contenuParagrahe"];
            //                ViewBag.ContenuReponse = reader["contenuQuestion"];

            //                reponseListe.Add(reader["contenuReponse"].ToString());
            //            }

            //        }

            //    }

            //}

            //ViewBag.ListeReponses = reponseListe;
            //return View();
            #endregion


            #region Deuxieme version --> POO
            JeuDroides.Core.Models.Paragraphe monParagraphe = new JeuDroides.Core.Models.Paragraphe();
            monParagraphe.Initialise(1);


            this.ViewBag.monParagraphe = monParagraphe;
            return View();
            #endregion
        }

        [HttpPost]
        public ActionResult Index(string testinput)
        {
            Paragraphe monParagraphe = new Paragraphe();
            monParagraphe.Initialise(int.Parse(testinput));


            this.ViewBag.monParagraphe = monParagraphe;
            return View();
        }

    }
}