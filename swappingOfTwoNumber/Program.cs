namespace swappingOfTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swapping the Number Program!");
            Console.WriteLine("Enter the first Number");
            int firstNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int secondNumber=int.Parse(Console.ReadLine());
                
            //int temp = firstNumber;
            //firstNumber = secondNumber;
            //secondNumber = temp;

            //without Using temp variable

            firstNumber= firstNumber+secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("After swapping");
            Console.WriteLine($"First Number:{firstNumber}");
            Console.WriteLine($"Second Number:{secondNumber}");

        }
    }
}