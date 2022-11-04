namespace sereiesTwoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <= number; i++)
            {
            if(i % 2 == 0)
                {
                    Console.WriteLine($"{-1 * i}");
                }
            else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}