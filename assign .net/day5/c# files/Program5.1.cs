using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
    class employee
    {
        string Firstname, Lastname, Middlename;

        public employee(string Firstname, string Lastname, string Middlename)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Middlename = Middlename;
        }
        public employee(string Firstname, string Lastname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
        }

        public void disp()
        {
            Console.WriteLine("{0}\t{1}\t{2}",this.Lastname,this.Firstname,this.Middlename);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee("abhijeet","chougule","prakash");
            employee e2 = new employee("omkar","chougule");
            e1.disp();
            e2.disp();
        }
    }
}
