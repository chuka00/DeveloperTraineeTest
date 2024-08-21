namespace Task_4_Array_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4: Array manipulation
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
                Console.WriteLine(num);
            }

            Console.WriteLine($"Sum of array elements: {sum}");
        }
    }
}
