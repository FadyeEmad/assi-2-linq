using LinQ_session_2_demo;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Numerics;
using System.Threading;
namespace assi_2_linq
{
    internal class prog
    {
        static void Main()
        {
            #region LINQ - Restriction Operators
            // 1.Find all products that are out of stock.
            //var res = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}
            // 2.Find all products that are in stock and cost more than 3.00 per unit.
            //var res = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}
            // 3.Returns digits whose name is shorter than their value.
            //string [] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where((x, i) => x.Length < i);
            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region LINQ - Element Operators1. Get first Product out of Stock 
            //// 1.get first product out of stouck
            //var result = ListGenerator.ProductsList.First(p=>p.UnitsInStock == 0);//
            // Console.WriteLine(result);

            //// 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.//
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000 , new Product { }) ;
            //Console.WriteLine(result);

            ///// 3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result= Arr.Where(x=> x>5).ElementAt(1);
            //Console.WriteLine(result);

            #endregion
            #region LINQ - Aggregate Operators
            #region  1.Uses Count to get the number of odd numbers in the array

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(x => x % 2 != 0);
            //Console.WriteLine(res.Count()); 
            #endregion
            #region  2. Return a list of customers and how many orders each has.
            //var res = ListGenerator.CustomersList.Select(x => new
            //{
            //    name = x.CustomerName,
            //    count =x.Orders.Count()
            //});
            //foreach (var item in res) { 
            //Console.WriteLine(item);
            //} 
            #endregion
            #region 3. Return a list of categories and how many products each has
            //var res = ListGenerator.ProductsList.GroupBy(p => p.Category).Select(x => new
            //{
            //    category = x.Key,
            //    num_of_product = x.Count()

            //});
            //foreach (var item in res) {Console.WriteLine(item); }
            #endregion
            #region  4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Sum();
            //Console.WriteLine(res);
            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Sum(x=>x.Length);
            //Console.WriteLine(res);
            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt
            //var word = File.ReadAllLines("dictionary_english.txt");
            //var res = word.OrderBy(word => word.Length).First();
            //Console.WriteLine(res.Length);
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt
            //var word = File.ReadAllLines("dictionary_english.txt");
            //var res = word.OrderBy(word => word.Length).last();
            //Console.WriteLine(res.Length);
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt 
            //var word = File.ReadAllLines("dictionary_english.txt");
            //var res = word.Average(x => x.Length);
            #endregion

            #endregion
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var res = ListGenerator.ProductsList.OrderBy(x => x.ProductName);
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.Order(new customcomperer());
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var res = ListGenerator.ProductsList.OrderByDescending(x => x.UnitsInStock);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
            //var res = Arr.OrderBy(x => x.Length).Order();
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var res = ListGenerator.ProductsList.Select(x => x.ProductName);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //var res = ListGenerator.ProductsList.Select(x => new
            //{
            //    upper = x.ProductName.ToUpper()
            //    , lower = x.ProductName.ToLower()
            //});
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion
            #region  Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var res = ListGenerator.ProductsList.Select(x => new
            //{
            //  product_name = x.ProductName,
            //  product_id = x.ProductID,
            //  price = x.UnitPrice
            //});
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Select((x, i) => new
            //{
            //  number = x,
            // index = i==x ? true : false
            //});
            //foreach (var x in res) { 
            //Console.WriteLine(x);
            //}
            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var res = numbersA.SelectMany(n => numbersB, (a, b) => new
            //{
            //    numbera = a,
            //    numberb = b
            //}).Where(p => p.numbera < p.numberb);
            //foreach (var n in res)
            //{
            //    Console.WriteLine($" {n.numbera} is less than {n.numberb} ");
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var res = ListGenerator.ProductsList.Select(p => p.Category).Distinct();
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var res = ListGenerator.ProductsList.Select(p => p.ProductName[0]).Union(ListGenerator.CustomersList.Select(c => c.CustomerName[0])); ;
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var res = ListGenerator.ProductsList.Select(p => p.ProductName[0]).Intersect(ListGenerator.CustomersList.Select(c => c.CustomerName[0])); ;
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var res = ListGenerator.ProductsList.Select(p => p.ProductName[0]).Except(ListGenerator.CustomersList.Select(c => c.CustomerName[0])); ;
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var res = ListGenerator.ProductsList.Select(p => p.ProductName[^3..]).Concat(ListGenerator.CustomersList.Select(c => c.CustomerName[^3..])); ;
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var res = ListGenerator.CustomersList.Where(x => x.Region == "WA").SelectMany(O => O.Orders).Take(3);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  2. Get all but the first 2 orders from customers in Washington.
            //var res = ListGenerator.CustomersList.Where(x => x.Region == "WA").SelectMany(O => O.Orders).skip(2);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((x, i) => x > i);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile(x => x % 3 != 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var word = File.ReadAllLines("dictionary_english.txt");
            //var res = word.Any(x => x.Contains("ei"));
            //Console.WriteLine(res);
            #endregion

            #endregion
        }
    }
}