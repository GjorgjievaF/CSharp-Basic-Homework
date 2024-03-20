

using System.Globalization;

namespace Homeworl_Class07.Models
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name,string color,int [] position,int sideA,int sideB) : base( name, color,position)
        {
           
            SideA = sideA;
            SideB = sideB;
        }

        public override void getArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area for ractangle is : {area}");
        }

        public override void getPerimetar()
        {
            int perimetar = 2 * (SideA + SideB);
            Console.WriteLine($"The perimetar for rectangle is : {perimetar}");

        }
        public override void Move()
        {
            base.Move();
        }

    }
}
