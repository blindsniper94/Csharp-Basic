using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill_154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number!");
            int userNum = Convert.ToInt32(Console.ReadLine());
            using(StreamWriter file = new StreamWriter(@"C:\Users\Alex\Documents\TechAcademyNotes\C#\log2.txt", true))
            {
                file.WriteLine(userNum);
            }
            string text = File.ReadAllText(@"C:\Users\Alex\Documents\TechAcademyNotes\C#\log2.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
