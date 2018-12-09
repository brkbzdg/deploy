using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deploy
{
    public class Hesapla
    {
        public int topla(int sayi1, int sayi2)
        {
            //int target = -5;
            //int num = 3;

            //target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            //target = +num; // Noncompliant; target = 3
            return sayi1 + sayi2;
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
}