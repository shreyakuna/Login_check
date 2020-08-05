using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Login_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the login details for verification");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Please enter the user Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the user password:");
            string password = Console.ReadLine();
            
            string connectionstring = "Data Source=localhost;Initial Catalog=databasename;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select * from login_details
                               where user_id=@id and user_password=@password";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = null;
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("User Id exists");
            }
            else {
                Console.WriteLine("Invalid user Id or password");
            }
            conn.Close();
            Console.ReadLine();

        }
    }
}
