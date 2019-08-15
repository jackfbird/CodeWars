using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public partial class Exercises
    {
        public bool ReverseString(string myString)
        {
            string reverse = new string(myString.ToCharArray().Reverse().ToArray());

            if (myString.Equals(reverse))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}