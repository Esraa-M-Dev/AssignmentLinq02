using LINQ.DataSources;
using LINQ.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using static LINQ.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace AssignmentLinq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var ProductSortedByCategoryAndPrice  = ProductList .OrderBy(p => p.Category)
            //                                .ThenByDescending(p => p.UnitPrice);

            //foreach (var p in ProductSortedByCategoryAndPrice)
            //    Console.WriteLine(p);

            //=====================================================================================
            //2-Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            //var Beverages = ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in Beverages)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

            //=====================================================================================
            //3-Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 c.CustomerID,
            //                 o.OrderDate
            //             };

            //foreach (var item in result)
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");

            //=======================================================================
            //4-Show position number alongside ProductName
            //var result = ProductList.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    p.ProductName
            //});
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}

            //===========================================================================
            //5- Sort first by - word length and then by a case -insensitive sort of the words in an array. String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //string[] Arr = {"aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var result = Arr
            //    .OrderBy(s => s.Length)
            //    .ThenBy(s => s, StringComparer.OrdinalIgnoreCase);

            //foreach (var s in result)
            //    Console.WriteLine(s);

            //====================================================================================================================
            //6-Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] words ={ "milk", "fish", "rice", "apple", "bike", "ice"};

            //var result = words .Where(s => s.Length > 1 &&char.ToLowerInvariant(s[1]) == 'i')
            //                   .Reverse();

            //foreach (var word in result)
            //    Console.WriteLine(word);

            //=============================================================================
            //7-Get top 3 most expensive products
            //var result = ProductList.OrderByDescending(p => p.UnitPrice)
            //                        .Take(3);

            //foreach (var p in result)
            //    Console.WriteLine(p);

            //================================================================================
            //8- show page 2 of products, with page size = 5
            //var result =ProductList.Skip(5)
            //                       .Take(5);

            //foreach (var p in result)
            //    Console.WriteLine(p);

            //=====================================================================================
            //9-Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = ProductList .OrderBy(p => p.UnitPrice)
            //                         .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //    Console.WriteLine(p);

            //=============================================================================================
            //10-Check if ALL products in the"Seafood" category are in stock
            //bool result =ProductList.Where(p => p.Category == "Seafood")
            //                         .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);

            //=======================================================================================
            //11-Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 };
            //int[] ids = { 3, 9, 13, 18 };
            //bool result = ids.Contains(9);

            //Console.WriteLine(result);

            //============================================================================================
            //12- Group all products by Category and print each group with its product count.
            //var result =ProductList.GroupBy(p => p.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(
            //        $"{group.Key}: {group.Count()} products");
            //}

            //==========================================================================================
            //13-Group products by Category and project only product names per group
            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new
            //                        {
            //                       Category = g.Key,
            //                       ProductNames = g.Select(p => p.ProductName)
            //                        });

            //foreach (var group in result)
            //{

            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductNames)
            //        Console.WriteLine(name);

            //    Console.WriteLine("\n");
            //}

            //===================================================================================
            //14- Find all categories that have MORE THAN 3 products
            //var result =ProductList.GroupBy(p => p.Category)
            //                       .Where(g => g.Count() > 3)
            //                       .Select(g => g.Key);

            //foreach (var category in result)
            //    Console.WriteLine(category);

            //===============================================================================================
            //15- Using QUERY SYNTAX, group customers by Country, and for each group select{ Country, Count, TotalOrderValue}.
            //var result = from c in CustomerList
            //             group c by c.Country into g
            //              select new
            //              {
            //             Country = g.Key,
            //            Count = g.Count(),
            //       TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //              };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} - Customers: {item.Count} - Total: {item.TotalOrderValue}");
            //}

            //=======================================================================================
            //16- Calculate the total number of units in stock across all products
            //int result = ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine(result);

            //===========================================================================================
            //17- Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapest = ProductList.Min(p => p.UnitPrice);

            //var mostExpensive = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest: {cheapest}");
            //Console.WriteLine($"Most Expensive: {mostExpensive}");

            //==============================================================================================
            //18-Get a distinct list of all product categories
            //var result = ProductList.Select(p => p.Category)
            //                        .Distinct();

            //foreach (var category in result)
            //    Console.WriteLine(category);

            //===============================================================================================
            //19-find product IDs that are in setA but NOT in setB int[] setA={ 1, 3, 5, 7, 9, 11, 13}; int[] setB={ 3, 6, 9, 12, 15, 13};
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var id in result)
            //    Console.WriteLine(id);

            //====================================================================================================
            //20-Find countries that appear in list1 but NOT in list2(case -insensitive). string[] list1 = { "Germany", "France", "UK", "Spain" }; string[] list2 = { "france", "SPAIN", "Italy" };
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except( list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var country in result)
            //    Console.WriteLine(country);

            //===========================================================================================================
            //21- Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //Dictionary<int, Product> products = ProductList.ToDictionary(p => p.ProductID);

            //Product product = products[18];

            //Console.WriteLine(product);

            //============================================================================================================
            //22-Get the first product whose price is greater than$50.
            //var result = ProductList.First(p => p.UnitPrice > 50);

            //Console.WriteLine(result);

            //==============================================================================================================
            //23-Try to get the first product with a price >$500.it returns null instead of throwing
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No product found");

            //===============================================================================================================
            //24-Generate a multiplication table row for 7
            //var result = Enumerable.Range(1, 12)
            //                       .Select(n => 7 * n);

            //foreach (var number in result)
            //    Console.WriteLine(number);

            //===========================================================================================================
            //25-Generate even numbers between 1 and 30.
            //var result = Enumerable.Range(1, 30)
            //                       .Where(n => n % 2 == 0);

            //foreach (var number in result)
            //    Console.WriteLine(number);

            //========================================================================================================
            //26-Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            //var products = ProductList.Take(3)
            //                          .Select(p => p.ProductName);

            //var customers = CustomerList.Take(3)
            //                           .Select(c => c.CustomerName);

            //var result = products.Concat(customers);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            //========================================================================================
            //27- Pair each product with a customer(by position) and produce a string"ProductName sold to CompanyName".
            var result = ProductList.Zip(CustomerList,(p, c) => $"{p.ProductName} sold to {c.CustomerName}");

            foreach (var item in result)
                Console.WriteLine(item); 



















        }
    }
}
