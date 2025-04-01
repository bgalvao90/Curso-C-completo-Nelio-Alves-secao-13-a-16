using System.Globalization;
using Aula177.Entities;
using System.IO;
using System.Linq;

Console.Write("Enter full file path: ");
string sourcePath = Console.ReadLine();

List<Employee> employees = new List<Employee>();

using (StreamReader sr = File.OpenText(sourcePath))
{
    while (!sr.EndOfStream)
    {
               string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        string email = fields[1];
        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
        employees.Add(new Employee(name, email, salary));
    }
}
Console.Write("Enter salary: ");
double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var emails = employees.Where(e => e.Salary > salaryLimit).OrderBy(employees => employees.Email).Select(e => e.Email);
foreach (string email in emails)
{
    Console.WriteLine(email);
}
var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));