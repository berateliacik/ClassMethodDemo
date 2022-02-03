using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer Customer)
        {

            Console.WriteLine("Customer Name: "+ Customer.Name+" Customer Surname: "+Customer.Surname);
            Console.WriteLine("Customer Added.");

        }

        public void CustomerDelete(Customer Customer)
        {
            Console.WriteLine("Customer Name: " + Customer.Name + " Customer Surname: " + Customer.Surname);
            Console.WriteLine("Customer Deleted.");

        }

        public void CustomerShow(Customer[] customer)
        {

            foreach (var customers in customer)
            {
                Console.WriteLine("Customer Name: " + customers.Name + " Customer Surname: " + customers.Surname);
            }

            Console.WriteLine("Customers have been shown.");
        }
    }
}
