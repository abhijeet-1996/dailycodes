using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace _19._3
{
    class business
    {
        public void disp()
        {
            
            string s = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            {
                SqlDataAdapter sa = new SqlDataAdapter("select * from emp",con);
                DataSet ds = new DataSet();
                sa.Fill(ds);
                ds.Tables[0].TableName = "emp";
                DataTable dt = ds.Tables["emp"];
                foreach(DataRow row in dt.Rows)
                {
                    foreach(DataColumn cl in dt.Columns)
                    {
                        Console.Write(row[cl]+"\t\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            business b = new business();
            b.disp();
        }
    }
}
