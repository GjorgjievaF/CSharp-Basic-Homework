Console.WriteLine("Sum of EVEN");

int[] arrayOfInt = new int[6];
int sum = 0;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Enter integer no.{i + 1} :");
    arrayOfInt[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < arrayOfInt.Length; i++)

{
    if (arrayOfInt[i] % 2 == 0)
    {

        sum += arrayOfInt[i];


    }


}

Console.WriteLine("The result is : " + sum);

