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

        PrintHeader("\nQuestion 6: Product count by category");

        var productsByCategory = ProductList.All.GroupBy(product => product.Category);

        foreach (var group in productsByCategory)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }

        PrintHeader("\nQuestion 7: Product names by category");

        var namesByCategory = ProductList.All
            .GroupBy(product => product.Category)
            .Select(group => new { Category = group.Key, Names = group.Select(product => product.ProductName) });

        foreach (var group in namesByCategory)
        {
            Console.WriteLine($"{group.Category}: {string.Join(", ", group.Names)}");
        }

        PrintHeader("\nQuestion 8: Categories with more than 3 products");

        var categoriesWithMoreThanThreeProducts = ProductList.All
            .GroupBy(product => product.Category)
            .Where(group => group.Count() > 3);

        foreach (var group in categoriesWithMoreThanThreeProducts)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }

        PrintHeader("\nQuestion 9: Customers grouped by country");

        var customerCountries =
            from customer in CustomerList.All
            group customer by customer.Country into countryGroup
            select new
            {
                Country = countryGroup.Key,
                Count = countryGroup.Count(),
                TotalOrderValue = countryGroup.Sum(customer => customer.OrderValues.Sum())
            };

        foreach (var country in customerCountries)
        {
            Console.WriteLine($"{country.Country}: {country.Count} customers, {country.TotalOrderValue:C}");
        }

        PrintHeader("\nQuestion 10: Total units in stock");

        var totalUnitsInStock = ProductList.All.Sum(product => product.UnitsInStock);
        Console.WriteLine(totalUnitsInStock);

        PrintHeader("\nQuestion 11: Cheapest and most expensive prices");

        Console.WriteLine($"Cheapest: {ProductList.All.Min(product => product.UnitPrice):C}");
        Console.WriteLine($"Most expensive: {ProductList.All.Max(product => product.UnitPrice):C}");

        PrintHeader("\nQuestion 12: Distinct product categories");

        foreach (var category in ProductList.All.Select(product => product.Category).Distinct())
        {
            Console.WriteLine(category);
        }

        PrintHeader("\nQuestion 13: IDs in setA but not setB");

        int[] setA = [1, 3, 5, 7, 9, 11, 13];
        int[] setB = [3, 6, 9, 12, 15, 13];

        Console.WriteLine(string.Join(", ", setA.Except(setB)));

        PrintHeader("\nQuestion 14: Countries in list1 but not list2");

        string[] list1 = ["Germany", "France", "UK", "Spain"];
        string[] list2 = ["france", "SPAIN", "Italy"];

        Console.WriteLine(string.Join(", ", list1.Except(list2, StringComparer.OrdinalIgnoreCase)));
    }

    private static void PrintHeader(string title) => Console.WriteLine(title);
}
