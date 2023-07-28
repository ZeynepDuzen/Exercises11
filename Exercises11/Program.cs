using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercises11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // *** match the username - password and login ***

            Login();

            Console.Read();
        }

        static bool CheckInformation()
        {
            string dataUserName = "cancan";
            string dataPassword = "123*123";

            Console.WriteLine("Please enter the user name : ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter the password : ");
            string password = Console.ReadLine();

            if (dataUserName == userName && dataPassword == password)
            {
                return true;
            }
                return false;
        } 
        
        static void Login()
        {
            bool result = CheckInformation();

            if (result)
            {
                Console.WriteLine("Your login is successful");
            }
            else
            {
                Console.WriteLine("Your login is incorrect");
            }
        }
    }
}
