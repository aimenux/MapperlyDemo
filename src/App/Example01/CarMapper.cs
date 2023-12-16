using Riok.Mapperly.Abstractions;

namespace App.Example01;

[Mapper]
public static partial class CarMapper
{
    public static partial CarDto Map(Car car);
}