using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab_121_hash_set_to_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSetToExcel h = new HashSetToExcel();

            h.HashSetToExcelTest();
        }
    }

    public class HashSetToExcel
    {
        public Custom HashSetToExcelTest()
        {
            var s = new Stopwatch();
            s.Start();
            // Pass 3 numbers to an array
            int[] myArr = new int[] { 1,2,3 };

            // Double the numbers and pass to a linked list
            LinkedList<int> link = new LinkedList<int>();

            foreach (var num in myArr)
            {
                link.AddLast(num * 2);
            }

            // Double the numbers and pass to a hash set 

            HashSet<int> hash = new HashSet<int>();

            foreach (var num in link)
            {
                hash.Add(num * 2);
            }

            // Add 15 to each number, then treble numbers and pass to a dictionary

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = 0;
            foreach (var num in hash)
            {
                dict.Add(sum, (num + 15) * 3);
                sum++;
            }
            // Stop the stopwatch
            s.Stop();
            // Return the test as a CUSTOM OBJECT CONTAINING
            //          ElapsedTime (integer, will be in milliseconds)
            //          First number
            //          Second number
            //          Third number
            // Test passes if stopwatch time less than time passed in (4th variable) (set to 10 seconds)
            Console.WriteLine($"a:{dict[0]}\nb:{dict[1]}\nc:{dict[2]}\nd:{s.ElapsedMilliseconds}");
            return new Custom(dict[0], dict[1], dict[2], (int)s.ElapsedMilliseconds);          
        }
    }

    public class Custom
    {
        public Custom() { }

        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        public Custom(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }
}
