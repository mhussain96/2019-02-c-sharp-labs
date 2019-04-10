using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArr = Enumerable.Range(1, 1000000);
            //Queue<int> myQueue = new Queue<int>();
            //Stack<int> myStack = new Stack<int>();
            //Dictionary<int, int> myDict = new Dictionary<int, int>();
            //int[] myArrList = new int[] { };
            //HashSet<int> myHash = new HashSet<int>();
            //LinkedList<int> myLink = new LinkedList<int>();
            //int sum = 0;
            var s = new Stopwatch();
            s.Start();
            int sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                sum += i;
            }
            
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(sum);

            
        }
    }

    class Add
    {

        public static int sumToMillion(int range)
        {
            var s = new Stopwatch();

            s.Start();
            int sum = 0;
            int[] myArr = new int[range];
            for (int i = 0; i < myArr.Length; i++)
            {
                sum += myArr[i];

            }
            
            return new   

        }

    }
    
}
