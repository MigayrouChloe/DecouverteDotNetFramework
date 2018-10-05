using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaSuperLibrairie.DataLayers;
using MaSuperLibrairie.Models; 

namespace AppelDalEtEntities.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Paragraphe monParagraphe = new Paragraphe();
            ParagrapheDataLayer dataLayer = new ParagrapheDataLayer();

            monParagraphe = dataLayer.GetOne(2);
            return View(monParagraphe);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}