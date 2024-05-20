namespace Homework_11;

class Program
{
    static void Main(string[] args)
    {
        /*
        Car car = new Car("Porsche", 250, 2);
        car.Move();
        Bike bike = new Bike("Trek FX+ 2", 45, "Electric");
        bike.Move();
        */

        Console.Write("Enter car name: ");
        string name_1 = Console.ReadLine();
        int speed_1;
        do Console.Write("Enter car speed: ");
        while(!int.TryParse(Console.ReadLine(), out speed_1) || speed_1 <= 0);

        int numOfDoors_1;
        do Console.Write("Enter num of doors: ");
        while(!int.TryParse(Console.ReadLine(), out numOfDoors_1) || numOfDoors_1 <= 0);
        Car car_2 = new Car(name_1, speed_1, numOfDoors_1);
        car_2.Move();
        
        
        Console.Write("Enter bike name: ");
        string name_2 = Console.ReadLine();
        int speed_2;
        do Console.Write("Enter bike speed: ");
        while(!int.TryParse(Console.ReadLine(), out speed_2) || speed_2 <= 0);
        Console.Write("Enter bike type: ");
        string bikeType = Console.ReadLine();
        Bike bike_2 = new Bike(name_2, speed_2, bikeType);
        bike_2.Move();
    }
}