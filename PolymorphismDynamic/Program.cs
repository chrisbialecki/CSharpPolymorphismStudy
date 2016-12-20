using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDynamic
{

   class Shape
    {
        protected double _height;
        protected double _width;

        public Shape(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public Shape()
        { }

        public virtual double Area()
        {
            Console.WriteLine("Hi from parent Area");
            Console.ReadLine();
           return 0;
        }

    }



    class Rectangle : Shape
    {
        public Rectangle(double x, double y)
            : base(x, y)
        {
            Console.WriteLine("hi from Rec constructor!");
            Console.ReadLine();
        }

        public override double Area()
        {
            Console.WriteLine("Hi from rectangle override Area");
            Console.ReadLine();
            return _height * _width;
        }


    }

    
    class Triangle : Shape
    {
        public Triangle(double x, double y)
            : base(x, y)
        {
            Console.WriteLine("hi from Tri constructor!");
            Console.ReadLine();
        }

        public override double Area()
        {
            Console.WriteLine("Hi from triangle override Area");
            Console.ReadLine();
            return _height * _width / 2;
        }

    }



   class Caller
    {
       public double GetArea(Shape sh)
       {
           Console.WriteLine("Hi from Caller GetArea");
           Console.ReadLine();
           return sh.Area();
       }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(3, 5);
            Triangle tri = new Triangle(2, 5);

            Caller call = new Caller();

            Shape s = new Shape();

            Console.WriteLine("enter t or r");
            string option = Console.ReadLine();

            if (option == "r")
                s = rec;
            else if (option == "t")
                s = tri;
                     
            
            double area = call.GetArea(s);

            Console.WriteLine("Shape area is: " + area.ToString());
            Console.ReadLine();



          
        }
    }
}
