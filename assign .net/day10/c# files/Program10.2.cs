using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenthtwo
{
    class students
    {
        private int _rollnumber;
        private static int gid;
        public students()
        {
            this._rollnumber = ++gid;
        }

        public int Rollnumber
        {
            get { return _rollnumber; }
        }
        public string Name
        {
            get;
            set;
        }

        public double Marks
        {
            get;
            set;
        }
    }

    class school : IEnumerable
    {
        students [] s = new students[4];
        static school()
        {
            Console.WriteLine("Jay Bharat Vidyalay, vasagade");
        }
        public school()
        {
            s[0] = new students() { Name = "abhijeet", Marks = 99};
            s[1] = new students() { Name = "omkar", Marks = 98 };
            s[2] = new students() { Name = "shree", Marks = 99 };
            s[3] = new students() { Name = "bunty", Marks = 96 };
        }
        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return s.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            school s = new school();

            foreach(students a in s)
            {
                Console.WriteLine(a.Rollnumber+"\t"+a.Name+"\t"+a.Marks);
            }

            IEnumerator i = s.GetEnumerator();
            while (i.MoveNext())
            {
                students z = (students)i.Current;
                Console.WriteLine(z.Rollnumber + "\t" + z.Name + "\t" + z.Marks);
            }
        }
    }
}
