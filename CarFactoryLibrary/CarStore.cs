using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class CarStore
    {
        public List<Car> cars;

        public CarStore()
        {
            cars = new List<Car>();
        }


        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void AddCars(List<Car> carsGroup)
        {
            cars.AddRange(carsGroup);
        }
    }
}
