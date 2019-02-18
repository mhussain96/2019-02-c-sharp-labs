using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassesParent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4
            string[] myNamesArray = { "Mage", "Mike", "Tyrone", "Seb", "Jake", "Steve", "Bob", "Adam", "Sam", "Desmond" };
            
            for (int i = 0; i < 99; i++)
            {
                Random rand = new Random();
                int index = rand.Next(myNamesArray.Length);


                int randomNumber = rand.Next(1, 100);


                DateTime start = new DateTime(1919, 1, 1);
                int range = (DateTime.Today - start).Days;
                DateTime randomDate = start.AddDays(rand.Next(range));



                Parent person01 = new Parent(myNamesArray[index], randomNumber, randomDate);

                List<Parent> myList = new List<Parent>();
                myList.Add(person01);

                Console.WriteLine($"Randomly selected person is {myNamesArray[index]}");
                Console.WriteLine($"Age is {randomNumber}");
                Console.WriteLine($"DOB: {randomDate}");
                Thread.Sleep(1000);
            }
        }
    }

    class Parent
    {
        string Name;
        int Age;
        private readonly DateTime Dob;

        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }
        public DateTime Dob1 => Dob;



        public Parent(string name, int age, DateTime? dob = null)
        {
            this.Age = age;
            this.Name = name;

            if (dob == null)
            {
                this.Dob = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second);
            }
            else
            {
                this.Dob = (DateTime)Dob;
            }
        }
    }
}
