namespace employeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter Employee id");
            int empId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter basic salary");
            int basicSalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Specical Allowance");
            double specialAllowance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Bonus Percentage");
            float bonusPercentage = float.Parse(Console.ReadLine());  
            
            Console.WriteLine("Enter Monthly Tax Investement");
            double monthlyTaxInvestement = double.Parse(Console.ReadLine());


            double grossMonthlySalary = basicSalary + specialAllowance ;
            Console.WriteLine($"Monthly Salary:{grossMonthlySalary}");
           
            double bonus = (basicSalary * 12) * bonusPercentage / 100.0;
            Console.WriteLine($"Bonus amount: {bonus}");
           
            double annualSalary = grossMonthlySalary * 12;
            Console.WriteLine($"Annual Salary: {annualSalary}");
            
            double grossAnnualSalary = (grossMonthlySalary * 12) + bonus;
            Console.WriteLine($"Gross Annual salary :{grossAnnualSalary}");
            double netAnnualSalary, taxAmount, taxPaid;
            double annualTax = monthlyTaxInvestement * 12;

            taxAmount = grossAnnualSalary - annualTax;




            if (grossAnnualSalary < 100000)
            {
                Console.WriteLine("Exempted!!!");
            }

            
            else if (grossAnnualSalary > 100000 && grossAnnualSalary < 150000)
                {
                     taxPaid = (taxAmount - 100000) * 0.2;
                 
                
                }
            else
            {
                taxPaid = (taxAmount - 150000) *0.3;
            }

            }
         


        }
    }
}