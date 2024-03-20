

namespace Homeworl_Class07.Models
{
    public class Shape
    {
        public string name;
        public string color;
        public int[] Position { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != null)
                {
                    name = value;
                    Console.WriteLine($"Name set to : {name}");
                }


            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (value.Length > 0)
                {
                    color = value;
                    Console.WriteLine($"Color set to : {color}");
                }
                else
                {
                    Console.WriteLine("Invalid color");
                }
            }
        }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;

        }

        public virtual void getArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void getPerimetar()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public virtual void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"Position : {Position[0]} - {Position[1]}");
        }
    }
}