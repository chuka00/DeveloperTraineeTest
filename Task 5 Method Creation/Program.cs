namespace Task_5_Method_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 5: Greet method
            static void Greet(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            // Call the Greet method
            Greet("Alice");
        }
    }
}
