namespace seriesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the Number!");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <((2 *n) +1); i = i + 2)
            {
                int result = (i * i);
                Console.WriteLine($"{result}");
            }
        }
    }
}