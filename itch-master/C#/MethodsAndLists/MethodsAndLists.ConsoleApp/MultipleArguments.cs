using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.ConsoleApp
{
    public class MultipleArguments
    {
        public void Run()
        {
            /*
                Returnera närliggande elementen i listan. Den första parametern avser index för "mittenelementet".

                List<string> result = NearbyElements(3, new List<string> {"a", "b", "c", "d", "e"});
                ==> c,d,e

            
                List<string> result = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
                ==> a,b

                List<string> result = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });
                ==> d,e

            */

            /*
                Multiplicera alla tal i listan med den första parametern

                List<double> result = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
                ==> 1200, 314, 5000, 9900
             */

            /*
                Returnera en ny lista där vissa ord är med stora bokstäver. 
                Den andra parmetern är en lista av "bool" som anger vilka som ska vara stora.

                List<string> result = SomeToUpper(new List<string> {"what", "does", "the", "fox", "says"}, new List<bool> {true, false, false, true, true});
                ==> WHAT, DOES, the, fox, SAYS
             */

            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
        }

        private List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            var result = new List<string>();
            int index = 0;
            foreach (var word in list)
            {
                if (toUpper[index]==true)
                    result.Add(word.ToUpper());
                else
                    result.Add(word);
                index++;
            }

            return result;

        }

        private List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            var result = new List<double>();
            foreach (var number in numbers)
            {
                double newNumber = number * factor;
                result.Add(newNumber);
            }

            return result;
        }

        private List<string> NearbyElements(int position, List<string> list)
        {
            var result = new List<string>();

            if (position>0)
                result.Add(list[position-1]);

            result.Add(list[position]);

            if (position<list.Count-1)
                result.Add(list[position+1]);

            return result;
        }
    }
}
