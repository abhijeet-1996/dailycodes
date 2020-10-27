using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_n_basetype_assign3._6
{
    class manu
    {
        public int sal;
    }
    class Program
    {
        static void Main(string[] args)
        {
            manu m = new manu();
            Console.WriteLine(m.GetType()+"\t\t\t"+m.GetType().BaseType);
            Console.ReadLine();
        }
    }
}
