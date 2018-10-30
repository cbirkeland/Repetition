using CommonStuff;

namespace M12_Interfaces
{
    public class Cat : IFriendly
    {
        ConsoleHelper ch = new ConsoleHelper();

        public string Name { get; }

        public Cat(string name)
        {
            Name = name;
        }

        public void Greet()
        {
            ch.WriteDark($"The cat {Name} says miao");
        }

        public void ThanksForDinner(string meal)
        {
            ch.WriteDark($"The cat {Name} thank you for the {meal}");
        }
    }
}
