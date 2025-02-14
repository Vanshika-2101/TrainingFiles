using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class LambdaClass
    {
        public void Method1()
        {
            int[] data = { 3, 2, 4, 5, 7, 8, 9, 0, 11, 10, 8, 21 };
            var info = data.TakeWhile(x => x < 10);
            Console.WriteLine(string.Join(" ",info));
        }

        public void Method2()
        {
            List<int> data = new List<int>() { 3, 2, 4, 5, 7, 8, 9, 0, 11, 10, 8, 21 };
            List<int> info = data.FindAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", info));
        }

        public void Method3()
        {
            List<int> data = new List<int>() { 3, 2, 4, 5, 7, 8, 9, 0, 11, 10, 8, 21 };
            List<int> info = data.Select(x => x * x).ToList();
            Console.WriteLine(string.Join(" ", info));
        }

        public void Method4()
        {
            List<int> data = new List<int>() { 3, 2, 4, 5, 7, 8, 9, 0, 11, 10, 8, 21 };
            List<int> info = data.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", info));
        }

    }
}
