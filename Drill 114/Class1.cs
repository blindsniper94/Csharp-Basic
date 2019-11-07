using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_114
{
    class Class1
    {
       public int NumeroUno { get; set; }
       public double NumeroDos { get; set; }
       public string numSpelledOut { get; set; }


        public static int functionUno(Class1 thisNum)
        {

            int answerUno = thisNum.NumeroUno * 2;
            Console.WriteLine(answerUno);
            Console.ReadLine();
            return(answerUno);
        }
        public static decimal functionUno(Class1 thisNum,double extraNum = 10.5)
        {
            double answerDos = thisNum.NumeroUno / thisNum.NumeroDos + extraNum;
            Console.WriteLine(answerDos);
            Console.ReadLine();
            return (Convert.ToDecimal(answerDos));
        }
        public static void functionUno(Class1 thisNum, int specialNum =5)
        {
            int spelledOut = Convert.ToInt32(thisNum.numSpelledOut);
            int answerTres = spelledOut + specialNum;
            Console.WriteLine(answerTres);
            Console.ReadLine();
        }
    }
    
}
