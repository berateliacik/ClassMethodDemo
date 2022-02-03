using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1 = new Customer();

            Customer1.Id = 01;
            Customer1.Name="Ali";
            Customer1.Surname = "Alioğlu";
            Customer1.Adress = "11111. sk. no 1 kat 1 ";
            Customer1.PhoneNumber = 05000000;


            Customer Customer2 = new Customer();
            Customer2.Id = 02;
            Customer2.Name = "Veli";
            Customer2.Surname = "Velioğlu";
            Customer2.Adress = "22222. sk. no 2 kat 2 ";
            Customer2.PhoneNumber = 051111111;


            Customer[] customers = new Customer[] { Customer1, Customer2 };

            CustomerManager customer = new CustomerManager();
            customer.CustomerAdd(Customer1);
            customer.CustomerDelete(Customer2);
            customer.CustomerShow(customers);






        }
    }
}
