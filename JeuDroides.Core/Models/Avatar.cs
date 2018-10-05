using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDroides.Core.Models
{
    public class Avatar
    {
        private string _nom = "";
        private string Sexe = "";
        private Role MonRole = null;
        private Espece MonEspece = null;


        public Avatar(string nom, string sexe, Role monRole, Espece monEspece)
        {
            Nom = nom;
            Sexe = sexe;
            MonRole = monRole;
            MonEspece = monEspece;
        }

        //public string Nom { get => _nom; set => _nom = value; }

        public string Nom
        {
            get
            {

                return _nom;
            }
            set
            {
                _nom = value;

            }
        }
    }
}
