using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    internal class Program
    {
        static void Main()
        {
            decimal Person1HourlyRate = 15.20m;
            int Person1WeeklyHours = 23;
            decimal Person2HourlyRate = 17.00m;
            int Person2WeeklyHours = 48;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: " + Person1HourlyRate);
            Console.WriteLine("Hours worked per week: " + Person1WeeklyHours);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: " + Person2HourlyRate);
            Console.WriteLine("Hours worked per week: " + Person2WeeklyHours);
            Console.ReadLine();

            float AnnualSalaryPerson1 = (float)(Person1HourlyRate * Person1WeeklyHours * 52);
            Console.WriteLine("Annual Salary of Person 1: " + AnnualSalaryPerson1);
            Console.ReadLine();

            float AnnualSalaryPerson2 = (float)(Person2HourlyRate * Person2WeeklyHours * 52);
            Console.WriteLine("Annual Salary of Person 2: " + AnnualSalaryPerson2);
            Console.ReadLine();

            bool DoesPerson1MakeMore = AnnualSalaryPerson1 > AnnualSalaryPerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + DoesPerson1MakeMore);
            Console.ReadLine();


        }
    }
}
