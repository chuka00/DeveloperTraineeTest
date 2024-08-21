namespace Task_2_Even_or_Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2: Determine if a number is even or odd
            Console.Write("Kindly enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
