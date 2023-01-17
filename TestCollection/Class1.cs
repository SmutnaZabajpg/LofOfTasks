using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection
{
 
    public class Square
    {
        protected double sideA;
        
        public Square()
        {

        }

        public Square(double side)
        {
            sideA = side;
        }
        
        public void ShowInfo()
        {
           
            Console.WriteLine("Informacje o obiekcie:");
            Console.WriteLine($"Bok: {sideA}");
            Console.WriteLine($"Pole: {sideA * sideA}");
            Console.WriteLine($"Obwód: {sideA * 4}");
        }
    }
    public class Rectangle : Square
    {
        protected double sideB;

        public Rectangle()
        {
            sideA = 1;
            sideB = 1;
        }

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public new void ShowInfo()
        {

            Console.WriteLine("Informacje o obiekcie:");
            Console.WriteLine($"Boki: {sideA}, {sideB}");
            Console.WriteLine($"Pole: {sideA * sideB}");
            Console.WriteLine($"Obwód: {sideA * 2 + sideB * 2}");
        }
    }
}
