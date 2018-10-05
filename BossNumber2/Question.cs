using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossNumber2
{
    public class Question
    {
        public int Numero = 0;
        public string IntituleQuestion = "";
        public string[] Reponse;

        public Question(int numero, string intituleQuestion, string[] reponse)
        {
            Numero = numero;
            IntituleQuestion = intituleQuestion;
            Reponse = reponse;
        }

    }
}
