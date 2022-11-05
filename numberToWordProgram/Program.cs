namespace numberToWordProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int val, next = 0, num_digits = 0; 
            int[] a = new int[10];            
            // words for every digits from 0 to 9
            string[] digits_words = {"zero","one","two","three","four","five","six","seven","eight","nine"};
            // number to be converted into words           
             Console.WriteLine("number:");           
             val=int.Parse(Console.ReadLine());
            do
            {
                next = val % 10;
                a[num_digits] = next;
                num_digits++;
                val = val / 10;
            }
            while (val > 0);
            num_digits--;
            for (; num_digits >= 0; num_digits--)
                Console.Write(digits_words[a[num_digits]] + " ");
                Console.ReadLine();


        }
    }
}