using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = @"Data Source=(localdb)\Projects;Initial Catalog=demo;Integrated Security=True";
            
            using(SqlConnection con = new SqlConnection(s))
            {
                SqlCommand sc = new SqlCommand("select * from emp",con);
                con.Open();
                SqlDataReader sd = sc.ExecuteReader();

                if (sd.HasRows)
                { 
                    while(sd.Read())
                    {
                        Console.WriteLine(sd["id"]+"\t\t"+sd["name"]+"\t\t"+sd["salary"]);
                    }
                }
            }
        }
    }
}
