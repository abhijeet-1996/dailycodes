using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    class program2
    {
        public int product(int no1, int no2)
        {
            return no1 * no2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            short b = 20;
            int c = a+b;
            Console.WriteLine(c);
            program2 p = new program2();
            Console.WriteLine(p.product(10,8));
            float f = 10f;
            Console.WriteLine(f*f);
            demoMath dm = new demoMath();
            Console.WriteLine(dm.sqr(12));
            Console.WriteLine(dm.cube(6));
            Console.ReadLine();
        }
    }
}
