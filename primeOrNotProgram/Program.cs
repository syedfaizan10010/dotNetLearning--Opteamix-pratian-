namespace primeOrNotProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Prime Number Problem!");
            int upperLimit, lowerLimit, i = 0, sum = 0; Boolean isPrime; 
            Console.Write("Enter the lower limit: "); 
            lowerLimit = int.Parse(Console.ReadLine()); 
            Console.Write("Enter the upper limit: ");
            upperLimit = int.Parse(Console.ReadLine());
            //finding all numbers in the given above range
            if (lowerLimit == 0)
            {                
                lowerLimit++;
            }            
            Console.Write("Prime numbers lying in the given range are: ");
            while (lowerLimit <= upperLimit)
            {                
                isPrime = true;
                i += 3;
                while ((i <= Math.Sqrt(lowerLimit)) && (isPrime == true))
                {                    
                    if (lowerLimit % i == 0)
                    {                        
                        isPrime=false;
                    }                
                }                                
                if (isPrime == true)                
                {                                        
                    Console.Write($"{lowerLimit}\t");                    
                    sum += lowerLimit;                
                }                                
                lowerLimit += 2;            
            }            
            Console.WriteLine($"\nSum of all prime numbers in the mentioned range is: {sum}");


        }
    }
}