using System;
using System.Data.SqlClient;

namespace ADO.Net_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstr = "Integrated Security=False;Server=.\\SqlExpress;uid=sa;password=pass@123;database=Shopify";
            using (SqlConnection con = new SqlConnection(connectionstr))
                try
                {
                    con.Open();
                    Console.WriteLine("connection Opened");
                    //SqlCommand cmd = new SqlCommand("select * from movies order by director ", con);
                    //var reader = cmd.ExecuteReader();
                    //while(reader.Read())
                    //{
                    //    Console.WriteLine($"{ reader["moviename"]}");
                    //}
                    //SqlCommand cmd = new SqlCommand("select Count(*) from movies  ", con);
                    //var totalitems=cmd.ExecuteScalar();
                    //Console.WriteLine(totalitems);
                    //string name = "Kiladi";
                    //string direct= "djsf";
                    //int collection = 834;
                    //string rev = "sjhg";
                    //SqlCommand cmd = new SqlCommand("insert into movies(moviename, director,collections ,review)" + "values(@moviename,@director,@collections,@review) " , con);
                    //cmd.Parameters.AddWithValue("@moviename", name);
                    //cmd.Parameters.AddWithValue("@director", direct);
                    //cmd.Parameters.AddWithValue("@collections", collection);
                    //cmd.Parameters.AddWithValue("@review", rev);

                    //int rowsaffected=cmd.ExecuteNonQuery();
                    //Console.WriteLine("added records successfully");
                    // Console.WriteLine("enter the movie name");
                    //string name = Console.ReadLine();
                    //SqlCommand cmd = new SqlCommand("delete from movies where moviename=@Name",con);
                    //cmd.Parameters.AddWithValue("@Name",name);
                    //int rowsaffected = cmd.ExecuteNonQuery();
                    //if(rowsaffected>0)
                    //{
                    //    Console.WriteLine("added records successfully");
                    //}
                    SqlCommand cmd = new SqlCommand("prcAddCustomer", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", 201);
                    cmd.Parameters.AddWithValue("@customername", "charan");
                    cmd.Parameters.AddWithValue("@age", 25);
                    cmd.Parameters.AddWithValue("@email", "charandhoni97@gmail.com");
                    cmd.Parameters.AddWithValue("@phone", 824);

                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected > 0)
                    {
                        Console.WriteLine("added records successfully");
                    }

                }
                catch (Exception excp)
                {
                    Console.WriteLine($"Error while connecting:{excp.Message}");
                }


        }
    }
}
