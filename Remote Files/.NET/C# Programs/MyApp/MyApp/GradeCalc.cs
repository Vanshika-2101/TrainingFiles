using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class GradeCalc
    {
        public string GetGradeByPercentage(int percentage)
        {
            if (percentage >= 90 & percentage <= 100)
                return "A";
            if (percentage >= 80 & percentage < 90)
                return "B";
            if (percentage >= 70 & percentage < 80)
                return "C";
            if (percentage >= 60 & percentage < 70)
                return "D";
            if (percentage >= 50 & percentage < 60)
                return "F";
            else
                return "Invalid";
        }
    }
}
