using System.Runtime.InteropServices.Marshalling;

class Vehicle
{
    protected double[] coordinates;
    protected double price;
    protected double speed;
    protected int year;

    public Vehicle(double price, double speed, int year, params double[] coord)
    {
        coordinates = coord;
        this.price = price;
        this.speed = speed;
        this.year = year;  
    }
    public void print()
    {
        Console.WriteLine("координаты:");
        foreach (var v in coordinates) Console.WriteLine(v);

        Console.WriteLine("price = " + price + ", speed = " + speed + ", year = " + year);
    }
} 

class Plane : Vehicle
{
    protected double hight;
    protected int pass;

    public Plane(double price, double speed, int year, int pass, params double[] coord) : base(price, speed, year, coord)
    { 
        this.hight = coord[2];
        this.pass = pass;
    }

    public new void print()
    {
        Console.WriteLine("Plane:");
        base.print();
        Console.WriteLine("passengers: " + pass);
    }

}

class Ship : Vehicle
{
    protected string port;
    protected int pass;

    public Ship(double price, double speed, int year, int pass, string port, params double[] coord) : base(price, speed, year, coord)
    {
        this.port = port;
        this.pass = pass;
    }

    public new void print()
    {
        Console.WriteLine("Ship:");
        base.print();
        Console.WriteLine("port: " + port);
    }
}

class Program
{
    static void Main()
    {
        double[] cord = [12.3, 32.1, 1000];
        Vehicle car = new Vehicle(200000, 90, 2018, cord);
        Plane plane = new Plane(1000000, 890, 2010, 100, cord);
        Ship ship= new Ship(1000000, 20, 1990, 500, "Samara", cord);
        car.print();
        plane.print();
        ship.print();
    }
}

