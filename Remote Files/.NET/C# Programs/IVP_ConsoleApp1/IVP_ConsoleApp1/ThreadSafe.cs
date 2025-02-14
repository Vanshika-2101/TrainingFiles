using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class ThreadSafe
    {
        static ConcurrentDictionary<int, string> data = new ConcurrentDictionary<int, string>();
        public static void Method1()
        {
            for (int i = 0; i <= 100; i++)
            {
                data.TryAdd(i, "Added by Method1 " + i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i <= 100; i++)
            {
                data.TryAdd(i, "Added by Method2 " + i);
            }
        }

        public static void Method3()
        {
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
