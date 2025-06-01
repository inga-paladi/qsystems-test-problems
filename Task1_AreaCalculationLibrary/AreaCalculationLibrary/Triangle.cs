namespace AreaCalculationLibrary;
public class Triangle : IGeometricShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (new[] { sideA, sideB, sideC }.Any(side => side <= 0))
        {
            throw new ArgumentException("Sides must be positive non null numbers.");
        }
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("The provided sides do not form a valid triangle.");

        A = sideA;
        B = sideB;
        C = sideC;
    }
    public double CalculateSemiPerimeter()
    {
        return (A + B + C) / 2;
    }

    public double CalculateArea()
    {
        double semiPerimeter = CalculateSemiPerimeter();
        return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
    }
    public bool IsRightAngled()
    {
        // Check if the triangle is a right-angled triangle using the Pythagorean theorem
        double[] sides = { A, B, C };
        Array.Sort(sides);

        // Check if the square of the longest side is equal to the sum of the squares of the other two sides
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }
}

