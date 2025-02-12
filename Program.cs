using static System.Net.Mime.MediaTypeNames;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace LINQ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Quantifiers


            // 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'

            string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            var containsEi = dictionaryWords.Any(word => word.Contains("ei"));

            

            // 2. Grouped list of products for categories with at least one product out of stock


            var categoriesWithOutOfStockProducts = ListGenerator.ProductList
                .GroupBy(p => p.Category)
                .Where(g => g.Any(p => p.UnitsInStock == 0))
                .Select(g => new { Category = g.Key, Products = g.ToList() });


            foreach (var category in categoriesWithOutOfStockProducts)
            {
                Console.WriteLine($"Category: {category.Category}");
                foreach (var product in category.Products)
                {
                    Console.WriteLine($"  {product.ProductName} (Stock: {product.UnitsInStock})");
                }
            }

            // 3. Grouped list of products for categories where all products are in stock

            var categoriesWithAllProductsInStock = ListGenerator.ProductList
                .GroupBy(p => p.Category)
                .Where(g => g.All(p => p.UnitsInStock > 0))
                .Select(g => new { Category = g.Key, Products = g.ToList() });


            foreach (var category in categoriesWithAllProductsInStock)
            {
                Console.WriteLine($"Category: {category.Category}");
                foreach (var product in category.Products)
                {
                    Console.WriteLine($"  {product.ProductName} (Stock: {product.UnitsInStock})");
                }
            }
            #endregion



            #region  LINQ – Grouping Operators

       
                // 1. Group numbers by their remainder when divided by 5

                List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                var numberGroups = numbers.GroupBy(n => n % 5);

                
                foreach (var group in numberGroups)
                {
                    Console.WriteLine($"Remainder {group.Key}:");
                    foreach (var number in group)
                    {
                        Console.WriteLine(number);
                    }
                }

         

                // 2. Group words by their first letter using dictionary_english.txt

                var words = File.ReadAllLines("dictionary_english.txt").Where(w => !string.IsNullOrWhiteSpace(w));
                var wordGroups = words.GroupBy(w => w[0].ToString().ToUpper());

                

                foreach (var group in wordGroups)
                {
                    Console.WriteLine($"Letter {group.Key}:");
                    foreach (var word in group.Take(5)) 
                    {
                        Console.WriteLine(word);
                    }
                }

         

                // 3. Group words with same characters together

                string[] arr = { "from", "salt", "earn", " last", "near", "form" };
                var Groups = arr.GroupBy(w => new string(w.Trim().ToCharArray().OrderBy(c => c).ToArray()));

           
                foreach (var group in Groups)
                {
                    Console.WriteLine($"Group: {string.Join(", ", group)}");
                }
       

    #endregion


}
    }
}
