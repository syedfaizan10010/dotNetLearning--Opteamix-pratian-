namespace powerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int n = 0;
            int i = 0;
            int pow = 1;
            Console.WriteLine(" enter the value of x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of n");
            n = int.Parse(Console.ReadLine());



            if (x == 0 && n == 0)



            {
                Console.WriteLine("enter the value other than ZEROs");



            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    pow = pow * x;
                }
            }
            Console.WriteLine("the power of number is" + pow);
        }
    }
}