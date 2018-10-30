using CommonStuff;
using System;
using System.Text.RegularExpressions;

namespace M8_Exception
{
    public class ExceptionAnimal
    {
        ConsoleHelper ch = new ConsoleHelper();

        public void Run()
        {

            while (true)
            {
                bool succeded = AskForAnimalsAndReportTheAmount();

                if (succeded)
                {
                    break;
                }
            }

        }

        private bool AskForAnimalsAndReportTheAmount()
        {
            string animalsString = ch.AskForString("Enter a list of animals:");

            try
            {
                var animals = ParseAnimals(animalsString);
                Console.WriteLine($"There are {animals.Length} animals in the list");
                return true;
            }
            catch (ArgumentException ex)
            {
                ch.ErrorMessage(ex.Message);
            }
            catch (Exception)
            {
                ch.ErrorMessage("Unexpected error");
            }
            return false;
        }

        private string[] ParseAnimals(string animalsString)
        {
            if (string.IsNullOrWhiteSpace(animalsString))
            {
                throw new ArgumentException("Animal string don't contain any letters");
            }
            string[] animals = animalsString.Split(',');

            foreach (string animal in animals)
            {
                if (string.IsNullOrWhiteSpace(animal))
                {
                    throw new ArgumentException("One of the animals didn't contain any letters");
                }
                if (!AllowedAnimal(animal))
                {
                    throw new ArgumentException($"Animal:'{animal}' contains invalid letters");
                }
                if (animal.Length > 10)
                {
                    throw new ArgumentException($"This animal:'{animal}' has too many letters");
                }
            }

            return animals;
        }

        private bool AllowedAnimal(string animal)
        {
            string s = @"c:\kalle\lisa";
            string s2 = "c:\\kalle\\lisa";

            return Regex.IsMatch(animal, "^[a-zåäö ]+$", RegexOptions.IgnoreCase);
        }
    }
}
