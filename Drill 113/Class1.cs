using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_113
{
    public class ClassOfNumbers
    {
        public int NumeroUno { get; set; }
        
        public static void TwoNumbersToTango(ClassOfNumbers Numero1, ClassOfNumbers Numero2)
        {
            Console.WriteLine("This function is inside a class");
            int NumeroTres = Numero1.NumeroUno + Numero2.NumeroUno;
            Console.WriteLine(NumeroTres);
        }
    }
}
