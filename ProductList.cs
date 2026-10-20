namespace G_NET_84_LINQ02;

public static class ProductList
{
    public static IReadOnlyList<Product> All { get; } =
    [
        new(1, "Chai", "Beverages", 18m, 39),
        new(2, "Chang", "Beverages", 19m, 17),
        new(3, "Aniseed Syrup", "Condiments", 10m, 13),
        new(4, "Chef Anton's Cajun Seasoning", "Condiments", 22m, 53),
        new(5, "Chef Anton's Gumbo Mix", "Condiments", 21.35m, 0),
        new(6, "Grandma's Boysenberry Spread", "Condiments", 25m, 120),
        new(7, "Uncle Bob's Organic Dried Pears", "Produce", 30m, 15),
        new(8, "Northwoods Cranberry Sauce", "Condiments", 40m, 6),
        new(9, "Mishi Kobe Niku", "Meat/Poultry", 97m, 29),
        new(10, "Ikura", "Seafood", 31m, 31),
        new(11, "Queso Cabrales", "Dairy Products", 21m, 22),
        new(12, "Queso Manchego La Pastora", "Dairy Products", 38m, 86),
        new(13, "Konbu", "Seafood", 6m, 24),
        new(14, "Tofu", "Produce", 23.25m, 35),
        new(15, "Genen Shouyu", "Condiments", 15.5m, 39),
        new(16, "Pavlova", "Confections", 17.45m, 29),
        new(17, "Alice Mutton", "Meat/Poultry", 39m, 0),
        new(18, "Carnarvon Tigers", "Seafood", 62.5m, 42),
        new(19, "Teatime Chocolate Biscuits", "Confections", 9.2m, 25),
        new(20, "Sir Rodney's Marmalade", "Confections", 81m, 40),
        new(21, "Sir Rodney's Scones", "Confections", 10m, 3),
        new(22, "Gustaf's Knäckebröd", "Grains/Cereals", 21m, 104),
        new(23, "Tunnbröd", "Grains/Cereals", 9m, 61),
        new(24, "Guaraná Fantástica", "Beverages", 4.5m, 20),
        new(25, "NuNuCa Nuß-Nougat-Creme", "Confections", 14m, 76),
        new(30, "Nord-Ost Matjeshering", "Seafood", 25.89m, 10),
        new(36, "Inlagd Sill", "Seafood", 19m, 112),
        new(40, "Boston Crab Meat", "Seafood", 18.4m, 123),
        new(44, "Gula Malacca", "Condiments", 19.45m, 27),
        new(58, "Escargots de Bourgogne", "Seafood", 13.25m, 62)
    ];
}
