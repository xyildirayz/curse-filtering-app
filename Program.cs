using System.Dynamic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace curseFilterApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> curses = new()
            {
              {"stupid", "!@?*"},
              {"hell", "!@?*"}, 
              // You may add more curse words here
            };
            Console.Write("Enter your expression: ");
            string sentence = Console.ReadLine()!.ToLower();
            foreach(var curse in curses)
            {
                sentence = sentence.Replace(curse.Key, curse.Value); // Checks the "curse" word from the sentence from the dictionary and replaces it with the value "!@?*"
            }
            Console.WriteLine(sentence);
            
            


        }

    }
}