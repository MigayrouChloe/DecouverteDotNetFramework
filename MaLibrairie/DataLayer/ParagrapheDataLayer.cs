using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairie.Models;


namespace MaLibrairie.DataLayers
{
    public class ParagrapheDataLayer  
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// Une liste de paragraphe 
        /// </returns>
        public List<Paragraphe> GetAll()
        {
            using (JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              orderby para.Numero
                              select para;

                // Autre méthode : toujours faire le order by avant le ToList. 
                // context.Paragraphe.OrderBy(item => item.Numero).ToList();

                return (requete.ToList());
            }
        }

        public Paragraphe GetOne(int id)
        {
            using (JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == id
                              select para;

                return requete.Single();
            }                          
        }

        public void Add(Paragraphe paragraphe)
        {
                using (JeuDroidesEntities context = new JeuDroidesEntities())
                {
                    context.Paragraphe.Add(paragraphe);
                    context.SaveChanges();
                }
        }

        public void Delete(int id)
        {
            Paragraphe paragrapheSelectionne = GetOne(id);
            
            using(JeuDroidesEntities contexte = new JeuDroidesEntities())
            {
                contexte.Paragraphe.Remove(paragrapheSelectionne);
                contexte.SaveChanges();
            }

        }

    }
}
