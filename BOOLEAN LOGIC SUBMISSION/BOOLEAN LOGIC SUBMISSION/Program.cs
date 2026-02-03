using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOLEAN_LOGIC_SUBMISSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thie Program demonstrates the use of boolean logic in C# by using a simple approval program for car insurance.
            Console.WriteLine("Welcome to the Car Insurance Approval Program!");
            //ask for the user's age, DUI history, and number of speeding tickets
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer True or False.");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            // boolean logic to determine if the user is approved for car insurance
            //will only be approved if they are over 15, have no DUIs,
            //AND have 3 or fewer speeding tickets AND is older than 15 years old
            bool isApproved = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);     
            Console.WriteLine("Qualified? ");
            //output the result to the user
            Console.WriteLine(isApproved);
            Console.ReadLine();
        }
    }
}
