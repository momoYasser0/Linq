using System.Threading;
using static LinqDemo.ListGenerator;
namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //var ProductOutOfStock = ProductList.Where(product => product.UnitsInStock <= 0);

            //foreach (var item in ProductOutOfStock)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var ProductOutOfStock = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3);
            //foreach (var item in ProductOutOfStock)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shorterNames = digits.Select((digit, index) => new { Digit = digit, Index = index })
            //                        .Where(x => x.Digit.Length < x.Index)
            //                        .Select(x => x.Digit);

            //foreach (var digit in shorterNames)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #endregion
            #region 2-LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var OrderProductsByName = ProductList.OrderBy(product => product.ProductName);

            //foreach (var item in OrderProductsByName)
            //        Console.WriteLine(item); 
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedArr = Arr.OrderBy(word => word.ToLower());
            //foreach (var word in SortedArr)
            //    Console.WriteLine(word);
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var products = from product in ProductList
            //               orderby product.UnitsInStock descending
            //               select product;
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var SortedArr = from digit in Arr
            //                orderby digit.Length, digit
            //                select digit;
            //foreach (var item in SortedArr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region 3-LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var ProductsName = ProductList.Select(product => product.ProductName);
            //foreach (var item in ProductsName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(word => new { UpperCase = word.ToUpper(), LowerCase = word.ToLower() });
            //foreach (var word in result)
            //    Console.WriteLine(word);
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Products = ProductList.Select(product => new {ItemName = product.ProductName,Price = product.UnitPrice});

            //foreach (var item in Products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
    }
}
