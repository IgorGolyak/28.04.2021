using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.72 b
            double s = 10;
            for (int i = 2; i <= 7; i = i + 1)
            {
                s = s + s / 100.0 * 10;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
