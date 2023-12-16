namespace App.Example01;

public sealed record Car(string Name, int NumberOfSeats, Manufacturer Manufacturer, CarColor Color);

public sealed record Manufacturer(int Id, string Name);

public enum CarColor
{
    Black = 1,
    Blue = 2,
    White = 3,
}