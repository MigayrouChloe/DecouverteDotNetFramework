using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAppelPost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                // On cree le tableau de valeur qui permettra de faire le bind 
                NameValueCollection monDico = new NameValueCollection();
                monDico.Add("Contenu", "essai contenu");
                monDico.Add("Numero", "essai titre");

                // Envoie des info à l'API 
                client.UploadValues("http://localhost/API/api/paragraphe" , monDico);
            }

        }
    }
}
