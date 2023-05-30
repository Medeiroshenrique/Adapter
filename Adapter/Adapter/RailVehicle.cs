using System;

namespace Adapter
{
    public class RailVehicle:IMoveQuickly
    {
        Random generator = new Random();
        
        public void BreakPneumatically()
        {
            int brakeDelayTimeInSeconds = this.generator.Next(10);
            Console.WriteLine($"Rail vehicle took {brakeDelayTimeInSeconds} seconds to brake!");
        }

        public void SpeedUp()
        {
            int speed = this.generator.Next(1000);
            Console.WriteLine($"The rail vehicle accelerated to {speed} kilometers per hour!");
        }

        public void Drive(string pilot)
        {
            Console.WriteLine($"{pilot} is driving now!");
        }
        
        
    }
}