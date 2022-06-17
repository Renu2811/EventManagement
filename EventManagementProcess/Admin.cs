using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EventManagementProcess
{
    public class Admin
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-2PKBUH0\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";


        public string InsertEvent()
        {
            Console.WriteLine("Enter Event Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Venue:");
            string place = Console.ReadLine();

            Console.WriteLine("Enter the Food Items provided:");
            string food = Console.ReadLine();

            Console.WriteLine("Enter the Equipment provided:");
            string equipment = Console.ReadLine();

            Console.WriteLine("Enter the lighting provided:");
            string lighting = Console.ReadLine();

            Console.WriteLine("Enter the Flowers provided:");
            string flowers = Console.ReadLine();

            Console.WriteLine("Enter the Cost:");
            Double cost = Convert.ToDouble(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Event_details values(" + id + ",'" + name + "', '" + place + "' ,'" + food + "','" + equipment + "', '" + lighting + "','" + flowers + "'," + cost + ")", sqlConnection);
            sqlConnection.Open();
           int  n =cmd.ExecuteNonQuery();
            sqlConnection.Close();

            return "inserted";
        }
        public string UpdateEvent()
        {
            Console.WriteLine("Enter Event Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Venue:");
            string place = Console.ReadLine();

            Console.WriteLine("Enter the Food Items provided:");
            string food = Console.ReadLine();

            Console.WriteLine("Enter the Equipment provided:");
            string equipment = Console.ReadLine();

            Console.WriteLine("Enter the lighting provided:");
            string lighting = Console.ReadLine();

            Console.WriteLine("Enter the Flowers provided:");
            string flowers = Console.ReadLine();

            Console.WriteLine("Enter the Cost:");
            Double cost = Convert.ToDouble(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommand = new SqlCommand("update Event set EveName='" + name + "', Venue=" + place + ",Food='" + food + "',Equipment='" + equipment + "',Lighting='" + lighting + "',Flowers='" + flowers + "',Cost=" + cost + " where EveId=" + id + "", sqlConnection);
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0)
            {
                return "Not updated";
            }
            return "updated";

        }
        public string DeleteEvent(int EventId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommand = new SqlCommand("delete from Event where EveId=" + EventId, sqlConnection);
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0)
            {
                return "Not Deleted";
            }
            return "Deleted";

        }

        public DataTable SelectEvent()
        {
            #region
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select *from Event", sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion

        }

        public DataTable DisplayCutomerDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Customer", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable DisplayBookedEvent()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from BookEvent ", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close();
            return dataTable;

        }

        public string AppOrRej()
        {
            Console.WriteLine("Enter the Event Id: ");
            int eventid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer  Id: ");
            int custid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Status: ");
            string status = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Status values(" + eventid + "," + custid + ",'" + status + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return " inserted";
        }

        public DataTable DisplayStatus()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Status", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            sqlConnection.Close();
            return dataTable;
        }











    }

}

