using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.WriteLine("We begin the typing game");
            //string str;
            //int alp,i,len;
            //alp = i = 0;
            //Console.WriteLine("Enter some letters: ");
            //str = Console.ReadLine();
            //Stopwatch stopwatch = new Stopwatch();
            //len = str.Length;
            //stopwatch.Start();
            //while (i < len)
            //{      
            //    if (str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        alp++;
            //    }

            //    if (stopwatch.Elapsed.TotalSeconds > 10)
            //    {
            //        Console.WriteLine("Game over!");                   
            //        break;
            //    }

            //    i++;
            //}
            //Console.Write("Number of characters in the string is : {0}\n", alp);
            //stopwatch.Stop();

            //Task 2 
            //List<char> alphabet = new List<char>() {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            //bool ordered = true;
            //Stopwatch s = new Stopwatch();
            //s.Start();
            //while (ordered == true)
            //{
            //    char input = (Console.ReadKey().KeyChar);
            //    if (alphabet[0] == input)
            //    {
            //        Console.WriteLine("\nCorrect input!");
            //        alphabet.RemoveAt(0);                   
            //    } 
            //    else
            //    {
            //        Console.WriteLine("\nInvalid input, try again!");
            //    }

            //    if (alphabet.Count <= 0)
            //    {
            //        Console.WriteLine("Alphabet done!");
            //        break;
            //    }

            //    if (s.Elapsed.TotalSeconds > 10)
            //    {

            //        Console.WriteLine("Game Over!");
            //        Console.WriteLine($"You achieved {alphabet.Count} out of 26");
            //        break; 
            //    }
            //}
            //s.Stop();     

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
