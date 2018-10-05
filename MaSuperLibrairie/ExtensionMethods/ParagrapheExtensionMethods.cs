using MaSuperLibrairie.Models;
using MaSuperLibrairie.Representations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSuperLibrairie.ExtensionMethods
{
    public static class ParagrapheExtensionMethods
    {
        #region Méthodes publiques
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paragraphe"></param>
        /// <returns></returns>
        public static ParagrapheRepresentation Convert(this Paragraphe paragraphe)
        {
            return new ParagrapheRepresentation()
            {
                Contenu = paragraphe.Contenu
            };
        }
        #endregion
    }
}
