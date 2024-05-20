namespace Homework_11;

public class Bike : Transport
{
    protected string TypeOfBicycle { get; set;}

    public Bike(string Name, int MaxSpeed, string typeOfBicycle) : base(Name, MaxSpeed)
    {
        this.TypeOfBicycle = typeOfBicycle;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} traveling at {MaxSpeed} km/h. It is {TypeOfBicycle} type of bicycle");
    } 
}