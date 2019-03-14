using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            int a = 2;

            List<int> divisor = new List<int>();

            foreach (int num in numbers)
            {
                if (num % a == 0)
                {
                    divisor.Add(num);
                    
                }

                
            }

            foreach (var i in divisor)
            {
                Console.WriteLine(i);
            }






        }

        
    }
}
