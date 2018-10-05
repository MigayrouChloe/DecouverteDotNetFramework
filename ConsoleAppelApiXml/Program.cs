using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace ConsoleAppelApiXml
{
    public class Program
    {
        static void Main(string[] args)
        {
            int idChoisi = 0;
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                string monUrlDeLApi = "http://localhost/API/api/paragraphe";
                string monContenuVenantDuWeb = client.DownloadString(monUrlDeLApi);

                // Recupere au format string le contenu JSON de la page web. Donc c'est du JSON mais on c'est que ce sont des objets. Donc on le déserialise
                // DeserializeObject est une fonction qui renvoit le type entre chevron. 
                List<Models.ClasseDeTestJson> listeObjetConvertiApJson = JsonConvert.DeserializeObject<List<Models.ClasseDeTestJson>>(monContenuVenantDuWeb);

                List<int> listeVerifId = new List<int>();
                bool verif = false;

                while (!listeVerifId.Contains(idChoisi) | !verif)
                {
                    Console.WriteLine("Veuillez saisir l'identifiant du paragraphe que vous souhaitez afficher :");
                    foreach (var item in listeObjetConvertiApJson.OrderBy(item => item.Id))
                    {
                        listeVerifId.Add(item.Id);
                        Console.WriteLine(item.Id);
                    }
                    verif = int.TryParse(Console.ReadLine(), out idChoisi);
                    Console.Clear();
                }

            }

            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                string monUrlDeLApi = "http://localhost/API/api/paragraphe/" + idChoisi;
                string monContenuVenantDuWeb = client.DownloadString(monUrlDeLApi);

                Models.ClasseDeTestJson objectConvertiApJson = JsonConvert.DeserializeObject<Models.ClasseDeTestJson>(monContenuVenantDuWeb);

                Console.WriteLine(objectConvertiApJson.Contenu);
            }
        }
    }
}
