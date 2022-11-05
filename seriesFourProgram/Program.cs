namespace seriesFourProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 4, c = 7, number;
            Console.WriteLine("Enter the Number!");
            number = int.Parse(Console.ReadLine());

            for( int i=1; i<number; i++)
            {
                int result = a +b+ c;
                a = b;
                b = c;
                c = result;
                Console.Write(result + " ");
            }
            
        }
    }
}