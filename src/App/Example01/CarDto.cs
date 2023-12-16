namespace App.Example01;

public sealed record CarDto(string Name, int NumberOfSeats, ManufacturerDto Manufacturer, CarColorDto Color);

public sealed record ManufacturerDto(int Id, string Name);

public enum CarColorDto
{
    Black = 1,
    Blue = 2,
    White = 3,
}