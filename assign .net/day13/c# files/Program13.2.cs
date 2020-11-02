using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class student
    {
        int _id;
        static int gid;

        public int Id
        {
            get { return _id; }
        }

        public student(string name,int marks)
        {
            _id = ++gid;
            Name = name;
            Marks = marks;
        }

        public String Name
        {
            get;set;
        }
        public int Marks
        {
            get;set;
        }

        public void give_gracemarks(int mks)
        {
            if (mks > 5)
            {
                throw new myexception("grace marks cannot be greater than 5");
            }
            else 
            {
                Marks += mks; 
            }
        }

        public override string ToString()
        {
            return Id+"\t"+Name+"\t"+Marks;
        }
    }

    class myexception : ApplicationException
    {
        String msg;

        
        public myexception(string msg)
        {

            this.msg = msg; 
        }

        public String Msg
        {
            get { return msg; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student [] s = new student[4]{new student("abc",56),new student("pqr",77),new student("xyz",35),new student("lmn",40)};

            for (int i = 0; i < 3; i++ )
            {
                s[i].give_gracemarks(4);
            }
            try
            {
                s[3].give_gracemarks(6);
            }
            catch (myexception e)
            {
                Console.WriteLine(e.Msg);
            }

            using (StreamWriter sw = new StreamWriter("manu.txt"))
            {
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(s[i]);
            }
        }
        }
    }
}
