using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class AgeException : Exception
    {
        public AgeException(string str): base(str){}

    }
}
