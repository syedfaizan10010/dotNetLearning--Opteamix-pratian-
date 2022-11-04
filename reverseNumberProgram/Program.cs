namespace reverseNumberProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, reverse = 0 , digit=0;
            Console.WriteLine("Enter the Number:");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                digit = number % 10;
                reverse = reverse * 10 + digit;
                number = number / 10;

            }
            Console.WriteLine($"Reverse of the Entered Number is: {reverse}");


            //Console.WriteLine($"The reverse of {number} is : {reverse})
        }
    }
}