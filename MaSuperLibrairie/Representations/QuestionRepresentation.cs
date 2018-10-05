using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSuperLibrairie.Representations
{
    public class QuestionRepresentation : TexteRepresentation
    {
        public int Id { get; set; }
        public List<ReponseRepresentation> MesReponses { get; set; }
    }
}
