using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenthfourth
{
    class employee : ICloneable
    {
        address _ad = new address();

        public employee(string name,double sal,string add)
        {
            Name = name;
            Salary = sal;
            AD.Address = add;
        }

        public String Name
        {
            get;set;
        }

        public double Salary
        {
            get;set;
        }

        public address AD
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public object Clone()
        {
           employee e = (employee)MemberwiseClone();
           e._ad = (address)e._ad.Clone();
           return e;
        }
    }

    class address : ICloneable
    {
        public string Address
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Address;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee("abhijeet",70000,"vasagade");
            Console.WriteLine(e.Name+"\t"+e.Salary+"\t"+e.AD);

            employee e1 = (employee)e.Clone();
            Console.WriteLine(e1.Name + "\t" + e1.Salary + "\t" + e1.AD);

            Console.WriteLine(Object.ReferenceEquals(e.AD,e1.AD));
        }
    }
}
