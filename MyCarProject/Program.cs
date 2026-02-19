namespace MyCarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Red");

            Console.WriteLine("Car Details:");
            // Console.WriteLine($"Brand: {myCar.Brand}");
            Console.WriteLine("Brand: " + myCar.Brand);
            

            myCar.Start();

            myCar.Accelerate(20);
            myCar.Accelerate(10);

            myCar.Stop();

            Console.ReadLine();


            //Console.WriteLine("Color: " + myCar.Color);
            //Console.ReadLine();

            //Console.WriteLine("Changed Color");
            //myCar.Color = "Green";
            //Console.WriteLine("Color: " + myCar.Color);
            //Console.ReadLine();


            //Console.WriteLine("-------------------");
            //Car anotherCar = new Car("Honda", "Blue");
            //Console.WriteLine("Another Car Details:");
            //Console.WriteLine("Brand: " + anotherCar.Brand);
            //Console.ReadLine();
        }
    }
}
