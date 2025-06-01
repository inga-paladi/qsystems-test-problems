namespace AreaCalculationLibrary.Tests;

public class TriangleAreaCalculationTests
{
    [Fact]
    public void CalculateArea_ValidSides_ReturnTrue()
    {
        var triangle = new AreaCalculationLibrary.Triangle(3,4,5);
       
        double calculatedArea = triangle.CalculateArea();
        
        Assert.Equal(6, calculatedArea);
    }
    
    [Fact]
    public void CalculateArea_NegativeSides_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new AreaCalculationLibrary.Triangle(-1, 2, 3));
    }

    [Fact]
    public void Constructor_SidesDoNotSatisfyTriangleInequality_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3)); 
    }


    [Fact]
    public void CalculateArea_ZeroSlides_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new AreaCalculationLibrary.Triangle(0, 2, 3));
    }

    [Fact]
    public void IsRightAngled_ValidRightAngledTriangle_ReturnsTrue()
    {
        var triangle = new AreaCalculationLibrary.Triangle(3, 4, 5);

        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void IsRightAngled_InvalidRightAngledTriangle_ReturnsFalse()
    {
        var triangle = new AreaCalculationLibrary.Triangle(3, 3, 5);

        Assert.False(triangle.IsRightAngled());
    }
}
