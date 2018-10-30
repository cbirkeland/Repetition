namespace ClassDemo.Version3
{
    using System;

    class Product
    {
        public int ProductId { get; set; }
    }

    class Book : Product
    {
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; }

        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
        }

        int _nrOfPages;

        public int NrOfPages
        {
            get => _nrOfPages;

            set
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
        }

        public double WeightInGram => _nrOfPages * 0.8;

        public string Size
        {
            get
            {
                if (_nrOfPages < 100)
                    return "Tunn";

                if (_nrOfPages < 300)
                    return "Normal";

                return "Tjock";
            }
        }

    }

    class ElectronicBook : Book
    {

        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"   Send book to {emailAdress}");
        }

        public ElectronicBook(string isbn, string title) : base(isbn, title)
        {
        }
    }

    public class App
    {
        public void Run()
        {
            Console.WriteLine();

            var b1 = new Book("XXXXXX", "Min bok");

            b1.Isbn = "978-3-16-148410-0";
            b1.Author = "Kalle";
            b1.NrOfPages = 400;
            b1.ProductId = 1234;

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:             {b1.Isbn}");
            Console.WriteLine($"   Författare:       {b1.Author}");
            Console.WriteLine($"   Antal sidor:      {b1.NrOfPages}");
            Console.WriteLine($"   Vikt:             {b1.WeightInGram} gram");
            Console.WriteLine($"   Storlek:          {b1.Size}");
            Console.WriteLine($"   Produktens id:    {b1.ProductId}");

            Console.WriteLine();

            var e1 = new ElectronicBook("978-9-17-639279-9", "Röda rummet");
            e1.SendBookTo("oo@happybits.se");

            Console.WriteLine();
        }
    }

}
