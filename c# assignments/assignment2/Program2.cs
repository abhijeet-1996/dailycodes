using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1, s2;
            s1 =Console.ReadLine();
            s2 = Console.ReadLine();
            float f1,f2;
            if (float.TryParse(s1, out f1) && float.TryParse(s2, out f2))
            {
                Console.WriteLine(f1+f2);
                Console.ReadLine();
            }
        }
    }
}
