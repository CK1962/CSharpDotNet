using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word that you would like translated to Pig Latin: ");
            string input = Console.ReadLine();
            /* Translate the word to Pig Latin
            */
            ToPigLatin_V2(input);
            Console.Read();
        }

        // ToPigLatin_V1 returns the converted word"
        public static string ToPigLatin_V1(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowel = word.IndexOfAny(vowels);
            if (firstVowel == -1)  // if there is no vowel in the word
            {
                return (word + "ay");
            }
            else
            {
                char firstLetter = word[0]; // get the first letter of the word
                char lastLetter = word[word.Length - 1]; // get the last letter of the word

                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    return (word + "yay");
                }
                else
                {
                    string firstHalf = word.Substring(0, firstVowel);
                    string secondHalf = word.Substring(firstVowel);
                    return (secondHalf + firstHalf + "ay");
                }

            }

        }

        // ToPigLatin_V2 does not return anything"
        public static void ToPigLatin_V2(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowel = word.IndexOfAny(vowels);

            if (firstVowel == -1)  // if there is no vowel in the word
            {
                Console.WriteLine(word + "ay");
            }
            else
            {
                char firstLetter = word[0]; // get the first letter of the word
                char lastLetter = word[word.Length - 1]; // get the last letter of the word
                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    Console.WriteLine(word + "yay");
                }
                else
                {
                    // either the first letter is not a vowel OR the last letter is not a vowel
                    // split the word into two parts at the first vowel 
                    string firstHalf = word.Substring(0, firstVowel);
                    string secondHalf = word.Substring(firstVowel);
                    Console.WriteLine(secondHalf + firstHalf + "ay");
                }

            }
        }
    }
}