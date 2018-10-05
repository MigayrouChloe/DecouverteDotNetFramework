using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliothequeProjet.Models;

namespace BibliothequeProjet.DataLayer
{
    public class DataLayerParagraphe
    {
        public Paragraphe GetOne(int id)
        {
            using(JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == id
                              select para;

                return requete.Single();
            }
        }

    }
}
