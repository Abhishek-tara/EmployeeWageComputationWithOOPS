﻿namespace EmpWageWithOops
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Employee Wage computation problem");
        
        ComputeEmpWage wage= new ComputeEmpWage();
        wage.calculateWage();
    }
}
}