using LinQ_session_2_demo;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
namespace LinQ_session_2_demo
{
    internal class prog
    {
        static void Main()
        {
            #region Casting [Conversion] Operators  — Immediate Execution
            // List<Product> result = ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0).ToList();
            // Product[] result = ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0).ToArray();
            //////////////// Dictionary< Key (long=> productid) , value> .ToDictionary(tyep of key);/////////////////
            //Dictionary<long , Product > result = ListGenerator.ProductsList.Where(p=>p.UnitsInStock == 0)
            //                                               .ToDictionary(p=> p.ProductID);
            //foreach (var item in result)
            //    Console.WriteLine($"key = {item.Key}  value = {item.Value}");

            //ArrayList Obj = new ArrayList() {
            //"Omar",
            //"Ahmed",
            //"Mona" ,
            //"Aliaa " ,
            //1,
            //2,
            //3
            //            };
            //            var Result = Obj.OfType<int>();
            //foreach (var item in Result)
            //                Console.WriteLine(item) ;
            #endregion
            #region Generation Operators — Deffered Execution
            // Valid Only With Fluent Syntax only
            // The Only Way To Call Them Is As Static Methods From Class Enumerable

            // var Result = Enumerable.Range(0, 100); // 0..99

            // Result = Enumerable.Repeat(2, 100);
            // /// Return IEnumerable Of 100 Element each One = 2

            // var Result = Enumerable.Repeat(new Product(), 100);
            // // Return IEnumerable Of 100 Product

            // var arrayProduct = Enumerable.Empty<Product>().ToArray();
            // Product[] Products = new Product[0];
            // // Both Will Generate an Empty Array of Products

            // var List = Enumerable.Empty<Product>().ToList();
            // List<Product> Products02 = new List<Product>();
            // // Both Will Generate An Empty List Of Product
            #endregion
            #region Set Operators [Union Family] - Deterred Execution
            //var seq1 = Enumerable.Range(0, 100); //0->100
            //var seq2 = Enumerable.Range(50, 100); // 50->149
            //var result = seq1.Union(seq2);
            //foreach (var num in result) { 
            //Console.Write($"{num} ");
            //}
            //Console.WriteLine("\n ===================== Concat Seq ==================");
            //var result2 = seq1.Concat(seq2); // with dublication
            //foreach (var num in result2)
            //{
            //    Console.Write($"{num} ");
            //}
            //result2=result2.Distinct (); // remove dublication


            //var result3 = seq1.Intersect(seq2); // المشترك بينهم بس
            //var result4 = seq1.Except(seq2); // اللي موجود في الاولي و مش موجود في التانيه
            #endregion
            #region Quantifier Operators - Deferred Execution - Return Boolean

            //var Result = ProductList.Any();
            //// If Sequence Contains At Least One Element => True

            //Result = ProductList.Any(P => P.UnitsInStock == 0);
            //// If Sequence Contains At Least One Element Match Condition => True

            //Result = ProductList.Any(P => P.UnitsInStock > 1000); // False

            //Result = ProductList.All(P => P.UnitsInStock == 1);
            //// If All Elements in Sequence Match Condition Return True

            //var Seq01 = Enumerable.Range(0, 100); // 0..99
            //var Seq02 = Enumerable.Range(0, 100); // 0..99

            //Result = Seq01.SequenceEqual(Seq02);
            //Console.WriteLine(Result);
            #endregion
            #region Zipping Operator - ZIP

            //string[] Names = { "Omar", "Amr", "Ahmed", "May" };
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] Chars = { 'A', 'B', 'C', 'D', 'E' };

            // var Result = Names.Zip(Numbers);
            // (Omar, 1)
            // (Amr, 2)
            // (Ahmed, 3)
            // (May, 4)
            // (Aya, 5)

            // var Result = Names.Zip(Numbers, (Name, Number) => new { index = Number, Name });

            //var Result = Names.Zip(Numbers, Chars);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Grouping Operators
            #region Get Products Grouped by Category
            /// // Query Syntax
            /// // var Result = from P in ProductList
            /// //              group P by P.Category;

            //var Result =ListGenerator.ProductsList.GroupBy(P => P.Category);
            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key); // Name of Category
            //    foreach (var Product in category)
            //    {
            //        Console.WriteLine($"             {Product.ProductName}");
            //    }
            //}
            #region Get Products in Stock Grouped by Category
            //var result = ListGenerator.ProductsList.Where(c => c.UnitsInStock > 0).GroupBy(c => c.Category);

            //foreach (var category in result) 
            //{
            //    Console.WriteLine($"{category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"                {product.ProductName}");
            //    }
            //    }
            #endregion
            #region Get Products in Stock Grouped by Category That Contains More Than 10 product
            //var result = ListGenerator.ProductsList.Where(c => c.UnitsInStock > 0).GroupBy(c => c.Category).Where(c => c.Count() > 10);
            //foreach (var category in result)
            //{
            //    Console.WriteLine($"{category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"                {product.ProductName}");
            //    }
            //}
            #endregion
            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category
            // var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 1).GroupBy(p => p.Category).Where(p => p.Count() > 10)
            //                      .Select(x => new
            //                      {
            //                         number_of_product = x.Count(),
            //                         category_name = x.Key

            //                      });
            // foreach (var item in result) {
            //     Console.WriteLine(item); 
            //}


            //foreach (var category in result)
            //{
            //    Console.WriteLine($"{category.Key}");
            //    foreach (var item in category) 
            //    {
            //        Console.WriteLine($"                {item.ProductName}");
            //    }
            //    Console.WriteLine($" number = {category.Count()}");
            //}
            #endregion
            #endregion

            #endregion
            #region Partitioning Operators
            // take , skip , TakeWhile ,skipWhile
            // var Result = ProductList.Take(10);
            ///// Take Number of Elements From First Only
            // Result = ProductList.Where(P => P.UnitsInStock > 0).Take(5);

            // Result = ProductList.Where(P => P.UnitsInStock > 0).TakeLast(10);
            ///// TakeLast => Take Number of Elements From Last Only
            ///

            // var Result =ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).Skip(2);
            // Skip Number of Elements From First And Get Rest Of Elements

            // Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).Skiplast(2);
            //int[] arr = { 4, 6, 8, 9, 7, 2 , 10, 15, 3, 19, 20 };
            //var result = arr.TakeWhile(num => num < 10);
            //var result2 = arr.TakeWhile((num , i) => num > i);
            //var result3 = arr.SkipWhile(num => num % 2 == 0);

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Let And Into [Valid Only With Query Syntax]
            //using System.Text.RegularExpressions;

            //List<string> Names = new List<string>() { "Omar", "Ali", "Sally", "Mohamed", "Ahmed" };
            //// A , O , U , I , E

            //var Result = from N in Names
            //             select Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //             into NoVowelNames
            //             where NoVowelNames.Length > 3
            //             select NoVowelNames;

            //// Into => Restart Query With Introducing A New Range Variable : NoVowelNames
            //Result = from N in Names
            //         let NoVowelNames = Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //         where NoVowelNames.Length > 3
            //         select NoVowelNames;

            //// Let => Continue Query With Adding New Range Variable : NoVowelNames
            //foreach (var Name in Result)
            //{
            //    Console.WriteLine(Name);
            //}
            #endregion
        }
    }
}
