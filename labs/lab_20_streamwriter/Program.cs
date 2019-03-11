using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_20_streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // overwrite mode

            using (var writer = new StreamWriter("data.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Data line {i}");
                }
            }

            // append mode 

            using (var writer = new StreamWriter("data.txt", true))  // true allows to add to data.txt, false overwrites the statement above
            {
                writer.WriteLine("and some more");
            }

            // set encoding (UTF8 default)

            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8))
            {
                writer.WriteLine("and some more");
            }

            // huge files : can speed up process by altering 'buffer size'
            // which is the unit of data transfer

            using (var writer = new StreamWriter("data.txt", true, Encoding.UTF8,10000))   // 10000 is the buffer size
            {
                writer.WriteLine("something and something of data");
            }
        }
    }
}
