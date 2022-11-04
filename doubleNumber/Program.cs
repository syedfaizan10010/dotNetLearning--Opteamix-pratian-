namespace doubleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.WriteLine("Enter the Number");
            number= double.Parse(Console.ReadLine());
            int integerNumber = (int)number;
            Console.WriteLine($"First part:{integerNumber}");
            double separating = number - integerNumber;
            Console.WriteLine($"Second Part:{separating}"); 




        }
    }
}