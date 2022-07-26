using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connectionstr = "Integrated Security=False;Server=.\\SqlExpress;uid=sa;password=pass@123;database=CGITraining";
            SqlConnection con = new SqlConnection(connectionstr);
            SqlCommand cmd = new SqlCommand("select * from movies", con);
            DataTable moviestable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(moviestable);
            con.Close();
            foreach (DataRow movie in moviestable.Rows)
                Console.WriteLine($"{movie["moviename"]}");
        }
    }
}
