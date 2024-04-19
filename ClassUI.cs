using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Models
{
    public class ClassUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Your ID:");
            string UserID = Console.ReadLine();
            Console.WriteLine("Enter Your Password:");
            string Password = Console.ReadLine();

            Verification accountDetails = new Verification();
            bool result = accountDetails.Verify(UserID, Password);

            if (result)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
