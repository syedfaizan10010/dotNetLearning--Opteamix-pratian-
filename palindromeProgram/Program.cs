

namespace palindromeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = " ";
           string rev = " ";
           int i = 0;
            Console.WriteLine("Please Enter the String");
            string reverse =Console.ReadLine();

            for ( i = 1; i <= str.Length; i++)
            {
                rev = str[i] + rev;
            }

            if (rev == str)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Plaindrome!)");
            }


        }
    }
}