using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToBool
    {
        public void Run()
        {
            // Demo: Returerna "true" om längen på alla ord tillsammans är större än 10

            /*
                Returnera "true" om alla ord har fem eller fler tecken
             
                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
                ==> true

                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
                ==> false
            */

            //Console.WriteLine(result);
        }

        private bool AllWordsAreFiveLettersOrLonger(List<string> list)
        {
            if (list.Count == 0)
                return false;

            bool result = true;
            
            foreach (var item in list)
            {
                if (item.Length < 5)
                    result = false;
            }

            return result;
        }
    }
}
