using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_n__base_type_assign3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 45.678f;
            Console.WriteLine(f.GetType());
            Console.WriteLine(f.GetType().BaseType);
            Console.ReadLine();
        }
    }
}
