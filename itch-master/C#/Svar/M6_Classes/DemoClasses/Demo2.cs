using System;

namespace M6_Classes.DemoClasses
{
    public class Demo2
    {
        class Car
        {
            private string color;
            private int weight;

            public void SetColor(string x)
            {
                color = x;
            }

            public string GetColor()
            {
                return color;
            }

            public void SetWeight(int x)
            {
                weight = x;
            }

            public int GetWeight()
            {
                return weight;
            }


        }

        public void Run()
        {
            var c1 = new Car();
            var c2 = new Car();
            Car c3 = new Car();

            c1.SetColor("blå");
            c1.SetWeight(1200);

            c2.SetColor("röd");
            c2.SetWeight(800);

            var yyy = c1.GetColor();
            var zzz = c2.GetColor();
            var qqq = c3.GetColor();

            Console.WriteLine("Färgen på bilen 'c1' är " + yyy + " och dess vikt är " + c1.GetWeight());
            Console.WriteLine("Färgen på bilen 'c2' är " + zzz + " och dess vikt är " + c2.GetWeight());
            Console.WriteLine("Färgen på bilen 'c3' är " + qqq + " och dess vikt är " + c3.GetWeight());


        }
    }
}
