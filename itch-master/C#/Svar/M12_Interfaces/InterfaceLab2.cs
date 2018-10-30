using CommonStuff;
using System;

namespace M12_Interfaces
{
    class InterfaceLab2
    {
        ConsoleHelper ch = new ConsoleHelper();

        public void Run()
        {
            ch.InitConsole();

            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");

            DoNiceThings(buddy);
            DoMeanThings(buddy);
            DoNiceThings(musse);

        }

        void DoNiceThings(IFriendly animal)
        {
            Console.WriteLine("DoNiceThings");
            animal.Greet();
            animal.ThanksForDinner("mouse");
        }

        void DoMeanThings(IAggressive animal)
        {
            Console.WriteLine("DoMeanThings");
            animal.ShowTeeth();

            int legs = animal.Bite();
            if (legs == 1) { ch.WriteDark("You lost one leg"); }
            if (legs == 2) { ch.WriteDark("You lost your legs"); }
            if (legs == 3) { ch.WriteDark("You lost your legs and one arm"); }
            if (legs == 4) { ch.WriteDark("You lost your legs and your arms"); }
        }

    }
}
