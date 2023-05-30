using System;

namespace Adapter
{
    public class Car
    {
        Random genarator = new Random();

        public void Accelerate()
        {
            int acceleratedSpeed = this.genarator.Next(250);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The car accelerated to {acceleratedSpeed} kilometers per hour");
            Console.ResetColor();
        }

        public void BrakeTheCar()
        {
            int TimeToBrake = this.genarator.Next(5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The car braked in {TimeToBrake} seconds.");
            Console.ResetColor();
        }

        public void Control(string pilot )
        {
            Console.WriteLine($"The car is being drived by {pilot}");
        }
    }
}