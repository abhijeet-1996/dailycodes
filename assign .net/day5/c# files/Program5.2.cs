using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace assignment_lasttry
{
    class account
    {
        static int getid;
        private int Id;
        string Name;
        double Balanceamt;

        public account(string name, double bal)
        {
            if (getid < 2)
            {
                this.Id = ++getid;
                this.Name = name;
                this.Balanceamt = bal;
            }
            else
                Console.WriteLine("only two objects are allowed");
        }
        public void deposit(int no)
        {
            this.Balanceamt += no;
        }
        public void withdraw(int no)
        {
            this.Balanceamt -= no;
        }
        public void disp()
        {
            Console.WriteLine("{0}\t{1}\t{2}",this.Id ,this.Name, this.Balanceamt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            account a1 = new account("abhijeet",29000);
            account a2 = new account("manu", 20000);
            a1.disp();
            a2.disp();
        }
    }
}
