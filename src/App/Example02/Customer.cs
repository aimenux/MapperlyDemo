namespace App.Example02;

public sealed record Customer
{
    public Guid CustomerId { get; init; }
    public string CompanyName { get; init; }
    public List<Order> Orders { get; init; }
}

public sealed record Order
{
    public Guid OrderId { get; init; }
    public DateTime OrderDate { get; init; }
    public List<OrderDetail> OrderDetails { get; init; }
}

public sealed record OrderDetail
{
    public int ProductId { get; init; }
    public decimal UnitPrice { get; init; }
    public short Quantity { get; init; }
}