using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Tests
{
    public class UnknownShapeAreaCalculationTest
    {
        [Fact]
        public void CalculateArea_WithNullShape_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => UnknownShapeAreaCalculator.CalculateArea(null));
        }

        [Fact]
        public void CalculateArea_WithValidShape_ReturnsCorrectArea()
        {
            var shape = new Triangle(3, 4, 5);
            double area = UnknownShapeAreaCalculator.CalculateArea(shape);
            Assert.Equal(6, area);
        }
    }
}
