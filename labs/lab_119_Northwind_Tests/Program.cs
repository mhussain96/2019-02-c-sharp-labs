using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_119_Northwind_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            FileAsync newF = new FileAsync();

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            newF.northWind(100);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }


    }

    public class FileAsync
    {
        public void manyNames(int numOfFiles)
        {
            Task[] manyTask = new Task[numOfFiles];

            for (int i = 0; i < numOfFiles; i++)
            {
                int multipleFiles = i;
                // array of tasks, method myfiles 
                manyTask[i] = Task.Run(() => northWind(multipleFiles));
                //File.WriteAllText($"data{numOfFiles}.txt", "something and something");

            }
            Task.WaitAll(manyTask);
        }

        public void northWind(int myContacts)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customer = new Customer();
                // lab 10 entity reference
                customer = db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();

                Console.WriteLine(customer.ContactName = myContacts.ToString());

                db.SaveChanges();
            }
        }
    } 
}
