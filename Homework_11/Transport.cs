using System.Runtime.CompilerServices;

namespace Homework_11;

public class Transport
{
    protected string Name { get; set;} 
    protected  int MaxSpeed { get; set;}

    public Transport(string Name, int MaxSpeed)
    {
        this.Name = Name;
        this.MaxSpeed = MaxSpeed;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} traveling at {MaxSpeed} km/h.");
    }

}