﻿using Aula172.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Aula172
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {


            Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category { Id = 3, Name = "Electronics", Tier = 1 };


            List<Product> products = new List<Product>()
{
    new Product () { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
    new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
    new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
    new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
    new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
    new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
    new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
    new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
    new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
    new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
    new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
    };


            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY NAME AND THEN BY PRICE:", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE AND THEN BY NAME SKIP 2 TAKE 4:", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            var r8 = products.Where(p => p.Id ==3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 sum prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 average prices: " + r13);




        }
    }
}