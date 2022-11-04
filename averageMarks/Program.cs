namespace averageMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int marks1 = 0, marks2 = 0, marks3 = 0;
            string name;
            {
                Console.WriteLine("Please Enter The Name of the student");
                name = Console.ReadLine();
                Console.WriteLine("Please Enter Marks1:");
                marks1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Marks2:");
                marks2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Marks3:");
                marks3 = int.Parse(Console.ReadLine());

                int total = marks1 + marks2 + marks3;
                double averageMarks = (marks1 + marks2 + marks3) / 3;


                if (averageMarks >= 60)
                {
                    Console.WriteLine("First Class");

                }
                else if (averageMarks >= 50)
                {
                    Console.WriteLine("Second Class");

                }
                else if (averageMarks >= 35)
                {
                    Console.WriteLine("Pass class");
                }
                else
                {
                    Console.WriteLine("Fail!!");
                }



            }
        }
    }
}
