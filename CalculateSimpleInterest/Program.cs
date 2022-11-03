namespace CalculateSimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest Calclulator");
            Console.WriteLine("Enter the Principal amount:");
            int principleAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interesr");
            int interestRate =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time/Duration:");
            int time = int.Parse(Console.ReadLine());

            float simpleInterest = principleAmount * interestRate *time  / 100;
            Console.WriteLine($" SImple Interest is {simpleInterest}");
        }
    }
}