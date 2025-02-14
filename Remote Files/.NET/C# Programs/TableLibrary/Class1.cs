namespace TableLibrary
{
    public class Class1
    {
        public void Table(int num)
        {
            Console.WriteLine($"Table of {num}: ");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        public void ForEvenOdd()
        {
            Console.WriteLine("For Loop");
            Console.WriteLine("Even Numbers");
            for(int i = 0; i <= 10; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nOdd Numbers");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
