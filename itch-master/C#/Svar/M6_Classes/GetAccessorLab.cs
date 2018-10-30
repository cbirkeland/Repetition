using System;

namespace M6_Classes
{
    public static class GetAccessorLab
    {
        public static void Run()
        {
            Address address = new Address
            {
                Street = "Långa gatan",
                StreetNumber = "13B",
                City = "Sundsvall",
                ZipCode = "111 22"
            };

            // (ej testat)
            Console.WriteLine($"Street:{address.Street.PadRight(20)}");
            Console.WriteLine($"StreetNumber:{address.StreetNumber.PadRight(20)}");
            Console.WriteLine($"City:{address.City.PadRight(20)}");
            Console.WriteLine($"ZipCode:{address.ZipCode.PadRight(20)}");
            Console.WriteLine($"FullStreet:{address.FullStreet.PadRight(20)}");
        }
    }
}
