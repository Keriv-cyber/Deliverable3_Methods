//Author: Keri Vollenweider
// Date: 2/4/2021
// Comments: The C# console application will demonstrate a method that allows user to enter their name, and the application will repeat back, Hello "Name"

using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter your First and Last Name: ");

           
           string User_Name = Console.ReadLine();

           Console.WriteLine("Thank you for inputing your First and Last Name!");
           Console.WriteLine("-------------------------------------------------");

           Console.WriteLine("Hello " + User_Name + "!");
            

       }
        
        // Using Private Void Method
        private void DisplayMessage()
        {
            Console.WriteLine("Please enter your First and Last Name: ");


            string User_Name = Console.ReadLine();

            Console.WriteLine("Thank you for inputing your First and Last Name!");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Hello " + User_Name + "!");
        }
    }
}
