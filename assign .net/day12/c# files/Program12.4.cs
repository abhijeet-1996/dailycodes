using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4
{
    class employee
    {
        int _id;

        //public employee(int id, string name, double sal)
        //{
        //    _id = id; Name = name; Salary = sal;
        //}

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
            get;
            set;
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
            employee [] e = new employee[100000];

            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new employee();
                Console.WriteLine("in {0} th generation",GC.GetGeneration(e[i]));
            }

            GC.Collect(0,GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine("sweept from 0 gen {0}",GC.CollectionCount(0));
            Console.WriteLine("sweept from 1 gen {0}", GC.CollectionCount(1));
            Console.WriteLine("sweept from 2 gen {0}", GC.CollectionCount(2));
        }
    }
}
