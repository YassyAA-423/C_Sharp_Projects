using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is a simple console progam that collects daily report information from a student
namespace TechAcademyReport
{
    internal class DailyReport
    {
        static void Main()
        {
            Console.WriteLine("Techademy Daily Report");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //This is a program/question asks for your name
            Console.WriteLine("What is your name?");
            string yourname = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourname);
            Console.ReadLine();


            //This is a program/question asks what course you are on
            Console.WriteLine("What course are you on?");
            string yourcourse = Console.ReadLine();
            Console.WriteLine("Your Course: " + yourcourse);
            Console.ReadLine();

            //This is a program/question asks for the page number
            Console.WriteLine("What page number?");
            int pagenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are on page number: " + pagenumber);
            Console.ReadLine();

            //This is a program/question asks if you need help
            Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\".");
            bool needhelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Need help: " + needhelp);
            Console.ReadLine();

            //This is a program/question asks if you had any positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveexp = Console.ReadLine();
            Console.WriteLine("Positive experiences: " + positiveexp);
            Console.ReadLine();

            //This is a program/question asks if you had any other feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Feedback: " + feedback);
            Console.ReadLine();

            //This is a program/question asks how many hours you studied 
            Console.WriteLine("How many hours did you study today?");
            int hourstoday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours studied today: " + hourstoday);
            Console.ReadLine();

            //This is a program simply thanks you for your answers
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
 