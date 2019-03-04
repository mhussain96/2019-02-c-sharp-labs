#define MAGETEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting app");
#if DEBUG
            Console.WriteLine("This is debug code");
#endif


            Console.WriteLine("This is not working");
#if MAGETEST
            Console.WriteLine("Finishing app");
#endif
        }
    }
}
