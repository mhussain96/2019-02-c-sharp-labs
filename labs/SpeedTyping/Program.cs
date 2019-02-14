using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Console.WriteLine("We begin the typing game");
            List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            bool ordered = true;
            Stopwatch s = new Stopwatch();
            s.Start();
            while (ordered == true)
            {
                char input = (Console.ReadKey().KeyChar);
                if (alphabet[0] == input)
                {
                    Console.WriteLine("\nCorrect input!");
                    alphabet.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("\nInvalid input, try again!");
                }

                if (alphabet.Count <= 0)
                {
                    Console.WriteLine("Alphabet done!");
                    break;
                }

                if (s.Elapsed.TotalSeconds > 10)
                {

                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"You achieved {alphabet.Count} out of 26");
                    break;
                }
            }
            s.Stop();


        }
    }
}
