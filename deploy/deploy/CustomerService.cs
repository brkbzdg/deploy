using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deploy
{
    public class CustomerService
    {
        private ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }
        public Customer GetCustomer(int id)
        {
            return _repository.GetCustomer(id);
        }

        public void YeniCustomer(int id)
        {
            //
            int a = 1;
            a = a + 1;

        }

        public void EskiCustomer(int id)
        {
            //
            int a = 1;
            a = a + 1;
            Console.Write("Burak");
            Console.Write("Burak");
            Console.Write("Burak");
            Console.Write("Burak");
            Console.Write("Burak");
            Console.Write("Burak");
            Console.Write("Burak");
        }
    }

    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
    }

    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}