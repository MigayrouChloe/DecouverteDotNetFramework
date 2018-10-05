using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MaSuperLibrairie.DataLayers;
using MaSuperLibrairie.Models;
using MaSuperLibrairie.Representations;
using MaSuperLibrairie.ExtensionMethods;


namespace API.Controllers
{
    public class ParagrapheController : ApiController
    {

        #region Version si il n'y as pas de lien dans entity entre des tables 

        //public IEnumerable<Paragraphe> Get()
        //{
        //    ParagrapheDataLayer layer = new ParagrapheDataLayer();
        //    List<Paragraphe> mesParagraphes = layer.GetAll();
        //    return mesParagraphes;
        //}



        // Indique au moteur mvc qu'il recuperes le petit tableau qui est dans le body de la requete http. 
        // [FROMBODY] Attribut de type aspect dans les argumetns des methodes  -> recupere toutes les valeurs qui ont été saisies par l'utilisateur dans le form de l'application. 

        public void Post([FromBody] Paragraphe item)
        {

        }



        #endregion


        #region Version avec les liens dans l'entity et les classes de representations 
        public IEnumerable<ParagrapheRepresentation> Get()
        {
            ParagrapheDataLayer dataLayer = new ParagrapheDataLayer();

            List<Paragraphe> listVenantDentities = dataLayer.GetAll();
            List<ParagrapheRepresentation> listARetourner = new List<ParagrapheRepresentation>();

            foreach (var item in listVenantDentities)
            {
                listARetourner.Add(new ParagrapheRepresentation()
                {
                    Id = (int)item.Id,
                    Numero = (int)item.Numero,
                    Contenu = item.Contenu
                });
            }

            return listARetourner;
        }

        public ParagrapheRepresentation Get(int id)
        {
            ParagrapheDataLayer layer = new ParagrapheDataLayer();
            Paragraphe paragrapheVenantDEntities = layer.GetOne(id);

            ParagrapheRepresentation paragrapheARetourner = paragrapheVenantDEntities.Convert();

            return paragrapheARetourner;

        }

        #endregion

    }

}
