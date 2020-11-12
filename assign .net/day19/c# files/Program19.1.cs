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
        
        public SqlConnection getconnection()
        {
            SqlConnection sq;
            string s = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            sq = new SqlConnection(s);
            return sq;
        }
        public employee search(int i)
        {
            SqlConnection con = getconnection();
            employee e = new employee();
            SqlCommand sc = new SqlCommand("select * from emp where id = @abc",con);
            con.Open();
            sc.Parameters.AddWithValue("@abc",i);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    e.Id = Convert.ToInt32(sd["id"]);
                    e.Name = sd["name"].ToString();
                    e.Salary = Convert.ToSingle(sd["salary"]);
                    break;
                }
            }
            return e;
        }

        public List<employee> search(string nm)
        {
            List<employee> l = new List<employee>();
            SqlConnection con = getconnection();
            employee e = new employee();
            SqlCommand sc = new SqlCommand("select * from emp where name = @abc", con);
            sc.Parameters.AddWithValue("@abc", nm);
            con.Open();
            
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    e.Id = Convert.ToInt32(sd["id"]);
                    e.Name = sd["name"].ToString();
                    e.Salary = Convert.ToSingle(sd["salary"]);
                    
                    l.Add(e);
                }
            }
            return l;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            business b = new business();
            employee e1 = (employee)b.search(1);
            Console.WriteLine(e1.Id + "\t" + e1.Name + "\t" + e1.Salary);
            Console.WriteLine("-------------------------------------------------------");
            foreach (employee e in b.search("manu"))
            {
                Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Salary);
            }
           
        }
    }
}
