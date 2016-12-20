using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOveloading
{
    // change the meaning of an operator

    public class Ball
    {
        public int _diameter = 0;
        public string _name = "";

        
        // change/add the meaning of "-" to "+"
        public static Ball operator - (Ball b1, Ball b2)
        {
            Ball b3 = new Ball();
            b3._diameter = b1._diameter + b2._diameter;
            b3._name = b1._name + b2._name;
            return b3;

        }

        public Ball(int x, string y)
        {
            _diameter = x;
            _name = y;
        }

        public Ball()
        { }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Ball b01 = new Ball(1, "pil");
            Ball b02 = new Ball(2, "ka");
            Ball b03 = new Ball();

            // here - means +
            b03 = b01 - b02;

            //here - means -
           int someNumber = 10 - 1;

           Console.WriteLine("B3 diameter is: " + b03._diameter.ToString() + "\nB3 name is: " + b03._name + "\nSome number is: " + someNumber.ToString());
           Console.ReadKey();

        }
    }
}
