namespace G_NET_84_LINQ02;

public static class CustomerList
{
    public static IReadOnlyList<Customer> All { get; } =
    [
        new("Alfreds Futterkiste", "Germany", [1200m, 450m]),
        new("Blauer See Delikatessen", "Germany", [875m]),
        new("Bon app'", "France", [640m, 310m]),
        new("Du monde entier", "France", [980m]),
        new("Around the Horn", "UK", [715m, 225m]),
        new("B's Beverages", "UK", [430m]),
        new("Bólido Comidas preparadas", "Spain", [520m, 190m]),
        new("FISSA Fabrica Inter. Salchichas S.A.", "Spain", [760m])
    ];
}
