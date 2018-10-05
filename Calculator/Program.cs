using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre1 = 5;
            int nombre2 = 3;

            AfficherResultatAddition(nombre1, nombre2);

            Tuple<int, int, int> essai = AdditionerResultatTuples(nombre1, nombre2);
            Console.WriteLine(essai.Item1 + " = " + essai.Item2 + " + " + essai.Item3 );


        }
        static int Additionner(int a, int b)
        {     
            return a + b;
        }
        static int Multiplier(int a, int b)
        {
            return a * b;
        }

        static void AfficherResultatAddition(int a, int b)
        {
            Console.WriteLine("Le resultat de l'addition entre " + a + " et " + b + " est " + Additionner(a, b));
            
        }
        static void AfficherResultatMultiplication(int a, int b)
        {
            Console.WriteLine("Le resultat de la multiplication entre " + a + " et " + b + " est " + Additionner(a, b));
            Console.ReadLine();
        }


        static Tuple<int, int, int> AdditionerResultatTuples(int a, int b)
        {
            int resultat = a + b;
            Tuple<int, int, int> infoAddition = new Tuple<int, int, int>(resultat, a,b);
            return infoAddition;
       

            
        }
    }
}
