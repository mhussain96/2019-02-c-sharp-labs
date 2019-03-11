using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            // try - code which can possibly crash  
            // exception
            try
            {
                string data01 = File.ReadAllText("file.txt");
            }
            // specific : handling the exception
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Phil says make a file!");
            }
            // always run regardless
            finally
            {
                Console.WriteLine("and make it quick");
            }
        }
    }
}
