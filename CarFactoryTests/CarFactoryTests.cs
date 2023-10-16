using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryTests
{
    public class CarFactoryTests
    {
        // Refrences assert

        [Fact]
        public void NewCar_CarTypeAudi_Null()
        {
            //Arrange


            // Act
            var result = CarFactory.NewCar(CarTypes.Audi);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void NewCar_CarTypeToyota_ObjectFromToyota()
        {
            //Arrange


            // Act
            var result = CarFactory.NewCar(CarTypes.Toyota);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Toyota>(result);  
            Assert.IsAssignableFrom<Car>(result);
        }

        [Fact]
        public void NewCar_CarTypeToyotaComparewithAnotherToyota_equals()
        {
            //Arrange
            Toyota toyota = new Toyota();

            // Act
            var result = CarFactory.NewCar(CarTypes.Toyota);

            // Assert
            Assert.Equal(toyota, result);
            //Assert.NotEqual(toyota, result);


           // Assert.Same(toyota, result);
            Assert.NotSame(toyota, result);
        }

        [Fact]
        public void NewCar_CarTypeToyotaComparewithAnotherToyota_same()
        {

            // Act
            var result = CarFactory.NewCar(CarTypes.Toyota);


            Car car = result;
            // Assert


            Assert.Same(car, result);
        }

        [Fact]
        public void NewCar_CarTypeHonda_NotEmplementedException()
        {
            // Arrange


            // Act


            // Asssert
            Assert.Throws<NotImplementedException>(() =>
            {
                CarFactory.NewCar(carType: CarTypes.Honda);
            });
        }
    }
}
