//Create a list of ten numbers.
//Use LINQ to select in a list of the squares of all the numbers in the list from above.


List<int> integers = new List<int> { 2, 4, 6, 8, 10, 11, 13, 15, 16, 18 };

List<int> newList = integers.Select(x => x * x).ToList();

foreach(var item in newList)
{
    Console.WriteLine(item);
}