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
         while (true)
            {
                Console.WriteLine("Enter your choice:\n1 Insert\n2 Update\n3 Get All Data\n4 Delete\n5 Exit");
                int n=int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            id.InsertEmpData();break;
                        }
                        case 2:
                        {
                            id.UpdateEmp();break;
                        }
                        case 3:
                        {
                            id.DisplayAll();break;
                        }
                        case 4:
                        {
                            id.DeleteEmp();break;
                        }
                        case 5: { Environment.Exit(0); break; }
                        default: { Console.WriteLine("Enter correct chioce"); break; }
                }
            }
          
        }
    }
}
