using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Topla;

namespace Test_islem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_topla_method()
        {

            Tislem isl = new Tislem();

            double sonuc = isl.toplamaislemi(10, 10);

            Assert.AreEqual(sonuc, 20);
        }

        [TestMethod]
        public void Test_cikart_method()
        {
            Tislem isl = new Tislem();

            double sonuc = isl.cikartmaislemi(20, 10);
            Assert.AreEqual(sonuc, 10);
        }


        public void Test_carp_method()
        {
            Tislem isl = new Tislem();

            double sonuc = isl.carpmaislemi(5, 5);
            Assert.AreEqual(sonuc, 25);
        }


        public void Test_bolme_method()
        {
            Tislem isl = new Tislem();

           double sonuc = isl.bolmeislemi(5, 5);
            Assert.AreEqual(sonuc, 1);
           
        }
    }
}
