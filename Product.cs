namespace G_NET_84_LINQ02;

public sealed record Product(
    int ProductId,
    string ProductName,
    string Category,
    decimal UnitPrice,
    int UnitsInStock);
