using hw10;

List<Triangle> triangles = new List<Triangle> {};
triangles.Add(new Triangle(new Point(2,1), new Point(5,1), new Point(0,1)));
triangles.Add(new Triangle(new Point(3,1), new Point(1,4), new Point(2,0)));
triangles.Add(new Triangle(new Point(1,0), new Point(4,2), new Point(0,3)));

foreach(Triangle t in triangles)
{
     t.Print();
}

public struct Point
{
    int x, y;

    public int X { get { return this.x; } set { this.x = value; } }
    public int Y { get { return this.y; } set { this.y = value; } }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({x},{y})";
    }
}

