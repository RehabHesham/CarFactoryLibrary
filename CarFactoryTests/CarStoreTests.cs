using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryTests
{
    public class CarStoreTests
    {
        [Fact]
        [Trait("Author","Ali")]
        public void AddCar_createCarAddtoStore_NotEmpltyStore()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Car car = new BMW();
            Car car1 = new BMW();
            car1.velocity = 1;

            // Act
            carStore.AddCar(car);

            // Assert
            //Assert.Empty(carStore.cars);
            Assert.NotEmpty(carStore.cars);
            //Assert.Contains<Car>(car1, carStore.cars);
            Assert.DoesNotContain<Car>(car1, carStore.cars);
        }
    }
}
