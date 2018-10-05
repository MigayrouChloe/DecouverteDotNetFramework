using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMvcNet.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {

            List<int> maListeEntier = new List<int>();
            maListeEntier.Add(1);
            maListeEntier.Add(2);
            maListeEntier.Add(3);
            maListeEntier.Add(5);

            this.ViewBag.MaListe = maListeEntier;

            return View();
        }
    }
}