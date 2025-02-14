using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class SealedClass
    {
        public virtual void DisplayDetails()
        {
            Console.WriteLine("displayDetails method of class SealedClass");
        }
    }

    internal class B : SealedClass
    {
        public override sealed void DisplayDetails()
        {
            Console.WriteLine("displayDetails method of class B");
        }
    }

    internal class C : B
    {
        public void DisplayDetails()
        {
            Console.WriteLine("displayDetails method of class C");
        }
    }
}