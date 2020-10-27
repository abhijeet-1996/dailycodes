using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletone_assign4._4
{
    class singletone
    { 
        private static singletone single= null;
        private singletone(){}
        public static singletone getSingletone()
        {
            if (single == null)
                single = new singletone();
            return single;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            singletone s = singletone.getSingletone();
            singletone s1 = singletone.getSingletone();
            if (s == s1)
            {
                Console.Write("both are equals");
            }
        }
    }
}
