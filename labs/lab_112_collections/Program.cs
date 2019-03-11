using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Collections
    {
        
        // receive 3 numbers 
        // put these 3 numbers into array 
        // output numbers, double each one and store in a STACK
        // repeat ie output numbers, double and store in QUEUE
        // output numbers, SQUARE THEM then store in List<int>
        // Add up numbers in the List<int> and return total 

        public int Collections20minutelab(int num1, int num2, int num3)
        {
            int[] numbers = new int[] {num1, num2, num3 };

            Stack<int> numberStack = new Stack<int>();

            foreach (var stackNum in numbers)
            {
                numberStack.Push(stackNum * 2);
            }


            Queue<int> numberQueue = new Queue<int>();

            foreach (var queueNum in numberStack)
            {
                numberQueue.Enqueue(queueNum * 2);
            }

            List<int> numberList = new List<int>();
            int total = 0;
            foreach (var listNum in numberQueue)
            {
                numberList.Add(listNum * listNum);
            }

            foreach (var item in numberList)
            {
                total += item;
            }

            return total;
        }
    }
}
