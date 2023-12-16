namespace App.Example02;

public sealed record CustomerDto
{
    public Guid Id { get; init; }
    public string EnterpriseName { get; init; }
    public List<OrderDto> Orders { get; init; }
}

public sealed record OrderDto
{
    public Guid Id { get; init; }
    public DateTime OrderDate { get; init; }
    public List<OrderDetailDto> OrderDetails { get; init; }
}

public sealed record OrderDetailDto
{
    public int ProductId { get; init; }
    public decimal UnitPrice { get; init; }
    public short Quantity { get; init; }
}