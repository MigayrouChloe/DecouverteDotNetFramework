using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaSuperLibrairie.Models;
using MaSuperLibrairie.DataLayers;

namespace AppelDalEtEntities.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {
            Paragraphe monParagraphe = new Paragraphe();
            ParagrapheDataLayer dataLayer = new ParagrapheDataLayer();

            monParagraphe = dataLayer.GetOne(2);
            return View();
        }
    }
}