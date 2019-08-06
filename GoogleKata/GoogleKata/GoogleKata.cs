using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleKata
{
    public partial class Exercises
    {
        public string GetStrings(string city)
        {
            {
                city = city.ToLower();
                var charLookup = city.Where(char.IsLetterOrDigit).ToLookup(c => c);
                string result = "";
                char colon = ':';
                List<char> listOfChars = new List<char>();
                string last = city.Substring((city.Length - 1), 1);

                foreach (var c in charLookup)
                {

                    if (!listOfChars.Contains(c.Key))
                    {
                        result += c.Key;
                        result += colon;
                        int i = 0;

                        while (i < charLookup[c.Key].Count())
                        {
                            result += '*';
                            i++;
                        }

                        if (!charLookup.LastOrDefault().Equals(c))
                        {
                            result += ',';
                        }
                    }

                    listOfChars.Add(c.Key);
                }

                return result;
            }

        }
    }
}
