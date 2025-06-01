namespace AreaCalculationLibrary;
public class Circle : IGeometricShape
{
    public double Radius { get; }
    public Circle(double radius)
    {
        if (radius <= 0) 
        {
            throw new ArgumentException("Radius must be a positive number."); 
        }
        Radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

