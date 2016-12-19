using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStudy
{

    public class Calculation
    {
        //polymorphism - allowed when the name stays the same but parameters change.
        // just changing return type is not enough
        
        // signature is: name + type, kind and number of parameters
        // return type is not part of signature



        public int SomeMethod(int x, int y)
        {
            return x + y;
        }

        public int SomeMethod(int x, int y, string a)
        {
            return x;
        }
        
        
       
        
        
        
        public int Add(int a, int b)
        {
            return a + b;               
        }

        public string Add(int a, int b, int c)
        {
            string message = "";
            
            if ((a + b + c) > 3)
            {
                message = "Total is more than 3";
            }

            return message;
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
 

            Calculation calc = new Calculation();
            Console.WriteLine(calc.Add(1, 4).ToString());
            Console.ReadKey();

            Console.WriteLine(calc.Add(2, 3, 4));
            Console.ReadKey();


           
        }
    }
}
