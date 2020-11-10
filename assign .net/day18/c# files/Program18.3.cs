using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _17._1
{
    class employee
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public float Salary
        {
            get;
            set;
        }

    }

    class business
    {
        string s = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public List<employee> emp()
        {
            List<employee> l = new List<employee>();


            using (SqlConnection con = new SqlConnection(s))
            {
                SqlCommand sc = new SqlCommand("select * from emp", con);
                con.Open();
                SqlDataReader sd = sc.ExecuteReader();

                if (sd.HasRows)
                {
                    while (sd.Read())
                    {
                        employee e = new employee();
                        e.Id = Convert.ToInt32(sd["id"]);
                        e.Name = sd["name"].ToString();
                        e.Salary = Convert.ToSingle(sd["salary"]);

                        l.Add(e);
                    }
                }
            }

            return l;
        }

        public void insorup(employee e)
        {
            using (SqlConnection sq = new SqlConnection(s))
            {
                string s1 = e.Name.ToString();
                SqlCommand sc = new SqlCommand("insert into emp values('" + s1 + "'," + e.Salary + ")", sq);
                sq.Open();
                int no = sc.ExecuteNonQuery();
                Console.WriteLine("record is updated" + no);

                sc.CommandText = "delete from emp where name like 'k'+'%'";
                sc.Connection = sq;
                no = sc.ExecuteNonQuery();
                Console.WriteLine("record is deleted" + no);

                sc.CommandText = "update emp set salary = 66000 where name = 'mansi'";
                sc.Connection = sq;
                no = sc.ExecuteNonQuery();
                Console.WriteLine("record is updated" + no);

            }
        }

        public Object maxsal()
        {
            using (SqlConnection sq = new SqlConnection(s))
            {
                SqlCommand sc = new SqlCommand("select MAX(salary) from emp", sq);
                sq.Open();
                object no = (object)sc.ExecuteScalar();
                return no;
            }  
        }
        public Object noemp()
        {
            using (SqlConnection sq = new SqlConnection(s))
            {
                SqlCommand sc = new SqlCommand("select count(id) from emp", sq);
                sq.Open();
                object no = (object)sc.ExecuteScalar();
                return no;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            business b = new business();
            foreach (employee e in b.emp())
            {
                Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Salary);
            }
            Console.WriteLine("-------------------------------------------------------");
           // b.insorup(new employee() { Id = 5, Name = "shit", Salary = 70000 });
            Console.WriteLine("max salary is "+b.maxsal());
            Console.WriteLine("no of employees are " + b.noemp());
        }
    }
}
