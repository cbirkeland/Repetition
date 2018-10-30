using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToNumberList
    {
        public void Run()
        {
            // Demo: dubblera alla tal i listan
            // Demo: dubblera alla tal i listan. Hoppa över negativa tal.


            /*
                Addera 100 till varje siffra i listan

                List<int> result = Add100ToEachNumber(new List<int> {5, 15, 23, 200});

                ==> 105, 115, 123, 300
             */


            /*
                Filtrera ut de tal som är högre än 1000
             
                List<int> result = GetNumbersHigherThan1000(new List<int>{1005, 6, 77, 200000, 666});

                ==> 1005, 200000
             */

            /*
                
                Returnera de tal som är delbara med 5

                List<int> result = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });

                ==> 20, 5, 10
             */

            /*
                Dela alla tal i listan med 100

                List<int> result = DivideEachNumberBy100(new List<int> { 300,200,-500,1000 });

                ==> 3, 2, -5, 10
             */


            /*
                Negera alla tal i listan

                List<int> result = NegateEachNumber(new List<int> { 10, 20, -30, 40 });

                ==> -10, -20, 30, -40
             */

            /*
                Addera 50 till de tre första elementen i listan
             
                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200,300 });

                ==> 56, 66, 73, 200, 300

                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16});
                ==> 56, 66

             */

            /*
                Lägg till 70 till varannat element i listan

                List<int> result = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000});
                ==> 1000, 2070, 3000, 4070, 5000

             */

            /*
                Experimentera med att kombinera metoder, t.ex såhär:

                List<int> result = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
             */


            //Console.WriteLine("RESULTAT:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> result = Add100ToEachNumber_Linq(new List<int> { 5, 15, 23, 200 });
            //List<int> result = GetNumbersHigherThan1000_Linq(new List<int> { 1005, 6, 77, 200000, 666 });
            //List<int> result = GetNumbersDividableByFive_Linq(new List<int> { 20, 5, 6, 7, 10 });
            //List<int> result = DivideEachNumberBy100_Linq(new List<int> { 300, 200, -500, 1000 });
        }

        private List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            var result = new List<int>();
            int counter = 1;
            foreach (var number in numbers)
            {
                int newNumber;

                if (counter % 2 == 0)
                    newNumber = number + 70;
                else
                    newNumber = number;

                result.Add(newNumber);

                counter++;
            }

            return result;
        }

        private List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            var result = new List<int>();
            int numberCounter = 1;
            foreach (var number in numbers)
            {
                int newNumber = number;

                if (numberCounter <= 3)
                    newNumber = number + 50;

                result.Add(newNumber);
                numberCounter++;
            }

            return result;
        }

        private List<int> NegateEachNumber(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = -number;
                result.Add(newNumber);
            }

            return result;
        }

        private List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = number / 100;
                result.Add(newNumber);
            }

            return result;
        }

        private List<int> DivideEachNumberBy100_Linq(List<int> numbers)
        {
            return numbers.Select(x => x / 100).ToList();
        }


        private List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 5 == 0)
                    result.Add(number);
            }

            return result;
        }

        private List<int> GetNumbersDividableByFive_Linq(List<int> numbers)
        {
            return numbers.Where(x=>x%5==0).ToList();
        }

        private List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (number>1000)
                    result.Add(number);
            }

            return result;
        }


        private List<int> GetNumbersHigherThan1000_Linq(List<int> numbers)
        {
            return numbers.Where(x => x > 1000).ToList();
        }


        private List<int> Add100ToEachNumber(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = number + 100;
                result.Add(newNumber);
            }

            return result;
        }

        private List<int> Add100ToEachNumber_Linq(List<int> numbers)
        {
            return numbers.Select(x => x + 100).ToList();
        }


    }
}