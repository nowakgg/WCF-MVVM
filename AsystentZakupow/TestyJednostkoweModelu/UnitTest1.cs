using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestyJednostkoweModelu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Tworzymy obiekt
            //wykomujemy czynność
            //sprawdzamy

            //arrange
            decimal sumaPoczatkowa = 250M;
            decimal kwota = 100M;
            Sumator.Sumator model = new Sumator.Sumator(1000, sumaPoczatkowa);

            //act
            model.Dodaj(kwota);

            //assert
            Assert.AreEqual(sumaPoczatkowa + kwota, model.Suma);
        }
    }
}
