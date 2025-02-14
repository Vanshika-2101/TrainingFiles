using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Async_Parallel_ConsoleApp
{

    internal class Program
    {

        public static void Method1()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 1 completed by thread {Thread.CurrentThread.ManagedThreadId}");
        }

        public static void Method2()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 2 completed by thread {Thread.CurrentThread.ManagedThreadId}");
        }

        public static void Method3()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 3 completed by thread {Thread.CurrentThread.ManagedThreadId}");
        }

        static void DoTask(int number)
        {
            Console.WriteLine($"DoSTask {number} started by Thread {Thread.CurrentThread.ManagedThreadId}");
            //Sleep for 5000 milliseconds
            Thread.Sleep(5000);
            Console.WriteLine($"DoTask {number} completed by Thread {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Main Started");
            //AsynchronousClass.Test();
            //Console.WriteLine("Main Ended");
            //Console.ReadKey();
            Console.WriteLine("Main Started");
            AsynchronousClass ac = new AsynchronousClass();
            ac.FetchInfo();
            Console.WriteLine("Main Ended");
            Console.ReadKey();




            //Stopwatch sw = new Stopwatch();
            //Console.WriteLine("Stopwatch started");
            //sw.Start();
            //Method1();
            //Method2();
            //Method3();
            //sw.Stop();
            //Console.WriteLine("Stopwatch Stopped");
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);


            //Console.WriteLine("Stopwatch started");
            //sw.Restart();
            //Parallel.Invoke(Method1, Method2,Method3, ()=>
            //{
            //    Console.WriteLine($"Method 4 by thread {Thread.CurrentThread.ManagedThreadId}");
            //});
            //sw.Stop();
            //Console.WriteLine("Stopwatch Stopped");
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);

            //Allowing three task to execute at a time
            //ParallelOptions parallelOptions = new ParallelOptions
            //{
            //    MaxDegreeOfParallelism = 3
            //};
            //Parallel.Invoke(parallelOptions,
            //        () => DoTask(1),
            //        () => DoTask(2),
            //        () => DoTask(3),
            //        () => DoTask(4),
            //        () => DoTask(5),
            //        () => DoTask(6),
            //        () => DoTask(7)
            //    );
            //Console.ReadKey();



            //ParallelProgrammingClass pp = new ParallelProgrammingClass();
            //pp.Test();
            //pp.TestParallel();

            //ParallelOptions dop = new ParallelOptions()
            //{
            //    MaxDegreeOfParallelism = 5
            //};

            //Stopwatch sw = new Stopwatch();
            //Console.WriteLine("Stopwatch started");
            //sw.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(pp.DoSomeTask() + " " + Thread.CurrentThread.ManagedThreadId);
            //}
            //sw.Stop();
            //Console.WriteLine("Stopwatch stopped");
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);
            //sw.Restart();
            //Parallel.For(1, 11, dop, a =>
            //{
            //    Console.WriteLine(pp.DoSomeTask() + " " + Thread.CurrentThread.ManagedThreadId);
            //});
            //Console.WriteLine("Stopwatch stopped");
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);
            //sw.Stop();
            //sw.Restart();
            //List<int> list = Enumerable.Range(1, 10).ToList();
            //foreach (int i in list)
            //{
            //    Console.WriteLine(pp.DoSomeTask() + " " + Thread.CurrentThread.ManagedThreadId);
            //}
            //sw.Stop();
            //Console.WriteLine("Stopwatch stopped");
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);
            //sw.Restart();

            //Parallel.ForEach(list, a =>
            //{
            //    Console.WriteLine(pp.DoSomeTask() + " " + Thread.CurrentThread.ManagedThreadId);
            //});
            //sw.Stop();
            //Console.WriteLine("Stopwatch stopped");
            //Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);


        }
    }
}
