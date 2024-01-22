using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22janConsole
{
    internal class Program
    {//Data Source=LAPTOP-SG7H0DO8;Initial Catalog=Employee;Integrated Security=True;Encrypt=False
        static void Main(string[] args)
        {
          InsertData id=new InsertData();
          
            id.DeleteEmp();
            Console.ReadLine();
        }
    }
}
