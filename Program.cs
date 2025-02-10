using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LINQ_03.ListGenerator;

namespace LINQ_03

{
//    class StringEqulityComparer : IEqualityComparer<string>
//    {
//        public bool Equals([AllowNull] string x, [AllowNull] string y)
//        
// => x?.ToLower().Equals(y?.ToLower()) ?? ( y is null ? true : false);
//
//        public int GetHashCode([DisallowNull] string obj);
//       obj.tolower().gethashcode();
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Grouping Operators - GroupBy , Chunk 

            #region GroupBy()

            /// Example 01
            /// var Result = from P in ProductList
            ///              group P by P.Category;
            /// 
            /// Result = ProductList.GroupBy(P => P.Category);
            ///
            /// foreach (var group in Result)
            /// {
            ///     Console.WriteLine(group.Key);
            ///
            ///     foreach (var Product in group)
            ///     {
            ///         Console.WriteLine(Product);
            ///     }
            /// }

            /// Example 02
            ///  var Result = from P in ProductList
            ///               where P.UnitsInStock > 0
            ///               group P by P.Category
            ///               into PrdGroup
            ///               where PrdGroup.Count() > 10
            ///               select new
            ///               {
            ///                   Category = PrdGroup.Key, Count = PrdGroup.Count(),
            ///                   
            ///               };
            ///  
            ///  Result = ProductList.Where(P => P.UnitsInStock > 0)
            ///                      .GroupBy(P => P.Category)
            ///                      .Where(PrdGroup => PrdGroup.Count() > 10)
            ///                      .Select(PrdGroup => new
            ///                      {
            ///                          Category = PrdGroup.Key,
            ///                          Count = PrdGroup.Count()
            ///                      });
            ///
            ///  foreach (var item in Result)
            ///  {
            ///      Console.WriteLine(item);
            ///  }

            ///  GroupBy() Overloads
            ///  var Result01 = ProductList.GroupBy(P => P.Category);
            ///  var Result02 = ProductList.Where(P => P.Category , new StringEqulityComparer());
            ///  
            ///  var Result03 = ProductList.GroupBy(P => P.Category , P => new { P.productId , P.ProductName});
            ///  var Result04 = ProductList.GroupBy(P => P.Category , P => new { P.productId , P.ProductName} , new tringEqulityComparer()  );
            ///  
            ///  var Result05 = ProductList.GroupBy(P => P.Category , (Key , Group) => new { Category = key , Count = product.Count()});
            ///  var Result06 = ProductList.GroupBy(P => P.Category , (Key , Group) => new { Category = key , Count = product.Count()} , new StringEqulityComparer());
            ///  
            /// var Result07 = ProductList.GroupBy(P => P.Category , P => new { P.productId , P.ProductName} , (Key , Group) => new { Category = key , Count = product.Count()});
            /// var Result07 = ProductList.GroupBy(P => P.Category , P => new { P.productId , P.ProductName} , (Key , Group) => new { Category = key , Count = product.Count()}, new StringEqulityComparer());
            /// 
            /// 
            /// foreach(var item in Result01)
            /// Console.WriteLine(item);
            /// foreach (var group in Result03)
            ///  {
            ///      Console.WriteLine(group.Key);
            ///      foreach ( var Product in group)
            ///      Console.WriteLine(Product);
            ///  }




            #endregion

            #region Chunk() [.NET 6.0 NEW Feature]

            // var fruits = new[] { "apple", "banana", "cherry", "date", "fig", "grape" , "Mango" , "Tomato" };
            // var Chunks = fruits.Chunk(2);
            //
            // foreach (var chunk in Chunks)
            // {
            //     foreach (var fruit in chunk)
            //     {
            //         Console.Write(fruit);
            //         Console.WriteLine();
            //     }
            // }


            #endregion
            #endregion

            #region PartIoning Operators - Skip , SkipWhile , Take , TakeWhile , TakeLast , SkipLast

            #region Take , Skip , TakeLast , SkipLast
            // var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                         .Skip(2)
            //                         .Take(3);
            // Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                     .SkipLast(5);
            //
            // var PageSize = 10;
            // var PageIndex = 4;
            //
            // Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                     .Skip(PageSize * (PageIndex - 1))
            //                     .Take(PageSize);
            //
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region TakeWhile , SkipWhile

            //int[] Numbers = { 5, 2, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // Get the Elementss Stating from the begining of the array until a number is hit that is lrss than its Position in the array

            //var Result = Numbers.TakeWhile((number, Index) => number > Index);

            // get the element of arraay stating from the frist element Divisible by 3

            //var Result = Numbers.SkipWhile(number => number % 3 != 0);
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

     

        }
    }
    }
