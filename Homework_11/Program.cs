using System.Data;

namespace Homework_11;

class Program
{
    static (string, int) GetInfo(string transport)
    {
        Console.Write($"Enter {transport.ToString()} name: ");
        string name = Console.ReadLine();
        int speed;
        do Console.Write("Enter car speed: ");
        while(!int.TryParse(Console.ReadLine(), out speed)|| speed <= 0);
        return (name , speed);
    }
    static void Main(string[] args)
    {
        /*
        Car car = new Car("Porsche", 250, 2);
        car.Move();
        Bike bike = new Bike("Trek FX+ 2", 45, "Electric");
        bike.Move();
        */

        var (carName, carSpeed) = GetInfo("car");
        int numOfDoors_1;
        do Console.Write("Enter num of doors: ");
        while(!int.TryParse(Console.ReadLine(), out numOfDoors_1) || numOfDoors_1 <= 0);
        Car car_2 = new Car(carName, carSpeed, numOfDoors_1);
        car_2.Move();
        
        
        var (bikeName, bikeSpeed) = GetInfo("bike");
        
        Console.Write("Enter bike type: ");
        string bikeType = Console.ReadLine();
        Bike bike_2 = new Bike(carName, carSpeed, bikeType);
        bike_2.Move();
    }
}