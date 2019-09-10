using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    public class AnagramKata
    {   public List<string> Anagrams(string word, List<string> words)
        {
            List<string> result = new List<string>();
            string orderedWord = new string(word.OrderBy(c => c).ToArray());

            foreach (string listWord in words)
            {
                string orderedWordFromList = new string(listWord.OrderBy(c => c).ToArray());

                if (orderedWord == orderedWordFromList)
                {
                    result.Add(listWord);
                }
            }

            return result;
        }
    }
}

