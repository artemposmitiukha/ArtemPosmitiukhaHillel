namespace Homework_11;

public class Car : Transport
{
    protected int NumOfDoors { get; set;}

    public Car(string Name, int MaxSpeed, int NumOfDoors) : base(Name, MaxSpeed)
    {
            
        this.NumOfDoors = NumOfDoors;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} traveling at {MaxSpeed} km/h. It has {NumOfDoors} {(NumOfDoors == 1?"door" :"doors")}");
    }
}