using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDynamic
{

    // method override

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



    class Rectangle : Shape , ISufrace
    {
        private double _height;
        private double _width;

        
        public Rectangle(double x, double y)
            : base(x, y)
        {
            Console.WriteLine("hi from Rec constructor!");
            Console.ReadLine();

            _height = x;
            _width = y;


        }

        public override double Area()
        {
            Console.WriteLine("Hi from rectangle override Area");
            Console.ReadLine();
            return _height * _width;
        }



        public double CalculateArea()
        {
            double area = _height * _width;
            return area;
        }
    }

    
    class Triangle : Shape, ISufrace
    {
        private double _height;
        private double _width;
        
        public Triangle(double x, double y)
            : base(x, y)
        {
            Console.WriteLine("hi from Tri constructor!");
            Console.ReadLine();

            _height = x;
            _width = y;
        }

        public override double Area()
        {
            Console.WriteLine("Hi from triangle override Area");
            Console.ReadLine();
            return _height * _width / 2;
        }


        public double CalculateArea()
        {
            double area = _height * _width;
            return area;
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
        public static double GetArea(ISufrace sufrace)
        {
            double area = sufrace.CalculateArea();
            return area;
        }
        
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
                     
            
            double areaInherited = call.GetArea(s);
            
            double areaInterface = GetArea(rec);

            Console.WriteLine("Inherited shape area is: " + areaInherited.ToString());
            Console.WriteLine("Interface shape area is: " + areaInterface.ToString());
            Console.ReadLine();




          
        }
    }
}
