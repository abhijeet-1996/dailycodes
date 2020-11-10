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
        public List<employee> emp()
        {
            List<employee> l = new List<employee>();
            string s = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

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

        class Program
        {
            static void Main(string[] args)
            {

                business b = new business();
                foreach (employee e in b.emp())
                {
                    Console.WriteLine(e.Id+"\t"+e.Name+"\t"+e.Salary);
                }

            }
        }
    }
}