using System;

namespace _3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //IfStatement();
            //TheWhileExercise();
            //TheForExercise();
            //TheForEachExercise();
            //TheForeachWithBreakExercise();
            //TheIfStatementExercise();
            TheConditionalOperatorExercise();

        }

        private static void TheConditionalOperatorExercise()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            string classify = (number == 20) ? "Equal to 20" : (number == 0) ? "Number is zero" : (number >= 20) ? "Equal or higher than 20" : "Equal or lower than 20";
            Console.WriteLine(classify);
        }

        private static void TheIfStatementExercise()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter number to compare to: ");
            int comparenr = int.Parse(Console.ReadLine());

            if (number < comparenr)
            {
                Console.WriteLine($"Number is lower than {comparenr}");
            }
            if (number == comparenr)
            {
                Console.WriteLine($"Number is equal to {comparenr}");
            }
            else
            {
                Console.WriteLine($"Number is higher than {comparenr}");
            }
        }

        private static void TheForeachWithBreakExercise()
        {
            Console.Write("Enter names in a list (like Maria, Peter, Lisa): ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var item in nameList)
            {
                
                if (item.Trim() == "Zelda")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{item} Andersson");
                }
                

            }

        }

        private static void TheForEachExercise()
        {
            
            Console.Write("Enter names in a list (like Maria, Peter, Lisa): ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var firstName in nameList)
            {
                Console.WriteLine($"{firstName} Andersson");
            }
            Console.WriteLine();
            Console.ResetColor();

        }

        private static void TheForExercise()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            int repeatAmount = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < repeatAmount; i++)
            {

                Console.WriteLine($"Your name is {name}");


            }
            Console.ResetColor();
        }

        private static void TheWhileExercise()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            int count = 0;

            Console.Write("Times to repeat: ");
            int repeatAmount = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            while (count < repeatAmount)
            {
                Console.WriteLine($"Your name is {name}");
                count++;
            }
            Console.ResetColor();
        }

        private static void IfStatement()
        {
            Console.Write("When did you go to bed? ");
            int bedTime = int.Parse(Console.ReadLine());
            Console.Write("When did you wake up? ");
            int wakeUp = int.Parse(Console.ReadLine());

            int sleepTime;

            if (bedTime > wakeUp)
            {
                sleepTime = wakeUp + (24 - bedTime);
            }
            else
            {
                sleepTime = wakeUp - bedTime;
            }


            if (sleepTime < 6)
            {
                Console.WriteLine("You have only slept " + sleepTime + " hours. Go back to bed!");
            }
            if (sleepTime > 12)
            {
                Console.WriteLine("You have slept " + sleepTime + " hours. That is alot!");
            }
            else
            {
                Console.WriteLine($"You have slept {sleepTime} hours. Nice");
            }
        }
    }
}
