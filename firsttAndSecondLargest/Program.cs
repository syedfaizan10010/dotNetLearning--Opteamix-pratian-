namespace firsttAndSecondLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = 0, secondNumber = 0, thirdNumber = 0;
            Console.WriteLine("Please Enter the first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Third number:");
            thirdNumber = int.Parse(Console.ReadLine());

            //if (firstNumber > secondNumber)
            //{
            //    if (firstNumber > thirdNumber)
            //    {
            //        Console.WriteLine("First Number is greater");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Third Number is greater");
            //    }

            //}
            //else if (secondNumber > thirdNumber)
            //{
            //    Console.WriteLine("Second Number is greater");
            //}
            //else { Console.WriteLine("Third is largest"); }   

            if (firstNumber >= secondNumber && firstNumber >=thirdNumber)
            {
                Console.WriteLine($"First greater number is {firstNumber}");
                if(secondNumber >= thirdNumber)
                {
                    Console.WriteLine($"Second larget is {secondNumber}");
                }
                else
                {
                    Console.WriteLine($"Second Largest is {thirdNumber}");
                }
            } 

            if (secondNumber>=firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine($"First Larget is {secondNumber}");
                if(firstNumber > thirdNumber)
                {
                    Console.WriteLine($"Second largest is {firstNumber}");
                }
                else
                {
                    Console.WriteLine($"Second Largest is {thirdNumber}");
                }

            }
            if (thirdNumber >= firstNumber && thirdNumber  >= secondNumber)
            {
                Console.WriteLine($"First Larget is {thirdNumber}");
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"Second largest is {firstNumber}");
                }
                else
                {
                    Console.WriteLine($"Second Largest is {secondNumber}");
                }

            }


        }
    }
}