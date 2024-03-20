

namespace Homeworl_Class07.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (string name,string color,int[] position,double radius) : base (name, color,position)
        {
            Radius = radius;

        }

        public override void getArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The area for the circle is :{area}");
        }

        public override void getPerimetar()
        {
            double perimetar = 2 * Math.PI * Radius;
            Console.WriteLine($"The perimetar for thr circle is :{perimetar}.");
        }

        public override void Move()
        {
            base.Move();
        }


    }
}
