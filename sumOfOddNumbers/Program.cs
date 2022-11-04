namespace sumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());

            for (int i =1; i <= number; i= i+2)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of odd number from 1 to {number} is: {sum}");
        }
    }
}