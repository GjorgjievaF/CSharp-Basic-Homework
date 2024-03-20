//Create a class Shape that has:

//Name
//Color
//Position, array of x and y coordinates (int[])
//getArea - method that will only write in the console that there is no special implementation for area
//getPerimeter - method that will only write in the console that there is no special implementation for perimeter *add method move that is shared among all instances and can be accessed through the class name. It updates the position of the input, by increasing the coordinates for 5.
//create a setter and getter for the color and name property. The setter/getter will log a corresponding message. The setter should do validation.

//Add class Rectangle, that inherits from Shape. It should have properties sideA and sideB. Override the getArea and getPerimeter methods correspondingly for a rectangle.
//Add class Circle, that inherits from Shape. It should have property radius. Override the getArea and getPerimeter methods correspondingly for a circle. Test with few objects.


using Homeworl_Class07.Models;

//Rectangle

Console.WriteLine("*** rectangle1 ***");

Rectangle rectangle1 = new Rectangle("Ractangle","Green",new int[] {1,2},4,5) ;
rectangle1.getArea();
rectangle1.getPerimetar();
rectangle1.Move();


Console.WriteLine("*** rectangle2 ***");

Rectangle rectangle2 = new Rectangle("Rectangle", "White", new int[] { 8, 3 }, 6, 9);
rectangle2.getArea();
rectangle2.getPerimetar();
rectangle2.Move();


//Circle

Console.WriteLine("*** circle1 ***");

Circle circle1 = new Circle("Circle","Blue",new int[] { 3, 3 },6);
circle1.getArea();
circle1.getPerimetar();
circle1.Move();

Console.WriteLine("*** circle2 ***");

Circle circle2 = new Circle("Circle", "Red", new int[] { 0, 0 }, 7);
circle2.getArea();
circle2.getPerimetar();
circle2.Move();

