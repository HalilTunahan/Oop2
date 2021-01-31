using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.Name = "Halil";
            customer1.SurName = "Çakantimor";
            customer1.TcNo = "1234784557";
            customer1.CustomerNumber = "12345";


            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Çakantimor Holding";
            customer2.CustomerNumber = "54321";
            customer2.TaxNumber = "147258369";



            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
