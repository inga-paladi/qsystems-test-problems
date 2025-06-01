using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary
{
    public static class UnknownShapeAreaCalculator
    {
        public static double CalculateArea(IGeometricShape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape), "Shape cannot be null");
            }
            return shape.CalculateArea();
        }
    }
}
