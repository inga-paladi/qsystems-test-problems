using ElementsFinder;

var list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 };
ulong sum = 11;
var elementsFinder = new ElementsFinderHelper();
elementsFinder.FindElementsForSum(list, sum, out int start, out int end);

if (start == 0 && end == 0)
    Console.WriteLine($"No sequence found. The indexes are start = {start}, end = {end}");
else 
    Console.WriteLine($"The indexes are start = {start}, end = {end}");