using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4
            Parent person01 = new Parent("Mage", 23, new DateTime(2000, 12, 15));
            Console.WriteLine(person01.Name1);
            Console.WriteLine(person01.Age1);
            Console.WriteLine(person01.Dob1);
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
