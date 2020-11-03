using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
namespace ninthone
{
    [Serializable]
    abstract partial class account
    {
        static int gid;
        int Id;
        string Name;
        double Balanceamt;
    }
    partial class account
    {
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
                this.Balanceamt = value;
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

    [Serializable]
    class saving : account
    {
        public saving(string nm, double bal)
        {
            if (bal < 0)
            {
                throw new Exception("balance can not be zero");
            }
            else
            {
                name = nm;
                balance = bal;
            }
        }
        public override void withdraw(int no)
        {
            if (no > 0 && (balance - no) >= 1000)
            {
                balance -= no;
            }
            else
            {
                throw new Exception("Insufficient balance");
            }
        }
    }

    [Serializable]
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

    static class serial
    {
        public static void saveObj(Object ob, String s)
        {
            SoapFormatter sf = new SoapFormatter();
            using (Stream st = new FileStream(s, FileMode.Create, FileAccess.Write))
            {
                sf.Serialize(st,ob);
            }

        }

        public static void getObj(String s)
        {
            SoapFormatter sf = new SoapFormatter();
            using (Stream st = new FileStream(s, FileMode.Open))
            {
                account[] ac = (account[]) sf.Deserialize(st);
                foreach (account a in ac)
                {
                    Console.WriteLine(a);
                }
            }

        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            account[] arr = new account[3];
            try
            {

                arr[0] = new saving("xyz", 30000);
            }
            catch
            {
                Console.WriteLine("inside catch");
            }
            try
            {

                arr[1] = new current("pqr", 80000);
            }
            catch
            {
                Console.WriteLine("inside catch 1");
            }

            arr[2] = new saving("lmn", 90000);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n\n");

            arr[1].deposit(20000);
            arr[1].withdraw(200);
            arr[2].deposit(1000);
            try
            {
                arr[0].withdraw(29500);
            }
            catch
            {
                Console.WriteLine("insufficient Balance");
            }

           serial.saveObj(arr,"abc.soap");
           serial.getObj("abc.soap");
           
        }
    }
}
