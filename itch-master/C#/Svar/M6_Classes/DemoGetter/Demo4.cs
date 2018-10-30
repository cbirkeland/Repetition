using System;

namespace M6_Classes.DemoGetter
{
    public class Demo4
    {
        class Product
        {
            public decimal Price { get; set; }
            public decimal VAT => Price * 0.25M;
            public decimal TotalPrice => Price + VAT;
        }

        public void Run()
        {
            var telefon = new Product();
            telefon.Price = 1000;
            Console.WriteLine("Total kostnad för telefonen är: " + telefon.TotalPrice);
        }
    }
}
