using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            bool repeat = true;
            do
            {
                Console.WriteLine("Enter a line to be translated:");
                string sentence = Console.ReadLine();
                sentence = sentence.ToLower();
                var pigLatin = GetSentenceInPigLatin(sentence);
                Console.WriteLine(pigLatin);
                Console.WriteLine("Translate another line? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    repeat = true;
                }
                else if (answer == "n")
                {
                    repeat = false;
                }
            } while (repeat == true);
            Console.WriteLine("Thank you for translating!");

        }

        private static string GetSentenceInPigLatin(string sentence)
        {
                const string vowels = "aeio";
                var returnSentence = "";
                foreach (var word in sentence.Split())
                {
                    var firstLetter = word.Substring(0, 1);
                    var restOfWord = word.Substring(1, word.Length - 1);
                    var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                    if (currentLetter == -1)
                    {
                        returnSentence += restOfWord + firstLetter + "ay ";
                    }
                    else
                    {
                        returnSentence += word + "way ";
                    }
                }
                return returnSentence;
        }
       
    }
}
