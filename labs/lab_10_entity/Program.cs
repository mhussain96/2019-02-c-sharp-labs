using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace lab_10_entity
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
                          
            // INSERT new customer 
            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer
                {
                    CustomerID = "MAGE5",
                    ContactName = "Magical Mage",
                    City = "K Town",
                    CompanyName = "I work here"
                };
                // add new customer to local database 
                db.Customers.Add(customerToCreate);
                // write changes permanently to real database 
                db.SaveChanges();               
            }

            // encapsulates database connection so its closed cleanly
            using (var db = new NorthwindEntities())
            {
                // customers list = (read from northwind).
                // (pull out from customer)
                // (send to list of customers)

                customers = db.Customers.ToList<Customer>();
            }

            // use list!!

            foreach (var customer in customers) // for each customer in customers 
            {
                Console.WriteLine($"{customer.ContactName} has ID " + $"{customer.CustomerID} from {customer.City}");


            }

            // CRUD C=create R=read U=update D=delete

            // select one customer
            using (var db = new NorthwindEntities())
            {
                // LINQ query : Microsoft : Language Independent Query 
                var customerToUpdate =
                    // select all customers from northwind 
                    (from customer in db.Customers
                         // choose one where ID matches
                     where customer.CustomerID == "ALFKI"
                     // output this one selected
                     select customer).FirstOrDefault();
                Console.WriteLine("\n\nfinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName}" + $" lives in {customerToUpdate.City}");
            }

            // UPDATE

            using (var db = new NorthwindEntities())
            {
                // LINQ query : Microsoft : Language Independent Query 
                var customerToUpdate =
                     db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                Console.WriteLine("\n\nfinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName}" + $" lives in {customerToUpdate.City}");

                // UPDATE
                // update customer 
                customerToUpdate.ContactName = "Fred Flinstone";
                // update DB permanently
                db.SaveChanges();
            }

            // have a look at customers INSERT AND UPDATE
            DisplayAll();

            // DELETE 

            using (var db = new NorthwindEntities())
            {
                var customerToDelete =
                    db.Customers.Where(c => c.CustomerID == "MAGE5").FirstOrDefault();

                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }

            // have a look at customers after DELETE
            DisplayAll();
        }

        static void DisplayAll()
        {
            // encapsulates database connection so its closed cleanly
            using (var db = new NorthwindEntities())
            {
                // customers list = (read from northwind).
                // (pull out from customer)
                // (send to list of customers)

                customers = db.Customers.ToList<Customer>();
            }

            // use list!!

            foreach (var customer in customers) // for each customer in customers 
            {
                Console.WriteLine($"{customer.ContactName} has ID " + $"{customer.CustomerID} from {customer.City}");
            }
        }
    }
}
