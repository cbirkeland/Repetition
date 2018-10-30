using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToNumber
    {
        public void Run()
        {
            // Demo: räkna antalet tecken i alla strängar tillsammans

            /*
                Hissen börjar på våning 0. 
                För varje "UPP" åker den upp en våning
                För varje "NER" åker den ner en våning

                int result = ElevatorGoUpAndDown(new List<string>{"UPP", "NER", "UPP", "UPP" });            
                ==> 2
             */
            //Console.WriteLine(result);
        }

        private int ElevatorGoUpAndDown(List<string> list)
        {
            int floorNumber = 0;
            foreach (string command in list)
            {
                if (command == "UPP")
                    floorNumber++;
                if (command == "NER")
                    floorNumber--;
            }

            return floorNumber;
        }
    }
}
