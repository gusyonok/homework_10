using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10
{
    public class Triangle
    {
        public Point vertex1, vertex2, vertex3;

        public Point point {  get; set; }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Distance(Point p1, Point p2)
        {
            double distance = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            return distance;
        }

        public double Perimeter()
        {
            double perimeter = Distance(vertex1,vertex2) + Distance(vertex1,vertex3) + Distance(vertex2,vertex3);
            return perimeter;
        }

        public double Area()
        {
            double halfP = Perimeter() / 2;
            double area = Math.Sqrt(halfP*(halfP-Distance(vertex1,vertex2))* (halfP - Distance(vertex1, vertex3))* (halfP - Distance(vertex2, vertex3)));
            return area;
        }

        public void Print()
        {
            Console.WriteLine($"Primeter of triangle = {Perimeter()} & Area = {Area()}");
        }

    }
}