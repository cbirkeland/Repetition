namespace ClassDemo.Version2
{
    using System;

    class Product
    {
        private int _productId;

        public int GetProductId()
        {
            return _productId;
        }

        public void SetProductId(int value)
        {
            _productId = value;
        }
    }

    class Book : Product
    {
        string _isbn;
        string _author;
        int _nrOfPages;

        public string GetIsbn()
        {
            return _isbn;
        }

        public void SetIsbn(string value)
        {
            _isbn = value;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string value)
        {
            _author = value;
        }

        public int GetNrOfPages()
        {
            return _nrOfPages;
        }

        public void SetNrOfPages(int value)
        {
            if (value > 0 && value < 1000)
            {
                _nrOfPages = value;
            }
            else
            {
                _nrOfPages = 300;
            }

        }

        public double WeightInGram()
        {
            return _nrOfPages * 0.8;
        }

        public string Size()
        {
            if (_nrOfPages < 100)
                return "Tunn";

            if (_nrOfPages < 300)
                return "Normal";

            return "Tjock";
        }
    }

    class ElectronicBook : Book
    {
        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"   Send book to {emailAdress}");
        }
    }

    public class App
    {
        public void Run()
        {
            Console.WriteLine();

            var b1 = new Book();
            var e1 = new ElectronicBook();

            b1.SetIsbn("978-3-16-148410-0");
            b1.SetAuthor("Kalle");
            b1.SetNrOfPages(400);
            b1.SetProductId(1234);

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:             {b1.GetIsbn()}");
            Console.WriteLine($"   Författare:       {b1.GetAuthor()}");
            Console.WriteLine($"   Antal sidor:      {b1.GetNrOfPages()}");
            Console.WriteLine($"   Vikt:             {b1.WeightInGram()} gram");
            Console.WriteLine($"   Storlek:          {b1.Size()}");
            Console.WriteLine($"   Produktens id:    {b1.GetProductId()}");

            Console.WriteLine();
            Console.WriteLine($"Olika test:");
            Console.WriteLine();

            Console.WriteLine($"   Är b1 en bok?     {b1 is Book}");
            Console.WriteLine($"   Är b1 en e-bok?   {b1 is ElectronicBook}");
            Console.WriteLine($"   Är b1 en produkt? {b1 is Product}");

            Console.WriteLine();

            Console.WriteLine($"   Är e1 en bok?     {e1 is Book}");
            Console.WriteLine($"   Är e1 en e-bok?   {e1 is ElectronicBook}");
            Console.WriteLine($"   Är e1 en produkt? {e1 is Product}");

            Console.WriteLine();
            Console.WriteLine($"Anrop:");
            Console.WriteLine();
            e1.SendBookTo("oo@happybits.se");

            Console.WriteLine();
        }
    }

}
