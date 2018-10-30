using System;

namespace _4_
{
    class Program
    {
        static void Main(string[] args)
        {

            MethodExercise();

            

        }















        private static void MethodExercise()
        {
            string name = GetResponseFromUser();
            string[] nameList = GetList(name);
            
            PrintAll(nameList);
        }

        private static void PrintAll(string[] nameList)
        {
            if (nameList.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list don't contain any names");
                Console.WriteLine();
                Console.ResetColor();
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var response in nameList)
            {
                

                if (response.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A person can only have 2 to 9 letters");
                    Console.WriteLine();
                    Console.ResetColor();
                    GetResponseFromUser();
                }

                
            }
            
            foreach (var item in nameList)
            {
                Console.WriteLine($"***SUPER-{item}***");
            }
        }

        private static string[] GetList(string response)
        {
            string[] nameList = response.ToUpper().Trim().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return nameList;
        }

        private static string GetResponseFromUser()
        {
            Console.WriteLine("Type names");
            string response = Console.ReadLine();
            
            
            return response;
        }
    }
}
