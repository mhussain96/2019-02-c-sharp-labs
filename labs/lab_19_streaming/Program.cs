using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace lab_19_streaming
{
    class Program
    {
        static string line;
        static List<string> list = new List<string>();

        static void Main(string[] args)
        {
            // Main thread !!!
            Console.WriteLine("Program started");
            ReadData();
            Console.WriteLine("Sleeping has finished so start work now");
            ReadDataAsync();
            Console.WriteLine("Code finished");
            Console.ReadLine();
        }

        static void ReadData()
        {
            Thread.Sleep(2000);
        }

        

        static async void ReadDataAsync()
        {
            using (var reader = new StreamReader("data.txt"))
            {
                while (true)
                {
                    line = await reader.ReadLineAsync();

                    if (line == null)
                    {
                        break;
                    }
                    list.Add(line);
                    Console.WriteLine(line);
                }
            }
            Thread.Sleep(3000);
            Console.WriteLine("work has finished reading 100 text lines");
        }

    }
}
