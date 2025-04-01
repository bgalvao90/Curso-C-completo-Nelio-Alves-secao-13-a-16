using System.Globalization;
using Aula176.Entities;
using System.IO;
using System.Linq;

Console.Write("Enter full file path: ");
string Path = Console.ReadLine();

List<Product> products = new List<Product>();


using (StreamReader sr = File.OpenText(Path))
{

    while (!sr.EndOfStream)
    {
        string[] strings = sr.ReadLine().Split(',');
        string name = strings[0];
        double price = double.Parse(strings[1], CultureInfo.InvariantCulture);
        products.Add(new Product(name, price));
    }

    var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
    var nameProducts = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
    foreach (string name in nameProducts)
    {
        Console.WriteLine(name);
    }
}

