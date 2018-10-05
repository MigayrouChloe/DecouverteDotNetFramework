using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MesOperationsArithmetiques;


namespace UnitTestProjectLePremier
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivisionCasParDefaut()
        {
            Calculator calc = new Calculator();
            decimal resultat = calc.Diviser(4, 2);

            Assert.IsTrue(resultat == 2);
        }


        [TestMethod]
        public void TestDivisionParZero()
        {
            Calculator calc = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(
                // Mise en place d'un delegué anonyme (créee a la volée) : elle n'a pas de nom ni de parametres 
                () =>
                    {
                        decimal resultat = calc.Diviser(4, 0);
                    }
            );

        }

    }
}
