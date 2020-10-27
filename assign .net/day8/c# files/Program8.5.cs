using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eightfifth
{
    class animal
    {
        public virtual string speak()
        {
            return " I don’t know how to speak";
        }
    }

    class dog : animal
    {
        public override string speak()
        {
            return "bhow bhow";
        }
    }

    class cat : animal
    {
        public override string speak()
        {
            return "myav myav";
        }
    }

    class donkey : animal
    { }

    class showpoly
    {
        public void call(animal a)
        {
            Console.WriteLine(a.speak());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            showpoly s = new showpoly();
            s.call(new dog());
            s.call(new cat());
            s.call(new donkey());
        }
    }
}
