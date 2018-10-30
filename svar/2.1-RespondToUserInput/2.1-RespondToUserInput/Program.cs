using System;

namespace _2._1_RespondToUserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            //NameExercise();
            //DifferentTypes();
            //StringCreation();



            
            
        }

        private static void StringCreation()
        {
            var f1 = new Fruit();
            var f2 = new Fruit();
            var f3 = new Fruit();
            Console.Write("Enter fruit 1: ");
            f1.FruitType = Console.ReadLine();
            Console.Write("Enter fruit 2: ");
            f2.FruitType = Console.ReadLine();
            Console.Write("Enter fruit 3: ");
            f3.FruitType = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;  
            string message1 = "You entered the fruits: " + f1.FruitType + ", " + f2.FruitType + ", " + f3.FruitType + "!";
            string message2 = string.Format("You entered the fruits: {0}, {1}, {2}!", f1.FruitType, f2.FruitType, f3.FruitType);
            string message3 = $"You entered the fruits: {f1.FruitType}, {f2.FruitType}, {f3.FruitType}";
            Console.ResetColor();

        }

        private static void DifferentTypes()
        {
            var p = new Person();
            Console.WriteLine("What is your name? ");
            p.Name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            p.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite letter? ");
            p.Letter = char.Parse(Console.ReadLine());

            bool likesNumbers = char.IsNumber(p.Letter);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is " + p.Name);
            Console.WriteLine("You are " + p.Age + " years old");
            if (likesNumbers)
            {
                Console.WriteLine("You like numbers");
            }
            else
            {
                Console.WriteLine("You dont like numbers");
            }
            

            Console.ResetColor();
        }




        private static void NameExercise()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite letter? ");
            string letter = Console.ReadLine();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Your favorite letter is " + letter);

            Console.ResetColor();
        }
    }
}
