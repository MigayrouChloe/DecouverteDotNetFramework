using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JeuDroides.Core.Models
{
    public class EquipeCombat
    {
        public List<Droide> ListeDroide = new List<Droide>();


        public void Load()
        {
            using(SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.chaineConnexion;
                connection.Open();
                using (SqlCommand charge = connection.CreateCommand())
                {
                    charge.CommandText = "SELECT Droide.Nom AS NomDroide " +
                                         "FROM Droide " +
                                         "WHERE left(Droide.Nom, 1) = 'M';";

                    using(SqlDataReader lectureNom = charge.ExecuteReader())
                    {
                        while (lectureNom.Read())
                        {
                            Droide droideEnCours = new Droide();
                            droideEnCours.Nom = lectureNom["NomDroide"].ToString();
                            this.ListeDroide.Add(droideEnCours);
                        }
                        lectureNom.Close();
                    }
                }
            }
        }

    }
}
