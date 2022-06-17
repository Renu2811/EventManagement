using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementProcess
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            SuperAdmin superadmin = new SuperAdmin();
            Admin admin = new Admin();
            
            
            Console.WriteLine("Press 1 for SuperAdmin");
            Console.WriteLine("Press 2 for Admin");
            Console.WriteLine("Press 3 for Customer");
            int re = Convert.ToInt32(Console.ReadLine());
            switch (re)
            {
                case 1:
                    Console.WriteLine("press 1 to Insert Admin");
                    Console.WriteLine("press 2 to Update Admin");
                    Console.WriteLine("press 3 to delete Admin");
                    Console.WriteLine("press 4 to Select Admin");
                    int g = Convert.ToInt32(Console.ReadLine());
                    switch (g)
                    {
                        case 1:
                            string insert = superadmin.InsertAdmin();
                            Console.WriteLine(insert);
                            break;

                        case 2:
                            string update = superadmin.UpdateAdmin();
                            Console.WriteLine(update);
                            break;

                        case 3:
                            Console.WriteLine("Enter the Admin Id to Delete the Admin: ");
                            int Aid = Convert.ToInt32(Console.ReadLine());
                            string Delete = superadmin.DeleteAdmin(Aid);
                            Console.WriteLine(Delete);
                            break;

                        case 4:
                            DataTable dt = superadmin.SelectAdmin();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;

                        
                        
                        default:
                            Console.WriteLine("enter a valid number");
                            break;
                    }
                    break;



                case 2:
                    Console.WriteLine("press 1 to Insert Event");
                    Console.WriteLine("press 2 to Update Event");
                    Console.WriteLine("press 3 to delete Event");
                    Console.WriteLine("press 4 to Select Event");
                    Console.WriteLine("press 5 to display customer details");
                    Console.WriteLine("press 6 to display booked events");
                    Console.WriteLine("press 7 to add approved or rejected");
                    Console.WriteLine("press 8 to display Status");
                    int h = Convert.ToInt32(Console.ReadLine());
                    switch (h)
                    {
                        case 1:
                            string insert = admin.InsertEvent();
                            Console.WriteLine(insert);
                            break;

                        case 2:
                            string update = admin.UpdateEvent();
                            Console.WriteLine(update);
                            break;

                        case 3:
                            Console.WriteLine("Enter the Event ID to Delete the Event:");
                            int Eid = Convert.ToInt32(Console.ReadLine());
                            string Delete = admin.DeleteEvent(Eid);
                            Console.WriteLine(Delete);
                            break;

                        case 4:
                            DataTable dt = admin.SelectEvent();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;

                        

                        case 5:
                            DataTable dt2 = admin.DisplayCutomerDetails();
                            if (dt2.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt2.Columns.Count; j++)
                                {
                                    Console.Write(dt2.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 6:
                            DataTable dt3 = admin.DisplayBookedEvent();
                            if (dt3.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt3.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt3.Columns.Count; j++)
                                {
                                    Console.Write(dt3.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 7:
                            string add = admin.AppOrRej();
                            Console.WriteLine(add);
                            break;

                        case 8:
                            DataTable dt4 = admin.DisplayStatus();
                            if (dt4.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt4.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt4.Columns.Count; j++)
                                {
                                    Console.Write(dt4.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;
                        default:
                            Console.WriteLine("enter a valid number");
                            break;


                    }
                    break;

                case 3:
                    Console.WriteLine("press 1 to Insert Customer");
                    Console.WriteLine("press 2 to Update Customer");
                    Console.WriteLine("press 3 to delete Customer");
                    Console.WriteLine("press 4 to display event");
                    Console.WriteLine("press 5 to book event");
                    Console.WriteLine("press 6 to display booked event");
                    Console.WriteLine("press 7 to display booked event status");

                    int t = Convert.ToInt32(Console.ReadLine());
                    switch (t)
                    {
                        case 1:
                            Console.Write("Enter Customer Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Customer name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Customer Mobile: ");
                            Double mobile = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Customer address : ");
                            string address = Console.ReadLine();

                            string Added = customer.InsertCustomer(id,name,mobile,address);
                            Console.WriteLine(Added);
                            break;

                        case 2:
                            Console.Write("Enter Customer Id: ");
                            int id1= Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Customer name: ");
                            string name1 = Console.ReadLine();

                            Console.Write("Enter Customer Mobile: ");
                            Double mobile1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Customer address : ");
                            string address1= Console.ReadLine();

                            string updated = customer.UpdateCustomer(id1,name1,mobile1,address1);
                            Console.WriteLine(updated);
                            break;

                        case 3:
                            Console.Write("Enter Customer Id: ");
                            int id2 = Convert.ToInt32(Console.ReadLine());

                            string deleted = customer.DeleteCustomer(id2);
                            Console.WriteLine(deleted);
                            break;


                        case 4:
                            DataTable dt = customer.DisplayEvent();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 5:
                            Console.WriteLine("");
                            string Booked = customer.BookingEvent();
                            Console.WriteLine(Booked);
                            break;


                        case 6:
                            Console.WriteLine("Enter the customer Id to get the booked event: ");
                            int custid = Convert.ToInt32(Console.ReadLine());
                            DataTable dt1 = customer.DisplayBookedEvent(custid);
                            if (dt1.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt1.Columns.Count; j++)
                                {
                                    Console.Write(dt1.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;


                     

                        case 7:
                            Console.WriteLine("Enter the Customer id to Get Status of the BookedEvent: ");
                            int custid1 = Convert.ToInt32(Console.ReadLine());
                            DataTable dt2 = customer.BookedEventStatus(custid1);
                            if (dt2.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt2.Columns.Count; j++)
                                {
                                    Console.Write(dt2.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            break;

                     
                        default:
                            Console.WriteLine("enter a valid number");
                            break;

                    }
                    break;

            }

            Console.ReadLine();
        }
    }
}