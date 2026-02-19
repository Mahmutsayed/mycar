using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarProject
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        //Constructor to initialize the properties
        public Car(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
            // Additional logic to start the car can be added here
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
            // Additional logic to stop the car can be added here
        }

        public void Accelerate(int increment)
        {
            // Speed = Speed + increment;
            Speed += increment;
            Console.WriteLine($"{Brand} is accelerating. Current speed: {Speed} km/h");
        }

        public void Decelerate(int decrement)
        {
            Speed -= decrement;
            if (Speed < 0)
                Speed = 0;
            Console.WriteLine($"{Brand} is decelerating. Current speed: {Speed} km/h");
        }



    }
}
