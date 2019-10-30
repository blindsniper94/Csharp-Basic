using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_97
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "alex";
            name = name.ToUpper();
            string greeting = "Hello!";
            string day = " I wish it wasn't snowing so ****ing much";
            string sentence = (greeting + name + day);
            Console.WriteLine(sentence);
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("But NOOOO");
            
            paragraph.Append("\nit just keeps snowing");
            
            paragraph.Append("\nand getting colder");
            
            paragraph.Append("\nand it shuts my power off every so often.");
            Console.WriteLine(paragraph);
            Console.ReadLine();

        }
    }
}
