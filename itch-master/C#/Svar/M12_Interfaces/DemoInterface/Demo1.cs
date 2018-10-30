
namespace M12_Interfaces.DemoInterface
{
    // yxa, svärd, bröd, mus, häst

    // djur

    // packa ner

    // Klass Animal
    // IPackable        PutInBag
    // IDangerous       GiveDamage
    // Axe              IDangerous, IPackable
    // Sword            IDangerous, IPackable
    // Mouse            Animal, IPackable
    // Horse            Animal
    // Bread            IPackable

    // PutStuffInBag       Förväntar sig en Lista av IPackable

    public class Demo1
    {
        interface IPackable
        {
            void PutInBag();
        }

        interface IDangerous
        {
            void GiveDamage();
        }
        class Animal
        {
        }

        class Axe : IPackable, IDangerous
        {
            public void PutInBag()
            {

            }

            public void GiveDamage()
            {
            }
        }

        class Sword : IPackable, IDangerous
        {
            public void PutInBag()
            {

            }

            public void GiveDamage()
            {
            }
        }

        class Bread : IPackable
        {
            public void PutInBag()
            {
            }
        }

        class Mouse : Animal, IPackable
        {
            public void PutInBag()
            {
            }
        }


        class Horse : Animal
        {

        }

        void PutStuffInBag(IPackable a)
        {
            a.PutInBag();
        }

        public void Run()
        {

            PutStuffInBag(new Axe());

            // Funkar inte ==> PutStuffInBag("sssssss");
            // Funkar inte ==> PutStuffInBag(123);
            PutStuffInBag(new Bread());
            PutStuffInBag(new Mouse());
            // Funkar inte ==> PutStuffInBag(new Horse());

        }
    }
}
