using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace _18._4
{
    class temp
    {
        public void names(string pname)
        {
            string s = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            {
                SqlCommand sc = new SqlCommand("select * from product where name like '" + pname + "'+'%'", con);
                con.Open();
                SqlDataReader sr = sc.ExecuteReader();
                if (sr.HasRows)
                { 
                    while(sr.Read())
                    {
                        Console.WriteLine(sr["Id"]+"\t\t"+sr["Name"]+"\t\t"+sr["Qty"]+"\t\t"+sr["Price"]);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            temp t = new temp();
            t.names("t';delete from product;select * from product where name like 't");
        }
    }
}
