internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Please Write a number");
        number = int.Parse(Console.ReadLine());

        for(int i=1; i< number +1; i++)
        {
            double data = (i * i * i);
            Console.WriteLine($"Series of the Given number is:{data}");
        }
        
    }
}