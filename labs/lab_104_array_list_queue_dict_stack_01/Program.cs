using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_dict_stack_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // put 10 numbers in an array 
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // move items to a list and add 1 (integer)
            
            List<int> numberArray = new List<int>();
            for (int i = 0; i < myArray.Length; i++)
            {
                numberArray.Add(myArray[i] + 1);
            }
            // move to stack and add 1 
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Push(numberArray[i] + 1);
            }

            // move to queue and add 1

            Queue<int> num = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                num.Enqueue(numbers.Pop() + 1);
            }

            // move to dictionary and add 1
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < 10; i++)
            {
                dict.Add(i,num.Dequeue() + 1);
            }

            // return total
            int total = 0;
            foreach(int key in dict.Keys)
            {
                total += dict[key];
            }
            Console.WriteLine(total);
        }
    }
}
