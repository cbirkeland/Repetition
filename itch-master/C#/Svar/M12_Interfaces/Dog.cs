

using CommonStuff;
using System;

namespace M12_Interfaces
{
    public class Dog : IFriendly, IAggressive
    {
        ConsoleHelper ch = new ConsoleHelper();

        public string Name { get; }

        public Dog(string name)
        {
            Name = name;
        }

        public int Bite()
        {
            ch.WriteDark($"The dog {Name} bit you!");
            return new Random().Next(4)+1;
        }

        public void ShowTeeth()
        {
            ch.WriteDark($"The dog {Name} shows his teeth");
        }

        public void Greet()
        {
            ch.WriteDark($"The dog {Name} says woof");
        }

        public void ThanksForDinner(string meal)
        {
            ch.WriteDark($"The dog {Name} thank you for the {meal}");
        }
    }
}
