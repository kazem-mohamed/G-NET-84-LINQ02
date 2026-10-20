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
    }

    private static void PrintHeader(string title) => Console.WriteLine(title);
}
