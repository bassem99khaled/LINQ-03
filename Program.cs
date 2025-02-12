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



                #region


                #endregion


            }
    }
}
