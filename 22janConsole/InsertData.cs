using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22janConsole
{
    public  class InsertData
    {
      
       
        static SqlConnection Connect() {
            string str = ConfigurationManager.ConnectionStrings["constr"].ToString();
            SqlConnection conn = new SqlConnection(str);
            return conn;
        } 
        public void InsertEmpData()
        {
            SqlConnection cn= Connect();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "insert into employeedetails values(@id,@empName,@salary,@city)";

            SqlParameter Pid = new SqlParameter("@id",SqlDbType.Int);
            Pid.SourceColumn = "empId";
            Console.WriteLine("Enter Employee Id");
            Pid.Value=Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.Add(Pid);

            SqlParameter PName = new SqlParameter("@empName", SqlDbType.Char, 20, "empName");
            Console.WriteLine("Enter Employee Name");
            PName.Value = Console.ReadLine();
            cmd.Parameters.Add(PName);

            SqlParameter Psal = new SqlParameter("@salary", SqlDbType.Float);
            Psal.SourceColumn = "salary";
            Console.WriteLine("Enter Employee Salary");
            Psal.Value = float.Parse(Console.ReadLine());
            cmd.Parameters.Add(Psal);

            SqlParameter PCity = new SqlParameter("@city", SqlDbType.VarChar,20, "city");
            Console.WriteLine("Enter Employee city");
            PCity.Value = Console.ReadLine();
            cmd.Parameters.Add(PCity);
            try { cmd.ExecuteNonQuery(); Console.WriteLine("1 Row Affected"); } 
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            
           
        }
        public  void UpdateEmp()
        {
            using (SqlConnection c= Connect()) {
                c.Open();
                try
                {
                SqlCommand cmd = new SqlCommand("update employeedetails set empName=@empName,salary=@salary,city=@city where empId=@empId",c);
                Console.WriteLine("Enter Employee id to update ");
                int id= Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.AddWithValue("@empId", id);

                Console.WriteLine("Enter Employee Name to update ");
                string name =Console.ReadLine();
                cmd.Parameters.AddWithValue("@empName", name);

                Console.WriteLine("Enter Employee Salary to update ");
                float salary =float.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@salary", salary);

                Console.WriteLine("Enter Employee City to update ");
                string city =Console.ReadLine();
                cmd.Parameters.AddWithValue("@city", city);

               
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("updated successfully");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        public void DeleteEmp() {
            using (SqlConnection c = Connect())
            {
                try { 
                c.Open();
                SqlCommand cmd = new SqlCommand("delete employeedetails where empId=@empId", c);
                Console.WriteLine("Enter Employee id to Delete ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.AddWithValue("@empId", id);
                int x = cmd.ExecuteNonQuery();
                Console.WriteLine(x + "data deleted");
                } 
                catch(Exception ex) { Console.WriteLine(ex.Message); }
        }
        }
    }

}
   

