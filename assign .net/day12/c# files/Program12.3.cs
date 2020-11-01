using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3
{
    class employee
    { 
        int _id;

        public employee(int id, string name, double sal)
        {
            _id = id; Name = name; Salary = sal;       
        }

        public int Id
        {
            get { return _id; }
        }

        public String Name
        {
            get;
            set;
        }

        public double Salary
        {
            get;set;
        }

        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + Salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var v = new employee(1,"abc",50000);
            Object o = new employee(2, "pqr", 50000);
            dynamic d = new employee(3, "xyz", 50000);

            Console.WriteLine(v);
            Console.WriteLine(o);
            Console.WriteLine(d);
        }
    }
}
