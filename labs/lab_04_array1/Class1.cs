using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_array1
{
    public class Array
    {
        // build some code here; test output
        // sum squares 

        

        public int CreateArray(int size)
        {
            int[] myArray = new int[size];
            // insert squares
            for (int i = 0; i < size; i++)
            {
                myArray[i] = i * i;
                Console.WriteLine(myArray[i]);
            }

            // check values
            int total = 0;
            for (int i = 0; i < size; i++)
            {
                total += myArray[i];
                Console.WriteLine(total);
            }
            return total;
        }

        
    }
}
