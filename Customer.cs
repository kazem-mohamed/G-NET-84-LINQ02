namespace G_NET_84_LINQ02;

public sealed record Customer(string CompanyName, string Country, IReadOnlyList<decimal> OrderValues);
