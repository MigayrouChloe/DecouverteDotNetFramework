using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaSuperLibrairie.Models;
using MaSuperLibrairie.Representations;


namespace MaSuperLibrairie.DataLayers
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

                return requete.ToList();
            }
        }

        public Paragraphe GetOne(int id)
        {
            using (JeuDroidesEntities context = new JeuDroidesEntities())
            {
                var requete = from para in context.Paragraphe
                              where para.Id == id
                              select para;

                return requete.Include("QuestionList")
                              .Include("QuestionList.ReponseList")
                              .Single();
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

            using (JeuDroidesEntities contexte = new JeuDroidesEntities())
            {
                contexte.Paragraphe.Remove(paragrapheSelectionne);
                contexte.SaveChanges();
            }

        }

        //public PageRepresentation GetPage(int id)
        //{
        //    PageRepresentation maPage = new PageRepresentation();

        //    using (JeuDroidesEntities contexte = new JeuDroidesEntities())
        //    {
        //        var requete = from para in contexte.Paragraphe
        //                      join quest in contexte.Question on para.Id equals quest.ParagrapheId
        //                      join rep in contexte.Reponse on quest.Id equals rep.QuestionId
        //                      where para.Id == id
        //                      select new { Paragraphe = para, Question = quest, Reponse = rep };

        //        return(requete.





        //         public List<SummaryClientItem> MediumMarginProjects
        //{
        //    get
        //    {
        //        return (from i in Items
        //                where i.Margin == "M"
        //                group i by new { i.ProjectNumber, i.ClientCode } into g
        //                select new SummaryClientItem
        //                {
        //                    ClientCode = g.Key.ClientCode,
        //                    ProjectNumber = g.Key.ProjectNumber,
        //                    Margin = "M",
        //                    SomeValue = g.Sum(i => i.SomeValue)
        //                }).ToList();
        //    }
        //}







    }
       
}

