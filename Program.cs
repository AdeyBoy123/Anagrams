using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionary = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            string[] words = dictionary.Split(',');

            Console.WriteLine("Anagrams of 'star' are:");
            foreach (var word in words)
            {
                if (AreAnagrams(word, "star"))
                {
                    Console.WriteLine(word);
                }
            }
        }

        static bool AreAnagrams(string word1, string word2)
        {
            // If the lengths are different, they can't be anagrams
            if (word1.Length != word2.Length) return false;

            // Sort the characters in each word and compare
            return new string(word1.OrderBy(c => c).ToArray()) == new string(word2.OrderBy(c => c).ToArray());
        }
    }
}
