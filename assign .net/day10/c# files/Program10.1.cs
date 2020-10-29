using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninthone
{
    abstract class account
    {
        static int gid;
        int Id;
        string Name;
        double Balanceamt;

        static account()
        {
            Console.WriteLine("\t\t\tICICI BANK OF INDIA\n\n\n");
        }
        public account()
        {
            this.Id = ++gid;
        }
        public int id
        {
            get { return this.Id; }
        }
        public string name
        {
            get { return this.Name; }
            set
            {
                if (value.Length < 15)
                {
                    this.Name = value;
                }
                else
                {
                    throw new Exception("name cannot be greater than 15 chars");
                }
            }
        }
        public double balance
        {
            get { return this.Balanceamt; }
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("balance can not be zero");
                }
                else
                {
                    this.Balanceamt = value;
                }
            }
        }
        public void deposit(int no)
        {
            balance += no;
        }
        public abstract void withdraw(int no);

        public override string ToString()
        {
            return "\t\t\t" + this.Id + "\t" + this.Name + "\t" + this.Balanceamt;
        }
    }

    class saving : account
    {
        public saving(string nm, double bal)
        {
            name = nm;
            balance = bal;
        }
        public override void withdraw(int no)
        {
            if (no < 0 && (balance - no) >= 1000)
            {
                balance -= no;
            }
            else
            {
                throw new Exception("cannot withdraw less than one and can not withdraw bcoz ur balance is not suff ");
            }
        }
    }

    class current : account
    {
        public current(string nm, double bal)
        {
            name = nm;
            balance = bal;
        }
        public override void withdraw(int no)
        {
            if (no > 0)
            {
                balance -= no;
            }
            else
            {
                throw new Exception("cannot withdraw less than one ");
            }
        }
    }

    class udsort : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            account a = (account)x;
            account b = (account)y;
            if (x != null && y != null)
            {
                return string.Compare(a.name,b.name);
            }
            else
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            account[] arr = new account[3];
            arr[0] = new saving("xyz", 30000);
            arr[1] = new current("pqr", 80000);
            arr[2] = new saving("lmn", 90000);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n\n");
            arr[1].deposit(20000);
            arr[1].withdraw(200);
            arr[2].deposit(1000);
            // arr[2].withdraw(90500);
            Array.Sort(arr,new udsort());
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
