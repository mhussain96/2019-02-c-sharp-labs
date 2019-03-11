using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_NUnit_XUnit_Tests
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class TestMeNow
    {
        public double TestThisMethodS(double a, double b,double c)
        {
            // 2,3,3 ==> (2*3)=6 and raise this to power of 3 ie 36*6=216
            Console.WriteLine($"Here is some data {2} {3} {3}");
            return Math.Pow((a*b), c);
        }
    }
}
