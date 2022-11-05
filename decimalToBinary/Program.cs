namespace decimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int decNum = int.Parse(Console.ReadLine());
            int rem;
            string result = "";
            while (decNum > 0)
            {
                rem = decNum % 2;
                decNum /= 2;
                result = rem + result;
            }
            Console.WriteLine("Binary:  {0}", result);
        }
    }
}