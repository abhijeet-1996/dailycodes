using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3
{
    delegate void abhi(string nm, double sal, double b);
   abstract class Employye
    {
        static int gid;
        int _id;
        public event abhi a;

        public Employye(string nm,double sal)
        {
            _id = ++gid;
            Name = nm;
            Salary = sal;
        }

        public string Name
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }

        public abstract void givebonus();

        public void ongivebonus(string nm,double sal,double b)
        {
            if (a != null)
            {
                a(nm,sal,b);
            }
        }
    }

   class perEmployee : Employye
   {
       public perEmployee(string nm, double sal)
           : base(nm, sal)
       { }
       public override void givebonus()
       {
           Console.WriteLine("give bonus permanent employee");
           double b = 15000;
           ongivebonus(Name,Salary, b);
       }
   }

   class tempEmployee : Employye
   {
       public tempEmployee(string nm, double sal)
           : base(nm, sal)
       { }

       public override void givebonus()
       {
           Console.WriteLine("give bonus temp employee");
           double b = 10000;
           ongivebonus(Name, Salary, b);
       }
   }

   class message
   {
       public static void sms(string nm,double sal,double b)
       {
           Console.WriteLine("SMS : name is  "+nm+"  salary is  "+sal+"  bonus is  "+b); 
       }
   }

    class Program
    {
        static void Main(string[] args)
        {
            Employye[] e = new Employye[2]{new perEmployee("abhi",90000),new tempEmployee("manu",70000)};
            //for (int i = 0; i < 2; i++)
            //{
            //    e[i].givebonus();
            //}

            for (int i = 0; i < 2; i++)
            {
                e[i].a += message.sms;
            }

            e[1].givebonus();
            e[0].givebonus();
        }
    }
}
