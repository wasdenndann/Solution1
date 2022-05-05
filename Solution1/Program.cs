using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Circle kreis1 = new Circle();
            Circle kreis2 = kreis1;
            kreis1.Radius = 10;

            Console.WriteLine(kreis2.Radius);

            kreis2.Radius = 20;
            Console.WriteLine(kreis2.Radius);
            Console.WriteLine(kreis1.Radius);
            Console.WriteLine();

            long value1 = 64;
            long value2 = value1;
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            value1 = 100;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Circle kreis3 = new Circle {Radius = 5};
            //kreis3.Radius = 5;


            Console.WriteLine("kreis1, Fläche {0}, Umfang {1}", kreis1.GetArea(), kreis1.GetCircumference());
            Console.WriteLine("kreis2, Fläche {0}, Umfang {1}", kreis2.GetArea(), kreis2.GetCircumference());
            Console.WriteLine("kreis3, Fläche {0}, Umfang {1}", kreis3.GetArea(), kreis3.GetCircumference());

            kreis1.Xcoordinate = -100;
            kreis1.Ycoordinate = 90;
            kreis1.Move(120, -200);

            Console.WriteLine();
            
            

        }
    }
    class Demo
    {
        public void Change(Circle @object)
        {
            @object.Radius = 1;
        }
    }
}
