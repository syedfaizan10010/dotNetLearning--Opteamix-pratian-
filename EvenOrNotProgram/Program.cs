namespace EvenOrNotProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            //number =int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            
            if (number%2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is ODD");
            }

        }
    }
}