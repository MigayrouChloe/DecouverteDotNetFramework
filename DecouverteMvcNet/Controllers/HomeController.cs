using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace DecouverteMvcNet.Controllers
{
    public class HomeController : Controller
    {
        //public int _maValeur = 10;

        //public ActionResult Index()
        //{

        //    using (SqlConnection connection = new SqlConnection())
        //    {
        //        connection.ConnectionString = Properties.Settings.Default.chaineConnexion;

        //        connection.Open();

        //        using (SqlCommand totalDroide = connection.CreateCommand())
        //        {
        //            totalDroide.CommandText = "SELECT COUNT(Id) AS nbDroide FROM Droide;";

        //            ViewBag.NombreDroide = totalDroide.ExecuteScalar();
        //        }
        //    }

        //    this.ViewBag.Heure = DateTime.Now.AddDays(3);
        //    //this.ViewBag.test = _maValeur + 1;
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";
        //    this.ViewBag.test = _maValeur + 2;
        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";
        //    this.ViewBag.test = _maValeur + 3;
        //    return View();
        //}
    }
}