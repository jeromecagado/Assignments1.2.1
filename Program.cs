namespace Assignments1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will check if two integers are equal.");
            Console.WriteLine("Please enter the first number");
            int fistIntegerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondIntegerNumber = Convert.ToInt32(Console.ReadLine());
            if (fistIntegerNumber != secondIntegerNumber)
            {
                Console.WriteLine("They are not equal!");
            } else
            {
                Console.WriteLine("They are equal!");
            }
            Console.Read();
        }
    }
}
