namespace binaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter a binary number: "); 
            int binNum = int.Parse(Console.ReadLine()); 
            int rem, decVal = 0, baseVal = 1; 
            while (binNum > 0) 
            { 
                rem = binNum % 10;
                binNum = binNum / 10;
                decVal = decVal + rem * baseVal;
                baseVal = baseVal * 2;
            }
            Console.WriteLine("Decimal: {0}", decVal);


        }
    }
}