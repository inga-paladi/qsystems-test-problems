namespace ElementsFinder.Tests;

public class ElementsFinderHelperTests
{
    [Fact]
    public void FindElements_SuccessfulCase_ReturnsCorrectIndices()
    {
        var list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 };
        ulong sum = 11;
        var finder = new ElementsFinderHelper();
        finder.FindElementsForSum(list, sum, out int start, out int end);
        Assert.Equal(5, start);
        Assert.Equal(7, end);
    }

    [Fact]
    public void FindElements_EmptyList_ThrowsArgumentException()
    {
        var list = new List<uint>();
        ulong sum = 10;
        var finder = new ElementsFinderHelper();
        Assert.Throws<ArgumentException>(() => finder.FindElementsForSum(list, sum, out int start, out int end));
    }

    [Fact]
    public void FindElements_SingleElementList_ThrowsArgumentException()
    {
        var list = new List<uint> { 5 };
        ulong sum = 5;
        var finder = new ElementsFinderHelper();
        Assert.Throws<ArgumentException>(() => finder.FindElementsForSum(list, sum, out int start, out int end));
    }

    [Fact]
    public void FindElements_NoMatchingSum_ReturnsZeroIndices()
    {
        var list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 };
        ulong sum = 88;
        var finder = new ElementsFinderHelper();
        finder.FindElementsForSum(list, sum, out int start, out int end);
        Assert.Equal(0, start);
        Assert.Equal(0, end);
    }

    [Fact]
    public void FindElements_MatchingSumAtStart_ReturnsCorrectIndices()
    {
        var list = new List<uint> { 2, 3, 4, 1, 1 };
        ulong sum = 5;
        var finder = new ElementsFinderHelper();
        finder.FindElementsForSum(list, sum, out int start, out int end);
        Assert.Equal(0, start);
        Assert.Equal(2, end);
    }

    [Fact]
    public void FindElements_MultipleMatchingSums_ReturnsFirstMatch()
    {
        var list = new List<uint> { 1, 2, 3, 4, 5, 6, 3, 7 ,3};
        ulong sum = 10;
        var finder = new ElementsFinderHelper();
        finder.FindElementsForSum(list, sum, out int start, out int end);
        Assert.Equal(0, start);
        Assert.Equal(4, end); 
    }

    [Fact]
    public void FindElements_LargeNumbers_ReturnsCorrectIndices()
    {
        var list = new List<uint> { 1_000_000, 2_000_000, 15_000_000, 4_000_000, 5_000_000, 6_000_001 };
        ulong sum = 15_000_001;
        var finder = new ElementsFinderHelper();
        finder.FindElementsForSum(list, sum, out int start, out int end);
        Assert.Equal(3, start);
        Assert.Equal(6, end);
    }



}
