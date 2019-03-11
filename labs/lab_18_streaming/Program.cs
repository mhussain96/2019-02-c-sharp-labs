using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_18_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            // not using streaming : writing directly
            //string File01 = File.ReadAllText("test.txt");
            List<string> list = new List<string>();
            // StreamReader 
            // Create StreamReader Object
            // Enclose in 'using' block (complete 'cleanup' afterwards)
            // ReadLine()

            // path as a variable 
            // path01 is relative path
            string path01 = "data.txt";
            // path02 is absolute path
            string path02 = "C:/2019-02-c-sharp-labs/labs/lab_18_streaming/bin/Debug/data.txt";
            string path03 = "C:\\2019-02-c-sharp-labs\\labs\\lab_18_streaming\\bin\\Debug\\data.txt";
            // @ means treat the following string literally 
            string path04 = @"C:\2019-02-c-sharp-labs\labs\lab_18_streaming\bin\Debug\data.txt";
            // environment variables : my documents path
            string path05 = Environment.ExpandEnvironmentVariables("%userprofile%") + "\\Documents\\data.txt";
            
            string path06 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";
            

            using (var reader = new StreamReader(path06))
            {
                string output;
                // read every line
                // output to string 
                // test each time that the string is not null
                // continue looping until out of data
                while ((output = reader.ReadLine())!= null)
                {
                    list.Add(output);
                }
            }

            list.ForEach(output => Console.WriteLine(output));


            // StreamWriter
        }
    }
}
