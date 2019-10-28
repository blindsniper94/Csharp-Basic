using System;

namespace Drill_75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int applicantAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Enter true or false.");
            string DUI = Console.ReadLine();
            bool applicantDUI = Convert.ToBoolean(DUI);

            Console.WriteLine("How many speeding tickets do you have? Ex: 12 not 'twelve'");
            string tickets = Console.ReadLine();
            int applicantTickets = Convert.ToInt32(tickets);

            bool qualify = ((applicantAge > 15) && (applicantDUI != true) && (applicantTickets < 3));

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualify);
            Console.ReadLine();

        }
    }
}
