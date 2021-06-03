using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic;

namespace MagicBricAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            Valid val = new Valid();
            Console.WriteLine("--Register--");
            Console.Write("Enter username :");
            string userName = Console.ReadLine();
            bool validPassword;
            string password;
            Console.Write("Please Enter password :");
            password = Console.ReadLine();
            validPassword = val.IsValidPassword(password);
            while (!validPassword)
            {
                Console.Write("Please Enter proper password :");
                password = Console.ReadLine();
                validPassword = val.IsValidPassword(password);
            }
            Console.Write("Enter Phone :");
            long phone = Convert.ToInt64(Console.ReadLine());

            bool signin = val.Signin(userName, password, phone);
            Console.WriteLine("Register: {0}", signin);

            Console.WriteLine("--Login--");
            Console.Write("Enter username :");
            userName = Console.ReadLine();
            Console.Write("Enter password :");
            password = Console.ReadLine();
            Console.WriteLine("Login : " + signin);
            op.Op();
            Console.Read();
        }
    }
}
