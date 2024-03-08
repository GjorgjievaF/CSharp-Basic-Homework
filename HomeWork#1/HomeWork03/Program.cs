Console.WriteLine("Swap Numbers");

int firstNumber;
int secondNumber;

Console.WriteLine("Input the first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Input the second number:");
string secondInput = Console.ReadLine();

bool firstParseInput = int.TryParse(firstInput, out firstNumber);
bool secondParseInput = int.TryParse(secondInput, out secondNumber);

Console.WriteLine($"First Number : {secondNumber}");
Console.WriteLine($"Second Number : {firstNumber}");
