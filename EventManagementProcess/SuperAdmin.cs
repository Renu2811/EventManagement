using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementProcess
{
    public  class SuperAdmin
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-2PKBUH0\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";


        public string InsertAdmin()
        {
            Console.WriteLine("Enter Admin Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Admin Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Admin Role:");
            string Role = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Admin values(" + id + ",'" + Name + "','" + Role + "')", sqlConnection);
            sqlConnection.Open();
            int num = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0)
            {
                return "Not Inserted";
            }
            return "Inserted";
        }
        public string UpdateAdmin()
        {
            Console.WriteLine("Enter the Admin Id to be upadated:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new Admin Name to be upadated :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the new Admin Role to be upadated:");
            string Role = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("update Admin set AdmName='" + Name + "', AdmRole='" + Role + "' where AdmId=" + id + "", sqlConnection);
            sqlConnection.Open();
            int num = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0)
            {
                return "Not Updated";
            }
            return "Updated";

        }
        public string DeleteAdmin(int adminId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("delete from Admin where AdmId=" + adminId, sqlConnection);
            sqlConnection.Open();
            int num = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0)
            {
                return "Not Deleted";
            }
            return "Deleted";

        }

        public DataTable SelectAdmin()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("select * from Admin", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close();
            return dataTable;
        }



    }
}
    
   
