Console.WriteLine("Avarage Number");

int firstNumber;
int secondNumber;
int thirdNumber;
int fourNumber;

Console.WriteLine("Enter the first number :");
string firstInput = Console.ReadLine();
Console.WriteLine("Enter the second number :");
string secondInput = Console.ReadLine();
Console.WriteLine("Enter the third number :");
string thirdInput = Console.ReadLine();
Console.WriteLine("Enter the four number :");
string fourInput = Console.ReadLine();

bool firstConvertInput = int.TryParse(firstInput, out firstNumber);
bool secondConvertInput = int.TryParse(secondInput, out secondNumber);
bool thirdConvertInput = int.TryParse(thirdInput, out thirdNumber);
bool fourConvertInput = int.TryParse(fourInput, out fourNumber);

int sumOfNumbers = firstNumber + secondNumber + thirdNumber + fourNumber;
int avarageNumbers = sumOfNumbers / 4;

Console.WriteLine(avarageNumbers);