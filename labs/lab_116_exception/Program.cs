using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_116_exception
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 0;
            try
            {
                try
                {
                    int z = x / y;
                    throw new DivideByZeroException(z.ToString());
                }
                catch (DivideByZeroException z)
                {
                    Console.WriteLine(z);
                    Console.WriteLine(z.Data);                    
                }
                finally { }
                try
                {
                    throw new Exception("Fix the error!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data);
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally { }
            }
            catch (DivideByZeroException z)
            {               
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine("thrown error in the upper level");
            }
            finally
            {
                Console.WriteLine("Fixed it!");
                Console.WriteLine();
            }
        }
    }
}
