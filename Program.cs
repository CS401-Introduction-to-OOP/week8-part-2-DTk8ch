using Variant2;

// Value type demo
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;

p2.X = 10;

Console.WriteLine("Struct test:");
p1.Print();
p2.Print();
Console.WriteLine("p1 did not change because struct is copied");
Console.WriteLine();

// Reference type demo
PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;

r2.X = 10;

Console.WriteLine("Class test:");
r1.Print();
r2.Print();
Console.WriteLine("r1 changed too because class stores reference");
Console.WriteLine();

// Boxing demo
BoxingTester.Test();
