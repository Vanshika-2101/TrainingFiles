using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal interface ICalc
    {
        void Addition(int a, int b);
    }

    internal interface ISciCalc
    {
        void Addition(int a, int b);
        void Subtraction(int a, int b);

    }
    internal class IVPCalc : ICalc, ISciCalc 
    {
        void ICalc.Addition(int a, int b)
        {
            Console.WriteLine("Normal Calc Addition: " + (a + b));
        }

        void ISciCalc.Addition(int a, int b)
        {
            Console.WriteLine("Scientific Calc Addition: " + (a + b));
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine("Scientific Calc Subtraction: " + (a - b));
        }
    }
}
