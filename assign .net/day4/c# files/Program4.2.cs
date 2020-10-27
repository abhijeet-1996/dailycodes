using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryassign4._2;
namespace assignment4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1,"manu",30000);
            e1.disp();
            Employee e2 = new Employee(1, "sup", 40000);
            e2.disp();
        }
    }
}
