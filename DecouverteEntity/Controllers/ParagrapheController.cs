using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecouverteEntity.Models;

namespace DecouverteEntity.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {

                /* 
                 * Il est preferable d'apeller le .edmx nomBase+Entities
                 * Remplace le using connection et le connection.open(). 
                 * Plus besoin de déclarer la chaine de connexion 
                 */

            using (DecouverteEntity.Models.JeuDroidesEntities contexte = new JeuDroidesEntities())
            {

                // Pour l'instant on n'est pas connecté a la BD. C'est comme la creation d'une nouvelle SQLconnection. 

                /* 
                 * OBJECTIF : Tu prends une collection. Tu prends tous les objets et tu me les donnes et apres j'en fais ce que je veux.
                   from : preparation pour recuperer des objets de la collection contexte (qui pour l'instant est vide). 
                 *        Il connait les types contenu dans contexte grâce a entity. C'est pourquoi Para est bien identifier comme un Paragraphe 
                 *        Attention cependant au bug, entity conserve les noms qui sont présents dans la BD SQL.
                 * select :  dit que l'on ramene la nouvelle collection de paragraph 
                 */
                var requete = from Para in contexte.Paragraphe
                              select Para;

                /* Ce n'est que la creation de la requête : c'est l'equivalent du select * dans SQL --> il manque l'exe. */


                /* C'est le .ToList() qui permet ici d'executer la requete. On utilise ToList() car on sait que l'on récupere tout ce qui est présent dans la base de données. 
                 On pourra ensuite demander d'afficher MesParagraphes.Contenu 
                */




                return View(requete.ToList());
            }
        }

        public ActionResult Edit(int id)
        {
            using(JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == id
                              select para;

                Paragraphe monParagraphe = requete.Single();

                return View(monParagraphe);
            }
        }

        [HttpPost] // Accessible uniquement pour le post
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return View();
        }

        public ActionResult Ajouter()
        {
            return View(new Paragraphe());
        }

        [HttpPost]
        public ActionResult Ajouter(Paragraphe paragraphe)
        {
            using(JeuDroidesEntities context = new JeuDroidesEntities())
            {
                context.Paragraphe.Add(paragraphe);
                context.SaveChanges();
            }

            return View(paragraphe);
        }

        public ActionResult Supprimer(int id)
        {
            using (JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == id
                              select para;

                return View(requete.Single());
            }
        }

        [HttpPost]
        public ActionResult Supprimer(Paragraphe paragraphe)
        {
            using (JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == paragraphe.Id
                              select para;

                context.Paragraphe.Remove(requete.Single());
                context.SaveChanges();
            }

            return View();
        }
    }
}


