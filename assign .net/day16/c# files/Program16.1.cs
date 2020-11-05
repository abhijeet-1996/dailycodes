using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1
{
    class employee
    { 
        public employee(int id,string name,int sal,string address)
        {
            Id = id;
            Name = name;
            Salary = sal;
            Address = address;
        }

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Salary
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Id+"\t\t"+Name+"\t\t"+Salary+"\t\t"+Address;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee(1,"abc",30000,"Vile parle");
            employee e2 = new employee(2, "efg", 40000, "Andheri");
            employee e3 = new employee(3, "pqr", 50000, "Kandivali");
            employee e4 = new employee(4, "xyz", 60000, "bandra");

            List<employee> l = new List<employee>();
            l.Add(e1); l.Add(e2); l.Add(e3); l.Add(e4);

            IEnumerable<employee> i = from g in l select g;

            foreach(var v in i)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("--------------------------------------------------------------");

            IEnumerable<employee> i1 = from g in l where(g.Address.StartsWith("Andhe")) select g;

            foreach (var v in i1)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("--------------------------------------------------------------");

            var i2 = (from g in l select g.Salary).Average()*4;

                Console.WriteLine(i2);

            Console.WriteLine("--------------------------------------------------------------");

            var i3 = from g in l where g.Name.StartsWith("x") select g;
            foreach (var v in i3)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("--------------------------------------------------------------");

            int i4 = (from g in l select g).Count();

            Console.WriteLine(i4);

            Console.WriteLine("--------------------------------------------------------------");

            var i5 = from g in l where g.Salary>49000 select g;
            foreach (var v in i5)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("--------------------------------------------------------------");

            var i6 = (from g in l select g.Salary).Average();
            var i7 = (from g in l select g.Salary).Max();
            var i8 = (from g in l select g.Salary).Min();

            Console.WriteLine("Average salary is : "+i6);
            Console.WriteLine("Max salary is : " + i7);
            Console.WriteLine("Min salary is : " + i8);

            Console.WriteLine("--------------------------------------------------------------");

            var i9 = from g in l orderby g.Name select g;
            foreach (var v in i9)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("--------------------------------------------------------------");

            var i0 = from g in l orderby g.Salary descending select g;
            foreach (var v in i0)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("--------------------------------------------------------------");

            var i11 = from g in l where g.Salary < 49000 select g;
            foreach (var v in i11)
            {
                Console.WriteLine(v.Id+"\t"+v.Name);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
