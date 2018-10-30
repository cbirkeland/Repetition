namespace ClassDemo.Version1
{
    using System;

    class Book
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

    public class App
    {
        public void Run()
        {
            Console.WriteLine();

            var b1 = new Book();

            b1.SetIsbn("978-3-16-148410-0");
            b1.SetAuthor("Kalle");
            b1.SetNrOfPages(400);

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {b1.GetIsbn()}");
            Console.WriteLine($"   Författare:  {b1.GetAuthor()}");
            Console.WriteLine($"   Antal sidor: {b1.GetNrOfPages()}");
            Console.WriteLine($"   Vikt:        {b1.WeightInGram()} gram");
            Console.WriteLine($"   Storlek:     {b1.Size()}");
            Console.WriteLine();
        }
    }

}
