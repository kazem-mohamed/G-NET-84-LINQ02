namespace G_NET_84_LINQ02;

class Program
{
    static void Main(string[] args)
    {
        PrintHeader("Question 1: Top 3 most expensive products");

        var mostExpensiveProducts = ProductList.All
            .OrderByDescending(product => product.UnitPrice)
            .Take(3);

        foreach (var product in mostExpensiveProducts)
        {
            Console.WriteLine($"{product.ProductName} - {product.UnitPrice:C}");
        }

        PrintHeader("\nQuestion 2: Page 2 (page size = 5)");

        var secondPage = ProductList.All
            .Skip(5)
            .Take(5);

        foreach (var product in secondPage)
        {
            Console.WriteLine(product.ProductName);
        }

        PrintHeader("\nQuestion 3: Products below $25 while ordered by price");

        var productsBelowTwentyFive = ProductList.All
            .OrderBy(product => product.UnitPrice)
            .TakeWhile(product => product.UnitPrice < 25m);

        foreach (var product in productsBelowTwentyFive)
        {
            Console.WriteLine($"{product.ProductName} - {product.UnitPrice:C}");
        }

        PrintHeader("\nQuestion 4: Are all seafood products in stock?");

        var allSeafoodInStock = ProductList.All
            .Where(product => product.Category == "Seafood")
            .All(product => product.UnitsInStock > 0);

        Console.WriteLine(allSeafoodInStock);

        PrintHeader("\nQuestion 5: Does the ID list contain 9?");

        int[] ids = [3, 9, 13, 18];
        Console.WriteLine(ids.Contains(9));
    }

    private static void PrintHeader(string title) => Console.WriteLine(title);
}
