using Aula150.Entities;
using Aula150.Services;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] product = Console.ReadLine().Split(',');
    string name = product[0];
    double price = double.Parse(product[1], CultureInfo.InvariantCulture);
    list.Add(new Product(name, price));

}
CalculationService calculationService = new CalculationService();

Product max = calculationService.Max(list);

Console.WriteLine("Max: ");
Console.WriteLine(max);