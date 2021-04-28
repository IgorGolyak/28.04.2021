using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.73 v
            double s = 100;
            double u = 20;
            double v = s * u;
            double s1 = v;
            for (int i = 2; i <= 6; i = i + 1)
            {
                s = s + s / 100.0 * 5;
                u = u + u / 100.0 * 2;
                v = s * u;
                s1 = s1 + s * u;
            }
            Console.WriteLine(s1);
            Console.ReadKey();
            
        }
    }
}
