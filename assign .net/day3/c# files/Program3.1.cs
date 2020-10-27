using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_assign_3._1
{
    struct first
    {

        public static int sqr(int no)
        {
            return no * no;
        }

        public static int cube(int no)
        {
            return no * no * no;
        }
    }
    class Program11
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first.sqr(4));
            Console.WriteLine(first.cube(4));
            Console.ReadLine();
        }
    }
}
