using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JeuDroides.Core.Models;

namespace AffichageDroideM.Controllers
{
    public class AffichageListeController : Controller
    {
        // GET: AffichageListe
        public ActionResult Index()
        {

            EquipeCombat maNouvelleEquipe = new EquipeCombat();
            maNouvelleEquipe.Load();

            this.ViewBag.monEquipe = maNouvelleEquipe;

            return View();
        }
    }
}