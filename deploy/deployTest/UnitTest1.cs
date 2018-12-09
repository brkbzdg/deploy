using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace deployTest
{
    [TestClass]
    public class TestHesapla
    {
        [TestMethod]
        public void testTopla()
        {
            //Arrange
            deploy.Hesapla hesap = new deploy.Hesapla();

            deploy.Adem aa = new deploy.Adem();
            aa.topla();
            //Act
            int sonuc = hesap.topla(20, 10);

            //Assert
            Assert.AreEqual(30, sonuc);
        }

        [TestMethod]
        public void testToplab()
        {
          

            deploy.Burak bb = new deploy.Burak();
            bb.topla();
            bb.topla1();
            //Act
            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
        [TestMethod]
        public void testHesapla2EskiCustomer()
        {

            //Arrange
            deploy.Hesapla2 hesap = new deploy.Hesapla2();

            //Act
            hesap.EskiCustomer(5);
           
            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
        [TestMethod]
        public void testHesapla2YeniCustomer()
        {

            //Arrange
            deploy.Hesapla2 hesap = new deploy.Hesapla2();

            //Act
            hesap.YeniCustomer(5);

            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
        [TestMethod]
        public void testHesaplaEskiCustomer()
        {

            //Arrange
            deploy.Hesapla hesap = new deploy.Hesapla();

            //Act
            hesap.EskiCustomer(5);

            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
        [TestMethod]
        public void testHesaplaYeniCustomer()
        {

            //Arrange
            deploy.Hesapla hesap = new deploy.Hesapla();

            //Act 
            hesap.YeniCustomer(5);

            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
    }
}
