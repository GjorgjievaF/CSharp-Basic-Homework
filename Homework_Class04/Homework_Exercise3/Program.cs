//Create a function that takes a number as input. This method should return the sum of the digits in the number.

Console.WriteLine("Please enter a number with digits :");
bool success = int.TryParse(Console.ReadLine(), out int number);
if (success)
{
    int result = SumOfDigits(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid input");
}




int SumOfDigits(int n)
{
    string number1 = Convert.ToString(n);
    int sum = 0;
    for(int i =0; i < number1.Length; i++)
    {
        sum += Convert.ToInt32(number1.Substring(i, 1));
    }

    return sum;
}
