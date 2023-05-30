namespace Adapter
{
    public class Car_To_RailAdapter: IMoveQuickly
    {
        private Car car;

        public Car_To_RailAdapter(Car new_car)
        {
            this.car = new_car;
        }

        public void BreakPneumatically()
        {
            this.car.BrakeTheCar();
        }

        public void SpeedUp()
        {
            this.car.Accelerate();
        }

        public void Drive(string pilot)
        {
            this.car.Control(pilot);
        }
    }
}