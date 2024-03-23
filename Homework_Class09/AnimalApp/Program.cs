using Exercise03.Enums;
using Exercise03.Models;



Animal dog = new Animal("Dog","Brown",4,GenderEnum.Male);
Animal giantPanda = new Animal("GiantPanda", "Black-white",7,GenderEnum.Female);
Animal horse = new Animal("Horse", "Brown",6,GenderEnum.Male);
Animal elephant = new Animal("Elephant", "White",5,GenderEnum.Female);
Animal chimpanzee = new Animal("Chimpanzee", "Gray",3,GenderEnum.Male);
Animal penguins = new Animal("Penguins", "White-black",2,GenderEnum.Male);
Animal alligator = new Animal("Alligator", "Gray",1,GenderEnum.Female);
Animal koala = new Animal("Koala", "Gray",4,GenderEnum.Male);
Animal tiger= new Animal("Tiger", "Brown",8,GenderEnum.Male);
Animal dolphin = new Animal("Dolphin", "Blue-gray-white",1,GenderEnum.Female);

List<Animal> animals = new List<Animal>()
{
    dog,giantPanda,horse,elephant,chimpanzee,penguins,alligator,koala,tiger,dolphin
};


Console.WriteLine("Animals aged 5 or more :");
var animalAged5OrMore = animals.Where(x => x.Age >= 5).Select(x => x.Name);

foreach(var a in animalAged5OrMore)
{

    Console.WriteLine(a);
}


Console.WriteLine("Animals that start with A:");
var startWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();
foreach(var start in startWithA)
{
    Console.WriteLine(start);
}

Console.WriteLine("All male animals and brown color:");

var maleBrownAnimals = animals.Where(x => x.Gender == GenderEnum.Male && x.Color == "Brown").Select(x => x.Name);
foreach(var male in maleBrownAnimals)
{
    Console.WriteLine(male);
}

Console.WriteLine("First animal with name longer than 10 characters :");

var firstAnimalLongerThan10Chr = animals.FirstOrDefault(x => x.Name.Length > 10);
if (firstAnimalLongerThan10Chr != null)
{
    Console.WriteLine(firstAnimalLongerThan10Chr);
}
else
{
    Console.WriteLine("There is no animal with a name longer than 10 characters.");
}

