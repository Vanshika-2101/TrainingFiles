namespace ThreadConsoleApp
{
    internal class StudentData
    {
        public void GetStudentDetails()
        {
            Console.WriteLine("Read Student Details");
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Write Student Details");
        }
    }
    internal class Program
    {
        public static void Method1()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method - 1 - {i}");
                //Thread.Sleep(1000);
            }
        }

        public static void Method2()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method - 2 - {i}");
                if (i == 3)
                {
                    Console.WriteLine("DB operation started");
                    Thread.Sleep(5000);
                    Console.WriteLine("DB operation completed");
                }
            }
        }

        public static void Method3()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method - 3 Read - {i}");
            }
        }

        public static void Method4()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Method - 4 Write - {i}");
            }
        }

        public static void Display(object x)
        {
            int v = (int)x;
            for (int i = 0;i < v; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " +i);
            }
        }

        public static void Method5()
        {
            lock (lockObject)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Console.WriteLine("Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("World of dot net");
            }
        }

        static object lockObject = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(Method5)
            {
                Name = "Thread 1",
                Priority = ThreadPriority.Normal
            };
            Thread t2 = new Thread(Method5)
            {
                Name = "Thread 2",
                Priority = ThreadPriority.Normal
            };
            Thread t3 = new Thread(Method5)
            {
                Name = "Thread 3",
                Priority = ThreadPriority.Normal
            };

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main thread ended");

            //Console.WriteLine("Main thread started");

            //Thread t1 = new Thread(Display);
            //Thread t2 = new Thread(Display);
            //Thread t3 = new Thread(Display);

            //t1.Name = "T1";
            //t2.Name = "T2";
            //t3.Name = "T3";

            //Console.WriteLine(t1.Priority);
            //Console.WriteLine(t2.Priority);
            //Console.WriteLine(t3.Priority);

            //t1.Priority = ThreadPriority.Lowest;
            //t3.Priority = ThreadPriority.Highest;

            //Console.WriteLine(t1.Priority);
            //Console.WriteLine(t2.Priority);
            //Console.WriteLine(t3.Priority);

            //t1.Start(3000);
            //t2.Start(3000);
            //t3.Start(3000);

            //Console.WriteLine("Main thread end");

            //Console.WriteLine("Main thread started");
            //ThreadStart ts1 = new ThreadStart(Method1);
            //Thread t1 = new Thread(ts1);
            //Console.WriteLine("Is the thread Background?: " + t1.IsBackground);
            //t1.IsBackground = true;
            //Console.WriteLine("Is the thread Background?: " + t1.IsBackground);
            //Console.WriteLine(t1.IsAlive);
            //t1.Start();
            //Thread.Sleep(10000);
            //Console.WriteLine("Main thread ended");
            //Console.WriteLine(t1.IsAlive);


            //Console.WriteLine("Main thread started");
            //Thread t1 = new Thread(new ThreadStart(Method1));
            //Thread t2 = new Thread(delegate ()
            //{
            //    Console.WriteLine("This is an anonymous function executed by a delegate");
            //});
            //Thread t3 = new Thread(()=>
            //{
            //    Console.WriteLine("This is an anonymous function executed by a thread itself; arrow syntax");
            //});

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Console.WriteLine("Main thread ended");


            //Console.WriteLine("Main thread started");
            //ThreadStart del1 = new ThreadStart(Method1);
            //ThreadStart del2 = new ThreadStart(Method2);
            //ThreadStart del3 = new ThreadStart(Method3);
            //del3 += new ThreadStart(Method4);
            //StudentData obj = new StudentData();
            //ThreadStart del4 = new ThreadStart(obj.GetStudentDetails);
            //del4 += new ThreadStart(obj.DisplayStudentDetails);

            //Thread t1 = new Thread(del1);
            //Thread t2 = new Thread(del2);
            //Thread t3 = new Thread(del3);
            //Thread t4 = new Thread(del4);
            //t1.Name = "Thread 1";
            //t2.Name = "Thread 2";
            //t3.Name = "Thread 3";
            //t4.Name = "StudentThread";

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //Console.WriteLine("Main thread ended");


        }
    }
}
