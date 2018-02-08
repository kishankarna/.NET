using System;

using System.Data.SqlClient;

namespace CSharpConsole.ADO.NET
{
    class AdoConn
    {
        static string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
        static SqlConnection cn = null;

        static SqlCommand cmd = null;
        static string query = string.Empty;

        static void Main(string[] args)
        {
            Console.WriteLine("This  is an example for ADO.NET Connection");
            cn = new SqlConnection(cs);
            cn.Open();
            Console.WriteLine("Connection established succesfully");

            query = "select * from Movies";
            cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("ID  Movi Name Duration  Date&Time");
            while(dr.Read())
            //if(dr.Read())
                Console.WriteLine(" {0} {1} {2} {3}",dr[0].ToString(),dr[1]," "+dr[2],"    "+dr[3]);
            Console.ReadKey();
            
        }
    }
}
