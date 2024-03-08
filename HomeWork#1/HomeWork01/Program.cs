Console.WriteLine("Real Calculator");

int firstNumberConvert;
int secondNumberConvert;


Console.WriteLine("Enter first number:");
string firstInput = Console.ReadLine();
Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();
Console.WriteLine("Enter operation:");
char operationInput = Convert.ToChar(Console.ReadLine());

bool firstParseString = int.TryParse(firstInput, out firstNumberConvert);
bool secondParseString = int.TryParse(secondInput, out secondNumberConvert);


int result = 0;



if (operationInput == '+')
{
    result = firstNumberConvert + secondNumberConvert;
}
else if (operationInput == '-')
{
    result = firstNumberConvert - secondNumberConvert;
}
else if (operationInput == '/')
{
    result = firstNumberConvert / secondNumberConvert;
}
else if (operationInput == '*')
{
    result = firstNumberConvert * secondNumberConvert;
}
else
{
    Console.WriteLine("You did not enter a number");
}



Console.WriteLine(result);