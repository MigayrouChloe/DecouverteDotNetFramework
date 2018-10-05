using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BibliothequeProjet.Models;
using BibliothequeProjet.DataLayer;


namespace ApiParagraphe.Controllers
{
    public class ParagrapheController : ApiController
    {

        public Paragraphe Get(int id)
        {
            DataLayerParagraphe layer = new DataLayerParagraphe();
            return layer.GetOne(id);
        }


    }
}
