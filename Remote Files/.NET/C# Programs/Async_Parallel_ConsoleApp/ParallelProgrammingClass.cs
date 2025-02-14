using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Parallel_ConsoleApp
{
    internal class ParallelProgrammingClass
    {
        public void Test()
        {
            Console.WriteLine("C# For Loop");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " - " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            
        }

        public void TestParallel()
        {
            Console.WriteLine("C# Parallel For Loop");
            Parallel.For(1, 11, a =>
            {
                Console.WriteLine(a + " - " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            });
           
        }


        public long DoSomeTask()
        {
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }

            return total;
        }
    }
}
