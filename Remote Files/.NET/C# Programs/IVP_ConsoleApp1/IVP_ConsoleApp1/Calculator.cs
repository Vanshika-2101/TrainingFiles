using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class Calculator
    {
        int a, b;
        float x, y;
        double p, q;
        string name;
        char value;


        public void Test()
        {
            Console.WriteLine($"{a} {b}");
            Console.WriteLine($"{x} {y}");
            Console.WriteLine($"{p} {q}");
            Console.WriteLine($"{name}");
        }

        public void GetChar()
        {   

            Console.Write("Enter any character between (+, -, *, /): ");
            //value = Convert.ToChar(Console.ReadLine());
            value = char.Parse(Console.ReadLine());
            Console.WriteLine($"You entered : {value}");

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome to C#, {name}");
        }
        public void Addition()
        {
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            int c = a+ b;
            Console.WriteLine("Addition: " + c);
        }

        public void Subtraction()
        {
            Console.Write("Enter first number: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = float.Parse(Console.ReadLine());

            float z = x - y;
            Console.WriteLine("Subtraction: " + z);
        }

        public void Multiplication()
        {
            Console.Write("Enter first number: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            q = double.Parse(Console.ReadLine());

            double r = p * q;
            Console.WriteLine("Multiplication: " + r);
        }
    }
}
