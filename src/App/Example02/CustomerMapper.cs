using Riok.Mapperly.Abstractions;

namespace App.Example02;

[Mapper]
public static partial class CustomerMapper
{
    [MapProperty(nameof(Customer.CustomerId), nameof(CustomerDto.Id))]
    [MapProperty(nameof(Customer.CompanyName), nameof(CustomerDto.EnterpriseName))]
    public static partial CustomerDto Map(Customer customer);

    [MapProperty(nameof(Order.OrderId), nameof(OrderDto.Id))]
    private static partial OrderDto Map(Order order);
}