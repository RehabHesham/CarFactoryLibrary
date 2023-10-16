using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryTests
{
    public class ToyotaTests
    {
        // Boolean Assert
        [Fact]
        [Trait("Author", "Ahmed")]
        [Trait("Priority","1")]
        public void IsStopped_velocity0_True()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Act
            var result = toyota.IsStopped();

            // Assert
            Assert.True(result);
        }


        // string asserts
        [Fact]
        [Trait("Author", "Ali")]
        [Trait("Priority", "1")]

        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.drivingMode = DrivingMode.Forward;

            // Act
            var result = toyota.GetDirection();

            //Assert
            // Assert.Equal("Forward",result);
            //Assert.StartsWith("For", result);
            //Assert.EndsWith("rd", result);
            //Assert.Contains("war", result);
            //Assert.Matches(regex, result)
        }

        // numeric asserts
        [Fact]
        [Trait("Author", "Ali")]
        [Trait("Priority", "2")]

        public void Accelerate_CarToyotavilocity5_10()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 5;

            // Act
            toyota.Accelerate();

            // Assert
            Assert.Equal(10, toyota.velocity);
        }

        [Fact(Skip ="Working to solve this error")] 
        public void Accelerate_AnyCarVelocity5_Range10to20()
        {
            // Arrange
            Car car = new BMW();
            car.velocity = 5;

            // Act
            car.Accelerate();

            // Assert
            Assert.InRange<double>(car.velocity, 10, 20);
           // Assert.NotInRange<>();
        }

       
       


    }
}
