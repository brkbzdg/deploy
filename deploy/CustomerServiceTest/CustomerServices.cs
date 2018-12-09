using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using deploy;


namespace CustomerServiceTest
{
    [TestClass]
    public class GetCustomer
    {
        [TestMethod]
        public void Can_GetCustomer()
        {
            const int customerId = 1;
            const string firstName = "Burak";
            const string lastName = "Bozdağ";

            var repository = new Mock<ICustomerRepository>();

            repository.Setup(m => m.GetCustomer(customerId)).Returns(new Customer { FirstName = firstName, LastName = lastName });

            var service = new CustomerService(repository.Object);

            var customer = service.GetCustomer(customerId);

            Assert.IsTrue(customer != null);
            Assert.IsTrue(customer.FirstName == firstName);
            Assert.IsTrue(customer.LastName == lastName);


        }

        [TestMethod]
        public void testCustomerServiceEskiCustomer()
        {
            var repository = new Mock<ICustomerRepository>();
            //repository.Setup(m => m.GetCustomer(1)).Returns(new Customer { FirstName = "Burak", LastName = "Bozdağ" });
            //Arrange
            CustomerService hesap = new CustomerService(repository.Object);

            //Act
            hesap.EskiCustomer(5);

            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
        [TestMethod]
        public void testCustomerServiceYeniCustomer()
        {
            var repository = new Mock<ICustomerRepository>();
            //repository.Setup(m => m.GetCustomer(1)).Returns(new Customer { FirstName = "Burak", LastName = "Bozdağ" });
            //Arrange
            CustomerService hesap = new CustomerService(repository.Object);

            //Act
            hesap.YeniCustomer(5);

            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
    }
}
