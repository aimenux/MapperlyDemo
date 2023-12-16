using App.Example01;
using App.Example02;

var car = new Car("Fiesta", 4, new Manufacturer(1, "Ford"), CarColor.Black);
var carDto = CarMapper.Map(car);
Console.WriteLine(car.Dump());
Console.WriteLine(carDto.Dump());

var customer = new Customer
{
    CustomerId = Guid.NewGuid(),
    CompanyName = "Ford",
    Orders = new List<Order>
    {
        new Order
        {
            OrderId = Guid.NewGuid(),
            OrderDate = DateTime.Today,
            OrderDetails = new List<OrderDetail>
            {
                new() {ProductId = 1, Quantity = 2, UnitPrice = 10},
                new() {ProductId = 2, Quantity = 4, UnitPrice = 20}
            }
        }
    }
};
var customerDto = CustomerMapper.Map(customer);
Console.WriteLine(customer.Dump());
Console.WriteLine(customerDto.Dump());

