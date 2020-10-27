using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zzzz;
namespace assignment5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("abhijeet",49000);
            Employee e2 = new Employee("omkar", 42000);
            e1.disp();
            e2.disp();
            Employee e3 = new Employee("manu", 90000);
        }
    }
}
