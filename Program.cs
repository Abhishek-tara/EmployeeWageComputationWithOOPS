namespace EmpWageWithOops
{
    public class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("Welcome to the Employee Wage computation problem");

             ComputeWage Company = new ComputeWage();

             Company.calculateWage("StarBucks",15, 20, 60);

             Company.calculateWage("Apple",25, 22, 70);


        }
    }
}