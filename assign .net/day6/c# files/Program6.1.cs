using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthoneassign
{
    class account
    {
        static int gid;
        int id;
        //string name;
        double balance;
        const float minbal=1000;
        static float Interestrate = 0.07f;

        static account()
        {
            Console.WriteLine("ICICI bank of INDIA");
        }
        public account(string name, double balance)
        {
            this.id = ++gid;
            Name = name;
            Balance = balance;
        }
        
        public int Id
        { get { return id; }}

        public string Name
        {
            get;
            set;
        }

        public double Balance
        {
            get  { return balance; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("balance cannot be 0 or -ve");
                    throw new Exception("balance should not be 0 and -ve");
                }
                else
                {

                    this.balance = value;
                }
            }
        }

        public void deposit(double no)
        {
            if (no <= 0)
            {
                Console.WriteLine("deposit amount cannot be zero");
            }
            else {

                Balance += no;
            }
        }
        public void withdraw(double no)
        {
            if (no <= 0)
            {
                Console.WriteLine("deposit amount cannot be zero");
            }
            else
            {
                if (Balance - no < minbal)
                {
                    Console.WriteLine("Failed,you do not have sufficient balance to withdraw");
                }
                else
                {
                    Balance -= no;
                }
            }
        }

        public void calculate_int()
        { 
            Balance += (Balance * Interestrate);
        }

        public void disp()
        {
            double b = Balance;
            calculate_int();
            double t = Balance - b;
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",this.id,Name,Balance,t); 
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            account a1 = null,a2 = null;
            
                 a1 = new account("abhijeet", 5000);
                 a1.disp();
                 a1.deposit(0);
                 try
                 {
                 a2 = new account("manu", 0);
                 }
                 catch
                {
                Console.WriteLine("inside catch");
                }
        }
    }
}
