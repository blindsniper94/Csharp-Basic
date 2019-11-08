using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_115
{
    public class Class1
    {
        public int numbah { get; set; }

        public static void OptionalParam(Class1 num1)
        {
            double answer = num1.numbah + 10;
            Console.WriteLine(answer);
            Console.ReadLine();
            
        }
        public static void OptionalParam(Class1 num1,Class1 num2 )
        {
            double answer = num1.numbah + num2.numbah + 10;
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
