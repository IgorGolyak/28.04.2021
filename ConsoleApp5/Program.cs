using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.89
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int i= 1; i<=n; i++)
            {
                 int f = 1;
                for (int j = 1; j<=i; j++)
                {
                    f = f * j;
                }
                s = s + f;
            }
            Console.WriteLine(s);
            Console.ReadKey();



        }
    }
}
