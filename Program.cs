using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,List<string>> dictionary = new Dictionary<char, List<string>>();
            dictionary['a'] = new List<string> {"Ape", "Awful", "Amazing"};
            dictionary['b'] = new List<string> {"Beautiful", "Bee", "Butcher"};
            dictionary['c'] = new List<string> {"Conditions", "Carrot", "Cool"};

            dictionary.Remove('c');
            int dictionarySize = dictionary.Count;
            Console.WriteLine(dictionarySize); 
        }
    }
}
