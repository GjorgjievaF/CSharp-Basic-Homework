

namespace Homework_Exercise2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog(string name,string bread,string color)
        {
            Name = name;
            Breed = bread;
            Color = color;
        }



        public string Eat()
        {
            return "The dog is now eating";
        }

        public string Play()
        {
            return "The dog is now playing";
        }

        public string ChaseTail()
        {
            return "Dog is now chasing its tail";
        }

    }

}
