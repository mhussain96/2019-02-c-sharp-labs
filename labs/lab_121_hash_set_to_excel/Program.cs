using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Stopwatch s = new Stopwatch();

            s.Start();

            int[] myNum = new int[] { 10, 20, 30 };

            LinkedList<int> numberArray = new LinkedList<int>();

            foreach (int num in myNum)
            {
                numberArray.AddLast(num * 2);
            }

            HashSet<int> myNum01 = new HashSet<int>();

            foreach (var newNum01 in numberArray)
            {
                myNum01.Add(newNum01 * 2);
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = 0;
            foreach (var dict01 in myNum01)
            {
                dict.Add(sum, (dict01 + 15) * 3);
                sum++;
            }

            s.Stop();
            Console.WriteLine($"a:{dict[0]}\nb:{dict[1]}\nc:{dict[2]}\ntime:{s.ElapsedMilliseconds}");
            
            return new Custom(dict[0], dict[1], dict[2], (int)s.ElapsedMilliseconds);           
        }
    }

    public class Custom
    {
        public Custom() { }
        
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        public int time { get; set; }

        public Custom(int a, int b, int c, int d)
        {
            this.num1 = a;
            this.num2 = b;
            this.num3 = c;
            this.time = d;
        }
    }
}
