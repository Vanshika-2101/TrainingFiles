using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class LoopsAndConstructs
    {
        public void ConstructIfElse()
        {
            int a = 10, b = 20;
            if (a > b)
            {
                Console.WriteLine($"a = {a} is greater than b = {b}");
            }
            else
            {
                Console.WriteLine($"b = {b} is greater than a = {a}");
            }
        }

        public void ConstructElseIf ()
        {
            int a=30, b=40, c=15;
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine($"{a} is the greatest");
                else
                    Console.WriteLine($"{c} is the greatest");
            }
            else
            {
                if (b > c)
                    Console.WriteLine($"{b} is the greatest");
                else
                    Console.WriteLine($"{c} is the greatest");
            }
        }

        public void SwitchCase()
        {
            char a;
            Console.WriteLine("Enter values for creating account: \n1 for Savings account, \n2 for Current account, \n3 for Joint account:  ");
            a = Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case '1':
                    Console.WriteLine("Savings account opened.");
                    break;
                case '2':
                    Console.WriteLine("Current account opened.");
                    break;
                case '3':
                    Console.WriteLine("Joint account opened.");
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }

        public void WhileDemo()
        {
            int i = 0;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileDemo()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }

        public void ForDemo()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void EvenOdd()
        {
            int i = 0;
            for (i = 0; i <= 10; i+=2)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                }
                else
                    Console.WriteLine($"{i} is Odd");
            }

            i= 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                }
                else
                    Console.WriteLine($"{i} is Odd");
                i++;
            }

            i= 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                }
                else
                    Console.WriteLine($"{i} is Odd");
                i++;
            } while (i <= 10);
        }

        public void TableOfSeventeen()
        {
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"17 * {i} = "+ 17*i);
            }
        }

        public void TableOfNum(int num)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} * {i} = { num * i }");
            }
        }

        public void Fibonacci(int n)
        {
            int f = 0, s = 1;
            Console.Write(f +" "+ s+ " ");
            for (int i = 2; i < n; i++)
            {
                int t = f + s;
                Console.Write(t + " ");
                f = s;
                s = t;
            }
        }

        public void ContinueDemo()
        {
            for( int i = 1;i <= 10; i++)
            {
                if(i == 3 || i == 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

    }
}
