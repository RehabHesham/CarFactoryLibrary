namespace CarFactoryLibrary
{
    public abstract class Car
    {
        public double velocity { get; set; }
        public DrivingMode drivingMode { get; set; }


        public Boolean IsStopped()
        {
            if(velocity == 0) return true;
            return false;
        }

        public void Stop()
        {
            velocity = 0;
        }

        public void IncreaseVelocity(double addedVelocity)
        {
            velocity += addedVelocity;
        }

        public abstract void Accelerate();
        
        public string GetDirection()
        {
            return drivingMode.ToString();
        }

        public Car GetMyCar()
        {
            return this;
        }


        public double TimeToCoverDistance(double distance)
        {
            return distance / velocity;
        }

        public override bool Equals(object? obj)
        {
            Car car = obj as Car;
            if (car == null) return false;

            return car.velocity == velocity && car.drivingMode == drivingMode;
        }
    }
}