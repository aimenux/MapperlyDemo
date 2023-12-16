using App.Example02;

using AutoFixture;
using FluentAssertions;

namespace Tests;

public class CustomerMapperTests
{
    private static readonly Fixture Fixture = new();
    
    [Fact]
    public void Should_Map_Customer_To_CustomerDto()
    {
        // arrange
        var customer = Fixture.Create<Customer>();

        // act
        var customerDto = CustomerMapper.Map(customer);

        // assert
        customerDto.Should().BeEquivalentTo(customer, options => options
            .WithMapping<Order, OrderDto>(s => s.OrderId, d => d.Id)
            .WithMapping<Customer, CustomerDto>(s => s.CustomerId, d => d.Id)
            .WithMapping<Customer, CustomerDto>(s => s.CompanyName, d => d.EnterpriseName));
    }
}