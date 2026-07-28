using System;
class Program
{
static void Main(string[] args)
{
Console.Write("Enter Employee Name: ");
string name = Console.ReadLine();
Console.Write("Enter Monthly Salary: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());
decimal bonus = salary * 0.10m;
decimal totalSalary = salary + bonus;
Console.WriteLine();
Console.WriteLine("Employee Bonus Report");
Console.WriteLine($"Employee : {name}");
Console.WriteLine($"Salary : ${salary:F2}");
Console.WriteLine($"Bonus : ${bonus:F2}");
Console.WriteLine($"Total Pay : ${totalSalary:F2}");
}
}