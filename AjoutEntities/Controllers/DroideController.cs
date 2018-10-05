using AjoutEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjoutEntities.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {

            using(JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from droide in context.Troide
                              select droide;
                return View(requete.ToList());
            }

        }


        public ActionResult Ajouter()
        {
            return View(new Droide());
        }

        [HttpPost]
        public ActionResult Ajouter(Droide droide)
        {
            using (JeuDroidesEntities context = new JeuDroidesEntities())
            {
                context.Troide.Add(droide);
                context.SaveChanges();
          
            }

            return View(droide);
        }


        public ActionResult Edition(int id)
        {

            using(JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from droide in context.Troide
                              where droide.Id == id
                              select droide;
                return View(requete.Single());
            }

        }


    }
}