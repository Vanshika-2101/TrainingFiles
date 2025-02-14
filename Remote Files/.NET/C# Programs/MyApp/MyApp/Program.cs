namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Testing....");
            var calc = new GradeCalc();

            Console.Write("Enter the percentage : ");
            var percentage = Convert.ToInt32(Console.ReadLine());
            var grade = calc.GetGradeByPercentage(percentage);
            Console.WriteLine("Student Grade = " + grade);
        }
    }
}
