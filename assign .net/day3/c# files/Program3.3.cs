using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_constru_assign3._3
{
    struct emp
    {
        public string name;
        public float salary;

        public emp(string name,float salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public void disp()
        {
            Console.WriteLine("{0}\t{1}",name,salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp("abhijeet",100000);
            e.disp();
            Console.ReadLine();
        }
    }
}
