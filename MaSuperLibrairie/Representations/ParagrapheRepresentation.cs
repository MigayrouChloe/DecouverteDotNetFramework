using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaSuperLibrairie.Models;
using MaSuperLibrairie.DataLayers;

namespace MaSuperLibrairie.Representations
{
    public class ParagrapheRepresentation : TexteRepresentation
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public List<QuestionRepresentation> Question { get; set; }
    }
}
