using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab_118_array_of_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            FileAsync newF = new FileAsync();
            
            newF.TaskArrayFileReadWrite(1000);          
            //newF.FileReadWrite();
        }
    }

    public class FileOperationSynchronous
    {
        public long FileReadWrite(int numOfFiles)
        {
            string data = "Saving some data - ";
            // create stopwatch
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            // write 1000 times to a file synchronously
            for (int i = 0; i < numOfFiles; i++)
            {
                File.WriteAllText("data.txt", data + i);
            }
            // read 1000 times that same file
            for (int i = 0; i < numOfFiles; i++)
            {
                File.ReadAllText("data.txt");
            }
            // end stopwatch 
            stopWatch.Stop();
            string output = $"Total time 1000 files write then read {stopWatch.ElapsedMilliseconds}";
            Console.WriteLine(output);
            // upgrade to this : create 1000 files!
            // string filename = "data" + string.format(i,D3) + ".txt"
            // data000.txt data.999.txt

            return stopWatch.ElapsedMilliseconds;

        }

        public long TaskArrayFileReadWrite(int numOfFiles)
        {
            // one task (input) => {method body}
            var singleTask = Task.Run(() => { });

            Task.WaitAll(singleTask);

            var s = new Stopwatch();
            s.Start();
            // array of tasks
            Task[] tasks = new Task[numOfFiles];

            for (int i = 0; i < numOfFiles; i++)
            {
                tasks[i] = Task.Run(() => { });
                // write to file

                // read from file
            }

            Task.WaitAll(tasks);
            s.Stop();
            return s.ElapsedMilliseconds;

            // Homework 1) complete and test read/write 1000 then 10000 files as task 
            // 2) Bonus : Create new project. Add northwind. update contact name of 1 customer 
            // 1000 times using 1000 tasks
        }
    }

    public class FileAsync
    {
        public void TaskArrayFileReadWrite(int numOfFiles)
        {
            Task[] manyTask = new Task[numOfFiles];

            for (int i = 0; i < numOfFiles; i++)
            {
                int multipleFiles = i;
                // array of tasks, method myfiles 
                manyTask[i] = Task.Run(() => myFiles(multipleFiles));
                //File.WriteAllText($"data{numOfFiles}.txt", "something and something");
                
            }
            Task.WaitAll(manyTask);
        }

        public void myFiles(int manyfiles)
        {
            File.WriteAllText($"data{manyfiles}.txt", "something and something");
        }
    }
}
