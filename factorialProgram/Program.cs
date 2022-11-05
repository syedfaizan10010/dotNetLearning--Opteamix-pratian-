namespace factorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1,fact = 1, number=0;
            

            Console.WriteLine("enter the number");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            { 
                fact = (fact * i); 
            }
            Console.WriteLine($"factorial of given number {number} is : {fact}");


        }
    }
}