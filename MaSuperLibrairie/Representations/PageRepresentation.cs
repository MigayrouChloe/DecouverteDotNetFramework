using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaSuperLibrairie.DataLayers;
using MaSuperLibrairie.Models;

namespace MaSuperLibrairie.Representations
{
    public class PageRepresentation
    {
        public ParagrapheRepresentation MonParagraphe { get; set; }
        public QuestionRepresentation MaQuestion { get; set;  }
        public List<ReponseRepresentation> MesReponses { get; set; }


        //public PageRepresentation Initialise(int id)
        //{
        //    ParagrapheDataLayer dataLayer = new ParagrapheDataLayer();

        //    List<Paragraphe> listVenantDentities = dataLayer.GetPage(id);

        //    foreach (var item in listVenantDentities)
        //    {
        //        item.
        //    }


        //    this.MonParagraphe = lis
        //    List<ParagrapheRepresentation> listARetourner = new List<ParagrapheRepresentation>();

        //    foreach (var item in listVenantDentities)
        //    {
        //        listARetourner.Add(new ParagrapheRepresentation()
        //        {
        //            Id = (int)item.Id,
        //            Numero = (int)item.Numero,
        //            Contenu = item.Contenu
        //        });
        //    }

        //    return listARetourner;
        //}









    }
}
