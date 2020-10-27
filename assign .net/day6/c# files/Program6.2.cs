using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixthsecondassign
{
    class Employee 
    {
        static int gid;
        int id;
        double salary;
        const float maxsal = 50000;
        static float TDS = 0.1f;
        double netsalary;
        static Employee ()
        {
            Console.WriteLine("Google");
        }
        public Employee (string name, double sal)
        {
            if (gid < 3)
            {
                this.id = ++gid;
                Name = name;
                Salary = sal;
                netsalary = calculate_netsal();
            }
            else
                throw new Exception("only 3 employees are allowed");
        }

        public int Id
        { get { return id; } }

        public string Name
        {
            get;
            set;
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0 || value >50000)
                {
                    Console.WriteLine("salary cannot be more than 50000 and salary cannot be 0 or -ve");
                    throw new Exception("alary cannot be more than 50000 and salary cannot be 0 or -ve");
                }
                else
                {

                    this.salary = value;
                }
            }
        }

        

        public double calculate_netsal()
        {
            Console.WriteLine(Salary * TDS);
            netsalary = Salary - (Salary * TDS);
            return netsalary;
        }

        public void disp()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", this.id, Name, Salary, this.netsalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("abhijeet",45000);
            e1.disp();
            Employee e2 = new Employee("omkar",30000);
            e2.disp();
            Employee e3 = new Employee("manu",60000);
            e3.disp();
           // Employee e4 = new Employee("shree",49000);
        }
    }
}
