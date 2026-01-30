using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Techademydailyreport
    {
    
        static void Main()


        {
            Console.WriteLine("Techademy Daily Report");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //This is a simple program that asks for your name
            Console.WriteLine("What is your name?");
            string yourname = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourname);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourcourse = Console.ReadLine();
            Console.WriteLine("Your Course: " + yourcourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pagenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are on page number: " + pagenumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\".");
            bool needhelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Need help: " + needhelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveexp = Console.ReadLine();
            Console.WriteLine("Positive experiences: " + positiveexp);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Feedback: " + feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hourstoday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours studied today: " + hourstoday);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



            //Different Data Types
            //Boolean example
            //bool isStudying = false;

            ////Byte example
            //byte hoursworked = 42;

            ////sbyte example
            //sbyte currenttempurature = -23;

            ////char example
            //char questionmark = '\u2103';

            ////decimal example
            //decimal moneyinbank = 100.5m;


            ////double example
            //double heightincentimeters = 211.456789012345;

            ////float example
            //float secondsLeft = 2.62f;

            ////short example
            //short tempuratureonMars = -341;

            ////String example
            //String myName = "Brandon";


            ////Int to String
            //int currentage = 27;
            //string yearsold = currentage.ToString();

            ////Bool to String
            //bool isRaining = true;
            //string raining = Convert.ToString(isRaining);





            //Console.WriteLine(isRaining);
            //Console.ReadLine();
        }
    }
}
 