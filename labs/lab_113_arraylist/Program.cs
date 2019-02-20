using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace lab_113_arraylist
{
    class Program
    {
        public static ArrayList myList = new ArrayList();
        static void Main(string[] args)
        {

        }
    }

    public class aArrayList
    {
        public int arrayListMethod(int a, int b, int c, int d)
        {
            int[] numbers = new int[] { a, b, c, d };
            int total = 0;
            Queue<int> myQueue = new Queue<int>();

            foreach (var queueNum in numbers)
            {
                myQueue.Enqueue(queueNum * 2);
            }

            Stack<int> myStack = new Stack<int>();

            foreach (var stackNum in myQueue)
            {
                myStack.Push(stackNum * 2);
            }

            Dictionary<int, int> myDict = new Dictionary<int, int>();
            int s = myStack.Count;
            for (int i = 0; i < s; i++)
            {
                int num = myStack.Pop();
                myDict.Add(i, num * num);
            }

            ArrayList myList = new ArrayList();
            

            foreach (KeyValuePair<int, int> item in myDict)
            {
                myList.Add(item.Value);              
            }

            foreach (var nums in myList)
            {
                total += (int)nums;
            }

            return total;
            // accept 4 integers 
            // put to ARRAY
            // extract ==> double ==> put to queue
            // extract ==> double ==> put to stack
            // extract ==> square ==> put to dictionary 
            // put to ARRAYLIST
            // extract and get the sum of items and return this sum

        }
    }
}
