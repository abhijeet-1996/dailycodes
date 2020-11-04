using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    class student
    {
        static int gid;
        int rollno;
        string name;
        int maths;
        int sci;
        int eng;
        int total;

        public student()
        {
            rollno = ++gid;
        }

        public string Name
        {
            get;set;
        }
        public int Maths
        {
            get;
            set;
        }

        public int Sci
        {
            get;
            set;
        }
        public int Eng
        {
            get;
            set;
        }

        public int Total
        {
            get {return total;}
            set {

                total = Maths + Eng + Sci;
            }
        }

        public override string ToString()
        {
            return Name+"\t"+Maths+"\t"+Eng+"\t"+Sci+"\t"+Total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student() { Name = "abhijeet",Maths = 60,Sci = 70,Eng = 70,Total = 0};
            student s2 = new student() { Name = "om", Maths = 90, Sci = 55, Eng = 89, Total = 0 };
            student s3 = new student() { Name = "viru", Maths = 77, Sci = 88, Eng = 99, Total = 0 };
            student s4 = new student() { Name = "shubham", Maths = 44, Sci = 66, Eng = 44, Total = 0 };
            student s5 = new student() { Name = "suraj", Maths = 50, Sci = 70, Eng = 70, Total = 0 };
            SortedList<string, student> sl = new SortedList<string, student>();
            sl.Add(s1.Name,s1);
            sl.Add(s2.Name, s2);
            sl.Add(s3.Name, s3);
            sl.Add(s4.Name, s4);
            sl.Add(s5.Name, s5);

            ICollection<student> ac = sl.Values;
            foreach(student s in ac)
            {
                Console.WriteLine(s);
            }

        }
    }
}
