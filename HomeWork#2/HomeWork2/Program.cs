Console.WriteLine("Student Group");

string[] studentsG1 = new string[] { "Marko", "Marija", "Nikola", "Aleksandar", "Stefanija" };
string[] studentsG2 = new string[] { "Kristina", "Riste", "Mila", "Branko", "Bojana" };

Console.WriteLine("Please enter a number between 1 and 2");
string input = Console.ReadLine();

if (input == "1")
{
    for (int i = 0; i < studentsG1.Length; i++)
    {
        Console.WriteLine(studentsG1[i]);
    }
}
else if (input == "2")
{
    for (int i = 0; i < studentsG2.Length; i++)
    {
        Console.WriteLine(studentsG2[i]);
    }
}
else
{
    Console.WriteLine("You did not enter number between 1 and 2!");
}


