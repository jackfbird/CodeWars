using System;
using System.Collections.Generic;
using System.Text;

namespace CompareSquaredArrays
{
    public partial class Exercises
    {
        public bool Comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            if (a.Length != b.Length)
            {
                return false;
            }
            bool result = false;
            Array.Sort(a);
            Array.Sort(b);
            Dictionary<int, int> aDic = new Dictionary<int, int>();
            Dictionary<int, int> bDic = new Dictionary<int, int>();
            int count = 1;
            int countTwo = 1;
            foreach (int i in a)
            {
                int value = (i * i);
                aDic.Add(count, value);
                count++;
            }

            foreach (int i in b)
            {
                bDic.Add(countTwo, i);
                countTwo++;
            }

            foreach (KeyValuePair<int, int> i in aDic)
            {
                if (aDic[i.Key] != bDic[i.Key])
                {
                    return false;
                }
            }

            result = true;
            return result;
        }
    }
}
    