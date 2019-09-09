using System;

namespace ReverseWords
{
    public class Reverse
    {
        public string ReverseWords(string str)
        {
            string result = "";
            string[] temp = str.Split(' ');

            for (int i = 0; i < temp.Length; i++)
            {
                char[] arr = temp[i].ToCharArray();
                Array.Reverse(arr);
                string tempString = new string(arr);
                if (i != (temp.Length - 1))
                {
                    result += tempString;
                    result += " ";
                }
                else if (i == (temp.Length - 1))
                {
                    result += tempString;
                }
            }
            return result;
        }
    }
}
