using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Tests
{
    public class CircleAreaCalculationTests
    {
        [Fact]
        public void CalculateArea_ValidCircle_ReturnsCorrectArea()
        {
            var circle = new AreaCalculationLibrary.Circle(5);

            double calculatedArea = circle.CalculateArea();

            Assert.Equal(Math.PI * 25, calculatedArea);
        }

        [Fact]
        public void CalculateArea_NegativeCircleRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new AreaCalculationLibrary.Circle(-5));
        }

        [Fact]
        public void CalculateArea_ZeroCircleRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new AreaCalculationLibrary.Circle(0));
        }

    }
}
