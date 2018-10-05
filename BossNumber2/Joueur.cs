using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossNumber2
{
    public class Joueur
    {
        public string Nom = "";
        public DateTime DateCreation ;


        public Joueur(string nom)
        {
            Nom = nom;
            DateCreation = DateTime.Now;

        }

    }
}
