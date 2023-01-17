using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace TestCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Square rectangle = new Rectangle(2, 5);
            square.ShowInfo();
           
        }
    }
}
