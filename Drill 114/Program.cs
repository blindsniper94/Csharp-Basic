using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_114
{
    class Program
    {
        int num1 = 17;
        static void Main(string[] args)
        {
            Class1 thisNum = new Class1();
            thisNum.NumeroDos = 2.5;
            thisNum.NumeroUno = 12;
            thisNum.numSpelledOut = "8";
            Class1.functionUno(thisNum);
            Class1.functionUno(thisNum,10);
            Class1.functionUno(thisNum,18);
            Console.ReadLine();
            
        }
    }
}
