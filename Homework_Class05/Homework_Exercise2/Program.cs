using Homework_Exercise2;

#region Exercise_requirtments!
//Create a class Dog
//Add properties: Name, breed, color
//The dog needs to have an Eat method that returns message: The dog is now eating.
//A Play method returning a message : The dog is now playing. and a
//ChaseTail method that returns a message: Dog is now chasing its tail.
//The user needs to create a dog object by using inputs and then choose an option to choose one
//of the methods mentioned above. For example, if he enters 1 to call Eat method, if he enters 2 to call Play, if user enters 3 to call Play.


#endregion


void PrintMessage()
{

    Console.WriteLine("Enter dog's name : ");
    string dogsName = Console.ReadLine();
    Console.WriteLine("Enter dog's breed :");
    string dogsBreed = Console.ReadLine();
    Console.WriteLine("Enter dog's color :");
    string dogsColor = Console.ReadLine();

    Dog dog = new Dog(dogsName, dogsBreed, dogsColor);

    Console.WriteLine("Chose one option :");
    Console.WriteLine("1.Eat");
    Console.WriteLine("2.Play");
    Console.WriteLine("3.Chase Tail");

    bool success = int.TryParse(Console.ReadLine(), out int input);
    if (success)
    {
        if (input == 1)
        {
            Console.WriteLine(dog.Eat());
        }
        else if (input == 2)
        {
            Console.WriteLine(dog.Play());
        }
        else if (input == 3)
        {
            Console.WriteLine(dog.ChaseTail());
        }

    }
    else
    {
        Console.WriteLine("You did not enter number between 1 and 3!");
    }

}

PrintMessage();
