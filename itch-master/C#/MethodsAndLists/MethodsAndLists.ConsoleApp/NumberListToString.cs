using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToString
    {

        public void Run()
        {
            // Demo: returnera "fjärde talet är jättestort" om det är större än 10000

            /*
            
                Returnera en text som talar om vilket det första och sista numret är i listan

                string result = ReportFirstAndLastValue(new List<int> {5, 1000, 2000, 3000, 6});

                ==>    Första siffran är 5 och sista siffran är 6
             */

            /*
             
                Returnera en text som säger om alla nummer är högre än 100 eller inte.

                string result = ReportIfAllValuesAreHigherThan100(new List<int> {200, 105, 150});
                ==>    Alla nummer är högre än 100

                string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
                ==>    Något nummer är lägre än 100

             */

            /*
             
                Returnera en text hur många negativa tal som finns i listan

                string result = ReportNumberOfNegativeValues(new List<int> {5, 7, -2, 100, -4});
                ==>     Det finns 2 st negativa tal i listan

                string result = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
                ==>     Jippi! Det finns inga negativa tal i listan
             */


            //Console.WriteLine("RESULT");
            //Console.WriteLine(result);

            // string result = ReportFirstAndLastValue_Linq(new List<int> { 5, 1000, 2000, 3000, 6 });
        }

        private string ReportNumberOfNegativeValues(List<int> numbers)
        {
            int negativeNumbersCounter = 0;
            foreach (var number in numbers)
            {
                if (number < 0)
                    negativeNumbersCounter++;
            }

            if (negativeNumbersCounter > 0)
                return "Det finns " + negativeNumbersCounter + "st negativa tal i listan";
            else
                return "Jippi! Det finns inga negativa tal i listan";
        }

        private string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            bool highNumbers = numbers.Count != 0;

            foreach (int number in numbers)
            {
                if (number <= 100)
                    highNumbers = false;
            }

            if (highNumbers)
                return "Alla nummer är högre än 100";
            else
                return "Något nummer är lägre (eller lika med) 100";
        }

        private string ReportFirstAndLastValue(List<int> numbers)
        {
            int first = numbers[0];

            int lastIndex = numbers.Count-1;
            int last = numbers[lastIndex];

            return "Första siffran är " + first + " och sista siffran är " + last;
        }

        private string ReportFirstAndLastValue_Linq(List<int> numbers)
        {
            return "Första siffran är " + numbers.First() + " och sista siffran är " + numbers.Last();
        }
    }
}