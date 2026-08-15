void DoSomethingWithPoint(Point p)
{
    p.X = 222;
    p.Y = 111;
}

var ourPoint = new Point()
{
    X = 123,
    Y = 456
};
Console.WriteLine(
        $"our point before DoSomethingWithPoint: {ourPoint.X}, {ourPoint.Y}"
    );
DoSomethingWithPoint(ourPoint);
Console.WriteLine($"our point after DoSomethingWithPoint: {ourPoint.X}, {ourPoint.Y}");

// a struct is a value type, even though it looks like a class

// classes are reference types

// here is an example of a struct:

public struct Point
{
    public int X;
    public int Y;
}

// same struct but with properties
public struct PointWithProperties
{
    public int x { get; set; }
    public int y { get; set; }
}

// same struct but with constructor
public struct PointWithConstructor
{
    public PointWithConstructor(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public int X { get; set; }
    public int Y { get; set; }
}

public struct PointWithMethod
{
    public int X;
    public int Y;

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}