using System;

namespace AbstractShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle(5.0);
            c.Scale(2);

            Console.WriteLine(c.Area);

            var t = new Triangle(3, 5);
            
            Console.WriteLine(t.Area);

            var s = new Square(10);
            Console.WriteLine(s.Area);
        }
    }

    // establish a contract for shapes that can be scaled
    interface IScalable
    {
        double Height {get;}
        double Width {get;}

        void Scale(double factor);
    }

    // polygons implement the IScalable interface
    abstract class Polygon : IScalable
    {
        public double Height {get;set;}
        public double Width {get;set;}
        public int NumSides {get;}

        // the constructor establishes the number of sides
        public Polygon(int numSides)
        {
            NumSides = numSides;
        }

        // note this property is derived based on the dimensions
        // it's effectively read only since there's no setter
        public double Area {
            get
            {
                return Height * Width;
            }
        }

        // the virtual keyword allows us to override this in child classes
        // play around with creating additional child classes that override
        // this method
        public virtual void Scale(double factor)
        {
            Height *= factor;
            Width *= factor;
        }
    }

    class Triangle : Polygon
    {
        // note the "new" keyword since we're "hiding" the parent's Area property
        // this suppresses the console warning
        new public double Area {
            get
            {
                return Width * Height * .5;
            }
        }

        // note that we're invoking the parent constructor with 3 to set the sides
        public Triangle(double height, double width) : base(3)
        {
            Height = height;
            Width = width;
        }
    }

    class Square : Polygon
    {
        // again, we invoke the parent constructor, this time with 4
        public Square(double side) : base(4)
        {
            Height = Width = side;
        }
    }

    // the Circle class also implements the IScalable interface
    class Circle : IScalable
    {
        public double Radius {get;set;}

        // the remaining properties are derived from the radius
        public double Height {
            get
            {
                return Radius * 2;
            }
        }
        public double Width {
            get
            {
                return Radius * 2;
            }
        }

        public double Area {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Scale(double factor)
        {
            Radius *= factor;
        }
    }
}
