using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteAdoNetBisExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int jessaieDeCreerUneVariableMolle = Properties.Settings.Default.maNouvelleVariable;

            Console.WriteLine(jessaieDeCreerUneVariableMolle);

            string ConnectionString = Properties.Settings.Default.connexionServeurDev;

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = ConnectionString;

                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {

                        Console.WriteLine("Quel est le nom du droide dont vous voulez changer le matricule? ");
                        string nomDuDroideAModifier = Console.ReadLine();

                        Console.WriteLine("Quel est le nouveau matricule? ");
                        string nouveauMatricule = Console.ReadLine();

                        command.CommandText = "UPDATE Droide " +
                                                "SET Matricule = '" + nouveauMatricule + "', " +
                                                "DateDerniereMiseAJour = GETDATE() " +
                                                "WHERE Nom = '" + nomDuDroideAModifier + "' ;";

                        int nbElementModifie = command.ExecuteNonQuery();


                    }

                    connection.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Impossible de se connecter, je passe dans le catch");
            }
            //finally
            //{
            //    Console.WriteLine("Essai");
            //}


        }
    }
}

