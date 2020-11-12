using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace _20._1
{

     class bs
    {
        SqlConnection con;
        SqlDataAdapter ad;
        DataSet ds;
         public void insert()
        {
            string s = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            con = new SqlConnection(s);
            ad = new SqlDataAdapter("Select * from emp", con);
            ds = new DataSet();
            ad.Fill(ds, "emp");

            DataRow dr = ds.Tables["emp"].NewRow();
            //dr["id"] = 122;
            dr["name"] = "surekha";
            dr["salary"] = 40000;

            ds.Tables["emp"].Rows.Add(dr);

            SqlCommandBuilder sb = new SqlCommandBuilder(ad);
            ad.Update(ds, "emp");
            Console.WriteLine("inserted");
        }

         public void update(int id)
         {
             DataRow dr = ds.Tables["emp"].Rows.Find(id);
             dr["name"] = "rakesh";
             SqlCommandBuilder sb = new SqlCommandBuilder(ad);
             ad.Update(ds,"emp");
             Console.WriteLine("updated");
         }

         public void delete(int id)
         {
             DataRow dr = ds.Tables["emp"].Rows.Find(id);
             dr.Delete();
             SqlCommandBuilder sb = new SqlCommandBuilder(ad);
             ad.Update(ds, "emp");
             Console.WriteLine("updated");
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bs b= new bs();
            b.insert();
            b.update(1);
            //b.delete(1);
        }
    }
}
