// Syfte: properties

using System;

namespace M6_Classes.DemoClasses
{
    public class Demo4
    {
        class Car
        {
            public string Color { get; set; }
            public int Weight { get; set; }

            public Car()
            {
                Color = "lila";
                Weight = 999;
            }

            public Car(string x, int y)
            {
                Color = x;
                Weight = y;
            }

        }

        public void Run()
        {
            var c1 = new Car("blå", 1200);
            var c2 = new Car("röd", 800);
            var c3 = new Car();

            Console.WriteLine("Färgen på bilen 'c1' är " + c1.Color + " och dess vikt är " + c1.Weight);
            Console.WriteLine("Färgen på bilen 'c2' är " + c2.Color + " och dess vikt är " + c2.Weight);
            Console.WriteLine("Färgen på bilen 'c3' är " + c3.Color + " och dess vikt är " + c3.Weight);
        }
    }
}
