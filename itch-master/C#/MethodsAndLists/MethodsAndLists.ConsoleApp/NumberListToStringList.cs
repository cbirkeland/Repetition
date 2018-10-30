using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToStringList
    {

        public void Run()
        {
            /*
                Lägg till tre stjärnor innan och efter siffran
                
                List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

                ==>  ***1003***, ***20***, ***-130***, ***2040***
            */

            /*
                Samma men lägg bara till stjärnor runt de som är större än 1000
             
                List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

                ==>   ***1003***, 20, -130, ***2040***
            */

            /*
                Negativa tal => "ZIP"
                Positiva tal => "ZAP"
                Noll         => "BOING"
            
                List<string> result = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
 
                =>    ZAP, ZAP, ZIP, BOING, ZAP
            */

            /*
              
                Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

                List<string> result = LongOrShort(new List<int> {170, 130, 205, -10, 600, 180});

                ==>    LÅNG, KORT, LÅNG, LÅNG

             */

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }

        private List<string> LongOrShort(List<int> heightList)
        {
            var result = new List<string>();
            foreach (var height in heightList)
            {
                string newString;

                if (height < 0 || height > 220)
                    continue;

                if (height < 160)
                    newString = height + "cm är kort!";
                else
                    newString = height + "cm är långt!";

                result.Add(newString);
            }

            return result;
        }

        private List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                string newString;

                if (number == 0)
                {
                    newString = "BOING";
                }
                else if (number > 0)
                {
                    newString = "ZIP";
                }
                else
                {
                    newString = "ZAP";
                }

                result.Add(newString);
            }

            return result;
        }

        private List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                string newString = number.ToString();
                if (number > 1000)
                {
                    newString = "***" + number + "***";
                }

                result.Add(newString);
            }

            return result;
        }

        private List<string> AddStars(List<int> numbers)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                string newString = "***" + number + "***";
                result.Add(newString);
            }

            return result;
        }
    }
}