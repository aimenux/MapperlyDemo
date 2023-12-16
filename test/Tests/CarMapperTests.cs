using App.Example01;

using AutoFixture;
using FluentAssertions;

using CarMapper = App.Example01.CarMapper;

namespace Tests;

public class CarMapperTests
{
    private static readonly Fixture Fixture = new();
    
    [Fact]
    public void Should_Map_Car_To_CarDto()
    {
        // arrange
        var car = Fixture.Create<Car>();

        // act
        var carDto = CarMapper.Map(car);

        // assert
        carDto.Should().BeEquivalentTo(car);
    }
}