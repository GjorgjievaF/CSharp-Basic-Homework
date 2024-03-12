
//Take a sentence as input and print its words.

Console.WriteLine("Please enter a sentance :");
string input = Console.ReadLine();

string[] splitString = input.Split(" ");

foreach (string split in splitString)
{
    Console.WriteLine(split);
}
