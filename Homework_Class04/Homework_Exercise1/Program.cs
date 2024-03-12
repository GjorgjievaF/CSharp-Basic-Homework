
//Take one string from the input and print its last 5 characters.

Console.WriteLine("Please enter a string : ");
string input = Console.ReadLine();

if(input.Length >= 5)
{
    string lastFive = input.Substring(input.Length -5);
    Console.WriteLine("The last five characters are " + lastFive);
}
else
{
    Console.WriteLine("Invalid input");
}

