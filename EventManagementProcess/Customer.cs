using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementProcess
{
    public class Customer
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-2PKBUH0\SQLEXPRESS;Initial Catalog=EventManagement;Integrated Security=True";

        public string InsertCustomer(int id, string name,Double mobile,string address)
        {
            

            #region disconnected mode
            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into Customer values(" + id + ",'" + name + "' ," + mobile + ",'" + address + "')", sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt); 
            return "Inserted";
            #endregion
        }
        public string UpdateCustomer(int id1, string name1, Double mobile1, string address1)
        {
           
            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("update Customer set CustName='" + name1 + "' , Mobile=" + mobile1 + " , CustAddress='" + address1 + "' where Custid=" + id1 + "", sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return "Updated";
            #endregion
        }
        public string DeleteCustomer(int custId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("delete from Customer where CustId=" + custId, sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return "Deleted";
        }
        public DataTable SelectCustomers()
        {

            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Customer", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
            #endregion
        }

        public DataTable DisplayEvent()
        {
            #region
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select *from Event_details", sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion

        }

        public string BookingEvent()
        {
            Console.WriteLine("Enter the Booking Id: ");
            int bookid = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the Customer Id: ");
            int custid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer Name: ");
            string custname = Console.ReadLine();

            Console.WriteLine("Enter the Event Id: ");
            int eventid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Name: ");
            int eventname = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Date(YY-MM-DD)");
            object date = Console.ReadLine();

            Console.WriteLine("Enter the Timings(starttime - endtime )");
            object time = Console.ReadLine();

            Console.WriteLine("Enter the Cost: ");
            Double cost = Convert.ToDouble(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into BookEvent values(" + bookid + "," + custid + ",'" + custname + "'," + eventid + ",'" + eventname + "', '" + date + "','" + time + "'," + cost + ")", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Booking is completed..";


        }

        public DataTable DisplayBookedEvent(int custid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from BookEvent where CustId=" + custid, sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;

        }

        public DataTable BookedEventStatus(int custid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Status where CustID=" + custid, sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }











    }

    }
